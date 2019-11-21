using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace ModuloUsuarios.MODEL
{
    //MODELO DE PERSONAJES
    class Caller_characters
    {
        //LECTURA DE PERSONAJES
        public List<String> charloader(List<String> array){
            XmlDocument charfile = new XmlDocument();
            charfile.Load("C:\\DAM\\Personajes.xml");

            XmlNodeList chars = charfile.GetElementsByTagName("Personajes");
            XmlNodeList charlist = ((XmlElement)chars[0]).GetElementsByTagName("Personaje");

            foreach (XmlElement node in charlist)
            {
                //cabecera pers
                array.Add(node.GetAttribute("Nombre"));
                array.Add(node.GetAttribute("Clase"));
                array.Add(node.GetAttribute("Raza"));
                //atributos
                array.Add(node.GetElementsByTagName("Nivel")[0].Attributes[0].InnerText);
                array.Add(node.GetElementsByTagName("Vida")[0].Attributes[0].InnerText);
                array.Add(node.GetElementsByTagName("Vida")[0].InnerText);
                array.Add(node.GetElementsByTagName("Energia")[0].Attributes[0].InnerText);
                array.Add(node.GetElementsByTagName("Energia")[0].InnerText);
                array.Add(node.GetElementsByTagName("Exp")[0].Attributes[0].InnerText);
                array.Add(node.GetElementsByTagName("Exp")[0].InnerText);
                array.Add(node.GetElementsByTagName("Monedas")[0].InnerText);
                array.Add(node.GetElementsByTagName("Fuerza")[0].InnerText);
                array.Add(node.GetElementsByTagName("Destreza")[0].InnerText);
                array.Add(node.GetElementsByTagName("Aguante")[0].InnerText);
                array.Add(node.GetElementsByTagName("Inteligencia")[0].InnerText);
                array.Add(node.GetElementsByTagName("Carisma")[0].InnerText);
                array.Add(node.GetElementsByTagName("Imagen")[0].InnerText);
                array.Add(node.GetElementsByTagName("Bio")[0].InnerText);
                //array habilidades opcional
            }
            return array;
        }
    }
}
