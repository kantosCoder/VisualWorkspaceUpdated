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
        //characters
        public void Chars()
        {
            Display chardis = new Display();
            //CREACION DE ARRAYS
            List<String> charray = new List<String>();
            Caller_characters charreader = new Caller_characters();
            //LECTURA DE PERSONAJES
            charray = charreader.charloader(charray);
            //CREACION DE TARJETAS
            for (int i = 0; i < charray.Count; i = i + 18)
            {
                String name = charray[i];
                String chrclass = charray[i + 1];
                String race = charray[i + 2];
                String lvl = charray[i + 3];
                String life = "Vida: " + charray[i + 5] + "/" + charray[i + 4];
                String energy = "Energia: " + charray[i + 7] + "/" + charray[i + 6];
                String xp = "XP: " + charray[i + 9] + "/" + charray[i + 8];
                String gold = "Gold: " + charray[i + 10];
                String force = "Fuerza: " + charray[i+ 11];
                String dexer = "Destreza: " + charray[i + 12];
                String body = "Aguante: " + charray[i + 13];
                String intel = "Inteligencia: " + charray[i + 14];
                String charism = "Carisma: " + charray[i + 15];
                String img = charray[i + 16];
                String bio = charray[i + 17];
                //control empty fields (to do)
                Charcard current = new Charcard(name, chrclass, race,
                lvl, life, energy, xp, gold, force, dexer, body, intel, charism, img, bio, chardis);
                chardis.charcardconstructor(current);
                current.fieldset(current);
            }

            chardis.Show();
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
            for (int i = 0; i < crearray.Count; i = i + 8)
            {
                String name = crearray[i];
                String lvl = crearray[i + 1];
                String a_version = "Aversión: " + crearray[i + 2];
                String life = "Vida: " + crearray[i + 4] + "/" + crearray[i + 3];
                String bio = ""+ crearray[i + 5];
                String dmg = "Daño base: " + crearray[i + 6];
                String img = crearray[i + 6];
                //control empty fields (to do)
                Creaturecard current = new Creaturecard(name, lvl, a_version, life, dmg, img, bio, creaturedis);
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