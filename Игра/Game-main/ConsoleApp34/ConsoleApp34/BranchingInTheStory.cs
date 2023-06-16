using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp34
{
    public class BranchingInTheStory
    {
        Hero hero = new Hero(100, 10, 1, 0);
        People people = new People();
        Enemy robosuck = new Enemy(65, 13, 2, 300);
        public void News()
        {
            ConsoleKeyInfo news;
            while (true)
            {
                news = Console.ReadKey();

                if (news.Key == ConsoleKey.Y)
                {
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    Console.WriteLine($" --- You pressed {news.Key}es\n");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("По телевизору показывали какой-то новый город и новых людей, вы были не последней личностью в городе\nи многие знали вас в лицо так же как и вы, но этих людей вы видели первый раз в своей жизни. Все люди были с какими - то протезами, ");
                    Console.WriteLine("на первый взгляд вам показалось, что репортаж был про людей с ограниченными возможностями.");
                    Console.WriteLine("Далее по новостям рассказали, что в городе появился какой-то новый рипер(киберхирург). Сначала вы даже не понимали некоторых слов которые говорили по телевизору\nВскоре новости закончились и вы решили всё таки заняться решением того самого дела");
                    break;
                }
                else if (news.Key == ConsoleKey.N)
                {
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    Console.WriteLine($" --- You pressed {news.Key}o\n");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Вы не захотели тратить своё личное время на просмотр зомбоящика, у вас были дела намного важнее этого");
                    Console.WriteLine("Далее\n");
                    break;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\n Включить новости на телевизоре или нет \n Yes or No");
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                }
            }
        }
        public void NewGame()
        {
            ConsoleKeyInfo newgame;
            while (true)
            {
                newgame = Console.ReadKey();
                if (newgame.Key == ConsoleKey.Y)
                {
                    Console.WriteLine($" --- You pressed {newgame.Key}es\n");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Вы накинули плащ и пошли на поиски рипера для того чтобы узнать что произошло за всё это время");
                    Console.WriteLine("Зайдя в какой-то переулок вы поспрашивали прохожих и смогли найти рипера. Вы зашли в его маленькую квартиру и с большим удивлением слушали о том, \nчто произошло за те 50 лет которые для вас прошли за одну ночь");
                    Console.WriteLine("Рипер предложил вам поставить импланты и протезы, вы согласились, но протянув ему деньги он был шокирован. ТАКАЯ ВАЛЮТА НЕ ИСПОЛЬЗУЕТСЯ С 2063 ГОДА");
                    Console.WriteLine("Все ваши счета и сбережения можно сказать были просто анулированы");
                    Console.WriteLine("Рипер предложил вам заработать маленьким налётом на местных бандитов и у вас не было варианта отказаться");
                    Console.WriteLine("Рипер дал вам новый пистолет и пару обойм");
                    FirstLine();
                    break;


                }
                else if (newgame.Key == ConsoleKey.N)
                {
                    Console.WriteLine($" --- You pressed {newgame.Key}o\n");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Вы так и остались в офисе, не захотев приключений на свою жизнь");
                    Console.WriteLine("Через 30 минут в офис ворвалась банда 'Рыжих котов' и разнесли всё что там было, вы пытались от них отбиться, но к сожалению против роботов у вас не было никаких шансов");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("МЁРТВ");    //доработать разветление событий и ветку сюжета
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    Console.WriteLine("\nПойти исследовать мир или остаться в офисе\n Yes or No");
                }
            }
        }

        public void FirstLine()
        {
            Console.WriteLine("После того как рипер рассказал вам дальнейшие действия вы отправились в путь");
            Console.WriteLine("Дойдя до квартиры где бандиты хранили краденные протезы у вас в голове было два варианта как им противостоять");
            Console.WriteLine("Первый и вполне разумный вариант был бы действовать тихо, но и в тот же момент вы хотели разнести их всех в щепки");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("\nВыбрать тихий или громкий вариант\n (S)ilent or (R)ush\n");
            ConsoleKeyInfo firstline;
            while (true)
            {



                firstline = Console.ReadKey();
                if (firstline.Key == ConsoleKey.S)
                {
                    Console.WriteLine($" --- You pressed {firstline.Key}ilent\n");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Немного подумав вы решили, что всё таки надо действовать скрытно и не идти в открытую, так как неизвестно насколько они сильны");
                    Console.WriteLine("Вы скрытно входите в квартиру и аккуратно подходите к первому противнику, он стоял спиной к вам и это был самый лучший шанс для его быстрого обезвреживания");
                    Console.WriteLine("Тихо подойдя со спины к противнику вы быстро его обезвредили и оттащили в тёмное место, чтобы друзья не заметили его пропажи");
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                    hero.Experience += 100;
                    LvlUp();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("К сожалению это был самый общительный человек в компании и враги сразу поняли, что здесь что-то не так");
                    Console.WriteLine("Вам пришлось достать пистолет и стрелять на поражение, ведь сейчас на кону стоит ваша жизнь");
                    break;
                }
                else if (firstline.Key == ConsoleKey.R)
                {
                    Console.WriteLine($" --- You pressed {firstline.Key}ush\n");
                    break;
                }
                else
                {

                }
            }


        }

        public void Battle()
        {
            Random headshotrnd = new Random();
            Random bodyshotrnd = new Random();
            while (true)
            {
                while (people.Health > 0 && hero.Health > 0)
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("Вы решили выстрелить в");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("1 - Выстрел в голову шанс попасть 25%");
                    Console.WriteLine("2 - Выстрел в тело шанс попасть 75%");
                    int shot = int.Parse(Console.ReadLine());

                    if (shot == 1)
                    {
                        int hsrnd = headshotrnd.Next(0, 4);
                        Console.WriteLine(hsrnd);
                        if (hsrnd <= 0)
                        {
                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                            Console.WriteLine("Вы попали в голову!");
                            people.Health -= hero.Damage * 2;

                        }
                        else if (hsrnd >= 1)
                        {
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("Вы промахнулись");
                            hero.Health -= people.Damage;
                        }
                        Console.WriteLine($"У вас {hero.Health} HP, враг {people.Health} HP");
                    }
                    else if (shot == 2)
                    {
                        int bdrnd = bodyshotrnd.Next(0, 4);
                        if (bdrnd <= 2)
                        {
                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                            Console.WriteLine("Вы попали в тело!");
                            people.Health -= hero.Damage;

                        }
                        else if (bdrnd == 3)
                        {
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("Вы промахнулись");
                            hero.Health -= people.Damage;
                        }
                        Console.WriteLine($"У вас {hero.Health} HP, враг {people.Health} HP \n");

                    }

                }

                if (hero.Health <= 0)
                {

                    Console.WriteLine("Вы проиграли, хотите перезапустить бой?");

                    string userInput = Console.ReadLine();

                    if (userInput == "y")
                    {
                        Console.WriteLine("Бой был перезапущен");
                        hero.Health = 110;
                        people.Health = 50;
                        continue;
                    }
                    else if (userInput == "n")
                    {
                        Console.WriteLine("бой окончен");

                        Environment.Exit(0);
                    }
                    else
                    {
                        Console.WriteLine("Вы ввели некорректное значение");
                        Console.WriteLine("вы хотите вернуться к выбору? (y/n)");
                        string c = (Console.ReadLine());
                        if (c == "y")
                        {
                            Console.Clear();
                            continue;
                        }
                        else
                        {
                            Environment.Exit(0);

                        }
                    }
                }
                else if (people.Health <= 0)
                {
                    hero.Health = 110;
                    hero.Experience = people.Experience;
                    if (hero.Experience == expvalue)
                    {
                        LvlUp();
                    }
                    Console.WriteLine("Итоги битвы:");
                    Console.WriteLine("Здоровье оставшееся у Игрока: " + hero.Health);
                    Console.WriteLine("Здоровье оставшееся у Бандита: " + people.Health);
                    Console.WriteLine("\n\nПосле убийства первого врага вы сразу поняли, что они будут покрепче тех людей, которых вы устраняли в 2027.");
                    Console.WriteLine("Но это были ещё цветочки, вы увидели какого-то непонятного парня, который стоял и почти весь был в протезах");
                    Console.WriteLine("Вы решили надееться на пистолет который вам дал рипер и это было верным решением, ведь технологии выросли\nна столько, что пистолетам того времени не хватало огневой мощи для пробития таких протезов");
                    Console.WriteLine("Он резко повернулся на вас и начал вести огонь, но вы тоже не из робкого десятка, быстро прыгнув за стену у вас началась ещё одна перестрелка");
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("Нажмите ЛЮБУЮ КНОПКУ");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.ReadKey();
                    break;
                }


            }


        }
        int expvalue = 100;
        public void LvlUp()
        {

            if (hero.Experience == expvalue)
            {
                hero.Experience = 0;
                hero.Level += 1;
                hero.Damage += 5;
                hero.Health += 10;
                expvalue *= 2;
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine($"Вам нужно набрать - {expvalue} XP для следующего уровня");
                Console.WriteLine($"Вы повысили уровень. Теперь ваш уровень {hero.Level}, урон {hero.Damage}, хп {hero.Health}, опыт {hero.Experience}");
                Console.ForegroundColor = ConsoleColor.Green;
            }

        }
        public void NextBattle()
        {
            Random headshotrnd = new Random();
            Random bodyshotrnd = new Random();
            while (true)
            {
                while (robosuck.Health > 0 && hero.Health > 0)
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("Вы решили выстрелить в");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("1 - Выстрел в голову шанс попасть 25%");
                    Console.WriteLine("2 - Выстрел в тело шанс попасть 75%");
                    int shot = int.Parse(Console.ReadLine());

                    if (shot == 1)
                    {
                        int hsrnd = headshotrnd.Next(0, 4);
                        Console.WriteLine(hsrnd);
                        if (hsrnd <= 0)
                        {
                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                            Console.WriteLine("Вы попали в голову!");
                            robosuck.Health -= hero.Damage * 2;

                        }
                        else if (hsrnd >= 1)
                        {
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("Вы промахнулись");
                            hero.Health -= robosuck.Damage;
                        }
                        Console.WriteLine($"У вас {hero.Health} HP, враг {robosuck.Health} HP");
                    }
                    else if (shot == 2)
                    {
                        int bdrnd = bodyshotrnd.Next(0, 4);
                        if (bdrnd <= 2)
                        {
                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                            Console.WriteLine("Вы попали в тело!");
                            robosuck.Health -= hero.Damage;

                        }
                        else if (bdrnd == 3)
                        {
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("Вы промахнулись");
                            hero.Health -= robosuck.Damage;
                        }
                        Console.WriteLine($"У вас {hero.Health} HP, враг {robosuck.Health} HP \n");

                    }

                }

                if (hero.Health <= 0)
                {

                    Console.WriteLine("Вы проиграли, хотите перезапустить бой?");

                    string userInput = Console.ReadLine();

                    if (userInput == "y")
                    {
                        Console.WriteLine("Бой был перезапущен");
                        hero.Health = 120;
                        robosuck.Health = 65;
                        continue;
                    }
                    else if (userInput == "n")
                    {
                        Console.WriteLine("бой окончен");

                        Environment.Exit(0);
                    }
                    else
                    {
                        Console.WriteLine("Вы ввели некорректное значение");
                        Console.WriteLine("вы хотите вернуться к выбору? (y/n)");
                        string c = (Console.ReadLine());
                        if (c == "y")
                        {
                            Console.Clear();
                            continue;
                        }
                        else
                        {
                            Environment.Exit(0);

                        }
                    }
                }
                else if (robosuck.Health <= 0)
                {
                    hero.Health = 120;
                    hero.Experience = robosuck.Experience;
                    if (hero.Experience == expvalue)
                    {
                        LvlUp();
                    }
                    Console.WriteLine("Итоги битвы:");
                    Console.WriteLine("Здоровье оставшееся у Игрока: " + hero.Health);
                    Console.WriteLine("\n\nЗдоровье оставшееся у Бандита: " + robosuck.Health);
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine($"{hero.Experience} / {expvalue}XP");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("чтобы продолжить нажмите любую кнопку");
                    Console.ReadKey();
                    break;
                }


            }
        }
    }
}