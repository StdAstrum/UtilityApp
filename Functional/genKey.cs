using System.IO;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Crypto.Generators;
using Org.BouncyCastle.Security;
using Org.BouncyCastle.Pkcs;
using Org.BouncyCastle.OpenSsl;
using Org.BouncyCastle.Asn1.Sec;
using UtilityApp.Models;

namespace UtilityApp.Functional
{
    public class genKey
    {
        public static List<string> generate(keyModel model)
        {
            switch (model.keyType)
            {
                case "RSA":
                    return generateRSAKey(model.keyPassphrase);
                case "ECDSA":
                    return generateECDSAKey(model.keyPassphrase);
                case "ED25519":
                    return generateEd25519Key(model.keyPassphrase);
                default:
                    throw new ArgumentException("Unsupported key type: " + model.keyType);
            }
        }

        private static List<string> generateRSAKey(string passphrase)
        {
            var rsaGen = new RsaKeyPairGenerator();
            rsaGen.Init(new KeyGenerationParameters(new SecureRandom(), 2048));
            var keyPair = rsaGen.GenerateKeyPair();

            string pubPem = ExportPublicKeyPem(keyPair.Public);
            string privPem = ExportEncryptedPrivateKeyPem(keyPair.Private, passphrase);

            return new List<string> { passphrase, pubPem, privPem };
        }

        private static List<string> generateECDSAKey(string passphrase)
        {
            var ecGen = new ECKeyPairGenerator();
            var ecParams = SecNamedCurves.GetByName("secp256k1");
            var ecDomain = new ECDomainParameters(ecParams.Curve, ecParams.G, ecParams.N, ecParams.H);
            ecGen.Init(new ECKeyGenerationParameters(ecDomain, new SecureRandom()));
            var keyPair = ecGen.GenerateKeyPair();

            string pubPem = ExportPublicKeyPem(keyPair.Public);
            string privPem = ExportEncryptedPrivateKeyPem(keyPair.Private, passphrase);

            return new List<string> { passphrase, pubPem, privPem };
        }

        private static List<string> generateEd25519Key(string passphrase)
        {
            var edGen = new Ed25519KeyPairGenerator();
            edGen.Init(new KeyGenerationParameters(new SecureRandom(), 256));
            var keyPair = edGen.GenerateKeyPair();

            string pubPem = ExportPublicKeyPem(keyPair.Public);
            string privPem = ExportEncryptedPrivateKeyPem(keyPair.Private, passphrase);

            return new List<string> { passphrase, pubPem, privPem };
        }

        private static string ExportPublicKeyPem(AsymmetricKeyParameter pubKey)
        {
            using var sw = new StringWriter();
            var pemWriter = new PemWriter(sw);
            pemWriter.WriteObject(pubKey);
            pemWriter.Writer.Flush();
            return sw.ToString();
        }

        private static string ExportEncryptedPrivateKeyPem(AsymmetricKeyParameter privKey, string passphrase)
        {
            var pkcs8Gen = new Pkcs8Generator(privKey, Pkcs8Generator.PbeSha1_3DES);
            pkcs8Gen.Password = passphrase.ToCharArray();

            using var sw = new StringWriter();
            var pemWriter = new PemWriter(sw);
            pemWriter.WriteObject(pkcs8Gen);
            pemWriter.Writer.Flush();
            return sw.ToString();
        }
    }
}
