using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SolPlanilla.BE;
using SolPlanilla.BL;

namespace SolPlanilla.Test.Maestros
{
    [TestClass]
    public class TestObrero
    {
        [TestMethod]
        public void CargarObreros()
        {
            var empresa = new BeMaestroEmpresa { IdEmpresa = new Guid("8822501E-59D2-4F4C-B2C3-87AD386283C8") };
            var obreroBl = new BlMaestroObrero();

            var lista = obreroBl.ConsultarObrero(empresa);
            Assert.IsTrue(lista != null);
        }
    }
}
