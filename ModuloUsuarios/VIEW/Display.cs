using ModuloUsuarios.MODEL;
using System;
using System.Collections;
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
    public partial class Display : Form
    {
        //STRINGS CARDS
        private String name = "";
        private String chrclass = "";
        private String race = "";
        private String lvl = "";
        private String life = "";
        private String damage = "";
        private String aversion = "";
        private String energy = "";
        private String xp = "";
        private String gold = "";
        private String force = "";
        private String dexer = "";
        private String body = "";
        private String intel = "";
        private String charism = "";
        private String type = "";
        private String value = "";
        private String space = "";
        private String weight = "";
        private String armor = "";
        private String ability = "";
        private String image = "";
        private String biography = "";
        private Display pointer;
        public Display()
        {
            
            InitializeComponent();
        }
        //Carga de CARDS
        //chars
        public void charcardconstructor(Charcard card) {
            this.cardroster.Controls.Add(card);
        }
        //creatures
        public void creaturecardconstructor(Creaturecard card)
        {
            this.cardroster.Controls.Add(card);
        }
        //items
        public void itemcardconstructor(Itemcard card)
        {
            this.cardroster.Controls.Add(card);
        }
        //abilities
        public void abilitycardconstructor(Abilitycard card)
        {
            this.cardroster.Controls.Add(card);
        }
        //users
        public void usercardconstructor(Usercard card)
        {
            this.cardroster.Controls.Add(card);
        }
        //Carga de DETAILS
        //chars
        public void chardetailload(String aname, String aclass, String arace,
            String alvl, String alife, String aenergy, String axp, String agold,
             String aforce, String adexer, String abody, String aintel, String acharism, String img, String bio, Display target) {
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
            image = img;
            biography = bio;
            pointer = target;
            chardetailshow();
        }

        public void chardetailshow() {
            pointer.chardetail_name.Text = name;
            pointer.chardetail_class.Text = chrclass;
            pointer.chardetail_race.Text = race;
            pointer.chardetail_lvl.Text = lvl;
            pointer.chardetail_life.Text = life;
            pointer.chardetail_energy.Text = energy;
            pointer.chardetail_experience.Text = xp;
            pointer.chardetail_gold.Text = gold;
            pointer.chardetail_force.Text = force;
            pointer.chardetail_dexer.Text = dexer;
            pointer.chardetail_body.Text = body;
            pointer.chardetail_intel.Text = intel;
            pointer.chardetail_charism.Text = charism;
            pointer.chardetail_bio.Text = biography;
            pointer.chardetails.Visible = true;
            try
            {
                pointer.picturedetailed.Image = Image.FromFile(image);
            }
            catch (Exception)
            {
                var replacer = new Bitmap(ModuloUsuarios.Properties.Resources.character);
                pointer.picturedetailed.Image = replacer;
            }
        }
        //creatures
        public void creaturedetailload(String aname, String alvl, String alife, String a_version, String dmg, String img, String bio, Display target)
        {
            name = aname;
            lvl = alvl;
            life = alife;
            damage = dmg;
            aversion = a_version;
            image = img;
            biography = bio;
            pointer = target;
            creaturedetailshow();
        }

        public void creaturedetailshow()
        {
            pointer.chardetail_name.Text = name;
            pointer.chardetail_class.Text = "";
            pointer.chardetail_race.Text = "";
            pointer.chardetail_lvl.Text = lvl;
            pointer.chardetail_life.Text = life;
            pointer.chardetail_energy.Text = "";
            pointer.chardetail_experience.Text = "";
            pointer.chardetail_gold.Text = gold;
            pointer.chardetail_force.Text = damage;
            pointer.chardetail_dexer.Text = aversion;
            pointer.chardetail_body.Text = "";
            pointer.chardetail_intel.Text = "";
            pointer.chardetail_charism.Text = "";
            pointer.chardetail_bio.Text = biography;
            pointer.chardetails.Visible = true;
            try
            {
                pointer.picturedetailed.Image = Image.FromFile(image);
            }
            catch (Exception)
            {
                var replacer = new Bitmap(ModuloUsuarios.Properties.Resources.creature);
                pointer.picturedetailed.Image = replacer;
            }
        }
        //items
        public void itemdetailload(String atype, String avalue, String alvl, String aname,
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
            pointer = target;
            //metodo relacion habilidades...
            itemdetailshow();
        }

        public void itemdetailshow()
        {
            pointer.chardetail_name.Text = name;
            pointer.chardetail_class.Text = type;
            pointer.chardetail_race.Text = space;
            pointer.chardetail_lvl.Text = lvl;
            pointer.chardetail_life.Text = "";
            pointer.chardetail_energy.Text = "";
            pointer.chardetail_experience.Text = "";
            pointer.chardetail_gold.Text = value;
            pointer.chardetail_force.Text = damage;
            pointer.chardetail_dexer.Text = armor;
            pointer.chardetail_body.Text = weight + space;
            pointer.chardetail_intel.Text = "";
            pointer.chardetail_charism.Text = "";
            pointer.chardetail_bio.Text = ability;
            pointer.status.Text = "";
            pointer.attrs.Text = "Propiedades";
            pointer.chardetails.Visible = true;
            var replacer = new Bitmap(ModuloUsuarios.Properties.Resources.items);
                pointer.picturedetailed.Image = replacer;
        }
        //items
        public void abilitydetailload(String aname, String alvl, String atype, String alife, 
            String aenergy, String photo, String bio, Display target)
        {
            name = aname;
            lvl = alvl;
            type = atype;
            life = alife;
            energy = aenergy;
            pointer = target;
            image = photo;
            biography = bio;
            abilitydetailshow();
        }

        public void abilitydetailshow()
        {
            pointer.chardetail_name.Text = name;
            pointer.chardetail_class.Text = type;
            pointer.chardetail_race.Text = "";
            pointer.chardetail_lvl.Text = lvl;
            pointer.chardetail_life.Text = "Salud: "+life;
            pointer.chardetail_energy.Text = "Energia: "+energy;
            pointer.chardetail_experience.Text = "";
            pointer.chardetail_gold.Text = "";
            pointer.chardetail_force.Text = "";
            pointer.chardetail_dexer.Text = "";
            pointer.chardetail_body.Text = "";
            pointer.chardetail_intel.Text = "";
            pointer.chardetail_charism.Text = "";
            pointer.chardetail_bio.Text = biography;
            pointer.status.Text = "Efectos";
            pointer.attrs.Text = "";
            pointer.chardetails.Visible = true;
            var replacer = new Bitmap(ModuloUsuarios.Properties.Resources.skill);
            pointer.picturedetailed.Image = replacer;
        }
        private void Back_Click(object sender, EventArgs e)
        {
            Invoker.controller.Nexus();
            this.Close();
        }
    }
}
