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
    public partial class Abilitycard : UserControl
    {
        private String name = "";
        private String lvl = "";
        private String type = "";
        private String damage = "";
        private String photoloc = "";
        private String biography = "";
        private String energy = "";
        private String life = "";
        private Display current;

        public Abilitycard(String aname, String alvl, String atype, String alife, 
            String aenergy, String photo, String bio, Display target)
        {
            
            name = aname;
            lvl = alvl;
            type = atype;
            life = alife;
            energy = aenergy;
            current = target;
            photoloc = photo;
            biography = bio;
            InitializeComponent();
        }
        public void fieldset(Abilitycard current) {
            current.abilityname.Text = name;
            current.abilitylevel.Text = lvl;
            current.abilitytype.Text = type;
            current.abilitydescr.Text = biography;
            try
            {
                current.abilityimg.Image = Image.FromFile(photoloc);
            }
            catch (Exception) {
                var replacer = new Bitmap(ModuloUsuarios.Properties.Resources.skill);
                current.abilityimg.Image = replacer;
            }
        }

        private void Abilitycard_load(object sender, EventArgs e)
        {
            current.abilitydetailload(name, lvl, type, life, energy, photoloc, biography, current);
        }

    }
}
