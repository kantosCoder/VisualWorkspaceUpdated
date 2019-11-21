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
    }
}
