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
        private String role = "";
        private String nick = "";
        private String pass = "";
        private String oldpass = "";
        private String ident = "";
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
        private String document = "";
        private Edit pointer;
        public Edit() { 
            InitializeComponent();
        }

        //Carga de datos de card
        //chars
        public void charinfo(String id, String aname, String aclass, String arace,
            String alvl, String alife, String malife, String aenergy, String maenergy, String axp, String maxp, String agold,
             String aforce, String adexer, String abody, String aintel, String acharism, String img, String bio, Edit target)
        {
            ident = id;
            document = "char";
            pointer = target;
                chardetailload(aname, aclass, arace, alvl, alife, malife, aenergy, maenergy, axp, maxp, agold, aforce, adexer, abody, aintel, acharism, img, bio);
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

        //creatures
        public void creatureinfo(String id, String aname,
            String alvl, String a_version, String alife, String malife, String bio, String dmg, String img, Edit target)
        {
            ident = id;
            document = "creature";
            pointer = target;
                creaturedetailload(aname, alvl, a_version, alife, malife, bio, dmg, img);
        }
        public void creaturedetailload(String aname,
            String alvl, String a_version, String alife, String malife, String bio, String dmg, String img)
        {
            name = aname;
            lvl = alvl;
            aversion = a_version;
            life = alife;
            maxlife = malife;
            damage = dmg;
            image = img;
            biography = bio;
            creaturedetailshow();
        }

        public void creaturedetailshow()
        {
            //EDIT FIELDS
            pointer.namefield.Text = name;
            pointer.classfield.Text = aversion;
            pointer.racefield.Text = damage;
            pointer.levelfield.Text = lvl;
            pointer.lifefield.Text = life;
            pointer.maxlifefield.Text = maxlife;
            pointer.energyfield.Visible = false;
            pointer.maxenergyfield.Visible = false;
            pointer.experiencefield.Visible = false;
            pointer.maxxpfield.Visible = false;
            pointer.goldfield.Visible = false;
            pointer.forcefield.Visible = false;
            pointer.dexerityfield.Visible = false;
            pointer.bodyfield.Visible = false;
            pointer.intelfield.Visible = false;
            pointer.charismfield.Visible = false;
            pointer.biofield.Text = biography;
            //TITLE TEXT
            pointer.nameofedition.Text = "Edicion de criatura: " + name;
            pointer.nameedit.Text = "Nombre";
            pointer.leveledit.Text = "Nivel";
            pointer.classedit.Text = "Aversion";
            pointer.raceedit.Text = "Daño";
            pointer.lifeedit.Text = "Vida actual/max";
            pointer.energyedit.Text = "";
            pointer.experienceedit.Text = "";
            pointer.goldedit.Text = "";
            pointer.forceedit.Text = "";
            pointer.dexerityedit.Text = "";
            pointer.bodyedit.Text = "";
            pointer.inteledit.Text = "";
            pointer.charismedit.Text = "";
            pointer.attrs.Text = "";

            try
            {
                pointer.imageedit.Image = Image.FromFile(image);
            }
            catch (Exception)
            {
                var replacer = new Bitmap(ModuloUsuarios.Properties.Resources.creature);
                pointer.imageedit.Image = replacer;
            }
        }
        //abilities
        public void abilityinfo(String id, String aname,
            String alvl, String atype, String alife, String aenergy, String photo, String bio, Edit target)
        {
            ident = id;
            document = "ability";
            pointer = target;
            abilitydetailload(aname, alvl, atype, alife, aenergy, photo, bio);
        }
        public void abilitydetailload(String aname,
            String alvl, String atype, String alife, String aenergy, String photo, String bio)
        {
            name = aname;
            lvl = alvl;
            type = atype;
            life = alife;
            energy = aenergy;
            image = photo;
            biography = bio;
            abilitydetailshow();
        }

        public void abilitydetailshow()
        {
            //EDIT FIELDS
            pointer.namefield.Text = name;
            pointer.classfield.Text = type;
            pointer.racefield.Visible = false;
            pointer.levelfield.Text = lvl;
            pointer.lifefield.Text = life;
            pointer.maxlifefield.Visible = false;
            pointer.energyfield.Text = energy;
            pointer.maxenergyfield.Visible = false;
            pointer.experiencefield.Visible = false;
            pointer.maxxpfield.Visible = false;
            pointer.goldfield.Visible = false;
            pointer.forcefield.Visible = false;
            pointer.dexerityfield.Visible = false;
            pointer.bodyfield.Visible = false;
            pointer.intelfield.Visible = false;
            pointer.charismfield.Visible = false;
            pointer.biofield.Text = biography;
            //TITLE TEXT
            pointer.nameofedition.Text = "Edicion de habilidad: " + name;
            pointer.nameedit.Text = "Nombre";
            pointer.leveledit.Text = "Nivel";
            pointer.classedit.Text = "Tipo";
            pointer.raceedit.Text = "";
            pointer.lifeedit.Text = "Vida";
            pointer.energyedit.Text = "Energía";
            pointer.experienceedit.Text = "";
            pointer.goldedit.Text = "";
            pointer.forceedit.Text = "";
            pointer.dexerityedit.Text = "";
            pointer.bodyedit.Text = "";
            pointer.inteledit.Text = "";
            pointer.charismedit.Text = "";
            pointer.attrs.Text = "";

            try
            {
                pointer.imageedit.Image = Image.FromFile(image);
            }
            catch (Exception)
            {
                var replacer = new Bitmap(ModuloUsuarios.Properties.Resources.skill);
                pointer.imageedit.Image = replacer;
            }
        }
        //items
        public void iteminfo(String id, String atype, String avalue, String alvl, String aname,
            String aspace, String aweight, String a_rmor, String admg, String dmgtype, String a_bility, Edit target)
        {
            ident = id;
            document = "item";
            pointer = target;
            itemdetailload(atype, avalue, alvl, aname, aspace, aweight, a_rmor, admg, dmgtype, a_bility);
        }
        public void itemdetailload(String atype, String avalue, String alvl, String aname,
            String aspace, String aweight, String a_rmor, String admg, String dmgtype, String a_bility)
        {
            type = atype;
            value = avalue;
            lvl = alvl;
            name = aname;
            space = aspace;
            weight = aweight;
            armor = a_rmor;
            damage = admg;
            damagetype = dmgtype;
            ability = a_bility;
            itemdetailshow();
        }

        public void itemdetailshow()
        {
            //EDIT FIELDS
            pointer.namefield.Text = name;
            pointer.classfield.Text = type;
            pointer.racefield.Text = value;
            pointer.levelfield.Text = lvl;
            pointer.lifefield.Text = armor;
            pointer.maxlifefield.Visible = false;
            pointer.energyfield.Text = weight;
            pointer.maxenergyfield.Text = space;
            pointer.experiencefield.Text = damage;
            pointer.maxxpfield.Text = damagetype;
            pointer.goldfield.Visible = false;
            pointer.forcefield.Visible = false;
            pointer.dexerityfield.Visible = false;
            pointer.bodyfield.Visible = false;
            pointer.intelfield.Visible = false;
            pointer.charismfield.Visible = false;
            pointer.biofield.Text = ability;
            //TITLE TEXT
            pointer.nameofedition.Text = "Edicion de item: " + name;
            pointer.nameedit.Text = "Nombre";
            pointer.leveledit.Text = "Nivel";
            pointer.classedit.Text = "Tipo";
            pointer.raceedit.Text = "Valor";
            pointer.lifeedit.Text = "Armadura";
            pointer.energyedit.Text = "Peso/Slots";
            pointer.experienceedit.Text = "Daño/tipo";
            pointer.goldedit.Text = "";
            pointer.forceedit.Text = "";
            pointer.dexerityedit.Text = "";
            pointer.bodyedit.Text = "";
            pointer.inteledit.Text = "";
            pointer.charismedit.Text = "";
            pointer.attrs.Text = "";
            pointer.bioedit.Text = "Habilidades";
                var replacer = new Bitmap(ModuloUsuarios.Properties.Resources.items);
                pointer.imageedit.Image = replacer;
        }
        //items
        public void userinfo(String arole, String anick, String apass, Edit target)
        {
            document = "user";
            pointer = target;
            userdetailload(arole, anick, apass);
        }
        public void userdetailload(String arole, String anick, String apass)
        {
            role = arole;
            nick = anick;
            pass = apass;
            userdetailshow();
        }

        public void userdetailshow()
        {
            //EDIT FIELDS
            pointer.namefield.Text = nick;
            pointer.classfield.Text = "";
            pointer.racefield.Text = "";
            pointer.classfield.PasswordChar = '*';
            pointer.racefield.PasswordChar = '*';
            pointer.levelfield.Text = role;
            pointer.lifefield.Visible = false;
            pointer.maxlifefield.Visible = false;
            pointer.energyfield.Visible = false;
            pointer.maxenergyfield.Visible = false;
            pointer.experiencefield.Visible = false;
            pointer.maxxpfield.Visible = false;
            pointer.goldfield.Visible = false;
            pointer.forcefield.Visible = false;
            pointer.dexerityfield.Visible = false;
            pointer.bodyfield.Visible = false;
            pointer.intelfield.Visible = false;
            pointer.charismfield.Visible = false;
            pointer.biofield.Visible = false;
            //TITLE TEXT
            pointer.nameofedition.Text = "Edicion de usuario: " + name;
            pointer.nameedit.Text = "Nombre";
            pointer.leveledit.Text = "Rol";
            pointer.classedit.Text = "Antigua pass";
            pointer.raceedit.Text = "Nueva pass";
            pointer.lifeedit.Text = "";
            pointer.energyedit.Text = "";
            pointer.experienceedit.Text = "";
            pointer.goldedit.Text = "";
            pointer.forceedit.Text = "";
            pointer.dexerityedit.Text = "";
            pointer.bodyedit.Text = "";
            pointer.inteledit.Text = "";
            pointer.charismedit.Text = "";
            pointer.attrs.Text = "";
            pointer.status.Text = "";
            var replacer = new Bitmap(ModuloUsuarios.Properties.Resources.items);
            pointer.imageedit.Image = replacer;
        }
        //back to display
        private void Back_Click(object sender, EventArgs e)
        {
            if (document.Equals("char"))
            {
                Invoker.controller.Chars(false);
                this.Close();
            }
            if (document.Equals("creature"))
            {
                Invoker.controller.Creatures();
                this.Close();
            }
            if (document.Equals("ability"))
            {
                Invoker.controller.Abilities();
                this.Close();
            }
            if (document.Equals("item"))
            {
                Invoker.controller.Items();
                this.Close();
            }
            if (document.Equals("user"))
            {
                Invoker.controller.Users();
                this.Close();
            }
        }

        private void savebutton_Click(object sender, EventArgs e)
        {
            
            if (document.Equals("char"))
            {
                Invoker.controller.Chars(true);
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
                image = pointer.imageedit.ImageLocation;
                Invoker.controller.Charrewrite(ident,name,chrclass,race,lvl,life,maxlife,energy,maxenergy,xp,max_xp,gold,force,dexer,body,intel,charism,image,biography,"modify");
            }
            if (document.Equals("creature"))
            {
                Invoker.controller.Creatures();
                //insert popup to confirm?
                //saves the data to the strings
                name = pointer.namefield.Text;
                aversion = pointer.classfield.Text;
                damage = pointer.racefield.Text;
                lvl = pointer.levelfield.Text;
                life = pointer.lifefield.Text;
                maxlife = pointer.maxlifefield.Text;
                biography = pointer.biofield.Text;
                image = pointer.imageedit.ImageLocation;
                Invoker.controller.Creaturewrite(ident, name, lvl, aversion, life, maxlife, damage, image, biography, "modify");
            }
            if (document.Equals("ability"))
            {
                Invoker.controller.Abilities();
                //insert popup to confirm?
                //saves the data to the strings
                name = pointer.namefield.Text;
                type = pointer.classfield.Text;
                lvl = pointer.levelfield.Text;
                life = pointer.lifefield.Text;
                energy = pointer.energyfield.Text;
                biography = pointer.biofield.Text;
                image = pointer.imageedit.ImageLocation;
                Invoker.controller.Abilitywrite(ident, name, lvl, type, life, energy, image, biography, "modify");
            }
            if (document.Equals("item"))
            {
                Invoker.controller.Items();
                //insert popup to confirm?
                //saves the data to the strings
                type = classfield.Text;
                value = racefield.Text;
                lvl = levelfield.Text;
                name = namefield.Text;
                space = maxenergyfield.Text;
                weight = energyfield.Text;
                armor = lifefield.Text;
                damage = experiencefield.Text;
                ability = biofield.Text;
                Invoker.controller.Itemwrite(ident, type, value, lvl, name, space, weight, armor, damage, damagetype, ability, "modify");
            }
            if (document.Equals("user"))
            {
                Invoker.controller.Users();
                //insert popup to confirm?
                //saves the data to the strings
                nick = pointer.namefield.Text;
                pass = pointer.classfield.Text;
                oldpass = pointer.racefield.Text;
                role = levelfield.Text;
                Invoker.controller.Userwrite(role, nick, pass, oldpass, "modify");
            }
            this.Close();
        }
    }
}
