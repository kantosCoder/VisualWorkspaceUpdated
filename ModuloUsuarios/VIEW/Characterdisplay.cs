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
    public partial class Characterdisplay : Form
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
        private String image = "";
        private String biography = "";
        private Characterdisplay pointer;
        public Characterdisplay()
        {
            
            InitializeComponent();
        }

        public void cardconstructor(Charcard card) {
            this.charroster.Controls.Add(card);
        }

        public void detailload(String aname, String aclass, String arace,
            String alvl, String alife, String aenergy, String axp, String agold,
             String aforce, String adexer, String abody, String aintel, String acharism, String img, String bio, Characterdisplay target) {
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
            detailshow();
        }

        public void detailshow() {
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
                pointer.picturedetailed.Image = null;
            }
        }


        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Back_Click(object sender, EventArgs e)
        {
            Invoker.controller.Nexus();
            this.Close();
        }
    }
}
