using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace CSV_TXT_to_XLS
{
    public static class SerializeData <T>
        where T : class, new()
    {
       public static void Save(T Data, string pathAndNameData)
        {
            FileStream stream = new FileStream(pathAndNameData, FileMode.Create, FileAccess.Write, FileShare.Read);
            XmlSerializer serializer = new XmlSerializer(typeof(Settings));
            serializer.Serialize(stream, Data);
            stream.Close();
        }

        public static T Restore(string pathData)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(T));
            if (File.Exists(pathData))
            {
                FileStream stream = new FileStream(pathData, FileMode.Open, FileAccess.Read, FileShare.Read);
                var result = serializer.Deserialize(stream) as T;
                stream.Close();
                return result;
            }

            else return  new T();
        }
    }
}
