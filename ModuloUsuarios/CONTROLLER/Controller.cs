using ModuloUsuarios.MODEL;
using System;
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
    public partial class Controller : Form
    {
        public Controller()
        {
            Staticvartable engine = new Staticvartable();
            InitializeComponent();
            Login logwin = new Login();
            logwin.Show();
            //AUTORELLENADO DE PASS(SOLO DEBUG)
            logwin.autofill();
            //FIN AUTORRELLENADO DE PASS
        }
        //lanzar otras ventanas
        //main menu
        public void Nexus() { 
            Nexus mainwin = new Nexus();
            mainwin.Show();
        }
        //login screen
        public void Login()
        {
            Login login = new Login();
            login.Show();
        }
        //DISPLAY CLASS
        //characters
        public void Chars(Boolean redo)
        {
            Display chardis = new Display();
            //CREACION DE ARRAYS
            List<String> charray = new List<String>();
            Caller_characters charreader = new Caller_characters();
            //LECTURA DE PERSONAJES
            charray = charreader.charloader(charray);
            //CREACION DE TARJETAS
            void cardload()
            {
                for (int i = 0; i < charray.Count; i = i + 19)
                {
                    String id = charray[i];
                    String name = charray[i + 1];
                    String chrclass = charray[i + 2];
                    String race = charray[i + 3];
                    String lvl = charray[i + 4];
                    String life = charray[i + 6];
                    String maxlife = charray[i + 5];
                    String energy = charray[i + 8];
                    String maxenergy = charray[i + 7];
                    String xp = charray[i + 10];
                    String max_xp = charray[i + 9];
                    String gold = charray[i + 11];
                    String force = charray[i + 12];
                    String dexer = charray[i + 13];
                    String body = charray[i + 14];
                    String intel = charray[i + 15];
                    String charism = charray[i + 16];
                    String img = charray[i + 17];
                    String bio = charray[i + 18];
                    //control empty fields (to do)
                    Charcard current = new Charcard(id, name, chrclass, race,
                    lvl, life, maxlife, energy, maxenergy, xp, max_xp, gold, force, dexer, body, intel, charism, img, bio, chardis);
                    chardis.charcardconstructor(current);
                    current.fieldset(current);
                }
                chardis.Show();
            }
            cardload();
            /*refrescado...
            if (redo == true)
            {
                chardis.Close();
                chardis = new Display();
                cardload();
            }*/
        }
        //creatures
        public void Creatures()
        {
            Display creaturedis = new Display();
            //CREACION DE ARRAYS
            List<String> crearray = new List<String>();
            Caller_creatures charreader = new Caller_creatures();
            //LECTURA DE CRIATURAS
            crearray = charreader.creatureloader(crearray);
            //CREACION DE TARJETAS
            for (int i = 0; i < crearray.Count; i = i + 9)
            {
                String id = crearray[i];
                String name = crearray[i + 1];
                String lvl = crearray[i + 2];
                String a_version = crearray[i + 3];
                String life = crearray[i + 5];
                String malife = crearray[i + 4];
                String bio = crearray[i + 6];
                String dmg = crearray[i + 7];
                String img = crearray[i + 8];
                //control empty fields (to do)
                Creaturecard current = new Creaturecard(id, name, lvl, a_version, life, malife, dmg, img, bio, creaturedis);
                creaturedis.creaturecardconstructor(current);
                current.fieldset(current);
            }

            creaturedis.Show();
        }
        //items
        public void Items()
        {
            Display itemdis = new Display();
            //CREACION DE ARRAYS
            List<String> itemarray = new List<String>();
            Caller_items itemreader = new Caller_items();
            //LECTURA DE CRIATURAS
            itemarray = itemreader.itemloader(itemarray);
            //CREACION DE TARJETAS
            for (int i = 0; i < itemarray.Count; i = i + 10)
            {
                String type = itemarray[i];
                String value = itemarray[i + 1]+" gold";
                String lvl = itemarray[i + 2];
                String name = itemarray[i+ 3];
                String space = "("+itemarray[i + 4]+" slots)";
                String weight = itemarray[i + 5]+"kg";
                String armor = "Armadura: "+itemarray[i + 6];
                String dmg = "Daño: " + itemarray[i + 8]+"("+itemarray[i + 7]+")";
                String ability = "Habilidades: "+itemarray[i + 9];
                //control empty fields (to do)
                Itemcard current = new Itemcard(type,value,lvl,name, space,weight,armor,dmg,ability,itemdis);
                itemdis.itemcardconstructor(current);
                current.fieldset(current);
            }

            itemdis.Show();
        }
        //abilities
        public void Abilities()
        {
            Display abildis = new Display();
            //CREACION DE ARRAYS
            List<String> abilarray = new List<String>();
            Caller_abilities itemreader = new Caller_abilities();
            //LECTURA DE CRIATURAS
            abilarray = itemreader.abilityloader(abilarray);
            //CREACION DE TARJETAS
            for (int i = 0; i < abilarray.Count; i = i + 7)
            {
                String name = abilarray[i];
                String lvl = abilarray[i + 1];
                String type = abilarray[i + 2];
                String life = abilarray[i + 3];
                String energy = abilarray[i + 4];
                String img = abilarray[i + 5];
                String bio = abilarray[i + 6];
                //control empty fields (to do)
                Abilitycard current = new Abilitycard(name, lvl, type, life, energy, img, bio, abildis);
                abildis.abilitycardconstructor(current);
                current.fieldset(current);
            }

            abildis.Show();
        }
        //users
        public void Users()
        {
            Display userdis = new Display();
            //CREACION DE ARRAYS
            List<String> userarray = new List<String>();
            Caller_users userreader = new Caller_users();
            //LECTURA DE CRIATURAS
            userarray = userreader.userloader(userarray);
            //CREACION DE TARJETAS
            for (int i = 0; i < userarray.Count; i = i + 2)
            {
                String name = userarray[i + 1];
                String type = userarray[i];
                //control empty fields (to do)
                Usercard current = new Usercard(name, type, userdis);
                userdis.usercardconstructor(current);
                current.fieldset(current);
            }

            userdis.Show();
        }
        //END DISPLAY CLASS

        //EDIT CLASS
        //Characters
        //char to modify
        public void Charmodify(String id,String aname, String aclass, String arace,
            String alvl, String alife, String malife, String aenergy, String maenergy, String axp, String maxp, String agold,
             String aforce, String adexer, String abody, String aintel, String acharism, String img, String bio) {
            Edit useredit = new Edit();
            useredit.charinfo(id, aname, aclass, arace, alvl, alife, malife, aenergy, maenergy, axp, maxp, agold, aforce, adexer, abody, aintel, acharism, img, bio, useredit);
            useredit.Show();
        }
        //char save changes
        public void Charrewrite(String id, String aname, String aclass, String arace,
            String alvl, String alife, String malife, String aenergy, String maenergy, String axp, String maxp, String agold,
             String aforce, String adexer, String abody, String aintel, String acharism, String img, String bio, String mode) {
            Caller_characters charsaver = new Caller_characters();
                if (mode.Equals("modify"))
                {
                    charsaver.charrewrite(id, aname, aclass, arace, alvl, alife, malife, aenergy, maenergy, axp, maxp, agold, aforce, adexer, abody, aintel, acharism, img, bio, "modify");
                }
                if (mode.Equals("create"))
                {
                charsaver.charrewrite(id, aname, aclass, arace, alvl, alife, malife, aenergy, maenergy, axp, maxp, agold, aforce, adexer, abody, aintel, acharism, img, bio, "create");
                }
            }
        //char destroy
        public void Chardestroy(String id) {
            Caller_characters chardestroyer = new Caller_characters();
            chardestroyer.chardestroy(id);
        }
        //Creatures
        //creature to modify
        public void Creaturemodify(String id, String aname,
            String alvl, String a_version, String alife, String malife, String admg, String photo, String bio)
        {
            Edit creatureedit = new Edit();
            creatureedit.creatureinfo(id, aname, alvl, malife, alife, a_version, bio, admg, photo, creatureedit);
            creatureedit.Show();
        }
        //creature save changes
        public void Creaturewrite(String id, String aname,
            String alvl, String a_version, String alife, String malife, String admg, String photo, String bio, String mode)
        {
            Caller_creatures creaturesaver = new Caller_creatures();
            if (mode.Equals("modify"))
            {
                creaturesaver.creaturerrewrite(id, aname, alvl, a_version, alife, malife, admg, photo, bio, "modify");
            }
            if (mode.Equals("create"))
            {
                creaturesaver.creaturerrewrite(id, aname, alvl, a_version, alife, malife, admg, photo, bio, "create");
            }
        }
        //creature destroy
        public void Creaturedestroy(String id)
        {
            Caller_creatures creaturedestroyer = new Caller_creatures();
            creaturedestroyer.creaturedestroy(id);
        }






















        //ELIMINA LA VISTA DEL CONTROLADOR.
        protected override void OnLoad(EventArgs e)
        {
            Visible = false; // esconde el controlador
            ShowInTaskbar = false; // lo elimina de la ventana de tareas
            Opacity = 0;

            base.OnLoad(e);
        }
    }
}