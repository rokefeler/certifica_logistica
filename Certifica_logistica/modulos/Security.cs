using Microsoft.Practices.EnterpriseLibrary.Security.Cryptography;
using Microsoft.Practices.EnterpriseLibrary.Common.Configuration;

namespace Certifica_logistica.modulos
{
    public class Security
    {
        public static string CreateHash(string plainText)
        {
            // TODO: Hash the plain text
                //hash = plainText;
                var crypto = EnterpriseLibraryContainer.Current.GetInstance<CryptographyManager>();
                var hash = crypto.CreateHash(CONSTANTE.HashProvider, plainText);
                return hash;
        }
        public static bool CompareHash(string plainText, string hashedText)
            {
            // TODO: Compare plain text with hash
                //compare = (plainText == hashedText);
                var crypto = EnterpriseLibraryContainer.Current.GetInstance<CryptographyManager>();
                var compare = crypto.CompareHash(CONSTANTE.HashProvider, plainText, hashedText);
                return compare;
            }
        public static string Encripta(string plainText)
        {
            var crypto = EnterpriseLibraryContainer.Current.GetInstance<CryptographyManager>();
            var scrypted = crypto.EncryptSymmetric(CONSTANTE.CryptoProvider, plainText);
            return scrypted;
        }
        /*public static byte[] Encripta(byte plainBytes)
        {
            CryptographyManager crypto = EnterpriseLibraryContainer.Current.GetInstance<CryptographyManager>();
            byte[] scrypted = crypto.EncryptSymmetric(HashProvider, plainBytes);
            return scrypted;
        }*/
        public static string Desencripta(string plainText)
        {
            var crypto = EnterpriseLibraryContainer.Current.GetInstance<CryptographyManager>();
            var descrypted = crypto.DecryptSymmetric(CONSTANTE.CryptoProvider, plainText);
            return descrypted;
        }
        public static byte[] Desencripta(byte[] plainBytes)
        {
            var crypto = EnterpriseLibraryContainer.Current.GetInstance<CryptographyManager>();
            var descrypted = crypto.DecryptSymmetric(CONSTANTE.CryptoProvider, plainBytes);
            return descrypted;
        }

        //source: http://www.ajpdsoft.com/modules.php?name=News&file=article&sid=601
        /*
         * * Texto a cifrar: el texto que queramos cifrar o encriptar con AES.
           * Contraseña o palabra de paso: texto que se usará para generar el algoritmo de cifrado.
* valorRGBSalt: una cadena de texto cualquiera.
* Algoritmo de cifrado: puede ser "MD5" ó "SHA1".
* Iteraciones: número de iteraciones.
* Vector inicial: un texto o número de 16 bytes (16 caracteres) 
* Tamaño clave: puede ser 128, 192 o 256.
         * 
        public static string CifrarTextoAes(string textoCifrar, string palabraPaso,
           string valorRGBSalt, int iteraciones, string vectorInicial, int tamanoClave)
        {
            const string algoritmoEncriptacionHash = "SHA1"; //puede ser MD5 o SHA1, pero MD5 esta desfasado y es inseguro
            try
            {
                var initialVectorBytes = Encoding.ASCII.GetBytes(vectorInicial);
                var saltValueBytes = Encoding.ASCII.GetBytes(valorRGBSalt);
                var plainTextBytes = Encoding.UTF8.GetBytes(textoCifrar);

                var password =
                    new PasswordDeriveBytes(palabraPaso, saltValueBytes,
                        algoritmoEncriptacionHash, iteraciones);

                var keyBytes = password.GetBytes(tamanoClave / 8);
                PasswordDeriveBytes 
                var symmetricKey = new RijndaelManaged();

                symmetricKey.Mode = CipherMode.CBC;

                var encryptor =
                    symmetricKey.CreateEncryptor(keyBytes, initialVectorBytes);

                var memoryStream = new MemoryStream();

                var cryptoStream =
                    new CryptoStream(memoryStream, encryptor, CryptoStreamMode.Write);

                cryptoStream.Write(plainTextBytes, 0, plainTextBytes.Length);

                cryptoStream.FlushFinalBlock();

                var cipherTextBytes = memoryStream.ToArray();

                memoryStream.Close();
                cryptoStream.Close();

                var textoCifradoFinal = Convert.ToBase64String(cipherTextBytes);

                return textoCifradoFinal;
            }
            catch
            {
                return null;
            }
        }


        public static string DescifrarTextoAes(string textoCifrado, string palabraPaso, 
            string valorRgbSalt, int iteraciones, string vectorInicial, int tamanoClave)
        {
            const string algoritmoEncriptacionHash = "SHA1"; //puede ser MD5 o SHA1, pero MD5 esta desfasado y es inseguro
            try
            {
                var initialVectorBytes = Encoding.ASCII.GetBytes(vectorInicial);
                var saltValueBytes = Encoding.ASCII.GetBytes(valorRgbSalt);

                var cipherTextBytes = Convert.FromBase64String(textoCifrado);

                var password =
                    new PasswordDeriveBytes(palabraPaso, saltValueBytes,
                        algoritmoEncriptacionHash, iteraciones);

                var keyBytes = password.GetBytes(tamanoClave / 8);

                var symmetricKey = new RijndaelManaged();

                symmetricKey.Mode = CipherMode.CBC;

                var decryptor = symmetricKey.CreateDecryptor(keyBytes, initialVectorBytes);

                var memoryStream = new MemoryStream(cipherTextBytes);

                var cryptoStream =
                    new CryptoStream(memoryStream, decryptor, CryptoStreamMode.Read);

                var plainTextBytes = new byte[cipherTextBytes.Length];

                var decryptedByteCount = cryptoStream.Read(plainTextBytes, 0, plainTextBytes.Length);

                memoryStream.Close();
                cryptoStream.Close();

                var textoDescifradoFinal = Encoding.UTF8.GetString(plainTextBytes, 0, decryptedByteCount);

                return textoDescifradoFinal;
            }
            catch
            {
                return null;
            }
        } */
    } 
    
}
