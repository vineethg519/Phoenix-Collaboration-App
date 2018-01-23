using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace PhoenixCollaborationApp
{
	public enum Supported_HA
	{
		SHA256, SHA512
	}
	class ShaEncryption
	{
		//This are new hashing functions with salt.
		public static string ComputeHash(string plainText, Supported_HA hash, byte[] salt)
		{
			int minSaltLength = 4;
			int maxSaltLength = 16;

			byte[] saltBytes = null;

			if (salt != null)
			{
				saltBytes = salt;
			}
			else
			{
				Random r = new Random();
				int saltLength = r.Next(minSaltLength, maxSaltLength);
				saltBytes = new byte[saltLength];
				RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider();
				rng.GetNonZeroBytes(saltBytes);
				rng.Dispose();
			}

			byte[] plainData = ASCIIEncoding.UTF8.GetBytes(plainText);
			byte[] plainDataWithSalt = new byte[plainData.Length + saltBytes.Length];

			for (int x = 0; x < plainData.Length; x++)
				plainDataWithSalt[x] = plainData[x];
			for (int n = 0; n < saltBytes.Length; n++)
				plainDataWithSalt[plainData.Length + n] = saltBytes[n];

			byte[] hashValue = null;

			switch (hash)
			{
				case Supported_HA.SHA256:
					SHA256Managed sha1 = new SHA256Managed();
					hashValue = sha1.ComputeHash(plainDataWithSalt);
					sha1.Dispose();
					break;
				case Supported_HA.SHA512:
					SHA512Managed sha2 = new SHA512Managed();
					hashValue = sha2.ComputeHash(plainDataWithSalt);
					sha2.Dispose();
					Console.WriteLine("OUTPUT BLOCK SIZE IS : "+ sha2.OutputBlockSize);
					break;
			}

			byte[] result = new byte[hashValue.Length + saltBytes.Length];
			for (int x = 0; x < hashValue.Length; x++)
				result[x] = hashValue[x];
			for (int n = 0; n < saltBytes.Length; n++)
				result[hashValue.Length + n] = saltBytes[n];

			return Convert.ToBase64String(result);
		}

		public static bool CheckHash(string plainText, string hashValue, Supported_HA hash)
		{
			byte[] hashBytes = Convert.FromBase64String(hashValue);
			int hashSize = 0;

			switch (hash)
			{
				case Supported_HA.SHA256:
					hashSize = 32;
					break;
				case Supported_HA.SHA512:
					hashSize = 64;
					break;
			}

			byte[] saltBytes = new byte[hashBytes.Length - hashSize];

			for (int x = 0; x < saltBytes.Length; x++)
				saltBytes[x] = hashBytes[hashSize + x];

			string newHash = ComputeHash(plainText, hash, saltBytes);

			return (hashValue == newHash);
		}

		//This are old hashing functions without salt.
		private static string GetStringFromHash(byte[] hash)
		{

			StringBuilder res = new StringBuilder();
			for (int i = 0; i < hash.Length; i++)
			{
				res.Append(hash[i].ToString("X2"));
			}
			return res.ToString();
		}
		
		public static string GenerateSHA512String(string inputString)
		{
			SHA512 sha512 = SHA512.Create();
			byte[] bytes = Encoding.UTF8.GetBytes(inputString);
			byte[] hash = sha512.ComputeHash(bytes);
			return GetStringFromHash(hash);
		}
	}
}
