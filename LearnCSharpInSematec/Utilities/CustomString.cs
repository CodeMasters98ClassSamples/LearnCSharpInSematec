namespace LearnCSharpInSematec.Utilities;

public static class CustomString
{
    public static string CleanPhoneNumber(this string phoneNumber)
    {
        if (string.IsNullOrEmpty(phoneNumber))
            return string.Empty;

        phoneNumber = phoneNumber.Trim().Replace("+98", "0").Replace("0098", "0");
        phoneNumber = phoneNumber.Length == 10 ? "0" + phoneNumber : phoneNumber;
        return phoneNumber;
    }
}
