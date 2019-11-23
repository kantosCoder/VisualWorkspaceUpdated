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
            String alvl, String a_version, String alife, String malife, String admg, String photo, String bio, String mode)
        {
            XmlDocument skillfile = new XmlDocument();
            skillfile.Load("C:\\DAM\\Habilidades.xml");
            XmlNodeList creatures = skillfile.GetElementsByTagName("Habilidades");
            XmlNode root = skillfile.DocumentElement;
            XmlNodeList charlist = ((XmlElement)creatures[0]).GetElementsByTagName("Habilidad");
            XmlElement replaced = skillfile.CreateElement("Habilidad");
            foreach (XmlElement node in charlist)
            {
                //cabecera pers
                if ((node.GetAttribute("Id").Equals(id)))
                {
                    replaced = node;
                }

            }
            //new node
            XmlElement replacer = skillfile.CreateElement("Criatura");
            //cabecera personaje
            replacer.SetAttribute("Id", id);
            replacer.SetAttribute("Nombre", aname);
            replacer.SetAttribute("Nivel", alvl);
            //atributos personaje
            //append
            XmlElement replacer_append = skillfile.CreateElement("Aversion");
            replacer_append.InnerText = a_version;
            replacer.AppendChild(replacer_append);
            //append
            replacer_append = skillfile.CreateElement("Vida");
            replacer_append.SetAttribute("Maxima", malife);
            replacer_append.InnerText = alife;
            replacer.AppendChild(replacer_append);
            //append
            replacer_append = skillfile.CreateElement("Bio");
            replacer_append.InnerText = bio;
            replacer.AppendChild(replacer_append);
            //append
            replacer_append = skillfile.CreateElement("Danyo_base");
            replacer_append.InnerText = admg;
            replacer.AppendChild(replacer_append);
            //append
            replacer_append = skillfile.CreateElement("Imagen");
            replacer_append.InnerText = photo;
            replacer.AppendChild(replacer_append);
            //insertion to root
            root.AppendChild(replacer);
            if (mode.Equals("modify"))
            {
                //delete old node
                root.RemoveChild(replaced);
            }
            skillfile.Save("C:\\DAM\\Criaturas.xml");
        }
        //ELIMINACION DE CRIATURAS
        public void creaturedestroy(String id)
        {
            XmlDocument creaturefile = new XmlDocument();
            creaturefile.Load("C:\\DAM\\Criaturas.xml");
            XmlNodeList creatures = creaturefile.GetElementsByTagName("Criaturas");
            XmlNode root = creaturefile.DocumentElement;
            XmlNodeList charlist = ((XmlElement)creatures[0]).GetElementsByTagName("Criatura");
            XmlElement target = creaturefile.CreateElement("Criatura");
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
            creaturefile.Save("C:\\DAM\\Criaturas.xml");
        }
    }
}