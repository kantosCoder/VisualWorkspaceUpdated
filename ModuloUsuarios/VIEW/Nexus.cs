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
    public partial class Nexus : Form
    {
        public Nexus()
        {
            InitializeComponent();
        }

        private void Nexus_Load(object sender, EventArgs e)
        {
            
        }
        private void button1_Click(object sender, EventArgs e) //BOTON PERSONAJES
        {
            Invoker.controller.Chars();
            this.Close();
        }
        private void button6_Click(object sender, EventArgs e)
        {
            Invoker.controller.Login();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Invoker.controller.Creatures();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Invoker.controller.Items();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Invoker.controller.Abilities();
            this.Close();
        }
    }
}
