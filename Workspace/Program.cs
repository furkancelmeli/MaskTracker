using Business.Concrete;
using Entities.Concrete;

internal class Program
{
    private static void Main(string[] args)
    {
        Person person1 = new Person();
        person1.NationalIdentity = 12345678910;
        person1.FirstName = "MUHAMMET FURKAN";
        person1.LastName = "ÇELMELİ";
        person1.DateOfBirthYear = 2000;

        PttManager pttManager = new PttManager(new PersonManager());
        pttManager.GiveMask(person1);
        Console.ReadLine();
    }
}