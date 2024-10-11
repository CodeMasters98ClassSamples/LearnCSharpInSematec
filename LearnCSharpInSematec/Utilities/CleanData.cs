using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnCSharpInSematec.Utilities;


//Class member => Property + Methods
public static class CleanData
{
    /// <summary>
    /// This method check phonemuber and make it better!
    /// </summary>
    /// <param name="phoneNumber">phoneNumber from ..</param>
    /// <returns>return clean phoneNumber</returns>
    public static string PhoneNumber(string phoneNumber)
    {
        if (string.IsNullOrEmpty(phoneNumber))
            return string.Empty;

        phoneNumber = phoneNumber.Trim().Replace("+98", "0").Replace("0098", "0");
        phoneNumber = phoneNumber.Length == 10 ? "0" + phoneNumber : phoneNumber;
        return phoneNumber;
    }
}
