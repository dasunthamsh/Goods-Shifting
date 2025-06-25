//using System.Text;

//private string HashPassword(string password)
//{
//    using (var sha256 = System.Security.Cryptography.SHA256.Create())
//    {
//        byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
//        StringBuilder builder = new StringBuilder();
//        foreach (byte b in bytes)
//            builder.Append(b.ToString("x2"));
//        return builder.ToString();
//    }
//}
