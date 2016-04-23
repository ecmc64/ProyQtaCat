using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using SolPlanilla.BE;
using SolPlanilla.BL;

namespace SolPlanilla.WCF
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IService1" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IServicioPlanilla
    {
        [OperationContract]
        bool TestConexion();

        #region Mantenimientos

        #region Mantenimiento Categoria Obrero

        [OperationContract]
        BeMaestroCategoriaObrero ConsultarCategoriaObrero(BeMaestroCategoriaObrero pCategoriaObrero);

        [OperationContract]
        List<BeMaestroCategoriaObrero> ConsultarCategoriaObreroLista(BeMaestroEmpresa pEmpresa);

        [OperationContract]
        BeMaestroCategoriaObrero GrabarCategoriaObrero(BeMaestroCategoriaObrero pCategoriaObrero, bool pGrabar);

        #endregion

        #region Mantenimiento Documento

        [OperationContract]
        BeMaestroDocumento ConsultarDocumento(BeMaestroDocumento pDocumento);

        [OperationContract]
        List<BeMaestroDocumento> ConsultarDocumentoLista(BeMaestroEmpresa pEmpresa);

        [OperationContract]
        BeMaestroDocumento GrabarDocumento(BeMaestroDocumento pDocumento, bool pGrabar);


        #endregion

        #region Mantenimiento Obrero

        [OperationContract]
        BeMaestroObrero ConsultarObrero(BeMaestroObrero pObrero);

        [OperationContract]
        List<BeMaestroObrero> ConsultarObreroLista(BeMaestroEmpresa pEmpresa);

        [OperationContract]
        BeMaestroObrero GrabarObrero(BeMaestroObrero pObrero, bool pGrabar);

        #endregion

        #region Mantenimiento Empresa
        
        [OperationContract]
        List<BeMaestroEmpresa> ConsultarEmpresaLista();

        [OperationContract]
        BeMaestroEmpresa GrabarEmpresa(BeMaestroEmpresa pEmpresa, bool pGrabar);

        #endregion

        #region Mantenimiento UIT

        [OperationContract]
        List<BeMaestroUit> ConsultarUitLista();

        [OperationContract]
        BeMaestroUit GrabarUit(BeMaestroUit pUit, bool pGrabar);

        #endregion

        #region Mantenimiento Obrero

        #endregion

        #region Mantenimiento Tasa

        [OperationContract]
        List<BeMaestroTasa> ConsultarTasaLista();
        [OperationContract]
        BeMaestroTasa GrabarTasa(BeMaestroTasa pTasa, bool pGrabar);

        #endregion

        #region Mantenimiento Obras

        [OperationContract]
        List<BeMaestroObras> ConsultarObrasLista(BeMaestroEmpresa pEmpresa);


        #endregion

        #endregion

        #region Importaciones

        [OperationContract]
        BeMaestroObrero ImportarObrero(BeMaestroObrero pObrero);

        [OperationContract]
        BeMaestroObras ImportarObras(BeMaestroObras pObra);

        #endregion
    }

}
