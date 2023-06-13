using StringMaker;
using System.ComponentModel;

namespace StringMaker;
public class PersonInput
{
    [Mask(MaskRegexPattern.FirstName, MaskPattern.FirstName)]
    public string FirstName { get; set; }

    [Mask(MaskRegexPattern.LastName, MaskPattern.LastName)]
    public string LastName { get; set; }

    [Mask(MaskRegexPattern.Email, MaskPattern.Email)]
    public string Email { get; set; }

    [Mask(MaskRegexPattern.BirthDate, MaskPattern.BirthDate)]
    public DateTime BirthDate { get; set; }
    [Mask(MaskRegexPattern.Date, MaskPattern.Date)]
    public DateTime ShortDate { get; set; }

    public override string ToString()
    {
        return $"FirstName: {FirstName}, LastName: {LastName}, Email: {Email}, BirthDate: {BirthDate}, Date: {ShortDate}";
    }
}
