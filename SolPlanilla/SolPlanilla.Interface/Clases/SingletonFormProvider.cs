using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurante.UI.BackOffice.Maestros
{
    class SingletonFormProvider
    {
        static Dictionary<Type, Form> mTypeFormLookup = new Dictionary<Type, Form>();

        static public T GetInstance<T>(Form owner)
        where T : Form
        {
            return GetInstance<T>(owner, null);
        }

        static public T GetInstance<T>(Form owner, params object[] args)
        where T : Form
        {
            if (!mTypeFormLookup.ContainsKey(typeof(T)))
            {
                Form f = (Form)Activator.CreateInstance(typeof(T), args);
                mTypeFormLookup.Add(typeof(T), f);
                f.Owner = owner;
                f.FormClosed += new FormClosedEventHandler(remover);
            }
            return (T)mTypeFormLookup[typeof(T)];
        }

        static void remover(object sender, FormClosedEventArgs e)
        {
            Form f = sender as Form;
            if (f == null) return;

            f.FormClosed -= new FormClosedEventHandler(remover);
            mTypeFormLookup.Remove(f.GetType());
        }
    }
}
