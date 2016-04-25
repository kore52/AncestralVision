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

        /// <summary>値がない場合デフォルト値を返す</summary>
        public static TValue TryGetValueEx<TKey, TValue>(this IDictionary<TKey, TValue> source, TKey key, TValue defaultValue)
        {
            //Dictionary自体がnullの場合はインスタンス作成
            if (source == null)
                source = new Dictionary<TKey, TValue>();

            //keyが存在しない場合はデフォルト値を設定
            if (!source.ContainsKey(key))
                source[key] = defaultValue;

            return source[key];
        }
    }
}
