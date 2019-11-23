using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace ModuloUsuarios.MODEL
{
    //MODELO DE HABILIDADES
    class Caller_abilities
    {
        //LECTURA DE HABILIDADES
        public List<String> abilityloader(List<String> array){
            XmlDocument skillfile = new XmlDocument();
            skillfile.Load("C:\\DAM\\Habilidades.xml");

            XmlNodeList skill = skillfile.GetElementsByTagName("Habilidades");
            XmlNodeList skilllist = ((XmlElement)skill[0]).GetElementsByTagName("Habilidad");

            foreach (XmlElement node in skilllist)
            {
                //start array 7pos
                //cabecera hab
                array.Add(node.GetAttribute("Id"));
                array.Add(node.GetAttribute("Nombre"));
                array.Add(node.GetAttribute("Nivel"));
                array.Add(node.GetAttribute("Tipo"));
                //efectos
                array.Add(node.GetElementsByTagName("Vida")[0].InnerText);
                array.Add(node.GetElementsByTagName("Energia")[0].InnerText);
                array.Add(node.GetElementsByTagName("Imagen")[0].InnerText);
                array.Add(node.GetElementsByTagName("Descripcion")[0].InnerText);
            }
            return array;
        }
        //MODIFICACION DE HABILIDADES
        public void abilityrewrite(String id, String aname,
            String alvl, String atype, String aenergy, String alife, String photo, String bio, String mode)
        {
            XmlDocument skillfile = new XmlDocument();
            skillfile.Load("C:\\DAM\\Habilidades.xml");
            XmlNodeList skills = skillfile.GetElementsByTagName("Habilidades");
            XmlNode root = skillfile.DocumentElement;
            XmlNodeList skilllist = ((XmlElement)skills[0]).GetElementsByTagName("Habilidad");
            XmlElement replaced = skillfile.CreateElement("Habilidad");
            foreach (XmlElement node in skilllist)
            {
                //cabecera pers
                if ((node.GetAttribute("Id").Equals(id)))
                {
                    replaced = node;
                }

            }
            //new node
            XmlElement replacer = skillfile.CreateElement("Habilidad");
            //cabecera personaje
            replacer.SetAttribute("Id", id);
            replacer.SetAttribute("Nombre", aname);
            replacer.SetAttribute("Nivel", alvl);
            replacer.SetAttribute("Nivel", atype);
            //atributos personaje
            //append
            XmlElement replacer_append = skillfile.CreateElement("Vida");
            replacer_append.InnerText = alife;
            replacer.AppendChild(replacer_append);
            //append
            replacer_append = skillfile.CreateElement("Energia");
            replacer_append.InnerText = aenergy;
            replacer.AppendChild(replacer_append);
            //append
            replacer_append = skillfile.CreateElement("Imagen");
            replacer_append.InnerText = photo;
            replacer.AppendChild(replacer_append);
            //append
            replacer_append = skillfile.CreateElement("Descripcion");
            replacer_append.InnerText = bio;
            replacer.AppendChild(replacer_append);
            //insertion to root
            root.AppendChild(replacer);
            if (mode.Equals("modify"))
            {
                //delete old node
                root.RemoveChild(replaced);
            }
            skillfile.Save("C:\\DAM\\Habilidades.xml");
        }
        //ELIMINACION DE CRIATURAS
        public void abilitydestroy(String id)
        {
            XmlDocument skillfile = new XmlDocument();
            skillfile.Load("C:\\DAM\\Habilidades.xml");
            XmlNodeList skills = skillfile.GetElementsByTagName("Habilidades");
            XmlNode root = skillfile.DocumentElement;
            XmlNodeList skilllist = ((XmlElement)skills[0]).GetElementsByTagName("Habilidad");
            XmlElement target = skillfile.CreateElement("Habilidad");
            foreach (XmlElement node in skilllist)
            {
                //cabecera pers
                if ((node.GetAttribute("Id").Equals(id)))
                {
                    target = node;

                }

            }
            //destroy node
            root.RemoveChild(target);
            skillfile.Save("C:\\DAM\\Habilidades.xml");
        }
    }
}