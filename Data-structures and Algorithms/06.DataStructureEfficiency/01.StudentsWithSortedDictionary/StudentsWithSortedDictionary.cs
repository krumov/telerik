using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace _01.StudentsWithSortedDictionary
{
    class StudentsWithSortedDictionary
    {
        public static SortedDictionary<string, SortedSet<Student>> studentsByCourse = new SortedDictionary<string, SortedSet<Student>>();

        public static void Main()
        {
            PopulateDictionary();

            PrintResults();
        }

        private static void PrintResults()
        {
            foreach (var pair in studentsByCourse)
            {
                Console.WriteLine("{0} : {1}", pair.Key, string.Join(", ", pair.Value));
            }
        }

        private static void PopulateDictionary()
        {
            StreamReader reader = new StreamReader(@"..\..\students.txt");

            try
            {
                string currLine = reader.ReadLine();

                while (currLine != null)
                {
                    var lineTokens = currLine.Split(new char[] { '|', ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

                    var studentToAdd = new Student(lineTokens[0], lineTokens[1]);

                    if (!studentsByCourse.ContainsKey(lineTokens[2]))
                    {
                        studentsByCourse.Add(lineTokens[2], new SortedSet<Student>());
                    }

                    studentsByCourse[lineTokens[2]].Add(studentToAdd);

                    currLine = reader.ReadLine();
                }
            }

            catch (FileNotFoundException)
            {
                Console.WriteLine("File students.txt not found!");
            }
        }
    }
}
