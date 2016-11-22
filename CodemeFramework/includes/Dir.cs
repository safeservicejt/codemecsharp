using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CodemeFramework.includes
{
    class Dir
    {
        public static void make(string inputData = "")
        {
            System.IO.Directory.CreateDirectory(@inputData);
        }

        public static void delete(string inputData = "")
        {
            if (Directory.Exists(@inputData))
            {
                Directory.Delete(@inputData);
            }
        }

        public static bool exists(string inputData = "")
        {
            bool status = false;

            if (Directory.Exists(@inputData) && empty(inputData))
            {
                status = true;
            }

            return status;
        }

        public static string[] listFiles(string filePath = "", string pattern = "*.*")
        {
            string[] result={};

            if (File.Exists(@filePath))
            {
               result[0] = filePath;
            }
            else if (Directory.Exists(@filePath))
            {
                result = Directory.GetFiles(@filePath, pattern);
            }

            return result;
        }

        public static string[] listDirs(string filePath = "")
        {
            string[] result = { };

            if (File.Exists(@filePath))
            {
                result[0] = filePath;
            }
            else if (Directory.Exists(@filePath))
            {
                result = Directory.GetDirectories(@filePath);
            }

            return result;
        }

        public static bool empty(string inputData = "")
        {
            bool status = false;

            if (Directory.GetFiles(@inputData).Length == 0 && System.IO.Directory.GetFiles(@inputData, "*", SearchOption.AllDirectories).Length == 0)
            {
                status = true;
            }

            return status;
        }

        

    }
}
