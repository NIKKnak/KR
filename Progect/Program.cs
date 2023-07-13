

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

            bool isWork = true;

            ShowAllObjs(_allAnimals);

            while (isWork)
            {
                Console.WriteLine("Выберите тип животного");
                int numAnim = int.Parse(Console.ReadLine());
                Animals selectedAnimals = _allAnimals[numAnim - 1];

                Console.WriteLine("Введите учетный номер животного");
                int Id = Console.ReadLine();

                Console.WriteLine("Введите дуту рождения животного в формате гггг/мм/дд");
                string birthdaySTR = Console.ReadLine();
                DateTime birthday = GetBirthday(birthdaySTR);

                Console.WriteLine("Введите команды животного");
                string commands = Console.ReadLine();



                




            }





        }


        static void ShowAllObjs<T>(IList<T> odjs) // общий метод
        {

            for (int i = 0; i < odjs.Count; i++)
            {
                Console.WriteLine($"{i + 1} {odjs[i]}");
            }

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
                return _packedAnimals;
            }


        }












    }
}