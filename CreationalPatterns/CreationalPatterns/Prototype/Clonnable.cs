using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace CreationalPatterns.Prototype
{
    [Serializable]
    public abstract class Clonnable<T>
    {
        public T CloneSelf()
        {
            return (T) MemberwiseClone();
        }

        public T DeepClone()
        {
            using (var stream = new MemoryStream())
            {
                var formatter = new BinaryFormatter();
                formatter.Serialize(stream, this);
                stream.Seek(0, SeekOrigin.Begin);
                return (T) formatter.Deserialize(stream);
            }
        }
    }
}
