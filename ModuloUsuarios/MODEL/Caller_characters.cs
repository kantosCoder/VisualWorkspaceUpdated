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
        public List<String> charloader(List<String> array)
        {
            XmlDocument charfile = new XmlDocument();
            charfile.Load("C:\\DAM\\Personajes.xml");

            XmlNodeList chars = charfile.GetElementsByTagName("Personajes");
            XmlNodeList charlist = ((XmlElement)chars[0]).GetElementsByTagName("Personaje");

            foreach (XmlElement node in charlist)
            {
                //cabecera pers
                array.Add(node.GetAttribute("id"));
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
        //MODIFICACION DE PERSONAJES
        public void charrewrite(String id, String aname, String aclass, String arace,
            String alvl, String alife, String malife, String aenergy, String maenergy, String axp, String maxp, String agold,
             String aforce, String adexer, String abody, String aintel, String acharism, String img, String bio, String mode)
        {
            XmlDocument charfile = new XmlDocument();
            charfile.Load("C:\\DAM\\Personajes.xml");
            XmlNodeList chars = charfile.GetElementsByTagName("Personajes");
            XmlNode root = charfile.DocumentElement;
            XmlNodeList charlist = ((XmlElement)chars[0]).GetElementsByTagName("Personaje");
            XmlElement replaced = charfile.CreateElement("Personaje");
            foreach (XmlElement node in charlist)
            {
                //cabecera pers
                if ((node.GetAttribute("Id").Equals(id)))
                {
                    replaced = node;

                }

            }
            //new node
            XmlElement replacer = charfile.CreateElement("Personaje");
            //cabecera personaje
            replacer.SetAttribute("Id", id);
            replacer.SetAttribute("Nombre", aname);
            replacer.SetAttribute("Clase", aclass);
            replacer.SetAttribute("Raza", arace);
            //atributos personaje
            //append
            XmlElement replacer_append = charfile.CreateElement("Atributos");
            //append of append (Atributos de personaje)
            //append of append
            XmlElement append_append = charfile.CreateElement("Fuerza");
            append_append.InnerText = aforce;
            replacer_append.AppendChild(append_append);
            //append of append
            append_append = charfile.CreateElement("Destreza");
            append_append.InnerText = adexer;
            replacer_append.AppendChild(append_append);
            //append of append
            append_append = charfile.CreateElement("Aguante");
            append_append.InnerText = abody;
            replacer_append.AppendChild(append_append);
            //append of append
            append_append = charfile.CreateElement("Inteligencia");
            append_append.InnerText = aintel;
            replacer_append.AppendChild(append_append);
            //append of append
            append_append = charfile.CreateElement("Carisma");
            append_append.InnerText = acharism;
            replacer_append.AppendChild(append_append);
            replacer.AppendChild(replacer_append);
            //append
            replacer_append = charfile.CreateElement("Vida");
            replacer_append.SetAttribute("Maxima", malife);
            replacer_append.InnerText = alife;
            replacer.AppendChild(replacer_append);
            //append
            replacer_append = charfile.CreateElement("Energia");
            replacer_append.SetAttribute("Maxima", maenergy);
            replacer_append.InnerText = aenergy;
            replacer.AppendChild(replacer_append);
            //append
            replacer_append = charfile.CreateElement("Nivel");
            replacer_append.SetAttribute("Actual", alvl);
            //append of append
            append_append = charfile.CreateElement("Exp");
            append_append.SetAttribute("Necesaria", maxp);
            append_append.InnerText = axp;
            replacer_append.AppendChild(append_append);
            replacer.AppendChild(replacer_append);
            //append
            replacer_append = charfile.CreateElement("Monedas");
            replacer_append.InnerText = agold;
            replacer.AppendChild(replacer_append);
            //append
            replacer_append = charfile.CreateElement("Bio");
            replacer_append.InnerText = bio;
            replacer.AppendChild(replacer_append);
            //append
            replacer_append = charfile.CreateElement("Imagen");
            replacer_append.InnerText = img;
            replacer.AppendChild(replacer_append);
            //insertion to root
            root.AppendChild(replacer);
            if (mode.Equals("modify"))
            {
                //delete old node
                root.RemoveChild(replaced);
            }
            charfile.Save("C:\\DAM\\Personajes.xml");
        }
        //ELIMINACION DE PERSONAJES
        public void chardestroy(String id)
        {
            XmlDocument charfile = new XmlDocument();
            charfile.Load("C:\\DAM\\Personajes.xml");
            XmlNodeList chars = charfile.GetElementsByTagName("Personajes");
            XmlNode root = charfile.DocumentElement;
            XmlNodeList charlist = ((XmlElement)chars[0]).GetElementsByTagName("Personaje");
            XmlElement target = charfile.CreateElement("Personaje");
            foreach (XmlElement node in charlist)
            {
                //cabecera pers
                if ((node.GetAttribute("Id").Equals(id)))
                {
                    target = node;

                }

            }
            //destroy node
            root.RemoveChild(target);
            charfile.Save("C:\\DAM\\Personajes.xml");
        }
    }
}