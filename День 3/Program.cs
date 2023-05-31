using System;

namespace ZADANIA
{
    class Program
    {
        




public class Employee
        {
            private static int idCounter = 1;

            private int id;
            public string FullName { get; private set; }
            public int Department { get; set; }
            public decimal Salary { get; set; }

            public Employee(string fullName, int department, decimal salary)
            {
                id = idCounter++;
                FullName = fullName;
                Department = department;
                Salary = salary;
            }

            public int GetId()
            {
                return id;
            }

            public override string ToString()
            {
                return $"ФИО: {FullName}, Отдел: {Department}, Зарплата: {Salary}";
            }
        }

       
        
            private static Employee[] employees = new Employee[10];

            public static void Main()
            {
                // Создаем и инициализируем объекты Employee
                employees[0] = new Employee("Иванов Иван Иванович", 3, 50000);
                employees[1] = new Employee("Петров Петр Петрович", 2, 45000);
                employees[2] = new Employee("Сидорова Анна Сергеевна", 1, 60000);
                // Добавьте остальных сотрудников по аналогии...

                // Получить список всех сотрудников
                PrintAllEmployees();

                // Посчитать сумму затрат на зарплаты в месяц
                decimal totalSalaryExpense = CalculateTotalSalaryExpense();
                Console.WriteLine("Total Salary Expense: " + totalSalaryExpense);

                // Найти сотрудника с минимальной зарплатой
                Employee minSalaryEmployee = FindEmployeeWithMinSalary();
                Console.WriteLine("Employee with Min Salary: " + minSalaryEmployee.ToString());

                // Найти сотрудника с максимальной зарплатой
                Employee maxSalaryEmployee = FindEmployeeWithMaxSalary();
                Console.WriteLine("Employee with Max Salary: " + maxSalaryEmployee.ToString());

                // Подсчитать среднее значение зарплат
                decimal averageSalary = CalculateAverageSalary();
                Console.WriteLine("Average Salary: " + averageSalary);

                // Получить Ф. И. О. всех сотрудников
                PrintAllEmployeeNames();
            }

            public static void PrintAllEmployees()
            {
                foreach (Employee employee in employees)
                {
                    if (employee != null)
                    {
                        Console.WriteLine(employee.ToString());
                    }
                }
            }

            public static decimal CalculateTotalSalaryExpense()
            {
                decimal totalSalaryExpense = 0;
                foreach (Employee employee in employees)
                {
                    if (employee != null)
                    {
                        totalSalaryExpense += employee.Salary;
                    }
                }
                return totalSalaryExpense;
            }

            public static Employee FindEmployeeWithMinSalary()
            {
                Employee minSalaryEmployee = employees[0];
                foreach (Employee employee in employees)
                {
                    if (employee != null && employee.Salary < minSalaryEmployee.Salary)
                    {
                        minSalaryEmployee = employee;
                    }
                }
                return minSalaryEmployee;
            }

            public static Employee FindEmployeeWithMaxSalary()
            {
                Employee maxSalaryEmployee = employees[0];
                foreach (Employee employee in employees)
                {
                    if (employee != null && employee.Salary > maxSalaryEmployee.Salary)
                    {
                        maxSalaryEmployee = employee;
                    }
                }
                return maxSalaryEmployee;
            }

            public static decimal CalculateAverageSalary()
            {
                decimal totalSalary = 0;
                int count = 0;
                foreach (Employee employee in employees)
                {
                    if (employee != null)
                    {
                        totalSalary += employee.Salary;
                        count++;
                    }
                }
                return count > 0 ? totalSalary / count : 0;
            }

            public static void PrintAllEmployeeNames()
            {
                foreach (Employee employee in employees)
                {
                    if (employee != null)
                    {
                        Console.WriteLine(employee.FullName);
                    }
                }
            }

            public override bool Equals(object obj)
            {
                return base.Equals(obj);
            }

            public override int GetHashCode()
            {
                return base.GetHashCode();
            }

            public override string ToString()
            {
                return base.ToString();
            }
        } } 
