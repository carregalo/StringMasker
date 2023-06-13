using StringMaker;

internal class Program
{
    private static void Main(string[] args)
    {
        PersonInput input = new PersonInput
        {
            FirstName = "John",
            LastName = "Doe",
            Email = "john.doe@example.com",
            BirthDate = new DateTime(1990, 8, 24)
        };


        PersonOutput? maskedString = MaskerService.MaskObject<PersonInput, PersonOutput>(input) as PersonOutput;

        Console.WriteLine(maskedString.ToString());


    }
}