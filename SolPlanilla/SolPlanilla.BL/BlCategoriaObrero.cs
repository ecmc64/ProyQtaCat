using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SolPlanilla.BE;
using SolPlanilla.DA;

namespace SolPlanilla.BL
{
    public class BlCategoriaObrero
    {
        /// <summary>
        /// Consulta una categorìa espesífica
        /// </summary>
        /// <param name="pCategoriaObrero">Categorìa a buscar</param>
        /// <returns>La categoría con todos los datos cargados</returns>
        public BeMaestroCategoriaObrero ConsultarCategoriaObrero(BeMaestroCategoriaObrero pCategoriaObrero)
        {
            var oDa = new DaMaestroCategoriaObrero();
            pCategoriaObrero = oDa.GetCategoriaObrero(pCategoriaObrero);

            oDa = null;

            return pCategoriaObrero;
        }

        /// <summary>
        /// Consulta las categorias de los obreros.
        /// </summary>
        /// <param name="pEmpresa">Entidad con los datos de la empresa a la que pertenece</param>
        /// <returns>Lista de Categorías</returns>
        public List<BeMaestroCategoriaObrero> ConsultarCategoriaObrero(BeMaestroEmpresa pEmpresa)
        {
            var oDa = new DaMaestroCategoriaObrero();
            var lista = oDa.GetCategoriaObrero(pEmpresa);

            oDa = null;

            return lista;
        }

        /// <summary>
        /// Registra la categoría del obrero
        /// </summary>
        /// <param name="pCategoriaObrero">Categorìa a registrar</param>
        /// <param name="pGrabar">Nuevo registro</param>
        /// <returns>La entidad con el resultado de la operación</returns>
        public BeMaestroCategoriaObrero GrabarCategoriaObrero(BeMaestroCategoriaObrero pCategoriaObrero, bool pGrabar)
        {
            var oDa = new DaMaestroCategoriaObrero();

            pCategoriaObrero = pGrabar
                ? oDa.InsCategoriaObrero(pCategoriaObrero)
                : oDa.UpdCategoriaObrero(pCategoriaObrero);

            return pCategoriaObrero;
        }

    }
}
