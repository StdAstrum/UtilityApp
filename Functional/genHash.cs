using UtilityApp.Models;

namespace UtilityApp.Functional
{
    public class genHash
    {
        public static List<string> generate(hashModel model)
        {
            List<string> hashes = new List<string>();

            if (string.IsNullOrEmpty(model.data))
                throw new ArgumentException("Data cannot be empty", nameof(model.data));

            if (string.IsNullOrEmpty(model.algorithm))
                model.algorithm = Data.defaultHashAlgorithm;

            using (var hashAlgorithm = System.Security.Cryptography.HashAlgorithm.Create(model.algorithm))
            {
                if (hashAlgorithm == null)
                    throw new NotSupportedException($"Hash algorithm '{model.algorithm}' is not supported.");

                if (string.IsNullOrEmpty(model.salt))
                    model.salt = string.Empty;

                byte[] dataBytes = System.Text.Encoding.UTF8.GetBytes(model.data + model.salt);
                byte[] hashBytes = hashAlgorithm.ComputeHash(dataBytes);

                hashes.Add(model.data);
                if (!string.IsNullOrEmpty(model.salt)) hashes.Add(model.salt);
                hashes.Add(model.algorithm);
                hashes.Add(BitConverter.ToString(hashBytes).Replace("-", "").ToLowerInvariant());

                return hashes;
            }
        }
    }
}
