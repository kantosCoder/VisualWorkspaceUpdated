using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModuloUsuarios
{
    static class Invoker
    {
        //CREO UN OBJETO GLOBAL CONTROLADOR PARA GENERAR TODAS LAS VENTANAS DESDE EL MISMO
        internal static Controller controller;

        [STAThread]
        public static void Main()
        {
            //Punto de entrada de la aplicación
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Instanciación de la ventana principal
            controller = new Controller();
            //LANZO EL CONTROLADOR
            Application.Run(controller);


            
        }
        
    }
}