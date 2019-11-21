using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace ModuloUsuarios.MODEL
{
    //MODELO DE HABILIDADES
    class Caller_habilities
    {
        //LECTURA DE HABILIDADES
        public List<String> habloader(List<String> array){
            XmlDocument skillfile = new XmlDocument();
            skillfile.Load("C:\\DAM\\Habilidades.xml");

            XmlNodeList skill = skillfile.GetElementsByTagName("Habilidades");
            XmlNodeList skilllist = ((XmlElement)skill[0]).GetElementsByTagName("Habilidad");

            foreach (XmlElement node in skilllist)
            {
                //start array 7pos
                //cabecera hab
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
    }
}
