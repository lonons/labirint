using System;
using System.IO;
using System.Xml.Serialization;

namespace Labirint
{
    public class SerializableXMLData<T> : IData<T>
    {
        private static XmlSerializer _formatter;

        public SerializableXMLData()
        {
            _formatter = new XmlSerializer(typeof(T));
        }

        public void Save(T data, string path = null)
        {
            if (data == null && !String.IsNullOrEmpty(path)) return;
            using(var fs = new FileStream(path, FileMode.Create))
            {
                _formatter.Serialize(fs,data);
            }
        }

        public T Load(string path = null)
        {
            throw new NotImplementedException();
        }

    }
}