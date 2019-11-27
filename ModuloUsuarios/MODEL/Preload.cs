using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace ModuloUsuarios.MODEL
{
    class Preload
    {
        public void checker() {
            XmlDocument checkfile = new XmlDocument();
            //check userfile
            try
            {
                checkfile.Load("C:\\DAM\\usuarios.xml");
            }
            catch (Exception) { 
                checkfile.LoadXml(
                    "<?xml version=\"1.0\" encoding=\"utf-8\" standalone=\"no\"?>" +
                    "<users>" +
                    "<usuario rol=\"ADMIN\">"+
                   "<nickname>ADMIN</nickname>" +
                   "<pass>ADMIN</pass>" +
                   "</usuario>"+
                   "</users>");
                checkfile.Save("C:\\DAM\\usuarios.xml");
            }
            //check charfile
            try
            {
                checkfile.Load("C:\\DAM\\Personajes.xml");
            }
            catch (Exception)
            {
                checkfile.LoadXml(
                    "<?xml version=\"1.0\" encoding=\"utf-8\" standalone=\"no\"?>" +
                    "<Personajes>" +
                      "<Personaje Id=\"9999\" Nombre=\"Nombre\" Clase=\"Clase\" Raza=\"Raza\">" +
                        "<Atributos>" +
                          "<Fuerza>1</Fuerza>" +
                          "<Destreza>1 </Destreza>" +
                          "<Aguante>1</Aguante>" +
                          "<Inteligencia>1</Inteligencia>" +
                          "<Carisma>1</Carisma>" +
                        "</Atributos>" +
                        "<Vida Maxima=\"2\">1</Vida>" +
                        "<Energia Maxima=\"2\">1</Energia>" +
                        "<Nivel Actual=\"1\">" +
                          "<Exp Necesaria=\"200\">1</Exp>" +
                        "</Nivel>" +
                        "<Monedas>2</Monedas>" +
                        "<Bio>Personaje de ejemplo</Bio>" +
                        "<Imagen></Imagen>" +
                      "</Personaje>" +
                    "</Personajes>"
                   );
                checkfile.Save("C:\\DAM\\Personajes.xml");
            }
            //check creaturefile
            try
            {
                checkfile.Load("C:\\DAM\\Criaturas.xml");
            }
            catch (Exception)
            {
                checkfile.LoadXml(
                    "<?xml version=\"1.0\" encoding=\"utf-8\" standalone=\"no\"?>" +
                    "<Criaturas>" +
                      "<Criatura Id=\"932\" Nombre=\"Nombre\" Nivel=\"20\">" +
                        "<Aversion>2</Aversion>" +
                        "<Vida Maxima=\"8000\">8000</Vida>" +
                        "<Bio>Criatura de ejemplo</Bio>" +
                        "<Danyo_base>5</Danyo_base>" +
                        "<Imagen>" +
                        "</Imagen>" +
                      "</Criatura>" +
                    "</Criaturas>"
                   );
                checkfile.Save("C:\\DAM\\Criaturas.xml");
            }
            //check abilities
            try
            {
                checkfile.Load("C:\\DAM\\Habilidades.xml");
            }
            catch (Exception)
            {
                checkfile.LoadXml(
                    "<?xml version=\"1.0\" encoding=\"utf-8\" standalone=\"no\"?>" +
                    "<Habilidades>"+
                      "<Habilidad Id=\"895\" Nombre=\"Nombre\" Nivel=\"1\" Tipo=\"Fisico\">"+
                        "<Vida>+5</Vida>"+
                        "<Energia>-20</Energia>"+
                        "<Imagen></Imagen>"+
                        "<Descripcion>Habilidad de ejemplo</Descripcion>"+
                      "</Habilidad>"+
                    "</Habilidades>"
                   );
                checkfile.Save("C:\\DAM\\Habilidades.xml");
            }
            //check items
            try
            {
                checkfile.Load("C:\\DAM\\Items.xml");
            }
            catch (Exception)
            {
                checkfile.LoadXml(
                    "<Items>" +
                      "<Item Tipo=\"Tipo\" Valor=\"2\" Nivel=\"1\">" +
                        "<Id>984</Id>" +
                        "<Nombre>Nombre</Nombre>" +
                        "<Espacio>1</Espacio>" +
                        "<Peso>2</Peso>" +
                        "<Armadura>3</Armadura>" +
                        "<Daño tipo=\"tipo_daño\">1</Daño>" +
                        "<Acciones_esp>" +
                          "<Habilidad>2</Habilidad>" +
                        "</Acciones_esp>" +
                      "</Item>" +
                    "</Items>"
                   );
                checkfile.Save("C:\\DAM\\Items.xml");
            }
        }
        
    }
}
