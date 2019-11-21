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
            Characterdisplay chardis = new Characterdisplay();
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
                Charcard current = new Charcard(name, chrclass, race,
                lvl, life, energy, xp, gold, force, dexer, body, intel, charism, img, bio, chardis);
                chardis.cardconstructor(current);
                current.fieldset(current);
            }

            chardis.Show();
        }
        private void cardconstructor(List<String> array, Charcard obj)
        {

            
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