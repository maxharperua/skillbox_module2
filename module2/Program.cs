using System;

namespace module2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            string FullName = "Иванов Иван Ивановчич";
            byte Age = 33;
            string Email = "mail@mail.com";
            byte ScroreProgrammer = 15;
            byte ScroreMath = 10;
            byte ScrorePhysix = 8;

            Console.WriteLine($"Ф.И.О. - {FullName} \n" +
                              $"Возраст {Age} \n" +
                              $"Email {Email} \n " +
                              $"Баллы по программированию - {ScroreProgrammer} \n" +
                              $"Баллы по математике - {ScroreMath} \n" +
                              $"Баллы по физике - {ScrorePhysix}");
            Console.ReadKey();

            int ScoreSumm = ScroreMath + ScrorePhysix + ScroreProgrammer;
            Console.WriteLine($"Сумма балов - {ScoreSumm} \nСрединй бал - {ScoreSumm / 3}");
            Console.ReadKey();
        }
    }
}