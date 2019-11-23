using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace ModuloUsuarios.MODEL
{
    //MODELO DE CRIATURAS
    class Caller_creatures
    {
        //LECTURA DE CRIATURAS
        public List<String> creatureloader(List<String> array){
            XmlDocument creatfile = new XmlDocument();
            creatfile.Load("C:\\DAM\\Criaturas.xml");

            XmlNodeList creature = creatfile.GetElementsByTagName("Criaturas");
            XmlNodeList creaturelist = ((XmlElement)creature[0]).GetElementsByTagName("Criatura");
            foreach (XmlElement node in creaturelist)
            {
                //start array 8pos
                //cabecera criatura
                array.Add(node.GetAttribute("Id"));
                array.Add(node.GetAttribute("Nombre"));
                array.Add(node.GetAttribute("Nivel"));
                //efectos
                array.Add(node.GetElementsByTagName("Aversion")[0].InnerText);
                array.Add(node.GetElementsByTagName("Vida")[0].Attributes[0].InnerText);
                array.Add(node.GetElementsByTagName("Vida")[0].InnerText); 
                array.Add(node.GetElementsByTagName("Bio")[0].InnerText);
                array.Add(node.GetElementsByTagName("Danyo_base")[0].InnerText);
                array.Add(node.GetElementsByTagName("Imagen")[0].InnerText);
            }
            return array;
        }
        //MODIFICACION DE CRIATURAS
        public void creaturerrewrite(String id, String aname,
            String alvl, String a_version, String alife, String malife, String admg, String photo, String bio, String mode)
        {
            XmlDocument creaturefile = new XmlDocument();
            creaturefile.Load("C:\\DAM\\Criaturas.xml");
            XmlNodeList creatures = creaturefile.GetElementsByTagName("Criaturas");
            XmlNode root = creaturefile.DocumentElement;
            XmlNodeList charlist = ((XmlElement)creatures[0]).GetElementsByTagName("Criatura");
            XmlElement replaced = creaturefile.CreateElement("Criatura");
            foreach (XmlElement node in charlist)
            {
                //cabecera pers
                if ((node.GetAttribute("Id").Equals(id)))
                {
                    replaced = node;

                }

            }
            //new node
            XmlElement replacer = creaturefile.CreateElement("Criatura");
            //cabecera personaje
            replacer.SetAttribute("Id", id);
            replacer.SetAttribute("Nombre", aname);
            replacer.SetAttribute("Nivel", alvl);
            //atributos personaje
            //append
            XmlElement replacer_append = creaturefile.CreateElement("Aversion");
            replacer_append.InnerText = a_version;
            replacer.AppendChild(replacer_append);
            //append
            replacer_append = creaturefile.CreateElement("Vida");
            replacer_append.SetAttribute("Maxima", malife);
            replacer_append.InnerText = alife;
            replacer.AppendChild(replacer_append);
            //append
            replacer_append = creaturefile.CreateElement("Bio");
            replacer_append.InnerText = bio;
            replacer.AppendChild(replacer_append);
            //append
            replacer_append = creaturefile.CreateElement("Danyo_base");
            replacer_append.InnerText = admg;
            replacer.AppendChild(replacer_append);
            //append
            replacer_append = creaturefile.CreateElement("Imagen");
            replacer_append.InnerText = photo;
            replacer.AppendChild(replacer_append);
            //insertion to root
            root.AppendChild(replacer);
            if (mode.Equals("modify"))
            {
                //delete old node
                root.RemoveChild(replaced);
            }
            creaturefile.Save("C:\\DAM\\Criaturas.xml");
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
