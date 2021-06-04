using System.Security.Cryptography;
using System.Text;
using SL.CentralCave.Services.Enums;

namespace SL.CentralCave.Services
{
    public sealed class Encryptor
    {
        #region Singleton
        private readonly static Encryptor _instance = new Encryptor();

        public static Encryptor Current
        {
            get
            {
                return _instance;
            }
        }
        #endregion

        public string Compute(string data)
        {
            return ComputeSha256(data);
        }

        public string Compute(string data, HashMethod method)
        {
            switch (method)
            {
                case HashMethod.MD5:
                    return ComputeMd5(data);
                case HashMethod.SHA1:
                    return ComputeSha1(data);
                case HashMethod.SHA256:
                    return ComputeSha256(data);
                default:
                    return ComputeSha256(data);
            }
        }

        private string ComputeSha256(string data)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                return ComputeHash(data, sha256Hash);
            }
        }

        private string ComputeSha1(string data)
        {
            using (SHA1 sha1Hash = SHA1.Create())
            {
                return ComputeHash(data, sha1Hash);
            }
        }

        private string ComputeMd5(string data)
        {
            using (MD5 md5Hash = MD5.Create())
            {
                return ComputeHash(data, md5Hash);
            }
        }

        private string ComputeHash(string data, HashAlgorithm algorithm)
        {
            // ComputeHash - returns byte array  
            byte[] bytes = algorithm.ComputeHash(Encoding.UTF8.GetBytes(data));

            // Convert byte array to a string   
            StringBuilder builder = new StringBuilder();
            for (int i = 0; i < bytes.Length; i++)
            {
                builder.Append(bytes[i].ToString("x2"));
            }

            return builder.ToString();
        }
    }
}
