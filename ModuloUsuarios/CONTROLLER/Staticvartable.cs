using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuloUsuarios
{
    //ESTA CLASE CONTIENE LAS VARIABLES ESTATICAS DE LA SESION
    class Staticvartable
    {
        private static String currentrole = "";
        private int currentwindow = 0;
        private int loginattemp = 0;
        private Boolean engine = true;
        private static String mode = "modify";

        //SETTERS AND GETTERS
        public void Rolesaver(String role) {
            currentrole = role;
        }
        public String Rolegetter() {
            return currentrole;
        }
        public void windowchoice(int win)
        {
            currentwindow = win;
        }
        public Boolean enginelife()
        {
            return engine;
        }
        public int windowread() {
            return currentwindow;
        }
        public void setmode(String amode)
        {
            mode = amode;
        }
        public String getmode()
        {
            return mode;
        }
        public void badlogin()
        {
            loginattemp++;
        }
        public int getbadlogin()
        {
            return loginattemp;
        }
        public void resetlogin()
        {
            loginattemp = 0;
        }
        //CONSTRUCTOR DEFAULT
        public Staticvartable() { 
        }
    }
}
