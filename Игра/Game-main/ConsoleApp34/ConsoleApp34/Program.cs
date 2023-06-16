namespace ConsoleApp34
{
    class program
    {

        static void Main(string[] args)
        {
            BranchingInTheStory branch = new BranchingInTheStory();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Однажды вы решили расследовать одно дело по пропаже мальчика \nВы решили зайти в полицейский участок и посмотреть ещё несколько дел похожих на это");
            Console.WriteLine("Зайдя в полицейский участок вы были удивлены, что никого нет на своих рабочих местах \nНо посмотрев на календарь, который висел на стене, было понятно, что сегодня воскресенье\n15 июля 2077 года... ");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("Включить новости на телевизоре или нет \n (Y)es or (N)o\n");
            branch.News();

            Console.WriteLine("Приступив к просмотру дел вы практически ничего не понимали о записях и пометках по типу 'КиберПсихоз', но вскоре вы начали впитывать информацию как губку и было понятно, \nчто здесь происходить что-то неладное ");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("Пойти исследовать мир или остаться в офисе\n (Y)es or (N)o\n");
            branch.NewGame();

            branch.Battle();
            branch.NextBattle();

            


        }

      
    }
}