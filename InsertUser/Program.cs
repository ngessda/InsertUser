using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsertUser
{
    public enum CommandType
    {
        None = 0,
        Stop = 10,
        Insert = 20,
        Update = 30,
        Delete = 40,
        Get = 50,
        GetAll = 60,
        Help = 70
    }
    public class Program
    {
        static void Main(string[] args)
        {
            GetCommand();
            Console.ReadKey();
        }
        static void GetCommand()
        {
            UserDataContext context = new UserDataContext();
            Command command;
            do
            {
                Console.Write("Введите команду: ");
                string insertCommand = Console.ReadLine();
                command = new Command(insertCommand);
                context.HandleCommand(command);
            }
            while (command.command != CommandType.Stop);
            Console.WriteLine("Программа завершена.");
        }
    }
}
