using System;
internal class Program
{
    static void Main(string[] args)
    {
        byte appRaitingFromUser;
        string userMail;
        Console.WriteLine("Добро пожаловать на тестирование нашей программы, " +
            "чтобы зарегестрироваться, введите ваше имя и придумайте пароль.");
        Console.Write("Имя: ");
        string registrationUserName = Console.ReadLine();
        Console.Write("Пароль: ");
        string registrationUserPassword = Console.ReadLine();
        Console.Clear();
        Console.WriteLine("Вы успешно зарегестрировались, теперь войдите в свой аккаунт.");
        Console.Write("Введите ваше имя: ");
        string userInputName = Console.ReadLine();
        Console.Write("Введите ваш пароль: ");
        string userInputPassword = Console.ReadLine();
        Console.Clear();

        if (userInputName == registrationUserName && userInputPassword == registrationUserPassword)
        {
            Console.WriteLine("Перейти в раздел меню - нажмите Enter, выйти из приложения напишите - Esc");

            while (Console.ReadLine() != "Esc")
            {
                Console.WriteLine("Menu:");
                Console.WriteLine("AppEvaluation - оценить наше приложение");
                Console.WriteLine("AddMail - добавить вашу почту, для уведомления обновлений и новостей по нашему приложению");
                Console.WriteLine("ChangeName -  изменить имя");
                Console.WriteLine("MyName -  узнать ваше имя)");
                Console.WriteLine("ChangePassword - изменить пароль \n");
                string userChoice = Console.ReadLine();

                switch (userChoice)
                {
                    case "AppEvaluation":
                        Console.WriteLine("Оцените наше приложение по 5-ти бальной шкале: ");
                        appRaitingFromUser = Convert.ToByte(Console.ReadLine());
                        Console.WriteLine("Спасибо за вашу оценку");
                        Console.WriteLine("Перейти в раздел меню - нажмите Enter, выйти из приложения напишите - Esc");
                        break;

                    case "AddMail":
                        Console.Write("Введите ваш e-mail: ");
                        userMail = Console.ReadLine();
                        Console.WriteLine("Теперь вам на почту будут приходить уведомления о нашем приложении.");
                        Console.WriteLine("Перейти в раздел меню - нажмите Enter, выйти из приложения напишите - Esc");
                        break;

                    case "ChangeName":
                        Console.WriteLine("Введите ваше прежне имя: ");
                        string oldUserName = Console.ReadLine();
                        if (oldUserName == registrationUserName)
                        {
                            Console.Write("Введите новое имя: ");
                            registrationUserName = Console.ReadLine();
                            Console.WriteLine("Перейти в раздел меню - нажмите Enter, выйти из приложения напишите - Esc");
                        }
                        else
                        {
                            Console.WriteLine("Вас не так зовут :Р");
                            Console.WriteLine("Перейти в раздел меню - нажмите Enter, выйти из приложения напишите - Esc");
                        }
                        break;

                    case "MyName":
                        Console.WriteLine("Ваше имя - " + registrationUserName);
                        Console.WriteLine("Перейти в раздел меню - нажмите Enter, выйти из приложения напишите - Esc");
                        break;

                    case "ChangePassword":
                        Console.WriteLine("Введите ваш прежний пароль: ");
                        string oldUserPassword = Console.ReadLine();
                        if (oldUserPassword == registrationUserPassword)
                        {
                            Console.Write("Введите новый пароль: ");
                            registrationUserPassword = Console.ReadLine();
                            Console.WriteLine("Перейти в раздел меню - нажмите Enter, выйти из приложения напишите - Esc");
                        }
                        else
                        {
                            Console.WriteLine("Пароль не совпадает с предыдущим :Р");
                            Console.WriteLine("Перейти в раздел меню - нажмите Enter, выйти из приложения напишите - Esc");
                        }
                        break;
                }
            }

        }
        else
        {
            Console.WriteLine("Имя или пароль введены не верно");
        }
    }
}