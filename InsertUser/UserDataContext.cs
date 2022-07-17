using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsertUser
{
    public class UserDataContext
    {
        private List<User> _users;
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
            var user = new User(name, surname, login, password);
            user.id = counter - 1;
            _users.Add(user);
            Console.WriteLine("Создание нового пользователя прошло успешно.");
        }
        private void HandleUpdateCommand()
        {

        }
        private void HandleDeleteCommand()
        {

        }
        private void HandleGetCommand()
        {

        }
        private void HandleGetAllCommand()
        {

        }
        private void HandleUnknownCommand()
        {

        }

    }
}
