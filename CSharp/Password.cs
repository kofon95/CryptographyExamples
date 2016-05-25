using System.Security.Cryptography;

public static class Password
{
	public static string GetPasswordHash(string password)
	{
		Rfc2898DeriveBytes rfc = new Rfc2898DeriveBytes(password, 32);
		rfc.IterationCount = 16384;
		byte[] hash = rfc.GetBytes(32);
		byte[] salt = rfc.Salt;
		return Convert.ToBase64String(salt) + "|" + Convert.ToBase64String(hash);
	}
}