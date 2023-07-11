

namespace KR
{

    internal class Program
    {
        static void Main(string[] args)
        {
           
        }

    }


    class Animals
    {
        protected int _petId;
        protected string _name;
        protected string _birthday;
        protected string _commands;


        public Animals(int petId, string name, string birthday, string commands)
        {
            _petId = petId;
            _name = name;
            _birthday = birthday;
            _commands = commands;
        }


        public void ShowInfo()
        {
            console.WriteLine($"id питомца - {_petId}, Имя - {_name}, Дата рождения - {_birthday}, Знает комманды - {_commands} " )
        }

        



    }




}