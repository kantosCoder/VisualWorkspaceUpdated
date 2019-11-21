using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace ModuloUsuarios
{
    class Caller_users //ESTA CLASE GESTIONA LA COMUNCIACION CON EL XML DE USUARIOS MEDIANTE SAX
    {
        //COMPRUEBA LA EXISTENCIA Y COHERENCIA DE LOS CAMPOS DE USER Y PASSWORD
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
    }
}

