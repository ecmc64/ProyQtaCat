using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SolPlanilla.BE;
using SolPlanilla.Interface.ProxyWeb;

namespace SolPlanilla.Interface
{
    internal class GlobalVars
    {
        internal static string PuertoWcf;
        internal static string Usuario;
        internal static DateTime FechaIngreso;
        internal static string Proyecto;
        internal static BeMaestroEmpresa Empresa;


        #region Funciones Estaticas

        public static void SoloNumeros(KeyEventArgs e)
        {
            var esapostrofe = false;
            if (!((e.KeyValue >= 48 && e.KeyValue <= 57) || (e.KeyValue >= 96 && e.KeyValue < 110) ||
            (e.KeyValue >= 37 && e.KeyValue <= 40) || (e.KeyValue == 8 || e.KeyValue == 46)) ||
            (e.Shift == true || e.Alt == true) || e.KeyValue == 106 || e.KeyValue == 107 || e.KeyValue == 109 ||
            e.KeyValue == 186 || e.KeyValue == 222)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;

                if (e.KeyValue == 186 || e.KeyValue == 222)
                    esapostrofe = true;
            }
            if (esapostrofe)
            {
                SendKeys.Send(Keys.Back.ToString());
            }
        }

        public static void SoloNumerosConPunto(KeyEventArgs e, TextBox txtValidar)
        {
            var esapostrofe = false;
            if (!((e.KeyValue >= 48 && e.KeyValue <= 57) || (e.KeyValue >= 96 && e.KeyValue <= 110) ||
                  (e.KeyValue >= 37 && e.KeyValue <= 40) || (e.KeyValue == 8 || e.KeyValue == 46 || e.KeyValue == 9 || e.KeyValue == 46 || e.KeyValue == 190)) ||
                (e.Shift == true || e.Alt == true) || e.KeyValue == 106 || e.KeyValue == 107 || e.KeyValue == 109)
            {
                if (e.KeyValue == 186 || e.KeyValue == 222)
                    esapostrofe = true;
                e.Handled = true;
                e.SuppressKeyPress = true;
            }

            if (txtValidar.Text.IndexOf(".", StringComparison.Ordinal) > 0 && (e.KeyValue == 110 || e.KeyValue == 190))
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
            if (esapostrofe)
                SendKeys.Send(Keys.Back.ToString());

        }

        public static bool ValidationRuc(string pRuc)
        {
            if (pRuc.Length != 11)
            {
                return false;
            }

            var dig01 = int.Parse(pRuc.Substring(0, 1));
            var dig02 = int.Parse(pRuc.Substring(1, 1));
            var dig03 = int.Parse(pRuc.Substring(2, 1));
            var dig04 = int.Parse(pRuc.Substring(3, 1));
            var dig05 = int.Parse(pRuc.Substring(4, 1));
            var dig06 = int.Parse(pRuc.Substring(5, 1));
            var dig07 = int.Parse(pRuc.Substring(6, 1));
            var dig08 = int.Parse(pRuc.Substring(7, 1));
            var dig09 = int.Parse(pRuc.Substring(8, 1));
            var dig10 = int.Parse(pRuc.Substring(9, 1));
            var dig11 = int.Parse(pRuc.Substring(10, 1));

            var suma = dig01 + dig02 + dig03 + dig04 + dig05 + dig06 + dig07 + dig08 + dig09 + dig10;
            var residuo = suma % 11;
            var resta = 11 - residuo;

            int digchk;

            switch (resta)
            {
                case 10:
                    digchk = 0;
                    break;
                case 11:
                    digchk = 1;
                    break;
                default:
                    digchk = resta;
                    break;
            }

            return digchk == dig11;
        }

        public static double ToDouble(object pvalue)
        {
            double valor;
            try
            {
                valor = Convert.ToDouble(pvalue);
            }
            catch (Exception)
            {
                valor = 0;
            }
            return valor;
        }

        public static int ToInteger(object pvalue)
        {
            int valor;
            try
            {
                valor = Convert.ToInt32(pvalue);
            }
            catch (Exception)
            {
                valor = 0;
            }
            return valor;
        }

        #endregion
    }
}
