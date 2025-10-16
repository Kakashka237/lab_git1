using System;
using lab_git;
class Program
{
    static void Main(string[] args)
    {
        string inputname = "";
        string inputspot = "";

        while (string.IsNullOrWhiteSpace(inputname))
        {
            Console.Write("Введите имя вашего героя: ");
            inputname = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(inputname))
            {
                Console.WriteLine("Имя не может быть пустым или состоять только из пробелов");
            }
        }

        while (string.IsNullOrWhiteSpace(inputspot))
        {
            Console.Write("Введите место куда отправится герой: ");
            inputspot = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(inputspot))
            {
                Console.WriteLine("Место не может быть пустым или состоять только из пробелов");
            }
        }
        Person p = new Person(inputname, inputspot);
        p.LeaveHome();
        p.GotHere();
        p.LightLamp();
        p.Condition();
    }
}