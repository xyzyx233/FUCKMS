using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.IO;

namespace FUCKMS
{
    class UWPencode
    {
        private string plainText;
        private string result;

        public UWPencode(string word)
        {
            plainText = word;
        }
        public string en()
        {
            string dt = DateTime.Now.ToString("yyyyMMdd");
            encodestring(dt);
            return result;
        }
        public string de(string when)
        {
            decodestring(when);
            return result;
        }
        private void encodestring(string nowtime)
        {
            byte[] encrypted;
            // Create an Aes object
            // with the specified key and IV.
            using (Aes aesAlg = Aes.Create())
            {
                byte[] k = Encoding.UTF8.GetBytes("ericxXinericxXinericxXinericxXin");
                byte[] i = Encoding.UTF8.GetBytes(nowtime+nowtime);
                int x = k.Length;
                int y = i.Length;
                aesAlg.Key = k;
                aesAlg.IV = i;

                // Create a decrytor to perform the stream transform.
                ICryptoTransform encryptor = aesAlg.CreateEncryptor(aesAlg.Key, aesAlg.IV);

                // Create the streams used for encryption.
                using (MemoryStream msEncrypt = new MemoryStream())
                {
                    using (CryptoStream csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                    {
                        using (StreamWriter swEncrypt = new StreamWriter(csEncrypt))
                        {

                            //Write all data to the stream.
                            swEncrypt.Write(plainText);
                        }
                        encrypted = msEncrypt.ToArray();
                    }
                }
            }
            // Return the encrypted bytes from the memory stream.
            result = Convert.ToBase64String(encrypted);
        }
        private void decodestring(string when)
        {
            byte[] cipherText = Convert.FromBase64String(plainText);
            // Create an Aes object
            // with the specified key and IV.
            using (Aes aesAlg = Aes.Create())
            {
                aesAlg.Key = Encoding.UTF8.GetBytes("ericxXinericxXinericxXinericxXin");
                aesAlg.IV = Encoding.UTF8.GetBytes(when+when);

                // Create a decrytor to perform the stream transform.
                ICryptoTransform decryptor = aesAlg.CreateDecryptor(aesAlg.Key, aesAlg.IV);

                // Create the streams used for decryption.
                using (MemoryStream msDecrypt = new MemoryStream(cipherText))
                {
                    using (CryptoStream csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
                    {
                        using (StreamReader srDecrypt = new StreamReader(csDecrypt))
                        {

                            // Read the decrypted bytes from the decrypting stream
                            // and place them in a string.
                            result = srDecrypt.ReadToEnd();
                        }
                    }
                }

            }
        }
    }
}
