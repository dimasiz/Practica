using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            string filePath = "data.txt";
            CreateFileWithData(filePath);

           
            Console.WriteLine("Содержимое файла:");
            PrintFileContents(filePath);

         
            int lineCount = CountLines(filePath);
            Console.WriteLine("Количество строк: " + lineCount);

           
            Console.WriteLine("Количество символов в каждой строке:");
            CountCharactersPerLine(filePath);

            
            string newFilePath = "new_data.txt";
            DeleteLastLineAndSaveToFile(filePath, newFilePath);

            
            int startLine = 2;
            int endLine = 4;
            Console.WriteLine($"Строки с {startLine} по {endLine}:");
            PrintLinesInRange(filePath, startLine, endLine);

         
            int maxLength = FindMaxLength(filePath);
            Console.WriteLine("Длина самой длинной строки: " + maxLength);

          
            char startingLetter = 'T';
            Console.WriteLine($"Строки, начинающиеся с буквы '{startingLetter}':");
            PrintLinesStartingWithLetter(filePath, startingLetter);

          
            string reversedFilePath = "reversed_data.txt";
            ReverseLinesAndSaveToFile(filePath, reversedFilePath);

            Console.WriteLine("Операции завершены.");
        }

        
        static void CreateFileWithData(string filePath)
        {
            string[] lines = {
            "Я календарь",
            "Переверну и снова 3 сентебря ",
            "На фото я, твое взгялну",
            "И снова 3 сентября ",
            "Но почему, но почему расстаться все же нам пришлось, 2 сентебря"};

            File.WriteAllLines(filePath, lines);
            Console.WriteLine("Файл успешно создан и заполнен данными.");
        }
        static void PrintFileContents(string filePath)
        {
            string[] lines = File.ReadAllLines(filePath);
            foreach (string line in lines)
            {
                Console.WriteLine(line);
            }
        }

        
        static int CountLines(string filePath)
        {
            string[] lines = File.ReadAllLines(filePath);
            return lines.Length;
        }

        
        static void CountCharactersPerLine(string filePath)
        {
            string[] lines = File.ReadAllLines(filePath);
            foreach (string line in lines)
            {
                int characterCount = line.Length;
                Console.WriteLine($"Строка '{line}' содержит {characterCount} символов.");
            }
        }

        
        static void DeleteLastLineAndSaveToFile(string originalFilePath, string newFilePath)
        {
            string[] lines = File.ReadAllLines(originalFilePath);
            string[] newLines = lines.Take(lines.Length - 1).ToArray();
            File.WriteAllLines(newFilePath, newLines);
            Console.WriteLine("Последняя строка удалена и сохранена в новый файл.");
        }

        
        static void PrintLinesInRange(string filePath, int startLine, int endLine)
        {
            string[] lines = File.ReadAllLines(filePath);
            for (int i = startLine - 1; i < endLine; i++)
            {
                Console.WriteLine(lines[i]);
            }
        }

       
        static int FindMaxLength(string filePath)
        {
            string[] lines = File.ReadAllLines(filePath);
            int maxLength = 0;
            foreach (string line in lines)
            {
                int length = line.Length;
                if (length > maxLength)
                {
                    maxLength = length;
                }
            }
            return maxLength;
        }

        static void PrintLinesStartingWithLetter(string filePath, char startingLetter)
        {
            string[] lines = File.ReadAllLines(filePath);
            foreach (string line in lines)
            {
                if (line.StartsWith(startingLetter.ToString()))
                {
                    Console.WriteLine(line);
                }
            }
        }

        static void ReverseLinesAndSaveToFile(string filePath, string reversedFilePath)
        {
            string[] lines = File.ReadAllLines(filePath);
            Array.Reverse(lines);
            File.WriteAllLines(reversedFilePath, lines);
            Console.WriteLine("Строки были переписаны в другой файл в обратном порядке.");
        }
    }
    
}
