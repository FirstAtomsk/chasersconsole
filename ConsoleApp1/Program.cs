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

            ID alex = new ID("Брайер Алексей", 60, "Обнинск", "Alex", "12345", 60, 1);           /*это у меня такая "БД"*/
            ID ilya = new ID("Ситников Илья", 70, "Москва", "BigRichDick", "12345", 0, 100 );
            ID homer = new ID("Гомер Симпсон", 120, "Спрингфилд", "Homer", "Donuts", 20, 4);
            ID simp = new ID("Мамин Симпатяга", 40, "Зажопинск", "Simpa98", "maman", 25, 3);
            ID brod = new ID("Папин Бродяга", 65, "Зажопинск", "CoolGuy", "pahan", 50, 2);

            List<ID> idList = new List<ID>();           /*заливаю БД в массив*/
            idList.Add(alex);
            idList.Add(ilya);

            Console.WriteLine("Введите свой логин");            /*проверяю логин по массиву*/
            string loginow = Console.ReadLine();

            int token = 1;          /*это я так чекаю прохождение массива без совпадений - связка a1 */

            ID usernow = new ID("0", 0, "0", "0", "0", 0, 101);

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

            NewRecordFunc(alex, homer, simp, brod, ilya, usernow);

            Console.ReadLine();
            
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

        static void NewRecordPage()             /*страница выбор упражнения новый рекорд*/         
        {
            //Console.WriteLine();
            //Console.WriteLine(" 1 - Bench press.");
            //Console.WriteLine(" 2 - Dead lift.");
            //string rec_choice = Console.ReadLine();
            //if (rec_choice == "1")
            //{
            //    NewRecordFunc(/*bench press*/);
            //}
            //else if (rec_choice == "2")
            //{
            //    NewRecordFunc(/*dead lift*/)
            //}
            //else Console.WriteLine("Неизвестный запрос");

            
        }

        static void NewRecordFunc(ID alex, ID homer, ID simp, ID brod, ID ilya, ID usernow)             /*функциональное исполнение нового рекорда*/
        {
            Console.WriteLine("Введите свой результат");
            usernow.BP_res = Int32.Parse(Console.ReadLine());

            List<ID> BenchPressList = new List<ID>();

            BenchPressList.Add(alex);
            BenchPressList.Add(homer);
            BenchPressList.Add(simp);
            BenchPressList.Add(brod);
            BenchPressList.Add(ilya);


            foreach (ID i in BenchPressList)
            {
                if (usernow.BP_res > i.BP_res)
                {
                    if (usernow.BP_place > i.BP_place) usernow.BP_place = i.BP_place;
                    i.BP_place++;
                }
            }

            foreach (ID i in BenchPressList)
            {
                Console.WriteLine(i.name + " " + i.BP_place + " " + i.BP_res);
            }
                
        }

        
         
    }
}
