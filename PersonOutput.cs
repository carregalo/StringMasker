using StringMaker;
using System.ComponentModel;

namespace StringMaker;
public class PersonOutput
{

    public string FirstName { get; set; }


    public string LastName { get; set; }


    public string Email { get; set; }


    public string BirthDate { get; set; }
    public string ShortDate { get; set; }

    public override string ToString()
    {
        return $"FirstName: {FirstName}, LastName: {LastName}, Email: {Email}, BirthDate: {BirthDate}, Date: {ShortDate}";
    }
}
