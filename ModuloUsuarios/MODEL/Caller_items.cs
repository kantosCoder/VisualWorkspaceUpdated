using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace ModuloUsuarios.MODEL
{
    //MODELO DE ITEMS
    class Caller_items
    {
        Random random = new Random();
        int randomNumber = 0;
        //LECTURA DE ITEMS
        public List<String> itemloader(List<String> array){
            XmlDocument itemfile = new XmlDocument();
            itemfile.Load("C:\\DAM\\Items.xml");

            XmlNodeList item = itemfile.GetElementsByTagName("Items");
            XmlNodeList itemlist = ((XmlElement)item[0]).GetElementsByTagName("Item");

            foreach (XmlElement node in itemlist)
            {
                //start array 9pos
                //cabecera items
                array.Add(node.GetElementsByTagName("Id")[0].InnerText);
                array.Add(node.GetAttribute("Tipo"));
                array.Add(node.GetAttribute("Valor"));
                array.Add(node.GetAttribute("Nivel"));
                //atributos
                array.Add(node.GetElementsByTagName("Nombre")[0].InnerText);
                array.Add(node.GetElementsByTagName("Espacio")[0].InnerText);
                array.Add(node.GetElementsByTagName("Peso")[0].InnerText);
                array.Add(node.GetElementsByTagName("Armadura")[0].InnerText);
                array.Add(node.GetElementsByTagName("Daño")[0].Attributes[0].InnerText);
                array.Add(node.GetElementsByTagName("Daño")[0].InnerText);
                array.Add(node.GetElementsByTagName("Habilidad")[0].InnerText); //explode? ":" para separarlas?
            }
            return array;
        }
        //MODIFICACION DE ITEMS
        public void itemrewrite(String id, String atype, String avalue, String alvl, String aname,
            String aspace, String aweight, String a_rmor, String admg, String dmgtype, String a_bility, String mode)
        {
            XmlDocument itemfile = new XmlDocument();
            itemfile.Load("C:\\DAM\\Items.xml");
            XmlNodeList items = itemfile.GetElementsByTagName("Items");
            XmlNode root = itemfile.DocumentElement;
            XmlNodeList itemlist = ((XmlElement)items[0]).GetElementsByTagName("Item");
            XmlElement replaced = itemfile.CreateElement("Item");
            foreach (XmlElement node in itemlist)
            {
                //cabecera item
                if ((node.GetElementsByTagName("Id")[0].InnerText.Equals(id)))
                {
                    replaced = node;
                }
                else
                {
                    mode = "create";
                }

            }
            //new node
            XmlElement replacer = itemfile.CreateElement("Item");
            //cabecera habilidad
            replacer.SetAttribute("Tipo", atype);
            replacer.SetAttribute("Valor", avalue);
            replacer.SetAttribute("Nivel", alvl);
            //atributos habilidad
            //append
            XmlElement replacer_append = itemfile.CreateElement("Id");
            //cabecera personaje
            if (mode.Equals("create"))
            {
                randomNumber = random.Next(10000, 999999);
                String newid = randomNumber.ToString();
                replacer_append.InnerText = newid;
            }
            else
            {
                replacer_append.InnerText = id;
            }
            
            replacer.AppendChild(replacer_append);
            //append
            replacer_append = itemfile.CreateElement("Nombre");
            replacer_append.InnerText = aname;
            replacer.AppendChild(replacer_append);
            //append
            replacer_append = itemfile.CreateElement("Espacio");
            replacer_append.InnerText = aspace;
            replacer.AppendChild(replacer_append);
            //append
            replacer_append = itemfile.CreateElement("Peso");
            replacer_append.InnerText = aweight;
            replacer.AppendChild(replacer_append);
            //append
            replacer_append = itemfile.CreateElement("Armadura");
            replacer_append.InnerText = a_rmor;
            replacer.AppendChild(replacer_append);
            //append
            replacer_append = itemfile.CreateElement("Daño");
            replacer_append.SetAttribute("tipo", dmgtype);
            replacer_append.InnerText = admg;
            replacer.AppendChild(replacer_append);
            //append
            replacer_append = itemfile.CreateElement("Acciones_esp");
            //append of append
            XmlElement append_append = itemfile.CreateElement("Habilidad");
            append_append.InnerText = a_bility;
            replacer_append.AppendChild(append_append);
            replacer.AppendChild(replacer_append);
            //insertion to root
            root.AppendChild(replacer);
            if (mode.Equals("modify"))
            {
                //delete old node
                root.RemoveChild(replaced);
            }
            itemfile.Save("C:\\DAM\\Items.xml");
        }
        //ELIMINACION DE ITEMS
        public void itemdestroy(String id)
        {
            XmlDocument itemfile = new XmlDocument();
            itemfile.Load("C:\\DAM\\Items.xml");
            XmlNodeList items = itemfile.GetElementsByTagName("Items");
            XmlNode root = itemfile.DocumentElement;
            XmlNodeList itemlist = ((XmlElement)items[0]).GetElementsByTagName("Item");
            XmlElement target = itemfile.CreateElement("Item");
            foreach (XmlElement node in itemlist)
            {
                //cabecera item
                if ((node.GetElementsByTagName("Id")[0].InnerText.Equals(id)))
                {
                    target = node;

                }

            }
            //destroy node
            root.RemoveChild(target);
            itemfile.Save("C:\\DAM\\Items.xml");
        }
    }
}
