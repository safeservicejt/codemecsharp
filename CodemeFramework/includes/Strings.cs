using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Runtime.Serialization;
using System.Xml;
using System.Reflection;
using System.Runtime.InteropServices;

namespace CodemeFramework.includes
{
    class Strings
    {
        public static string addslash(string inputData="")
        {
            inputData = System.Text.RegularExpressions.Regex.Replace(inputData, @"[\042\047]", "\\$0");

            return inputData;
        }

        public static string stripslash(string inputData = "")
        {
            inputData = System.Text.RegularExpressions.Regex.Replace(inputData, @"(\\)([\042\047])", "$2");

            return inputData;
        }

        public static string randNumber(int len=10)
        {
            string result = "012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789";

            result = randString(result, len);

            return result;
        }

        public static string randAll(int len = 10)
        {
            string result = "!@#$%^&*()_+-=[]{}:'\"|<>?,./!@#$%^&*()_+-=[]{}:'\"|<>?,./qwertyuiopasdfghjklzxcvbnm0123456789qwertyuiopasdfghjklzxcvbnm0123456789qwertyuiopasdfghjklzxcvbnm0123456789qwertyuiopasdfghjklzxcvbnm0123456789qwertyuiopasdfghjklzxcvbnm0123456789qwertyuiopasdfghjklzxcvbnm0123456789";

            result = randString(result, len);

            return result;
        }

        public static string implode(string inputChar = ",", string[] inputData = null)
        {
            string result = "";

            if (inputData is Array)
            {
                result = String.Join(inputChar, inputData);
            }
            else if (inputData is String)
            {
                result = inputData.ToString();
            }

            return result;
        }

        public static string[] explode(char inputChar = ',', string inputData = null)
        {
            string[] result = { };

            if (inputData is String)
            {
                result = inputData.Split(inputChar);
            }

            return result;
        }

        public static string[] preg_match(string pattern = "", string inputData = "")
        {
            string[] result = { };

            int ctr = 0;
            foreach (Match m in Regex.Matches(inputData, pattern))
            {
                result[ctr] = m.Groups[1].Value;

                ++ctr;
            }

            return result;
        }


        public static string randAlphabet(int len = 10)
        {
            string result = "qwertyuiopasdfghjklzxcvbnmqwertyuiopasdfghjklzxcvbnmqwertyuiopasdfghjklzxcvbnmqwertyuiopasdfghjklzxcvbnmqwertyuiopasdfghjklzxcvbnmqwertyuiopasdfghjklzxcvbnm";

            result = randString(result, len);

            return result;
        }

        public static string randText(int len = 10)
        {
            string result = "qwertyuiopasdfghjklzxcvbnm0123456789qwertyuiopasdfghjklzxcvbnm0123456789qwertyuiopasdfghjklzxcvbnm0123456789qwertyuiopasdfghjklzxcvbnm0123456789qwertyuiopasdfghjklzxcvbnm0123456789qwertyuiopasdfghjklzxcvbnm0123456789";

            result = randString(result,len);

            return result;
        }

        public static string randString(string inputData, int len = 10)
        {
            if (inputData.Length > 0)
            {
                inputData = shuffle(inputData);

                inputData = inputData.Substring(0, len);
            }

            return inputData;
        }

        public static string shuffle(string inputData)
        {
            Random num = new Random();

            // Create new string from the reordered char array
            string rand = new string(inputData.ToCharArray().OrderBy(s => (num.Next(2) % 2) == 0).ToArray());

            return rand;
        }


    }
}
