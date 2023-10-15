using System;

static void menu()
{

    Console.WriteLine("  14.10.2023");
    Console.WriteLine("  1.Сходить в Логово Нелтариона");
    Console.WriteLine("  2.Поделать че-нить по дому");


}
static void vtoroe_menu()
{

    Console.WriteLine("  15.10.2023");
    Console.WriteLine("  1.Поделать че-нить");
    Console.WriteLine("  2.Заняться делом");
}
static void tretie_menu()
{
    Console.WriteLine("  16.10.2023");
    Console.WriteLine("  1.Сходить на пары");
    Console.WriteLine("  2.Купить че-нить вкусного");
    Console.WriteLine("  3.Аберий.Затененное Горнило");
}


static void cicl()
{

    ConsoleKeyInfo key;
    do
    {



        menu();
        int positon = 2;



        key = Console.ReadKey();
        if (key.Key == ConsoleKey.RightArrow)
        {
            Console.Clear();
            cicl_dva();

        }


        else if (key.Key == ConsoleKey.LeftArrow)
        {

            Console.Clear();
            cicl_tri();

        }










        while (key.Key != ConsoleKey.Enter)
        {
            Console.SetCursorPosition(0, positon);
            Console.WriteLine("  ");
            if (key.Key == ConsoleKey.UpArrow)
            {
                positon--;
            }
            else if (key.Key == ConsoleKey.DownArrow)
            {
                positon++;
            }

            Console.SetCursorPosition(0, positon);
            Console.WriteLine("=>");
            key = Console.ReadKey();
        }
        if (positon == 1)
        {
            Console.Clear();
            Console.WriteLine("Сходитть в Логово Нелтариона");
            Console.WriteLine("-------------------------------");
            Console.WriteLine("Описание: Ретри паладин никому ненужен даже не смотря на то что у него 2900 рио 444 шмот но попытатся стоит");
            Console.WriteLine("Дата: 14.10.2023 12:00");
            key = Console.ReadKey();
            if (key.Key == ConsoleKey.Enter)
            {
                Console.Clear();
            }

        }
        else if (positon == 2)
        {
            Console.Clear();
            Console.WriteLine("Поделать че-нить по дому");
            Console.WriteLine("--------------------------");
            Console.WriteLine("Описание: Пропылесосить, загрузить посуду в посудомоичною машину, разгрузить посудомоичную машину, вытереть пыль");
            Console.WriteLine("Дата: 14.10.2023 13:30");
            key = Console.ReadKey();
            if (key.Key == ConsoleKey.Enter)
            {
                Console.Clear();
            }
        }

    } while (key.Key != ConsoleKey.Tab);
    Console.ReadKey();
}
static void cicl_dva()
{

    ConsoleKeyInfo key;
    do
    {



        vtoroe_menu();
        int positon = 2;
        key = Console.ReadKey();

        if (key.Key == ConsoleKey.LeftArrow)
        {
            Console.Clear();
            cicl();

        }
        else if (key.Key == ConsoleKey.RightArrow)
        {
            Console.Clear();
            cicl_tri();
        }








        while (key.Key != ConsoleKey.Enter)
        {
            Console.SetCursorPosition(0, positon);
            Console.WriteLine("  ");
            if (key.Key == ConsoleKey.UpArrow)
            {
                positon--;
            }
            else if (key.Key == ConsoleKey.DownArrow)
            {
                positon++;
            }

            Console.SetCursorPosition(0, positon);
            Console.WriteLine("=>");
            key = Console.ReadKey();
        }
        if (positon == 1)
        {

            Console.Clear();
            Console.WriteLine("Поделать че-нить");
            Console.WriteLine("-------------------------------");
            Console.WriteLine("Описание: Поиграй во че-нить там вов или ск2 или ваху");
            Console.WriteLine("Дата: 15.10.2023 11:00");
            key = Console.ReadKey();
            if (key.Key == ConsoleKey.Enter)
            {
                Console.Clear();
            }

        }
        else if (positon == 2)
        {
            Console.Clear();
            Console.WriteLine("Поделать че-нить");
            Console.WriteLine("--------------------------");
            Console.WriteLine("Описание: Там куча практических на неделю задали, их бы сделать");
            Console.WriteLine("Дата: 15.10.2023 13:30");
            key = Console.ReadKey();
            if (key.Key == ConsoleKey.Enter)
            {
                Console.Clear();
            }
        }

    } while (key.Key != ConsoleKey.Tab);
    Console.ReadKey();
}
static void cicl_tri()
{
    ConsoleKeyInfo key;
    do
    {



        tretie_menu();
        int positon = 2;

        do
        {
            key = Console.ReadKey();
            if (key.Key == ConsoleKey.RightArrow)
            {
                Console.Clear();
                cicl();

            }


            else if (key.Key == ConsoleKey.LeftArrow)
            {
                Console.Clear();
                cicl_dva();


            }
        } while (key.Key == ConsoleKey.F1);









        while (key.Key != ConsoleKey.Enter)
        {
            Console.SetCursorPosition(0, positon);
            Console.WriteLine("  ");
            if (key.Key == ConsoleKey.UpArrow)
            {
                positon--;
            }
            else if (key.Key == ConsoleKey.DownArrow)
            {
                positon++;
            }

            Console.SetCursorPosition(0, positon);
            Console.WriteLine("=>");
            key = Console.ReadKey();
        }
        if (positon == 1)
        {
            Console.Clear();
            Console.WriteLine("Сходить на пары");
            Console.WriteLine("-------------------------------");
            Console.WriteLine("Описание: Основы алгоритмизации и программирования и Информационные технологии на 3 и 4 пары");
            Console.WriteLine("Дата: 16.10.2023 6:00");
            key = Console.ReadKey();
            if (key.Key == ConsoleKey.Enter)
            {
                Console.Clear();
            }

        }
        else if (positon == 2)
        {
            Console.Clear();
            Console.WriteLine("Купить че-нить вкусного");
            Console.WriteLine("--------------------------");
            Console.WriteLine("Описание: Купить батончики Марс на обратном пути ");
            Console.WriteLine("Дата: 16.10.2023 16:00");
            key = Console.ReadKey();
            if (key.Key == ConsoleKey.Enter)
            {
                Console.Clear();
            }
        }
        else if (positon == 3)
        {
            Console.Clear();
            Console.WriteLine("Аберий.Затененное Горнило");
            Console.WriteLine("--------------------------");
            Console.WriteLine("Описание: 21:00 сбор на рейд.Купить фласки, руны, еды. Не забудь поменять билд  ");
            Console.WriteLine("Дата: 14.10.2023 21:00");
            key = Console.ReadKey();
            if (key.Key == ConsoleKey.Enter)
            {
                Console.Clear();
            }
        }

    } while (key.Key != ConsoleKey.Tab);
    Console.ReadKey();
}

cicl();