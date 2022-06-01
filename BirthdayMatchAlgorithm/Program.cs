using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirthdayMatchAlgorithm
{
    class Program
    {
        public static List<PersonModel> _persons = new List<PersonModel>();

        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to the Birthday Match Algorithm Program!\n" +
                "This program will take in unlimited number of persons with birthdays and will stop when it finds two matching birthdays.");
            Console.WriteLine("Press any key to continue...");
            Console.ReadLine();

            for (int i = 1; i == i; i++)
            {
                DateTime dateInput = SetDateInput();

                var personQuery = CheckForBirthdayMatch(dateInput);

                if (personQuery != null)
                {
                    Console.WriteLine(DisplayMatch(personQuery, i));
                    break;
                }

                PersonModel person = new PersonModel(i, dateInput);
                _persons.Add(person);

                Console.WriteLine("No match was found. Press enter to continue and add another person.");
            }

            Console.WriteLine("Press any key to exit the program.");
            Console.ReadLine();
        }

        public static int SetBirthMonth()
        {
            bool success = false;
            int result;
            do
            {
                Console.WriteLine("Please enter the birth month(MM): ");
                string birthMonthInput = Console.ReadLine();

                bool monthSuccess = int.TryParse(birthMonthInput, out result);

                if (birthMonthInput.Length == 2)
                {
                    if (monthSuccess)
                    {
                        success = true;
                    }
                }
                else
                {
                    Console.WriteLine("Please enter a valid birth month in MM format. Press any key to continue.");
                    Console.ReadLine();
                }
            } while (!success);

            return result;
        }

        public static int SetBirthDay()
        {
            bool success = false;
            int result;
            do
            {
                Console.WriteLine("Please enter the birth day(DD): ");
                string birthDayInput = Console.ReadLine();

                bool monthSuccess = int.TryParse(birthDayInput, out result);

                if (birthDayInput.Length == 2)
                {
                    if (monthSuccess)
                    {
                        success = true;
                    }
                }
                else
                {
                    Console.WriteLine("Please enter a valid birth day in DD format. Press any key to continue.");
                    Console.ReadLine();
                }
            } while (!success);

            return result;
        }

        public static int SetBirthYear()
        {
            bool success = false;
            int result;
            do
            {
                Console.WriteLine("Please enter the birth Year(YYYY): ");
                string birthMonthInput = Console.ReadLine();

                bool monthSuccess = int.TryParse(birthMonthInput, out result);

                if (birthMonthInput.Length == 4)
                {
                    if (monthSuccess)
                    {
                        success = true;
                    }
                }
                else
                {
                    Console.WriteLine("Please enter a valid birth year in YYYY format. Press any key to continue.");
                    Console.ReadLine();
                }
            } while (!success);

            return result;
        }

        public static DateTime SetDateInput()
        {
            int birthMonth = SetBirthMonth();
            int birthDay = SetBirthDay();
            int birthYear = SetBirthYear();

            return new DateTime(birthYear, birthMonth, birthDay);
        }

        public static PersonModel CheckForBirthdayMatch(DateTime inputtedDate)
        {
            var personQuery = _persons.Find(p => p.BirthDate == inputtedDate);

            if (personQuery != null)
            {
                return personQuery;
            }
            else
            {
                return null;
            }
        }

        public static string DisplayMatch(PersonModel matchedPerson, int iterations)
        {
            string output;

            PersonModel p = matchedPerson;

            return output = ($"There is a match! The date you just entered matched with Person Id: {p.Id} with a birthday of {p.BirthDate.ToShortDateString()}\n" +
                $"It took {iterations} tries to find a match.");
        }
    }
}
