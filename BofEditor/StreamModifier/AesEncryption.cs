using System;
using System.IO;
using System.Security.Cryptography;

namespace BofEditor {
    public class AesEncryption : IStreamModifier {
        public byte[] Key { get; set; }

        public void Modify(Stream input, Stream output) {
            using (Aes aesAlg = Aes.Create()) {
                aesAlg.Key = Key;
                aesAlg.GenerateIV();

                ICryptoTransform encryptor = aesAlg.CreateEncryptor(aesAlg.Key, aesAlg.IV);

                using (CryptoStream stEncryptor = new CryptoStream(output, encryptor, CryptoStreamMode.Write)) {
                    output.Write(aesAlg.IV, 0, 16);

                    input.CopyTo(stEncryptor);
                    stEncryptor.FlushFinalBlock();
                }
            }
        }
        public void Unmodify(Stream input, Stream output) {
            using (Aes aesAlg = Aes.Create()) {
                aesAlg.Key = Key;

                byte[] iv = new byte[16];
                input.Read(iv, 0, iv.Length);
                aesAlg.IV = iv;

                ICryptoTransform decryptor = aesAlg.CreateDecryptor(aesAlg.Key, aesAlg.IV);

                using (CryptoStream stDecryptor = new CryptoStream(input, decryptor, CryptoStreamMode.Read)) {
                    stDecryptor.CopyTo(output);
                    stDecryptor.Flush();
                }
            }
        }
    }
}
