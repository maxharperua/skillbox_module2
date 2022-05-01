using System;

namespace module2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            string fullName = "Иванов Иван Ивановчич";
            byte age = 33;
            string email = "mail@mail.com";
            byte scroreProgrammer = 15;
            byte scroreMath = 11;
            byte scrorePhysix = 8;

            Console.WriteLine($"Ф.И.О. - {fullName} \n" +
                              $"Возраст {age} \n" +
                              $"Email {email} \n" +
                              $"Баллы по программированию - {scroreProgrammer} \n" +
                              $"Баллы по математике - {scroreMath} \n" +
                              $"Баллы по физике - {scrorePhysix}");
            Console.ReadKey();

            int ScoreSumm = scroreMath + scrorePhysix + scroreProgrammer;
            string middleScore = string.Format("{0:f}", ScoreSumm / 3.0);
            Console.WriteLine($"Сумма балов - {ScoreSumm} \nСрединй бал - {middleScore}");
            Console.ReadKey();
        }
    }
}