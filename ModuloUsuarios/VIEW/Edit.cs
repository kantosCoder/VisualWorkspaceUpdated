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
    public partial class Edit : Form
    {
        //STRINGS CARDS
        private String ident = "";
        private String name = "";
        private String chrclass = "";
        private String race = "";
        private String lvl = "";
        private String life = "";
        private String maxlife = "";
        private String damage = "";
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
        private String document = "";
        private Edit pointer;
        public Edit() { 
            InitializeComponent();
        }

        //Carga de datos de card
        //chars
        public void charinfo(String id, String aname, String aclass, String arace,
            String alvl, String alife, String malife, String aenergy, String maenergy, String axp, String maxp, String agold,
             String aforce, String adexer, String abody, String aintel, String acharism, String img, String bio, Edit target, String kind)
        {
            ident = id;
            document = kind;
            pointer = target;
            if (kind == "char")
            {
                chardetailload(aname, aclass, arace, alvl, alife, malife, aenergy, maenergy, axp, maxp, agold, aforce, adexer, abody, aintel, acharism, img, bio);
            }
        }
    public void chardetailload(String aname, String aclass, String arace,
            String alvl, String alife, String malife, String aenergy, String maenergy, String axp, String maxp, String agold,
             String aforce, String adexer, String abody, String aintel, String acharism, String img, String bio) {
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
            chardetailshow();
        }

        public void chardetailshow() {
            //EDIT FIELDS
            pointer.namefield.Text = name;
            pointer.classfield.Text = chrclass;
            pointer.racefield.Text = race;
            pointer.levelfield.Text = lvl;
            pointer.lifefield.Text = life;
            pointer.maxlifefield.Text = maxlife;
            pointer.energyfield.Text = energy;
            pointer.maxenergyfield.Text = maxenergy;
            pointer.experiencefield.Text = xp;
            pointer.maxxpfield.Text = max_xp;
            pointer.goldfield.Text = gold;
            pointer.forcefield.Text = force;
            pointer.dexerityfield.Text = dexer;
            pointer.bodyfield.Text = body;
            pointer.intelfield.Text = intel;
            pointer.charismfield.Text = charism;
            pointer.biofield.Text = biography;
            //TITLE TEXT
            pointer.nameofedition.Text = "Edicion de personaje: " + name;
            pointer.nameedit.Text = "Nombre";
            pointer.leveledit.Text = "Nivel";
            pointer.classedit.Text = "Clase";
            pointer.raceedit.Text = "Raza";
            pointer.lifeedit.Text = "Vida actual/max";
            pointer.energyedit.Text = "Energia actual/max";
            pointer.experienceedit.Text = "XP actual/max";
            pointer.goldedit.Text = "Gold"; //to staticvartable currency?
            pointer.forceedit.Text = "Fuerza";
            pointer.dexerityedit.Text = "Destreza";
            pointer.bodyedit.Text = "Aguante";
            pointer.inteledit.Text = "Intelecto";
            pointer.charismedit.Text = "Carisma";

            try
            {
                pointer.imageedit.Image = Image.FromFile(image);
            }
            catch (Exception)
            {
                var replacer = new Bitmap(ModuloUsuarios.Properties.Resources.character);
                pointer.imageedit.Image = replacer;
            }
        }
        private void Back_Click(object sender, EventArgs e)
        {
            Invoker.controller.Chars();
            this.Close();
        }

        private void savebutton_Click(object sender, EventArgs e)
        {
            Invoker.controller.Chars();
            if (document == "char")
            {
                //insert popup to confirm?
                //saves the data to the strings
                name = pointer.namefield.Text;
                chrclass = pointer.classfield.Text;
                race = pointer.racefield.Text;
                lvl = pointer.levelfield.Text;
                life = pointer.lifefield.Text;
                maxlife = pointer.maxlifefield.Text;
                energy = pointer.energyfield.Text;
                maxenergy = pointer.maxenergyfield.Text;
                xp = pointer.experiencefield.Text;
                max_xp = pointer.maxxpfield.Text;
                gold = pointer.goldfield.Text;
                force = pointer.forcefield.Text;
                dexer = pointer.dexerityfield.Text;
                body = pointer.bodyfield.Text;
                intel = pointer.intelfield.Text;
                charism = pointer.charismfield.Text;
                biography = pointer.biofield.Text;
                Invoker.controller.Charrewrite(ident,name,chrclass,race,lvl,life,maxlife,energy,maxenergy,xp,max_xp,gold,force,dexer,body,intel,charism,image,biography);
            }
            this.Close();
        }
    }
}
