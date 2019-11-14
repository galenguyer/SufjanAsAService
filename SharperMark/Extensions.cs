using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace SharperMark
{
    public static class Extensions
    {
        public static T GetRandomItem<T>(this List<T> list)
        {
            RNGCryptoServiceProvider crypto = new RNGCryptoServiceProvider();
            byte[] bytes = new byte[4];
            crypto.GetNonZeroBytes(bytes);
            int rand = Math.Abs(BitConverter.ToInt32(bytes, 0)) % list.Count;

            return list[rand];
        }
    }
}
