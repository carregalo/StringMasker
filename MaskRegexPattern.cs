using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringMaker
{
    public static class MaskRegexPattern 
    {
        public const string Email = "(?<=^[^@]{0,})[^@]";
        public const string FirstName = "[A-Za-z]{1}";
        public const string LastName = "[A-Za-z]{1}";
        //public const string BirthDate = @"\d{1,2}/\d{1,2}/\d{4}\s.*";
        public const string BirthDate = @"\d{1,2}/\d{1,2}";
        public const string Date = @"\d{1,2}/\d{1,2}/\d{4}";

    }

    public static class MaskPattern
    {
        public const string Email = "*";
        public const string FirstName = "*";
        public const string LastName = "*";
        public const string BirthDate = "**/**";
        public const string Date = "**/**/****";

    }
}
