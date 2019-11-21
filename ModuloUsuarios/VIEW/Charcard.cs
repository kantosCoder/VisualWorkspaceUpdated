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
    public partial class Charcard : UserControl
    {
        private String name = "";
        private String chrclass = "";
        private String race = "";
        private String lvl = "";
        private String life = "";
        private String energy = "";
        private String xp = "";
        private String gold = "";
        private String force = "";
        private String dexer = "";
        private String body = "";
        private String intel = "";
        private String charism = "";
        private String photoloc = "";
        private String biography = "";
        private Display current;

        public Charcard(String aname, String aclass, String arace,
            String alvl, String alife, String aenergy, String axp, String agold,
             String aforce, String adexer, String abody, String aintel, String acharism, String photo, String bio, Display target)
        {
            
            name = aname;
            chrclass = aclass;
            race = arace;
            lvl = alvl;
            life = alife;
            energy = aenergy;
            xp = axp;
            gold = agold;
            force = aforce;
            dexer = adexer;
            body = abody;
            intel = aintel;
            charism = acharism;
            current = target;
            photoloc = photo;
            biography = bio;
            InitializeComponent();
        }
        private void Charcard_Load(object sender, EventArgs e)
        {
            //CARGAR DATOS A DETALLE
            current.chardetailload(name,chrclass,race,lvl,life,energy,xp,gold,force,dexer,body,intel,charism,photoloc,biography,current);

        }
        public void fieldset(Charcard current) {
            current.charname.Text = name;
            current.charclass.Text = chrclass;
            current.charrace.Text = race;
            current.charlvl.Text = lvl;
            current.charlife.Text = life;
            current.charenergy.Text = energy;
            current.charxp.Text = xp;
            current.chargold.Text = gold;
            try
            {
                current.imagebox.Image = Image.FromFile(photoloc);
            }
            catch (Exception) {
                var replacer = new Bitmap(ModuloUsuarios.Properties.Resources.character);
                current.imagebox.Image = replacer;
            }
        }
    }
}
