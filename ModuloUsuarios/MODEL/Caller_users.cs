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
            Staticvartable roleput = new Staticvartable();
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
                        role = reader.GetAttribute("rol");
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
                        roleput.Rolesaver(role);
                        valid = true;
                    }
                }
            }
                return valid;
        }
        //LECTURA DE USUARIOS
        public List<String> userloader(List<String> array)
        {
            XmlDocument userfile = new XmlDocument();
            userfile.Load("C:\\DAM\\usuarios.xml");

            XmlNodeList user = userfile.GetElementsByTagName("users");
            XmlNodeList userlist = ((XmlElement)user[0]).GetElementsByTagName("usuario");

            foreach (XmlElement node in userlist)
            {
                //start array 3pos
                //cabecera users
                array.Add(node.GetAttribute("rol"));
                //nombre
                array.Add(node.GetElementsByTagName("nickname")[0].InnerText);
                //pass
                array.Add(node.GetElementsByTagName("pass")[0].InnerText);
            }
            return array;
        }
        //MODIFICACION DE USUARIOS
        public void userrewrite(String arole, String anick, String apass, String oldpass, String mode)
        {
            XmlDocument userfile = new XmlDocument();
            userfile.Load("C:\\DAM\\usuarios.xml");
            XmlNodeList users = userfile.GetElementsByTagName("users");
            XmlNode root = userfile.DocumentElement;
            XmlNodeList userlist = ((XmlElement)users[0]).GetElementsByTagName("usuario");
            XmlElement replaced = userfile.CreateElement("usuario");
            //comprobar que la oldpass es buena popup que no y retorno
            mode = "create";
            foreach (XmlElement node in userlist)
            {
                //comprobar que no sea el ultimo admin
                //cabecera users
                if ((node.GetElementsByTagName("nickname")[0].InnerText.Equals(anick)))
                {
                    replaced = node;
                    mode = "modify";
                }

            }
            //new node
            XmlElement replacer = userfile.CreateElement("usuario");
            //cabecera habilidad
            replacer.SetAttribute("rol", arole);
            //atributos habilidad
            //append
            XmlElement replacer_append = userfile.CreateElement("nickname");
            replacer_append.InnerText = anick;
            replacer.AppendChild(replacer_append);
            //append
            replacer_append = userfile.CreateElement("pass");
            replacer_append.InnerText = apass;
            replacer.AppendChild(replacer_append);
            //insertion to root
            root.AppendChild(replacer);
            if (mode.Equals("modify"))
            {
                
                //delete old node
                root.RemoveChild(replaced);
            }
            userfile.Save("C:\\DAM\\usuarios.xml");
        }
        //ELIMINACION DE USUARIOS
        public void userdestroy(String id)
        {
            XmlDocument userfile = new XmlDocument();
            userfile.Load("C:\\DAM\\usuarios.xml");
            XmlNodeList users = userfile.GetElementsByTagName("users");
            XmlNode root = userfile.DocumentElement;
            XmlNodeList userlist = ((XmlElement)users[0]).GetElementsByTagName("usuario");
            XmlElement target = userfile.CreateElement("usuario");
            foreach (XmlElement node in userlist)
            {
                //cabecera habil
                if ((node.GetElementsByTagName("nickname")[0].InnerText.Equals(id)))
                {
                    target = node;
                }

            }
            //destroy node
            root.RemoveChild(target);
            userfile.Save("C:\\DAM\\usuarios.xml");
        }
    }
}

