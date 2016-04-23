using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolPlanilla.BE
{
    public class HelperEntidad
    {
        public static void CopiarPropiedades<T>(T pDestino, T pOrigen)
        {
            var t = typeof(T);

            var properties = t.GetProperties().Where(prop => prop.CanRead && prop.CanWrite);

            foreach (var prop in properties)
            {
                var value = prop.GetValue(pOrigen, null);
                if (value != null)
                    prop.SetValue(pDestino, value, null);
            }
        }

        public static BeMaestroObrero CopiarPropiedadesPersonaObrero(BeMaestroPersona pPersona)
        {
            var obrero = new BeMaestroObrero();

            obrero.Activo = pPersona.Activo;
            obrero.Apellidos = pPersona.Apellidos;
            obrero.Categoria = new BeMaestroCategoriaObrero();
            obrero.Direccion = pPersona.Direccion;
            obrero.Documento = pPersona.Documento;
            obrero.Empresa = pPersona.Empresa;
            obrero.FechaCreacion = pPersona.FechaCreacion;
            obrero.FechaModificacion = pPersona.FechaModificacion;
            obrero.IdPersona = pPersona.IdPersona;
            obrero.Nombres = pPersona.Nombres;
            obrero.UsuarioCreador = pPersona.UsuarioCreador;
            obrero.UsuarioModificador = pPersona.UsuarioModificador;

            return obrero;
        }

    }
}
