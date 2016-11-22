using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using CodemeFramework.includes;
using CodemeFramework.forms;
using System.Net;

namespace CodemeFramework
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Do not remove funcs after this line
            App.rootPath = System.IO.Directory.GetCurrentDirectory();

            //var MyIni = new IniFile(@"Settings.ini");
            // Do not remove funcs before this line
            Webservers ws = new Webservers(Webservers.SendResponse, "http://localhost:8080/test/");
            ws.Run();
            //Console.WriteLine("A simple webserver. Press a key to quit.");
            //Console.ReadKey();
            //ws.Stop();       
       
        }



        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            textBox1.BackColor = Color.Red;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            DataClasses1DataContext db = new DataClasses1DataContext();

            var query = from c in db.users select c;

            string str = "";

            foreach (var q in query)
            {
                str += q.fullname;
            }

            textBox1.Text = str;

            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Forms.hide("Form2");
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
