using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace CodemeFramework.includes
{
    class Arrays
    {
        public static string[] array_keys(IDictionary inputData)
        {
            /*
            IDictionary<string,string> openWith = new Dictionary<string,string>()
            {
                { "txt", "notepad.exe" }
                { "bmp", "paint.exe" }
                { "rtf", "wordpad.exe" }
            };

            data.Add("abc", 123);
            */

            string[] result={};

            int i=0;

            foreach (DictionaryEntry item in inputData)
            {
                result[i] = item.Key.ToString();

                i++;
            }

            return result;

        }

        public static string[] array_values(IDictionary inputData)
        {
            /*
            IDictionary<string,string> openWith = new Dictionary<string,string>()
            {
                { "txt", "notepad.exe" }
                { "bmp", "paint.exe" }
                { "rtf", "wordpad.exe" }
            };

            data.Add("abc", 123);
            */

            string[] result = {};

            int i = 0;

            foreach (DictionaryEntry item in inputData)
            {
                result[i] = item.Value.ToString();

                i++;
            }

            return result;

        }

    }
}
