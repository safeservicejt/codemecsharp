using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace CodemeFramework.includes
{
    class XML
    {
        private string[] contents;

        public string message = "";

        public bool get(string filePath)
        {
            bool status = false;

            System.Xml.XmlTextReader reader;

            try
            {
                reader = new System.Xml.XmlTextReader(filePath);

                //string contents = "";

                string keyName = "";

                string keyVal = "";

                while (reader.Read())
                {
                    reader.MoveToContent();
                    if (reader.NodeType == System.Xml.XmlNodeType.Element)
                    {
                        keyName = reader.Name;
                    }
                    //contents += "<" + reader.Name + ">\n";

                    if (reader.NodeType == System.Xml.XmlNodeType.Text)
                    {
                        keyVal = reader.Value;
                    }
                    //contents += reader.Value + "\n";
                }

                status = true;
            }
            catch (Exception ex)
            {
                message = ex.Message;
                status = false;
            }
            
            return status;
        }

        public string getMessage()
        {
            return message;
        }

    }
}
