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
        private String name = "";
        private String lvl = "";
        private String type = "";
        private String value = "";
        private String space = "";
        private String weight = "";
        private String armor = "";
        private String ability = "";
        private String damage = "";
        private Display current;

        public Itemcard(String atype, String avalue, String alvl, String aname, 
            String aspace, String aweight, String a_rmor, String admg, String a_bility, Display target)
        {
            type = atype;
            value = avalue;
            lvl = alvl;
            name = aname;
            space = aspace;
            weight = aweight;
            armor = a_rmor;
            ability = a_bility;
            damage = admg;
            current = target;
            InitializeComponent();
        }
        public void fieldset(Itemcard current) {
            current.itemname.Text = name;
            current.itemtype.Text = type;
            current.itemvalue.Text = value;
            current.itemlevel.Text = lvl;
            current.itemspace.Text = space;
            current.itemweight.Text = weight;
            current.itemdamage.Text = damage;
            current.itemarmor.Text = armor;
                //items would not load custom images
                var replacer = new Bitmap(ModuloUsuarios.Properties.Resources.items);
                current.creatureimage.Image = replacer;
        }

        private void Item_load(object sender, EventArgs e)
        {
            current.itemdetailload(type,value,lvl,name,space,weight,armor,damage,ability,current);
        }
    }
}
