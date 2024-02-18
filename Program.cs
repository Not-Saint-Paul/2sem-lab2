using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab02
{
    class InfoFolder
    {
        public string FilenameExpansion;
        public string Name;
        public string Author;
        public string[] KeyWords;
        public string Topic;
        public string FilePath;
    }
    class MSWordInfoFolder : InfoFolder
    {
        public static new string FilenameExpansion = "MS Word";
    }
    class PDFileInfoFolder : InfoFolder
    {
        public static new string FilenameExpansion = "PDF";
    }
    class MSExcelInfoFolder : InfoFolder
    {
        public static new string FilenameExpansion = "MS Excel";
    }
    class TXTInfoFolder : InfoFolder
    {
        public static new string FilenameExpansion = "txt";
    }
    class HTMLInfoFolder : InfoFolder
    {
        public static new string FilenameExpansion = "HTML";
    }
    public sealed class Singleton
    {
        private Singleton()
        {
        }

        private static Singleton source = null;
        private static readonly object threadlock = new object();

        public static Singleton Source
        {
            get
            {
                lock (threadlock)
                {
                    if (source == null)
                        source = new Singleton();

                    return source;
                }
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int LengthOfArray = 1;
            Console.WriteLine("Введите формат файла: ");
            string FilenameExpansion = Convert.ToString(Console.ReadLine());
            string MSWordFilenameExpansion = MSWordInfoFolder.FilenameExpansion;
            string PDFFilenameExpansion = PDFileInfoFolder.FilenameExpansion;
            string MSExcelFilenameExpansion = MSExcelInfoFolder.FilenameExpansion;
            string TxtFilenameExpansion = TXTInfoFolder.FilenameExpansion;
            string HTMLFilenameExpansion = HTMLInfoFolder.FilenameExpansion;
            if (FilenameExpansion == MSWordFilenameExpansion)
            {
                Console.WriteLine("Введите имя файла: ");
                string MSWordName = Convert.ToString(Console.ReadLine());
                Console.WriteLine("Введите имя автора файла: ");
                string MSWordAuthor = Convert.ToString(Console.ReadLine());
                Console.WriteLine("Введите кодовые слова файла ('\0' для окончания ввода): ");
                string[] MSWordKeyWords = new string[10];
                for (int NumberOfWords = 0; NumberOfWords < LengthOfArray; ++NumberOfWords)
                {
                    MSWordKeyWords[NumberOfWords] = Convert.ToString(Console.ReadLine());
                    if (MSWordKeyWords[NumberOfWords] == "\0")
                    {
                        break;
                    } 
                    else
                    {
                        ++LengthOfArray;
                    }
                }
                Console.WriteLine("Введите тематику файла: ");
                string MSWordTopic = Convert.ToString(Console.ReadLine());
                Console.WriteLine("Введите путь к файлу: ");
                string MSWordFilePath = Convert.ToString(Console.ReadLine());
                Console.ReadKey();
            }
            else if (FilenameExpansion == PDFFilenameExpansion)
            {
                Console.WriteLine("Введите имя файла: ");
                string PDFName = Convert.ToString(Console.ReadLine());
                Console.WriteLine("Введите имя автора файла: ");
                string PDFAuthor = Convert.ToString(Console.ReadLine());
                Console.WriteLine("Введите кодовые слова файла ('\0' для окончания ввода): ");
                string[] PDFKeyWords = new string[10];
                for (int NumberOfWords = 0; NumberOfWords < LengthOfArray; ++NumberOfWords)
                {
                    PDFKeyWords[NumberOfWords] = Convert.ToString(Console.ReadLine());
                    if (PDFKeyWords[NumberOfWords] == "\0")
                    {
                        break;
                    }
                    else
                    {
                        ++LengthOfArray;
                    }
                }
                Console.WriteLine("Введите тематику файла: ");
                string PDFTopic = Convert.ToString(Console.ReadLine());
                Console.WriteLine("Введите путь к файлу: ");
                string PDFFilePath = Convert.ToString(Console.ReadLine());
                Console.ReadKey();
            }
            else if (FilenameExpansion == MSExcelFilenameExpansion)
            {
                Console.WriteLine("Введите имя файла: ");
                string MSExcelName = Convert.ToString(Console.ReadLine());
                Console.WriteLine("Введите имя автора файла: ");
                string MSExcelAuthor = Convert.ToString(Console.ReadLine());
                Console.WriteLine("Введите кодовые слова файла ('\0' для окончания ввода): ");
                string[] MSExcelKeyWords = new string[10];
                for (int NumberOfWords = 0; NumberOfWords < LengthOfArray; ++NumberOfWords)
                {
                    MSExcelKeyWords[NumberOfWords] = Convert.ToString(Console.ReadLine());
                    if (MSExcelKeyWords[NumberOfWords] == "\0")
                    {
                        break;
                    }
                    else
                    {
                        ++LengthOfArray;
                    }
                }
                Console.WriteLine("Введите тематику файла: ");
                string MSExcelTopic = Convert.ToString(Console.ReadLine());
                Console.WriteLine("Введите путь к файлу: ");
                string MSExcelFilePath = Convert.ToString(Console.ReadLine());
                Console.ReadKey();
            }
            else if (FilenameExpansion == TxtFilenameExpansion)
            {
                Console.WriteLine("Введите имя файла: ");
                string TxtName = Convert.ToString(Console.ReadLine());
                Console.WriteLine("Введите имя автора файла: ");
                string TxtAuthor = Convert.ToString(Console.ReadLine());
                Console.WriteLine("Введите кодовые слова файла ('\0' для окончания ввода): ");
                string[] TxtKeyWords = new string[10];
                for (int NumberOfWords = 0; NumberOfWords < LengthOfArray; ++NumberOfWords)
                {
                    TxtKeyWords[NumberOfWords] = Convert.ToString(Console.ReadLine());
                    if (TxtKeyWords[NumberOfWords] == "\0")
                    {
                        break;
                    }
                    else
                    {
                        ++LengthOfArray;
                    }
                }
                Console.WriteLine("Введите тематику файла: ");
                string TxtTopic = Convert.ToString(Console.ReadLine());
                Console.WriteLine("Введите путь к файлу: ");
                string TxtFilePath = Convert.ToString(Console.ReadLine());
                Console.ReadKey();
            }
            else if (FilenameExpansion == HTMLFilenameExpansion)
            {
                Console.WriteLine("Введите имя файла: ");
                string HTMLName = Convert.ToString(Console.ReadLine());
                Console.WriteLine("Введите имя автора файла: ");
                string HTMLAuthor = Convert.ToString(Console.ReadLine());
                Console.WriteLine("Введите кодовые слова файла ('\0' для окончания ввода): ");
                string[] HTMLKeyWords = new string[10];
                for (int NumberOfWords = 0; NumberOfWords < LengthOfArray; ++NumberOfWords)
                {
                    HTMLKeyWords[NumberOfWords] = Convert.ToString(Console.ReadLine());
                    if (HTMLKeyWords[NumberOfWords] == "\0")
                    {
                        break;
                    }
                    else
                    {
                        ++LengthOfArray;
                    }
                }
                Console.WriteLine("Введите тематику файла: ");
                string HTMLTopic = Convert.ToString(Console.ReadLine());
                Console.WriteLine("Введите путь к файлу: ");
                string HTMLFilePath = Convert.ToString(Console.ReadLine());
                Console.ReadKey();
            } 
            else
            {
                Console.WriteLine("Неверный формат файла.");
                Console.ReadKey();
            }
        }
    }
}
