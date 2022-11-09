using System;

namespace Ezednevnik
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stranitsa();
        }
        static void Stranitsa()
        {
            int stranitsa = 0;
            int arrowPosition = 1;

            Stranitsa stranitsa1 = new Stranitsa()
            {
                data = new DateTime(2022, 10, 19),
                St = new string[] { "Обед, уютненько", "Сделать план по БЖД", "--------------------", "Чтобы выйти из описания заметки нажмите на верхнюю или нижнюю стрелку. Переключать ежедненик можно при помощи стрелок", "Чтобы выйти из ежедневника нажмите на esc" }
            };
            Stranitsa stranitsa2 = new Stranitsa()
            {
                data = new DateTime(2022, 10, 20),
                St = new string[] { "Сделать практическую по C#", "Посмотреть турнир", "Лечь спать пораньше", "--------------------" }
            };
            Stranitsa stranitsa3 = new Stranitsa()
            {
                data = new DateTime(2022, 10, 21),
                St = new string[] { "Погулять с собачками", "Матеша", "Завтрашний тест", "--------------------" }
            };
            Stranitsa stranitsa4 = new Stranitsa()
            {
                data = new DateTime(2022, 10, 22),
                St = new string[] {"Сделать 'Тортики' ", "Приготовить обед", "Помыть машину", "--------------------" }
            };

            Console.SetCursorPosition(0, arrowPosition);
            Cursor(stranitsa1);

            while (true)
            {
                ConsoleKeyInfo key = Console.ReadKey();

                switch (key.Key)
                {
                    case ConsoleKey.RightArrow:
                        arrowPosition = 1;

                        if (stranitsa == 0)
                        {
                            Console.Clear();
                            Console.SetCursorPosition(0, arrowPosition);
                            Cursor(stranitsa2);
                            stranitsa++;
                        }
                        else if (stranitsa == 1)
                        {
                            Console.Clear();
                            Console.SetCursorPosition(0, arrowPosition);
                            Cursor(stranitsa3);
                            stranitsa++;
                        }
                        else if (stranitsa == 2)
                        {
                            Console.Clear();
                            Console.SetCursorPosition(0, arrowPosition);
                            Cursor(stranitsa4);
                            stranitsa++;
                        }
                        break;
                    case ConsoleKey.LeftArrow:
                        arrowPosition = 1;
                        if (stranitsa == 3)
                        {
                            Console.Clear();
                            Console.SetCursorPosition(0, arrowPosition);
                            Cursor (stranitsa3);
                            stranitsa--;
                        }

                        else if (stranitsa == 2)
                        {
                            Console.Clear();
                            Console.SetCursorPosition(0, arrowPosition);
                            Cursor(stranitsa2);
                            stranitsa--;
                        }
                        else if (stranitsa == 1)
                        {
                            Console.Clear();
                            Console.SetCursorPosition(0, arrowPosition);
                            Cursor(stranitsa1);
                            stranitsa--;
                        }
                        break;

                    case ConsoleKey.DownArrow:
                        if (key.Key == ConsoleKey.DownArrow && stranitsa == 0)
                        {
                            arrowPosition++;
                            if (arrowPosition > 4)
                            {
                                arrowPosition--;
                            }
                            Console.Clear();
                            Console.SetCursorPosition(0, arrowPosition);
                            Cursor(stranitsa1);
                        }
                        else if (key.Key == ConsoleKey.DownArrow && stranitsa == 1)
                        {
                            arrowPosition++;
                            if (arrowPosition > 5)
                            {
                                arrowPosition--;
                            }
                            Console.Clear();
                            Console.SetCursorPosition(0, arrowPosition);
                            Cursor(stranitsa2);
                        }
                        else if (key.Key == ConsoleKey.DownArrow && stranitsa == 2)
                        {
                            arrowPosition++;
                            if (arrowPosition > 4)
                            {
                                arrowPosition--;
                            }
                            Console.Clear();
                            Console.SetCursorPosition(0, arrowPosition);
                            Cursor(stranitsa3);
                        }
                        else if (key.Key == ConsoleKey.DownArrow && stranitsa == 3)
                        {
                            arrowPosition++;
                            if (arrowPosition > 4)
                            {
                                arrowPosition--;
                            }
                            Console.Clear();
                            Console.SetCursorPosition(0, arrowPosition);
                            Cursor (stranitsa4);
                        }
                        break;
                    
                    case ConsoleKey.UpArrow:
                        if (key.Key == ConsoleKey.UpArrow && stranitsa == 0)
                        {
                            arrowPosition--;
                            if (arrowPosition < 1)
                            {
                                arrowPosition++;
                            }
                            Console.Clear();
                            Console.SetCursorPosition(0, arrowPosition);
                            Cursor(stranitsa1);
                        }
                        else if (key.Key == ConsoleKey.UpArrow && stranitsa == 1)
                        {
                            arrowPosition--;
                            if (arrowPosition < 1)
                            {
                                arrowPosition++;
                            }
                            Console.Clear();
                            Console.SetCursorPosition(0, arrowPosition);
                            Cursor(stranitsa2);
                        }
                        else if (key.Key == ConsoleKey.UpArrow && stranitsa == 2)
                        {
                            arrowPosition--;
                            if (arrowPosition < 1)
                            {
                                arrowPosition++;
                            }
                            Console.Clear();
                            Console.SetCursorPosition(0, arrowPosition);
                            Cursor(stranitsa3);
                        }
                        else if (key.Key == ConsoleKey.UpArrow && stranitsa == 3)
                        {
                            arrowPosition--;
                            if (arrowPosition < 1)
                            {
                                arrowPosition++;
                            }
                            Console.Clear();
                            Console.SetCursorPosition (0, arrowPosition);
                            Cursor (stranitsa4);
                        }
                        break;
                    case ConsoleKey.Enter:
                        switch (stranitsa)
                        {
                            case 0:
                                if (arrowPosition == 2)
                                {
                                    Console.Clear();
                                    Console.WriteLine("Обед, уютненько");
                                    Console.WriteLine($"Выбрана дата: {stranitsa1.data}");
                                    Console.WriteLine("------------Описание ежедневника-------------");
                                    Console.WriteLine("Налить чай и сделать бутерброды с колбасой.");
                                    Console.WriteLine("Открыть пачку печенья");
                                }
                                else if (arrowPosition == 3)
                                {
                                    Console.Clear();
                                    Console.WriteLine("Сделать план по БЖД");
                                    Console.WriteLine($"Выбрана дата: {stranitsa1.data}");
                                    Console.WriteLine("------------Описание ежедневника-------------");
                                    Console.WriteLine("План эвакуации по БЖД сам себя не сделает!");
                                }
                                break;
                            case 1:
                                if (arrowPosition == 2)
                                {
                                    Console.Clear();
                                    Console.WriteLine("Сделать практическую по C#");
                                    Console.WriteLine($"Выбрана дата: {stranitsa2.data}");
                                    Console.WriteLine("------------Описание ежедневника-------------");
                                    Console.WriteLine("Доделать уже наконец-то ежедневник...");
                                }
                                else if (arrowPosition == 3)
                                {
                                    Console.Clear();
                                    Console.WriteLine("Посмотреть турнир");
                                    Console.WriteLine($"Выбрана дата: {stranitsa2.data}");
                                    Console.WriteLine("------------Описание ежедневника-------------");
                                    Console.WriteLine("Найти какой-нибудь турнир по игре и посмотреть его.");
                                }
                                else if (arrowPosition == 4)
                                {
                                    Console.Clear();
                                    Console.WriteLine("Лечь спать пораньше");
                                    Console.WriteLine($"Выбрана дата: {stranitsa2.data}");
                                    Console.WriteLine("------------описание ежедненика-------------");
                                    Console.WriteLine("Завтра рано вставать, поэтому необходимо лечь до 22:00");
                                }
                                break;
                            case 2:
                                if (arrowPosition == 2)
                                {
                                    Console.Clear();
                                    Console.WriteLine("Погулять с собачками");
                                    Console.WriteLine($"Выбарана дата: {stranitsa3.data}");
                                    Console.WriteLine("------------Описание ежедневника-------------");
                                    Console.WriteLine("Нужно сходить погулять с собачками в 16:00");
                                }
                                else if (arrowPosition == 3)
                                {
                                    Console.Clear();
                                    Console.WriteLine("Матеша");
                                    Console.WriteLine($"Выбрана дата: {stranitsa3.data}");
                                    Console.WriteLine("------------Описание ежедневника-------------");
                                    Console.WriteLine("Сделать дз по высшей математике и отправсить в Classroom");
                                }
                                else if (arrowPosition == 4) 
                                {
                                    Console.Clear();
                                    Console.WriteLine("Тест по БЖД");
                                    Console.WriteLine($"Выбрана дата: {stranitsa3.data}");
                                    Console.WriteLine("------------Описание ежедневника-------------");
                                    Console.WriteLine("Нужно подготовиться к тесту по БЖД");
                                
                                }
                                break;
                            case 3:
                                if (arrowPosition == 2)
                                {
                                    Console.Clear();
                                    Console.WriteLine("Тортики");
                                    Console.WriteLine($"Выбарана дата: {stranitsa4.data}");
                                    Console.WriteLine("------------Описание ежедневника-------------");
                                    Console.WriteLine("Срок сдачи до 9 ноября!!!");
                                }
                                else if (arrowPosition == 3)
                                {
                                    Console.Clear();
                                    Console.WriteLine("Приготовить обед");
                                    Console.WriteLine($"Выбрана дата: {stranitsa3.data}");
                                    Console.WriteLine("------------Описание ежедневника-------------");
                                    Console.WriteLine("Приготовить себе пельмени или не заморачиваться, и пойти в мак.");
                                }
                                else if (arrowPosition == 4)
                                {
                                    Console.Clear();
                                    Console.WriteLine("Помыть машину");
                                    Console.WriteLine($"Выбрана дата: {stranitsa3.data}");
                                    Console.WriteLine("------------Описание ежедневника-------------");
                                    Console.WriteLine("Надо помыть, а то дадут по башке... :(");

                                }
                                break;
                        }
                        break;
                    case ConsoleKey.Escape:
                        Environment.Exit(0);
                        break;
                }
            }
        }
        static void Cursor(Stranitsa currentPage)
        {
            Console.WriteLine("=>");
            Console.SetCursorPosition(3, 0);
            Console.WriteLine(currentPage.data);
            Console.CursorVisible = false;

            int i = 1;
            foreach (string n in currentPage.St)
            {
                i++;
                Console.SetCursorPosition(3, i);
                Console.WriteLine(n);
            }
        }
    }
}
