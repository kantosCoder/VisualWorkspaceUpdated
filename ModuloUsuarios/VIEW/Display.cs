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
        private String maxlife = "";
        private String damage = "";
        private String damagetype = "";
        private String aversion = "";
        private String energy = "";
        private String maxenergy = "";
        private String xp = "";
        private String max_xp = "";
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
            String alvl, String alife, String malife, String aenergy, String maenergy, String axp, String maxp, String agold,
             String aforce, String adexer, String abody, String aintel, String acharism, String img, String bio, Display target) {
            name = aname;
            chrclass = aclass;
            race = arace;
            lvl = alvl;
            life = alife;
            maxlife = malife;
            energy = aenergy;
            maxenergy = maenergy;
            xp = axp;
            max_xp = maxp;
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
            pointer.chardetail_life.Text = "Vida: "+life+"/"+maxlife;
            pointer.chardetail_energy.Text = "Energia: " + energy + "/" + maxenergy;
            pointer.chardetail_experience.Text = "XP: " + xp + "/" + max_xp;
            pointer.chardetail_gold.Text = "Gold: "+gold;
            pointer.chardetail_force.Text = "Fuerza: "+force;
            pointer.chardetail_dexer.Text = "Destreza: "+dexer;
            pointer.chardetail_body.Text = "Resistencia: "+body;
            pointer.chardetail_intel.Text = "Inteligencia: "+intel;
            pointer.chardetail_charism.Text = "Carisma: "+charism;
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
        public void creaturedetailload(String aname, String alvl, String alife, String malife, String a_version, String dmg, String img, String bio, Display target)
        {
            name = aname;
            lvl = alvl;
            life = alife;
            maxlife = malife;
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
            pointer.chardetail_life.Text = "Vida: " + life + "/" + maxlife;
            pointer.chardetail_energy.Text = "";
            pointer.chardetail_experience.Text = "";
            pointer.chardetail_gold.Text = "";
            pointer.chardetail_force.Text = "Daño: "+damage;
            pointer.chardetail_dexer.Text = "Aversion: "+aversion;
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
            String aspace, String aweight, String a_rmor, String admg, String dmgtype, String a_bility, Display target)
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
            damagetype = dmgtype;
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
            pointer.chardetail_gold.Text = "valor: "+value;
            pointer.chardetail_force.Text = "Daño: "+damage+"("+damagetype+")";
            pointer.chardetail_dexer.Text = "Armadura: "+armor;
            pointer.chardetail_body.Text = weight+"kg" + "("+space+" slots)";
            pointer.chardetail_intel.Text = "";
            pointer.chardetail_charism.Text = "";
            pointer.chardetail_bio.Text = "Habilidades: "+ability;
            pointer.status.Text = "";
            pointer.attrs.Text = "Propiedades";
            pointer.chardetails.Visible = true;
            var replacer = new Bitmap(ModuloUsuarios.Properties.Resources.items);
                pointer.picturedetailed.Image = replacer;
        }
        //ability
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
        //users
        public void userdetailload(String aname, String atype, Display target)
        {
            name = aname;
            type = atype;
            pointer = target;
            userdetailshow();
        }

        public void userdetailshow()
        {
            pointer.chardetail_name.Text = name;
            pointer.chardetail_class.Text = type;
            pointer.chardetail_race.Text = "";
            pointer.chardetail_lvl.Text = "";
            pointer.chardetail_life.Text = "";
            pointer.chardetail_energy.Text = "";
            pointer.chardetail_experience.Text = "";
            pointer.chardetail_gold.Text = "";
            pointer.chardetail_force.Text = "";
            pointer.chardetail_dexer.Text = "";
            pointer.chardetail_body.Text = "";
            pointer.chardetail_intel.Text = "";
            pointer.chardetail_charism.Text = "";
            pointer.chardetail_bio.Text = "";
            pointer.status.Text = "";
            pointer.attrs.Text = "";
            pointer.chardetails.Visible = true;
            var replacer = new Bitmap(ModuloUsuarios.Properties.Resources.user);
            pointer.picturedetailed.Image = replacer;
        }
        private void Back_Click(object sender, EventArgs e)
        {
            Invoker.controller.Nexus();
            this.Close();
        }
    }
}
