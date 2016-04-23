using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using SolPlanilla.BE;
using SolPlanilla.DA;

namespace SolPlanilla.BL
{
    public class BlMaestroObrero
    {
        public BeMaestroObrero ConsultarObrero(BeMaestroObrero pObrero)
        {
            var oDaPersona = new DaMaestroPersona();
            var persona = oDaPersona.GetMaetroPersona(pObrero);

            if (persona.EstadoEntidad.Correcto && persona.EstadoEntidad.NumeroFilasAfectadas > 0)
            {
                var oDa = new DaMaestroObrero();
                pObrero = oDa.GetMaestroObrero(pObrero);

                pObrero = HelperEntidad.CopiarPropiedadesPersonaObrero(persona);

                oDa = null;

                /*
                var oDaDocumento = new DaMaestroDocumento();
                var documento = oDaDocumento.GetDocumento(pObrero.Documento);
                documento.NumDocumento = persona.Numdocumento;
                pObrero.Documento = documento;
                oDaDocumento = null;
                 * */
            }
            else
            {
                pObrero.EstadoEntidad = persona.EstadoEntidad;
            }

            oDaPersona = null;
            
            return pObrero;
        }

        public List<BeMaestroObrero> ConsultarObrero(BeMaestroEmpresa pEmpresa)
        {
            var oDa = new DaMaestroObrero();
            var listaObrero = oDa.GetMaestroObrero(pEmpresa);
            oDa = null;

            if (listaObrero.Count <= 0) return listaObrero;

            var oDaPersona = new DaMaestroPersona();
            var oDaDocumento = new DaMaestroDocumento();
            var oDaCategorias = new DaMaestroCategoriaObrero();

            var personas = oDaPersona.GetMaetroPersona(pEmpresa);
            var documentos = oDaDocumento.GetDocumento(pEmpresa);
            var categorias = oDaCategorias.GetCategoriaObrero(pEmpresa);

            var nuevaLista = new List<BeMaestroObrero>();

            foreach (var obrero in listaObrero)
            {
                var persona = personas.Find(x => x.IdPersona == obrero.IdPersona);
                var documento = documentos.Find(x => x.IdDocumento == persona.Documento.IdDocumento);
                var categoria = categorias.Find(x => x.IdCategoria == obrero.Categoria.IdCategoria);

                var obreroAux = HelperEntidad.CopiarPropiedadesPersonaObrero(persona);
                HelperEntidad.CopiarPropiedades(obrero,obreroAux);
                documento.NumDocumento = persona.Documento.NumDocumento;
                obrero.Categoria = categoria;
                HelperEntidad.CopiarPropiedades(obrero.Documento, documento);
                //obrero.Documento = documento;

                //nuevaLista.Add((BeMaestroObrero)obrero.Clone());
            }

            oDaPersona = null;
            oDaDocumento = null;
            categorias = null;


            return listaObrero;
        }

        public BeMaestroObrero GrabarObrero(BeMaestroObrero pObrero, bool pGrabar)
        {
            
            using (var tsTransScope = new TransactionScope())
            {
                var oDa = new DaMaestroObrero();
                var oDaPersona = new DaMaestroPersona();

                var persona = pGrabar ? oDaPersona.InsPersona(pObrero) : oDaPersona.UpdPersona(pObrero);

                if (persona.EstadoEntidad.Correcto)
                {
                    pObrero = pGrabar ? oDa.InsMaestroObrero(pObrero) : oDa.UpdMaestroObrero(pObrero);

                    if(pObrero.EstadoEntidad.Correcto)
                        tsTransScope.Complete();
                    else
                        tsTransScope.Dispose();
                }
                else
                {
                    tsTransScope.Dispose();
                    pObrero.EstadoEntidad = persona.EstadoEntidad;
                }

                oDa = null;
                oDaPersona = null;
            }

            return pObrero;
        }

        public BeMaestroObrero ImportarObrero(BeMaestroObrero pObrero)
        {
            var oPersonaDa = new DaMaestroPersona();
            var obreroDb = oPersonaDa.GetMaetroPersonaByDni(pObrero.Empresa, pObrero.Documento.NumDocumento);

            pObrero.EstadoEntidad = obreroDb.EstadoEntidad;
            
            if (!pObrero.EstadoEntidad.Correcto) return pObrero;

            if (obreroDb.EstadoEntidad.NumeroFilasAfectadas != 0)
            {
                pObrero.IdPersona = obreroDb.IdPersona;
            }
            pObrero = GrabarObrero(pObrero, obreroDb.EstadoEntidad.NumeroFilasAfectadas == 0);

            return pObrero;
        }

    }
}
