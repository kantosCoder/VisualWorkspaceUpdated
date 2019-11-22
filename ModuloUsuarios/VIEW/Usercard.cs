using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModuloUsuarios
{
    public partial class Usercard : UserControl
    {
        private String name = "";
        private String type = "";
        private Display current;

        public Usercard(String aname, String atype, Display target)
        {
            
            name = aname;
            type = atype;
            current = target;
            InitializeComponent();
        }
        public void fieldset(Usercard current) {
            current.username.Text = name;
            current.userrole.Text = type;
                var replacer = new Bitmap(ModuloUsuarios.Properties.Resources.user);
                current.abilityimg.Image = replacer;
        }

        private void Usercard_load(object sender, EventArgs e)
        {
            current.userdetailload(name,type,current);
        }
    }
}
