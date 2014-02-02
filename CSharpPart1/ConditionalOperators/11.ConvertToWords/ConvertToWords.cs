using System;

namespace _11.ConvertToWords
{
    class ConvertToWords
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            int tens = (number % 100) / 10;
            int hundreds = number / 100;
            int digits = number % 10;
            //разделяме задачата на 3 основни части. Числа < 20, [20 - 99], [100 - 999]. Като със switch конструкции разпределяме логиката кое число да изпише на конзолата

            if (number < 20)
            {
                switch (number)
                {
                    case 0: Console.WriteLine("0 -> Нула");
                        break;
                    case 1: Console.WriteLine("1 -> Едно");
                        break;
                    case 2: Console.WriteLine("2 -> Две");
                        break;
                    case 3: Console.WriteLine("3 -> Три");
                        break;
                    case 4: Console.WriteLine("4 -> Четири");
                        break;
                    case 5: Console.WriteLine("5 -> Пет");
                        break;
                    case 6: Console.WriteLine("6 -> Шест");
                        break;
                    case 7: Console.WriteLine("7 -> Седем");
                        break;
                    case 8: Console.WriteLine("8 -> Осем");
                        break;
                    case 9: Console.WriteLine("9 -> Девет");
                        break;
                    case 10: Console.WriteLine("10 -> Десет");
                        break;
                    case 11: Console.WriteLine("11 -> Единадесет");
                        break;
                    case 12: Console.WriteLine("12 -> Дванадесет");
                        break;
                    case 13: Console.WriteLine("13 -> Тринадесет");
                        break;
                    case 14: Console.WriteLine("14 -> Четиринадесет");
                        break;
                    case 15: Console.WriteLine("15 -> Петнадесет");
                        break;
                    case 16: Console.WriteLine("16 -> Шестнадесет");
                        break;
                    case 17: Console.WriteLine("17 -> Седемнадесет");
                        break;
                    case 18: Console.WriteLine("18 -> Осемнадесет");
                        break;
                    case 19: Console.WriteLine("19 -> Деветнадесет");
                        break;
                }
            }

            if (number > 19 && number < 100)
            {
                switch (tens)
                {
                    case 2: Console.Write("Двадесет");
                        break;
                    case 3: Console.Write("Тридесет");
                        break;
                    case 4: Console.Write("Четиридесет");
                        break;
                    case 5: Console.Write("Петдесет");
                        break;
                    case 6: Console.Write("Шестдесет");
                        break;
                    case 7: Console.Write("Седемдесет");
                        break;
                    case 8: Console.Write("Осемдесет");
                        break;
                    case 9: Console.Write("Деветдесет");
                        break;
                }

                switch (digits)
                {
                    case 0: Console.WriteLine(" ");
                        break;
                    case 1: Console.WriteLine(" и Едно");
                        break;
                    case 2: Console.WriteLine(" и Две");
                        break;
                    case 3: Console.WriteLine(" и Три");
                        break;
                    case 4: Console.WriteLine(" и Четири");
                        break;
                    case 5: Console.WriteLine(" и Пет");
                        break;
                    case 6: Console.WriteLine(" и Шест");
                        break;
                    case 7: Console.WriteLine(" и Седем");
                        break;
                    case 8: Console.WriteLine(" и Осем");
                        break;
                    case 9: Console.WriteLine(" и Девет");
                        break;
                }
            }

            if (number > 99 && number < 1000)
            {
                switch (hundreds)
                {
                    case 0: Console.Write(" ");
                        break;
                    case 1: Console.Write("Сто");
                        break;
                    case 2: Console.Write("Двеста");
                        break;
                    case 3: Console.Write("Триста");
                        break;
                    case 4: Console.Write("Четиристотин");
                        break;
                    case 5: Console.Write("Петстотин");
                        break;
                    case 6: Console.Write("Шестстотин");
                        break;
                    case 7: Console.Write("Седемстотин");
                        break;
                    case 8: Console.Write("Осемстотин");
                        break;
                    case 9: Console.Write("Деветстотин");
                        break;
                }

                if (tens == 0)
                {
                    switch (digits)
                    {
                        case 0: Console.WriteLine(" ");
                            break;
                        case 1: Console.WriteLine(" и Едно");
                            break;
                        case 2: Console.WriteLine(" и Две");
                            break;
                        case 3: Console.WriteLine(" и Три");
                            break;
                        case 4: Console.WriteLine(" и Четири");
                            break;
                        case 5: Console.WriteLine(" и Пет");
                            break;
                        case 6: Console.WriteLine(" и Шест");
                            break;
                        case 7: Console.WriteLine(" и Седем");
                            break;
                        case 8: Console.WriteLine(" и Осем");
                            break;
                        case 9: Console.WriteLine(" и Девет");
                            break;
                    }
                }

                if (tens != 0)
                {
                    if (tens == 1)
                    {
                        switch (digits)
                        {
                            case 0: Console.WriteLine(" и Десет");
                                break;
                            case 1: Console.WriteLine(" и Единадесет");
                                break;
                            case 2: Console.WriteLine(" и Дванадесет");
                                break;
                            case 3: Console.WriteLine(" и Тринадесет");
                                break;
                            case 4: Console.WriteLine(" и Четиринадесет");
                                break;
                            case 5: Console.WriteLine(" и Петнадесет");
                                break;
                            case 6: Console.WriteLine(" и Шестнадесет");
                                break;
                            case 7: Console.WriteLine(" и Седемнадесет");
                                break;
                            case 8: Console.WriteLine(" и Осемнадесет");
                                break;
                            case 9: Console.WriteLine(" и Деветнадесет");
                                break;
                        }
                    }
                    else
                    {
                        switch (tens)
                        {
                            case 1: Console.Write(" и Десет");
                                break;
                            case 2: Console.Write(" и Двадесет");
                                break;
                            case 3: Console.Write(" и Тридесет");
                                break;
                            case 4: Console.Write(" и Четиридесет");
                                break;
                            case 5: Console.Write(" и Петдесет");
                                break;
                            case 6: Console.Write(" и Шестдесет");
                                break;
                            case 7: Console.Write(" и Седемдесет");
                                break;
                            case 8: Console.Write(" и Осемдесет");
                                break;
                            case 9: Console.Write(" и Деветдесет");
                                break;
                        }

                        switch (digits)
                        {
                            case 0: Console.WriteLine(" ");
                                break;
                            case 1: Console.WriteLine(" и Едно");
                                break;
                            case 2: Console.WriteLine(" и Две");
                                break;
                            case 3: Console.WriteLine(" и Три");
                                break;
                            case 4: Console.WriteLine(" и Четири");
                                break;
                            case 5: Console.WriteLine(" и Пет");
                                break;
                            case 6: Console.WriteLine(" и Шест");
                                break;
                            case 7: Console.WriteLine(" и Седем");
                                break;
                            case 8: Console.WriteLine(" и Осем");
                                break;
                            case 9: Console.WriteLine(" и Девет");
                                break;
                        }
                    }

                }
            }
        }
    }
}
