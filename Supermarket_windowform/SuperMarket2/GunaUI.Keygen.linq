void Main()
{
    string strMail = "email@host.com";
    DateTime ExpirationDate = new DateTime(2099, 07, 31);
    string HWID = Registry.GetValue("HKEY_LOCAL_MACHINE\\HARDWARE\\DESCRIPTION\\System\\CentralProcessor\\0", "ProcessorNameString", "??").ToString() +
                   Registry.GetValue("HKEY_LOCAL_MACHINE\\HARDWARE\\DESCRIPTION\\System\\BIOS", "SystemManufacturer", "").ToString();

    string strKey = CreateKey(strMail, string.Join("~", new string[] { "1", "3", ExpirationDate.ToString("yyyy-MM-dd") }));
    string lic1 = Convert.ToBase64String(Encoding.UTF8.GetBytes(strMail + "," + strKey + "," + HWID));

    string strToHash = "97" + strKey;
    string strHash = CreateMD5(strToHash);
    string strHash2 = CreateMD5(strHash);
    string strCode = strHash2.Substring(8, 4).ToUpper();

    string Any2Chars = "w3";                   
    string lic2 = Any2Chars + Encrypt(lic1, 1);
    string lic3 = Encrypt(lic2, 2);
    string lic4 = strCode + Any2Chars + Encrypt(strCode + Any2Chars + lic3, 3);
    string lic5 = Encrypt(lic4, 4);

    //Location of license v2.0.0.7 - v2.0.0.9
    string LicPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), ".guna\\guna-ui-v2");
    if (!Directory.Exists(LicPath))
        Directory.CreateDirectory(LicPath);
    File.WriteAllText(LicPath + "\\.gunauiv2cache", lic5);

    //Location of license v2.0.1.1 - v2.0.1.4
    string LicPath2 = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), ".guna\\gunaui");
    if (!Directory.Exists(LicPath2))
        Directory.CreateDirectory(LicPath2);
    File.WriteAllText(LicPath2 + "\\.gunaui_v2", lic5);
  
    HWID.Dump("HWID:") ;
    ("1. " + LicPath + "\r\n2. " + LicPath2).Dump("Location of license:");
    "All versions from v2.0.0.7 up to v2.0.1.4 are activated now !".Dump("Info:");
 
    MessageBox.Show("License written to \r\n\r\n" + "1. \"" + LicPath + "\\.gunaui_v2\"   and\r\n2. \"" + LicPath2 + "\\.gunauiv2cache\"\r\n\r\n*** All versions from v2.0.0.7 up to v2.0.1.4 are activated now ! *** " , "Keygen GunaUI v2.0.0.7 - v2.0.1.4",MessageBoxButtons.OK,MessageBoxIcon.Information);

}

private string Encrypt(string param, sbyte num)
{
    byte[] rgbKey = new byte[32];
    byte[] rgbIV = new byte[16];
    PaddingMode PM = PaddingMode.None;

    switch (num)
    {
        case 1:
            rgbKey = new Rfc2898DeriveBytes("P@@Sw0rd", Encoding.ASCII.GetBytes("S@LT&KEY")).GetBytes(32);
            rgbIV = Encoding.ASCII.GetBytes("@1B2c3D4e5F6g7H8");
            PM = PaddingMode.Zeros;
            break;
        case 2:
            PasswordDeriveBytes password2 = new PasswordDeriveBytes("stagram.com/ilham.1607", null);
            rgbKey = password2.GetBytes(32);
            rgbIV = Encoding.ASCII.GetBytes("pemgail9uzpgzl88");
            PM = PaddingMode.PKCS7;
            break;
        case 3:
            string Prefix = param.Substring(0, 6);
            param = param.Substring(6);
            PasswordDeriveBytes password = new PasswordDeriveBytes(Prefix.Substring(2, 2), null);
            rgbKey = password.GetBytes(32);
            rgbIV = Encoding.ASCII.GetBytes("pemgail9uzpgzl88");
            PM = PaddingMode.PKCS7;
            break;
        case 4:
            PasswordDeriveBytes password4 = new PasswordDeriveBytes("@ilham.1607", null);
            rgbKey = password4.GetBytes(32);
            rgbIV = Encoding.ASCII.GetBytes("pemgail9uzpgzl88");
            PM = PaddingMode.PKCS7;
            break;
    }

    ICryptoTransform transform = new RijndaelManaged
    {
        Mode = CipherMode.CBC,
        Padding = PM
    }.CreateEncryptor(rgbKey, rgbIV);

    byte[] bytes = Encoding.UTF8.GetBytes(param);
    byte[] inArray = new byte[] { };
    using (MemoryStream memoryStream = new MemoryStream())
    {
        using (CryptoStream cryptoStream = new CryptoStream(memoryStream, transform, CryptoStreamMode.Write))
        {
            cryptoStream.Write(bytes, 0, bytes.Length);
            cryptoStream.FlushFinalBlock();
            inArray = memoryStream.ToArray();
            cryptoStream.Close();
        }
        memoryStream.Close();
    }
    return Convert.ToBase64String(inArray);
}


private static string CreateKey(string strMail, string strData)
{
    string text2 = CreateMD5("ilham" + strMail);
    string text3 = "";

    int length = text2.Length;
    int num = strData.Length;
    checked
    {
        for (int i = 1; i <= num; i++)
            text3 += (((int)strData[i - 1]) ^ ((int)text2[i % length])).ToString("X2");

        return text3;
    }
}


public static string CreateMD5(string string_0)
{
    HashAlgorithm halg = new MD5CryptoServiceProvider();
    byte[] array2 = halg.ComputeHash(Encoding.ASCII.GetBytes(string_0));
    string text = "";
    checked
    {
        for (int i = 0; i < array2.Length; i++)
        {
            byte b = array2[i];
            text += b.ToString("x2");
        }
        return text;
    }
}