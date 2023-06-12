internal class Program
{
    private static void Main(string[] args)
    {
        MyClass myObject = new MyClass
        {
            FirstName = "John",
            LastName = "Doe",
            Email = "john.doe@example.com"
        };

        Dictionary<string, string> maskPatterns = new Dictionary<string, string>
        {
            { "FirstName", @"[A-Za-z]{1}" },   // Masks the first character of the first name
            { "LastName", @"[A-Za-z]{1}" },    // Masks the first character of the last name
            { "Email", @"(?<=^[^@]{0,})[^@]" } // Masks the "john.doe" part in the email address
        };

        object maskedString = StringMasker.MaskString(myObject, maskPatterns);

        Console.WriteLine(maskedString.ToString());


    }
}