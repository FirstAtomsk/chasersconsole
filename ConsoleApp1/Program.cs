using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {


        static void Main(string[] args)
        {

            ID alex = new ID("Брайер Алексей", 60, "Обнинск", "Alex", "12345");           /*это у меня такая "БД"*/
            ID ilya = new ID("Ситников Илья", 70, "Москва", "BigRichDick", "12345");

            List<ID> idList = new List<ID>();           /*заливаю БД в массив*/
            idList.Add(alex);
            idList.Add(ilya);

            Console.WriteLine("Введите свой логин");            /*проверяю логин по массиву*/
            string loginow = Console.ReadLine();

            int token = 1;          /*это я так чекаю прохождение массива без совпадений - связка a1 */

            ID usernow = new ID("0", 0, "0", "0", "0");

            foreach (ID i in idList)            /*собственно, аутентификация, шарю массив*/
            {
                if (i.login == loginow)
                {
                    Console.WriteLine("Логин принят, введите пароль");
                passcheck:
                    string passnow = Console.ReadLine();
                    if (i.pass == passnow)
                    {
                        Console.WriteLine("Аутентификация успешна.");
                        token = 0;
                        usernow = i;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Неверный пароль, попробуйте ещё раз.");
                        goto passcheck;
                    }
                }
            }


            if (token == 1) Console.WriteLine("Данное имя пользователя не найдено");            /*связка a1*/

            Profile (usernow.name, usernow.city, usernow.weight);
            
        }



        static void Profile(string name, string city, int weight)           /*имитация страницы профиля*/
        {


            Console.WriteLine();
            Console.WriteLine("Имя: " + name);
            Console.WriteLine("Город: " + city);
            Console.WriteLine("Вес: " + weight);

            Console.WriteLine("Вам доступны следующие функции:");

            Console.WriteLine("Новый рекорд");

            Console.ReadLine();

        }


    }
}
