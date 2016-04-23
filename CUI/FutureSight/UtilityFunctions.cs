using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace FutureSight
{
    public static class UtilityFunctions
    {
        /// <summary>オブジェクトのディープコピー</summary>
        public static T Copy<T>(T target)
        {
            T result;
            var b = new BinaryFormatter();
            var mem = new MemoryStream();

            try
            {
                b.Serialize(mem, target);
                mem.Position = 0;
                result = (T)b.Deserialize(mem);
            }
            finally
            {
                mem.Close();
            }
            return result;
        }
    }
}
