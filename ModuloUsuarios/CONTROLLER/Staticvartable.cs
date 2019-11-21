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
        private Boolean engine = true;

        //SETTERS AND GETTERS
        public void Rolesaver(String role) {
            currentrole = role;
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
        //CONSTRUCTOR DEFAULT
        public Staticvartable() { 
        }
    }
}
