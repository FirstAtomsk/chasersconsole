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
            ID alex = new ID("alex", 60, "Obninsk", "alex", "12345");           /*это у меня такая БД*/
            ID ilya = new ID("ilya", 70, "Moscow", "ilya", "12345");

            List<ID> idList = new List<ID>();           /*вывожу мою БД в массив*/
            idList.Add(alex);
            idList.Add(ilya);

            Console.WriteLine("Введите свой логин");            /*проверяю логин по массиву*/
            string loginow = Console.ReadLine();

            foreach ( ID i in idList)
            {
                if (i.login == loginow)
                {
                    Console.WriteLine("Логин принят, введите пароль");
                    passcheck:
                    string passnow = Console.ReadLine();
                    if(i.pass == passnow)
                    {
                        Console.WriteLine("Аутентификация успешна.");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Неверный пароль, попробуйте ещё раз.");
                        goto passcheck;
                    }
                }
                else
                {
                    Console.WriteLine("Данное имя пользователя не зарегистрировано");
                }
            
            }

            Console.ReadLine();
        }


        
    }
}
