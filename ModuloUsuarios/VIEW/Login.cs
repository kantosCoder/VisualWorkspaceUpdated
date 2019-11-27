using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModuloUsuarios
{
    public partial class Login : Form
    {
        Caller_users checker = new Caller_users();
        Staticvartable window = new Staticvartable();
        public Login()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Boolean usercheck = checker.Loader(this.userField.Text,this.passField.Text);
            if (usercheck == true)
            {
                window.resetlogin();
                Invoker.controller.Nexus();
                this.Close();
            }
            else {
                window.badlogin();
            }
            if (window.getbadlogin()==3)
            {
                Application.Exit();
            }


        }

        private void Userwindow_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //FUNCION DE AUTORRELLENADO(SOLO DEBUG)
        public void autofill() {
            this.userField.Text = "ADMIN";
            this.passField.Text = "1234";
        }
        //FIN FUNCION AUTORRELLENADO
    }
}
