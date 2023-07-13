

namespace KR
{

    internal class Program
    {

        static List<Animals> _allAnimals = new List<Animals>()
        {
            new Animals("Домашнее животное")
            new Animals("Вьючное животное")
        }









        static void Main(string[] args)
        {
          

            





        }



        static DateTime GetBirthday(string animalDateInput)
        {
            DateTime date = DateTime.Parse(animalDateInput);
            return date;
        }

        abstract class HomeAnimals
        {
            protected int _petId;
            protected string _name;
            protected DateTime _birthday;
            protected string _commands;


            public HomeAnimals(int petId, string name, string commands = "Default", DateTime? birthday = null)
            {
                _petId = petId;
                _name = name;
                _commands = commands;
                _birthday = birthday ?? DateTime.Now;
            }


            public override string ToString()
            {
                return $"{_petId} {_name} {_commands} {_birthday.ToShortDateString()}"
            }


        }

        public class Cat : HomeAnimals
        {
            public Cat(int petId, string name, string commands = "Default", DateTime? birthday = null) : base(petId, name, commands, birthday)
            {
                
            }


            public override string ToString()
            {
                return $"{base.ToString()} {Job}";
            }

        }

        class Animals
        {
            public int _homeAnimals { get; private set; }
            public int _packedAnimals { get; private set; }

            public Animals(string packedAnimals)
            {
                _packedAnimals = packedAnimals;
            }

            public Animals(string homeAnimals)
            {
                _homeAnimals = homeAnimals;
            }

            public override string ToString()
            {
                return _homeAnimals;
            }


        }












    }
}