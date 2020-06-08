using System;
using System.IO;

namespace labba2sem3._2._0
{
    class Program
    {
        public static void Main(string[] args)
        {
            string path = @"C:\Users\Laptop\Desktop\labba2sem.txt";
       
            StreamWriter stream = new StreamWriter("newfile.txt");
            string  text = File.ReadAllText(path);
            var zapis = new StreamWriter(@"C:\Users\Laptop\Desktop\newfile.txt");
           char[] textm = text.ToCharArray();
            char a = textm[0]; //o
            textm[0] = textm[3]; //o-a

            
            textm[3] = a;// a-o

            zapis.Write(textm);
       
            
            zapis.Close();
            stream.Close();





        }
    }
}
//Дано файл, елементами якого є окремі символи, що складають слово "олгаритм". Отримати
//новий файл, в якому літери слова "алгоритм" будуть розміщені правильно.