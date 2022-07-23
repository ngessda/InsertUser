using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsertUser
{
    public class UserDataContext
    {
        private List<User> _users = new List<User>();
        public void HandleCommand(Command _command)
        {
            switch (_command.command)
            {
                case CommandType.Insert:
                    HandleInsertCommand();
                    break;
                case CommandType.Update:
                    HandleUpdateCommand();
                    break;
                case CommandType.Delete:
                    HandleDeleteCommand();
                    break;
                case CommandType.Get:
                    HandleGetCommand();
                    break;
                case CommandType.GetAll:
                    HandleGetAllCommand();
                    break;
                case CommandType.None:
                    HandleUnknownCommand();
                    break;
            }
        }
        private void HandleInsertCommand()
        {
            string name, surname, login, password;
            int id = _users.Count;
            Console.WriteLine("Создание нового пользователя...");
            Console.Write("Имя пользователя: ");
            name = Console.ReadLine();
            Console.Write("Фамилия пользователя: ");
            surname = Console.ReadLine();
            Console.Write("Логин пользователя: ");
            login = Console.ReadLine();
            Console.Write("Пароль пользователя: ");
            password = Console.ReadLine();
            var user = new User()
            {
                id = id,
                name = name,
                surname = surname,
                login = login,
                password = password
            };
            _users.Add(user);
            Console.WriteLine("Создание нового пользователя прошло успешно.");
        }
        private void HandleUpdateCommand()
        {
            int id = 0;
            Console.WriteLine("Изменение существующего пользователя...");
            Console.Write("Введите id пользователя: ");
            if(int.TryParse(Console.ReadLine(), out var _id))
            {
                id = _id;
                if (_users.Count > id)
                {
                    string name, surname, login, password;
                    var user = new User();
                    Console.WriteLine("Началась процедура изменения данных пользователя...");
                    int counter = _users.Count;
                    Console.WriteLine("Создание нового пользователя...");
                    Console.Write("Имя пользователя: ");
                    name = Console.ReadLine();
                    Console.Write("Фамилия пользователя: ");
                    surname = Console.ReadLine();
                    Console.Write("Логин пользователя: ");
                    login = Console.ReadLine();
                    Console.Write("Пароль пользователя: ");
                    password = Console.ReadLine();
                    user.name = name;
                    user.surname = surname;
                    user.login = login;
                    user.password = password;
                    _users[id] = user;
                    Console.WriteLine("Данные пользователя успешно изменены.");
                }
                else
                {
                    Console.WriteLine($"Пользователя с id:{id} не существует?");
                    return;
                }
            }
            else
            {
                Console.WriteLine("Некорректный ввод id.");
            }

        }
        private void HandleDeleteCommand()
        {
            int id = 0;
            Console.WriteLine("Удаление существующего пользователя...");
            Console.Write("Введите id пользователя: ");
            if (int.TryParse(Console.ReadLine(), out var _id))
            {
                Console.WriteLine("Началась процедура удаления пользователя...");
                id = _id;
                if (_users.Count > id)
                {
                    _users.RemoveAt(id);
                }
                else
                {
                    Console.WriteLine($"Пользователя с id:{id} не существует?");
                    return;
                }
            }
            else
            {
                Console.WriteLine("Некорректный ввод id.");
            }
            Console.WriteLine("Пользователь успешно удален.");
        }
        private void HandleGetCommand()
        {
            int id = 0;
            Console.Write("Введите id пользователя: ");
            if (int.TryParse(Console.ReadLine(), out var _id))
            {
                id = _id;
                if (_users.Count > id)
                {
                    Console.WriteLine(_users[id]);
                }
                else
                {
                    Console.WriteLine($"Пользователя с id:{id} не существует");
                    return;
                }
            }
            else
            {
                Console.WriteLine("Некорректный ввод id.");
            }
        }
        private void HandleGetAllCommand()
        {
            for(int i = 0; i < _users.Count; i++)
            {
                Console.WriteLine($"Пользователь с {i} id:");
                Console.WriteLine(_users[i]);
                Console.WriteLine();
            }
        }
        private void HandleUnknownCommand()
        {
            Console.WriteLine("Была введена команда неизвестного типа.");
            return;
        }

    }
}
