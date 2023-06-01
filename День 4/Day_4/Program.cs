using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_4
{
    internal class Program
    {
        static void Main(string[] args)
        {  
            Employee employees = new Employee("fio", 10000, 1, 1);
            List<Employee> employee = new List<Employee>()
            {
                new Employee("Сергеев Сергей Сергеевич", 10000, 1, 1),
                new Employee("Ильин Виталий Сергеевич", 15000, 2, 2),
                new Employee("Семенов Валерий Петрович", 17000, 1, 3),
                new Employee("Никольский Иван Федорвич", 12000, 3, 4),
                new Employee("Никольский Владимир Федорович", 15000, 5, 5),
                new Employee("Сергина Александра Олеговна", 15000, 5, 6),
                new Employee("Аврамова Ирина Владимировна", 19000, 4, 7),
                new Employee("Дубов Егор Сергеевич", 22000, 1, 8),
                new Employee("Акбарин Федор Ильич", 16000, 3, 9),
                new Employee("Зубова Елена Анатольевна", 20000, 2, 10),
                new Employee("Сеченова Самира Ахметовна", 25000, 4, 11),
                new Employee("Петров Петр Петрович", 15000, 4, 12),
                new Employee("Иванов Иван Иванович", 20000, 2, 13),
                new Employee("Николаев Николай Николаевич", 25500, 3, 14),
                new Employee("Aлексеев Алексей Алексеевич", 30000, 5, 15),
            };
            TargetA();
            TargetB();
            TargetC();
            TargetD();
            TargetE();
            TargetF();
            Index();
            Wagesminimal();
            Wagesmaximal();
            Tasks();
            

            void TargetA()
            {
                Console.WriteLine("Task A");
                foreach (var emp in employee)
                {
                    Console.WriteLine($"Id: {emp.Id} ФИО: {emp.fio}, Зарплата: {emp.wages}, Отдел: {emp.department}");
                }
            }
            void TargetB()
            {
                Console.WriteLine("\n" + "Task B");
                double sum = 0;
                foreach (var emp in employee)
                {
                    sum += emp.wages;
                }
                Console.WriteLine($"Сумма затрат на ЗП {sum} в месяц");
            }
            void TargetC()
            {
                Console.WriteLine("\n" + "Task C");
                double min = 500000;
                foreach (var emp in employee)
                {
                    if (emp.wages < min)
                    {
                        min = emp.wages;
                    }
                }
                Console.WriteLine($"Минимальная ЗП: {min}");
            }
            void TargetD()
            {
                Console.WriteLine("\n" + "Task D");
                double max = 0;
                foreach (var emp in employee)
                {
                    if (emp.wages > max)
                    {
                        max = emp.wages;
                    }
                }
                Console.WriteLine($"Максимальная ЗП: {max}");
            }
            void TargetE()
            {
                Console.WriteLine("\n" + "Task E");
                int count = 0;
                double sum = 0;
                foreach (var emp in employee)
                {
                    count++;
                    sum += emp.wages;
                }
                Console.WriteLine($"Среднее значение ЗП: {sum / count}");
            }
            void TargetF()
            {
                Console.WriteLine("\n" + "Task F");
                foreach (var emp in employee)
                {
                    Console.WriteLine($"ФИО: {emp.fio}");
                }
            }
            void Index()
            {
                Console.WriteLine("\n" + "Индексация ЗП");
                double index = 1.12;
                foreach (var emp in employee)
                {
                    Console.WriteLine($"После индексации ЗП составляет: {index * emp.wages}");
                }
            }
            void Wagesminimal()
            {
                Console.WriteLine("\n" + "Сотрудники с ЗП меньше 20000 ");
                foreach (var emp in employee)
                {
                    if (emp.wages < 20000)
                    {
                        Console.WriteLine($"Id: {emp.Id} ФИО: {emp.fio}, Зарплата: {emp.wages}, Отдел: {emp.department}");
                    }
                }
            }
            void Wagesmaximal()
            {
                Console.WriteLine("\n" + "Сотрудники с ЗП меньше 20000 ");
                foreach (var emp in employee)
                {
                    if (emp.wages >= 20000)
                    {
                        Console.WriteLine($"Id: {emp.Id} ФИО: {emp.fio}, Зарплата: {emp.wages}, Отдел: {emp.department}");
                    }
                }
            }
            void Tasks()
            {
                Console.WriteLine("\n" + "Введите число от 1 до 5 ддля получения информации");
                Console.WriteLine("1. Сотрудник с минимальной ЗП" + "\n" +
                    "2. Сотрудник с максимальной ЗП" + "\n" +
                    "3. Средняя ЗП по отделу" + "\n" +
                    "4. Напечатать всех сотрудников отдела" + "\n" +
                    "5. Проиндексировать зарплату всех сотрудников отдела");
                int tasks = Convert.ToInt32(Console.ReadLine());
                switch (tasks)
                {
                    case 1:
                        double min = 500000;
                        foreach (var emp in employee)
                        {
                            if (emp.wages < min)
                            {
                                min = emp.wages;
                                Console.WriteLine($"Минимальная ЗП: {min} - {emp.fio}");
                            }
                        }
                        break;
                    case 2:
                        double max = 0;
                        foreach (var emp in employee)
                        {
                            if (emp.wages > max)
                            {
                                max = emp.wages;
                            }
                        }
                        Console.WriteLine($"Максимальная ЗП: {max}");
                        break;
                    case 3:
                        Console.WriteLine("Введите номер отдела");
                        int choosedep = Convert.ToInt32(Console.ReadLine());
                        int count = 0;
                        double sum = 0;
                        foreach (var emp in employee)
                        {
                            if (choosedep == emp.department)
                            {
                                count++;
                                sum += emp.wages;
                            }
                        }
                        Console.WriteLine($"Среднее значение ЗП: {sum / count}");
                        break;
                    case 4:
                        Console.WriteLine("Введите номер отдела");
                        int choosedepp = Convert.ToInt32(Console.ReadLine());
                        foreach (var emp in employee)
                        {
                            if (choosedepp == emp.department)
                            {
                                Console.WriteLine($" ФИО:{emp.fio}");
                            }
                        }
                        break;
                    case 5:
                        Console.WriteLine("Введите номер отдела");
                        double index = 1.12;
                        int choosedeppp = Convert.ToInt32(Console.ReadLine());
                        foreach (var emp in employee)
                        {
                            if (choosedeppp == emp.department)
                            {
                                Console.WriteLine($"После индексации ЗП составляет: {index * emp.wages} - {emp.fio}");
                            }  
                        }
                        break;
                }
            }
            Console.ReadKey();
        }
    }
}
