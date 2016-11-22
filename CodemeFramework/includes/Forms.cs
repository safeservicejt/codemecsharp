using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CodemeFramework.includes
{
    class Forms
    {
        static string formName = "";
        static Form curForm;

        public static void show(string FormName)
        {
            formName = FormName;

            var _formName = (from t in System.Reflection.Assembly.GetExecutingAssembly().GetTypes()
                             where t.Name.Equals(FormName)
                             select t.FullName).Single();
            var _form = (Form)Activator.CreateInstance(Type.GetType(_formName));
            if (_form != null)
            {
                curForm = _form;

                _form.Show();
            }
                

            //Form frm = (Form)Assembly.GetExecutingAssembly().CreateInstance("namespace.form");
            //frm.Show();
        }

        public static void hide(string FormName)
        {
            if (formName == FormName)
            {
                curForm.Hide();
            }

            //var _formName = (from t in System.Reflection.Assembly.GetExecutingAssembly().GetTypes()
            //                 where t.Name.Equals(FormName)
            //                 select t.FullName).Single();
            //var _form = (Form)Activator.CreateInstance(Type.GetType(_formName));
            //if (_form != null)
            //{
            //    _form.Hide();
            //}
                

            //Form frm = (Form)Assembly.GetExecutingAssembly().CreateInstance("namespace.form");
            //frm.Hide();
        }

    }
}
