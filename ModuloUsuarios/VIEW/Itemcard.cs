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
    public partial class Itemcard : UserControl
    {
        private String ident = "";
        private String name = "";
        private String lvl = "";
        private String type = "";
        private String value = "";
        private String space = "";
        private String weight = "";
        private String armor = "";
        private String ability = "";
        private String damage = "";
        private String damagetype = "";
        private Display current;

        public Itemcard(String id, String atype, String avalue, String alvl, String aname, 
            String aspace, String aweight, String a_rmor, String admg, String dmgtype, String a_bility, Display target)
        {
            ident = id;
            type = atype;
            value = avalue;
            lvl = alvl;
            name = aname;
            space = aspace;
            weight = aweight;
            armor = a_rmor;
            ability = a_bility;
            damage = admg;
            damagetype = dmgtype;
            current = target;
            InitializeComponent();
        }
        public void fieldset(Itemcard current) {
            current.itemname.Text = name;
            current.itemtype.Text = type;
            current.itemvalue.Text = value+" Golds";
            current.itemlevel.Text = lvl;
            current.itemspace.Text = space+"slots";
            current.itemweight.Text = weight+"kg";
            current.itemdamage.Text = "Daño: "+damage;
            current.itemarmor.Text = "Armadura: "+armor;
                //items would not load custom images
                var replacer = new Bitmap(ModuloUsuarios.Properties.Resources.items);
                current.creatureimage.Image = replacer;
        }

        private void Item_load(object sender, EventArgs e)
        {
            current.itemdetailload(type,value,lvl,name,space,weight,armor,damage,damagetype,ability,current);
        }

        private void modify_button_Click(object sender, EventArgs e)
        {
            Invoker.controller.Itemmodify(ident, type, value, lvl, name, space, weight, armor, damage, damagetype, ability);
            current.Close();
        }

        private void deleter_button_Click(object sender, EventArgs e)
        {
            Invoker.controller.Itemdestroy(ident);
        }
    }
}
