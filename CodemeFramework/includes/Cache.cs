using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodemeFramework.includes
{
    class Cache
    {
        public static void make(string keyName="",string fileData="")
        {
            string cachePath=App.rootPath+@"\caches\";

            string savePath = cachePath + @keyName + ".cache";

            string cacheTimePath = cachePath + @"\times\";

            string saveTime = DateTimes.UnixTimeNow().ToString();

            string saveTimePath = cacheTimePath + @keyName + @"_time.cache";

            Files.make(@savePath, fileData);

            Files.make(@saveTimePath, saveTime);

        }

        public static void delete(string keyName)
        {
            string cachePath = App.rootPath + @"\caches\";

            string savePath = cachePath + @keyName + ".cache";

            string cacheTimePath = cachePath + @"\times\";

            string saveTime = DateTimes.UnixTimeNow().ToString();

            string saveTimePath = cacheTimePath + @keyName + @"_time.cache";

            Files.delete(savePath);

            Files.delete(saveTimePath);
        }

        public static string get(string keyName="",int live=0)
        {
            string result = "";

            string cachePath = App.rootPath + @"\caches\";

            string savePath = cachePath + @keyName + ".cache";

            string cacheTimePath = cachePath + @"\times\";

            string saveTime = DateTimes.UnixTimeNow().ToString();

            string saveTimePath = cacheTimePath + @keyName + @"_time.cache";

            string timeTmp = System.IO.File.ReadAllText(@saveTimePath);

            long timeLiveSaved = Int32.Parse(timeTmp);

            long curTimeLive = DateTimes.UnixTimeNow();

            if (live > 0)
            {
                long TTL = curTimeLive - timeLiveSaved;

                if (TTL <= live)
                {
                    if (System.IO.File.Exists(@savePath))
                    {
                        result = System.IO.File.ReadAllText(@savePath);
                    }
                }
            }
            else if (live == 0)
            {
                if (System.IO.File.Exists(@savePath))
                {
                    result = System.IO.File.ReadAllText(@savePath);
                }
            }

            return result;
        }
    }
}
