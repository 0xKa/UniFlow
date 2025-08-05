using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UniFlow.Shared;

public class Validation
{
    public static bool IsValidNationalID(string nationalID)
    {
        // remove any spaces or dashes
        string cleanedID = System.Text.RegularExpressions.Regex.Replace(nationalID, @"[\s\-]", "");

        // id between 2-14 digits
        return System.Text.RegularExpressions.Regex.IsMatch(cleanedID, @"^\d{2,14}$");
    }

    public static bool IsValidPhoneNumber(string phone)
    {
        // Remove spaces, dashes, parentheses
        string cleanedPhone = System.Text.RegularExpressions.Regex.Replace(phone, @"[\s\-\(\)]", "");

        // Supports: +1234567890, 01234567890, 1234567890
        return System.Text.RegularExpressions.Regex.IsMatch(cleanedPhone, @"^(\+?\d{1,3})?\d{7,14}$");
    }

    public static bool IsValidDateOfBirth(DateTime dateOfBirth)
    {
        return dateOfBirth <= DateTime.Today.AddYears(-18).AddMonths(3) && dateOfBirth >= DateTime.Today.AddYears(-100);
    }

    public static bool IsValidEmail(string email)
    {
        string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
        return Regex.IsMatch(email, pattern) || string.IsNullOrEmpty(email);
    }


    public static bool IsPositiveDecimal(string sNumber)
    {
        return decimal.TryParse(sNumber, out decimal Fees) && Fees > 0;
    }

}
