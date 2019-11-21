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
            creatfile.Load("C:\\DAM\\Habilidades.xml");

            XmlNodeList creature = creatfile.GetElementsByTagName("Criaturas");
            XmlNodeList creaturelist = ((XmlElement)creature[0]).GetElementsByTagName("Criatura");

            foreach (XmlElement node in creaturelist)
            {
                //start array 7pos
                //cabecera criatura
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
    }
}
