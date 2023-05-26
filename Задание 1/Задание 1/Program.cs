using System;

namespace Задание_1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Задание 1");

            string str1 = "hello";
            string str2 = "word";
            string result = str1 + " " + str2;
            Console.WriteLine(result);


            Console.WriteLine("Задание 2");

            int a = 20;
            int b = 10;
            Console.WriteLine("Сложение:" + (a + b));
            Console.WriteLine("Вычетание:" + (a - b));
            Console.WriteLine("Умножение:" + (a * b));
            Console.WriteLine("Деление:" + (a / b));

            Console.WriteLine("Задание 3");

            Console.WriteLine("Введите имя:");
            string firstName = Console.ReadLine();

            Console.WriteLine("Введите фамилию:");
            string lastName = Console.ReadLine();

            Console.WriteLine("Введите отчесвто:");
            string middleName = Console.ReadLine();

            String fullName = $"{lastName} {firstName} {middleName}";
            Console.WriteLine($"ФИО: {fullName}");

            Console.WriteLine("Задание 4");

            int playerHealth = 90; // сколько осталось здоровья у игрока
            int playerDamage = 35; // сколько нанёс урон игрок
            int playerDefense = 10; // Защита игрока

            int monsterHealth = 70; // сколько осталось здоровья у монстра
            int monsterDamage = 20; // сколько нанёс урона монстр
            int monsterDefense = 5; // Защита монстра

            int playerDamageDealt = (int)Math.Round((double)monsterDamage / playerDefense * 90); // Урон игрока монстру
            int monsterDamageDealt = (int)Math.Round((double)playerDamage / monsterDefense * 90); // Урон монстра игроку

            playerHealth -= monsterDamageDealt; // Уменьшаем здоровье игрока на урон, нанесенный монстром
            monsterHealth -= playerDamageDealt; // Уменьшаем здоровье монстра на урон, нанесеннйы игроком

            Console.WriteLine("сколько осталось здоровья у игрока:" + playerHealth);
            Console.WriteLine("сколько осталось здоровья у монстра:" + monsterHealth);
            Console.WriteLine("сколько нанёс урон игрок:" + playerDamageDealt);
            Console.WriteLine("сколько нанёс урона монстр:" + monsterDamageDealt);



        }
    }
}
