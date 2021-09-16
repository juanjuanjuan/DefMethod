using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;


namespace CommandApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine(Environment.CurrentDirectory);
            List<Person> all = new List<Person>();

            // Add all files into one List
            all.AddRange(readFilePipe());
            all.AddRange(readFileCommas());
            all.AddRange(readFileSpace());

            // Sort & print list, output 1
            Console.WriteLine("Output 1:");
            IEnumerable<Person> sortAscendingQuery =
                from person in all
                orderby person.gender, person.lastname
                select person;

            foreach (Person s in sortAscendingQuery) Console.WriteLine(s.ToString());

            // Sort & print list, output 2
            Console.WriteLine("\nOutput 2:");
            sortAscendingQuery =
                from person in all
                orderby person.birth, person.lastname descending
                select person;

            foreach (Person s in sortAscendingQuery) Console.WriteLine(s.ToString());

            // Sort & print list, output 3
            Console.WriteLine("\nOutput 3:");
            sortAscendingQuery =
                from person in all
                orderby person.lastname descending
                select person;

            foreach (Person s in sortAscendingQuery) Console.WriteLine(s.ToString());
        }

        private static List<Person> readFilePipe() {
            List<Person> pList = new List<Person>();
            string[] lines = System.IO.File.ReadAllLines(@".\Files\def-method-code-test-input-files\pipe.txt");
            foreach (string line in lines)
            {
                string[] p = line.Split('|');

                var dateAux = getDate("M-d-yyyy" , p[5].Trim());

                pList.Add(
                    new Person(
                        p[1].Trim(),
                        p[2].Trim(),
                        p[0].Trim(),
                        (String.Equals(p[3].Trim(), "M") ? "Male" : "Female"),
                        p[4].Trim(),
                        dateAux
                    )
                );
            }

            return pList;
        }

        private static List<Person> readFileCommas() {
            List<Person> pList = new List<Person>();
            string[] lines = System.IO.File.ReadAllLines(@".\Files\def-method-code-test-input-files\comma.txt");
            foreach (string line in lines)
            {
                string[] p = line.Split(',');

                var dateAux = getDate("M/dd/yyyy" , p[4].Trim());

                pList.Add(
                    new Person(
                        p[1].Trim(),
                        null,
                        p[0].Trim(),
                        p[2].Trim(),
                        p[3].Trim(),
                        dateAux
                    )
                );
            }

            return pList;
        }

        private static List<Person> readFileSpace() {
            List<Person> pList = new List<Person>();
            string[] lines = System.IO.File.ReadAllLines(@".\Files\def-method-code-test-input-files\space.txt");
            foreach (string line in lines)
            {
                string[] p = line.Split(' ');

                var dateAux = getDate("M-d-yyyy", p[4].Trim());

                pList.Add(
                    new Person(
                        p[1].Trim(),
                        p[2].Trim(),
                        p[0].Trim(),
                        (String.Equals(p[3].Trim(), "M") ? "Male" : "Female"),
                        p[5].Trim(),
                        dateAux
                    )
                );
            }

            return pList;
        }

        private static DateTime getDate(string format, string value) {
                string[] formats = { format };
                return DateTime.ParseExact(value, formats, new CultureInfo("en-US"), DateTimeStyles.None);
        }
    }
}
