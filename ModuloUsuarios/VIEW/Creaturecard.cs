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
    public partial class Creaturecard : UserControl
    {
        private String ident = "";
        private String name = "";
        private String lvl = "";
        private String life = "";
        private String max_life = "";
        private String aversion = "";
        private String damage = "";
        private String photoloc = "";
        private String biography = "";
        private Display current;

        public Creaturecard(String id, String aname,
            String alvl, String a_version, String alife, String malife, String admg, String photo, String bio, Display target)
        {
            ident = id;
            name = aname;
            lvl = alvl;
            life = alife;
            max_life = malife;
            aversion = a_version;
            damage = admg;
            current = target;
            photoloc = photo;
            biography = bio;
            InitializeComponent();
        }
        public void fieldset(Creaturecard current) {
            current.creaturename.Text = name;
            current.creaturelevel.Text = lvl;
            current.creaturelife.Text = "Vida: "+life+"/"+max_life;
            current.creatureaversion.Text = "Aversion: "+aversion;
            current.creaturebasedamage.Text = "Daño: "+damage;
            try
            {
                current.creatureimage.Image = Image.FromFile(photoloc);
            }
            catch (Exception) {
                var replacer = new Bitmap(ModuloUsuarios.Properties.Resources.creature);
                current.creatureimage.Image = replacer;
            }
        }

        private void Creaturecard_Load(object sender, EventArgs e)
        {
            //CARGAR DATOS A DETALLE
            current.creaturedetailload(name, lvl, life, max_life, aversion, damage, photoloc, biography, current);
        }

        private void modify_button_Click(object sender, EventArgs e)
        {
            Invoker.controller.Creaturemodify(ident, name, lvl, life, max_life, aversion, damage, photoloc, biography);
            current.Close();
        }

        private void deleter_button_Click(object sender, EventArgs e)
        {
            Invoker.controller.Creaturedestroy(ident);
            //refresh... current.Close();
        }
    }
}
