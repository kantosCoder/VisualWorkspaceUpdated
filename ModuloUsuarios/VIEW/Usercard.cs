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
        private String password = "";
        private String currentrole = "";
        private Display current;

        public Usercard(String aname, String atype, String pass, Display target)
        {
            
            name = aname;
            type = atype;
            password = pass;
            current = target;
           
            InitializeComponent();
        }
        public void fieldset(Usercard current) {
            current.username.Text = name;
            current.userrole.Text = type;
                var replacer = new Bitmap(ModuloUsuarios.Properties.Resources.user);
                current.abilityimg.Image = replacer;
            Staticvartable role = new Staticvartable();
            currentrole = role.Rolegetter();
            if (currentrole.Equals("ADMIN"))
            {
                current.modify_button.Visible = true;
                current.deleter_button.Visible = true;
            }
        }

        private void Usercard_load(object sender, EventArgs e)
        {
            current.userdetailload(name,type,current);
        }

        private void modify_button_Click(object sender, EventArgs e)
        {
            Invoker.controller.Usermodify(type,name,password);
            current.Close();
        }

        private void deleter_button_Click(object sender, EventArgs e)
        {
            Invoker.controller.Userdestroy(name);
            Invoker.controller.Users();
            current.Close();
        }
    }
}
