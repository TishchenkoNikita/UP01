//задание 1
Console.WriteLine("Задание №1");
Console.WriteLine("Введите число: ");
int chislo = Convert.ToInt32(Console.ReadLine());
if (chislo > 0)
{
    Console.WriteLine("Ответ: " + (chislo+5));
}
else if (chislo < 0)
{
    Console.WriteLine("Ответ" + (chislo-5));
}
else
{
    Console.WriteLine("Ошибка");
}
Console.ReadKey();



//задание 2
Console.WriteLine("Задание №2");
Console.WriteLine("Введите первое число: ");
int chislo1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int chislo2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число: ");
int chislo3 = Convert.ToInt32(Console.ReadLine());
if ((chislo1 > chislo2) && (chislo1 > chislo3)) {
    Console.WriteLine("Ответ: " + chislo1);
}
else if ((chislo2 > chislo1) && (chislo2 > chislo3))
{
    Console.WriteLine("Ответ: " + chislo2);
}
else { Console.WriteLine("Ответ: " + chislo3); }
Console.ReadKey();


//задание 3
Console.WriteLine("Задание №3");
int res = 0;
Console.WriteLine("Введите первое число: ");
int chislo_1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int chislo_2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число: ");
int chislo_3 = Convert.ToInt32(Console.ReadLine());
if (chislo_1 > 0)
{
    res += chislo_1;
}
if (chislo_2 > 0)
{
    res += chislo_2;
}
if (chislo_3 > 0)
{
    res += chislo_3;
}
Console.WriteLine("Ответ: " + res);
Console.ReadKey();



//задание 4
Console.WriteLine("Задание №4");
Console.WriteLine("Введите х: ");
double chislo_x = Convert.ToDouble(Console.ReadLine());
if (chislo_x > 10)
{
    Console.WriteLine("Ответ: " + chislo_x * 2);
}
else { Console.WriteLine("Ответ: " + chislo_x); }
Console.ReadKey();



//задание 5
Console.WriteLine("Задание №5");
Console.WriteLine("Введите число: ");
int den = Convert.ToInt32(Console.ReadLine());
switch (den)
{
    case 1:
        Console.WriteLine("Понедельник");
        break;
    case 2:
        Console.WriteLine("Вторник");
        break;
    case 3:
        Console.WriteLine("Среда");
        break;
    case 4:
        Console.WriteLine("Четверг");
        break;
    case 5:
        Console.WriteLine("Пятница");
        break;
    case 6:
        Console.WriteLine("Суббота");
        break;
    case 7:
        Console.WriteLine("Воскресенье");
        break;
}
Console.ReadKey();


//задание 6 
Console.WriteLine("Задание №6");
for (int chislo_min = 200; chislo_min < 500; chislo_min++)
{
    if (chislo_min % 17==0)
    {
        Console.WriteLine("Ответ: "+ chislo_min);
        break;
    }
}
Console.ReadKey();



//задание 7
Console.WriteLine("Задание №7");
double  km= 10;
double summakm=km;
int day = 1;
while (km < 20)
{
    km += km * 0.05;
    day++;
}
Console.WriteLine($"В {day} день человек пройдет {km} км");

km = 10;
day = 1;
while (summakm < 100)
{
    km += km * 0.05;
    summakm += km;
    day++;
}
Console.WriteLine($"За {day} дней человек пройдет 100км ");
Console.ReadKey();




//задание 8
Console.WriteLine("Задание №8");
Console.WriteLine("Введите число факториала: ");
int chislo_factoriala = Convert.ToInt32(Console.ReadLine());
int g = 1;
for (int o = 1; chislo_factoriala >= o; o++)
{
    g*=o;
}
Console.WriteLine("Ответ: " + g);
Console.ReadKey();


//задание 9
Console.WriteLine("Задание №9");
Console.WriteLine("Введите натуральное число: ");
int chislo_natur = Convert.ToInt32(Console.ReadLine());
for (int j = 2; chislo_natur >= j; j++)
{
    if (chislo_natur % j==0)
    {
        Console.WriteLine("Ответ: " + j);
        break;
    }
}
Console.ReadKey(); 