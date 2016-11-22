using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CodemeFramework.includes
{
    class Files
    {
        public static void open(string filePath="")
        {
            System.Diagnostics.Process.Start(@filePath);
        }

        public static string getContents(string filePath = "")
        {
            string result = "";

            if (System.IO.File.Exists(@filePath))
            {
                result = System.IO.File.ReadAllText(@filePath);
            }
            
            return result;
        }

        public static string[] getLines(string filePath = "")
        {
            string[] result={};

            if (System.IO.File.Exists(@filePath))
            {
                result = System.IO.File.ReadAllLines(@filePath);
            }

            return result;
        }

        public static string getPath(string filePath = "")
        {
            string result = "";

            result = System.IO.Path.GetDirectoryName(filePath);

            return result;
        }

        public static void make(string filePath = "", string fileData = "")
        {
            //Dir dr = new Dir();

            try
            {
                string dirPath = getPath(@filePath);

                if (!Dir.exists(dirPath))
                {
                    Dir.make(dirPath);
                }

                using (FileStream fs = System.IO.File.Create(@filePath))
                {
                    Byte[] info = new UTF8Encoding(true).GetBytes(fileData);
                    // Add some information to the file.
                    fs.Write(info, 0, info.Length);

                    fs.Close();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error", ex);
            }

        }

        public static void delete(string filePath = "")
        {
            if (System.IO.File.Exists(@filePath))
            {
                System.IO.File.Delete(@filePath);
            }
        }
    }
}
