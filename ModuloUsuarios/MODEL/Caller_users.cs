using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace ModuloUsuarios
{
    class Caller_users //MODELO DE USUARIOS
    {
        //VALIDADOR DE LOGIN
        public Boolean Loader(String user, String pass)
        {
            XmlTextReader reader = new XmlTextReader("C:\\DAM\\usuarios.xml");
            Boolean valid = false;
            String element = "";
            String role = "";
            String name = "";
            String passwd = "";
            while (reader.Read() & valid == false)
            {
                    // reads the element
                if (reader.NodeType == XmlNodeType.Element)
                {
                    element = reader.Name; // the name of the current element
                    if (element == "usuario")
                    {
                        reader.GetAttribute("rol");
                    }
                }
                // reads the element value
                else if (reader.NodeType == XmlNodeType.Text)
                {
                    switch (element)
                    {
                        case "nickname":
                            name = reader.Value;
                            break;
                        case "pass":
                            passwd = reader.Value;
                            break;
                    }
                    if (name == user & passwd == pass) {
                        Staticvartable roleput = new Staticvartable();
                        roleput.Rolesaver(role);
                        valid = true;
                    }
                }
            }
                return valid;
        }
        //LECTURA DE ITEMS
        public List<String> itemloader(List<String> array)
        {
            XmlDocument userfile = new XmlDocument();
            userfile.Load("C:\\DAM\\usuarios.xml");

            XmlNodeList user = userfile.GetElementsByTagName("Usuarios");
            XmlNodeList userlist = ((XmlElement)user[0]).GetElementsByTagName("Usuario");

            foreach (XmlElement node in userlist)
            {
                //start array 9pos
                //cabecera items
                array.Add(node.GetAttribute("rol"));
                //atributos
                array.Add(node.GetElementsByTagName("nickname")[0].InnerText);
                array.Add(node.GetElementsByTagName("pass")[0].InnerText);
            }
            return array;
        }
    }
}

