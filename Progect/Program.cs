

namespace KR
{

    internal class Program
    {
        static void Main(string[] args)
        {
            Animals[] animals =
            {
                new Animals(1,"Тузик", "01.01.2010", "сидеть")
            };


            Console.WriteLine(HomeAnimals);





        }










        public abstract class HomeAnimals
        {
            protected int _petId;
            protected string _name;
            protected string _birthday;
            protected string _commands;


            public HomeAnimals(int petId, string name, string birthday, string commands)
            {
                _petId = petId;
                _name = name;
                _birthday = birthday;
                _commands = commands;
            }


            public void ShowInfo()
            {
                Console.WriteLine($"id питомца - {_petId}, Имя - {_name}, Дата рождения - {_birthday}, Знает комманды - {_commands} ");
            }


        }






        public class Cat : HomeAnimals
        {
            public Cat(int petId, string name, string birthday, string commands) : base(petId, name, birthday, commands)
            {
                // super(petId, "asd", "01012020", "мяу");
            }

        }
















    }
}












