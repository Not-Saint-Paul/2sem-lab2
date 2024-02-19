using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab02 
{
   
    internal class Program 
    {
        public sealed class Singleton 
        {
            public static Singleton Instance 
            {
                get 
                {
                    if (instance == null) instance = new Singleton();
                    return instance;
                }
            }
            private Singleton()
            {
            }

            private static Singleton source = null;
            private static readonly object threadlock = new object();
            private static Singleton instance;
            public void ShowDocsInfoFolder() 
            {
                DocxInfoFolder File = new DocxInfoFolder();
                File.ShowInfoFolder();
            }
            public void ShowPdfInfoFolder() 
            {
                PdfileInfoFolder File = new PdfileInfoFolder();
                File.ShowInfoFolder();
            }
            public void ShowXlsxInfoFolder() 
            {
                XlsxInfoFolder File = new XlsxInfoFolder();
                File.ShowInfoFolder();
            }
            public void ShowTxtInfoFolder()
            {
                TxtInfoFolder File = new TxtInfoFolder();
                File.ShowInfoFolder();
            }
            public void ShowHTMLInfoFolder()
            {
                HTMLInfoFolder File = new HTMLInfoFolder();
                File.ShowInfoFolder();
            }

        }
        public abstract class InfoFolder
        {
            protected static string FilenameExtension = "null";
            protected string FileName = "It's " + FilenameExtension + "file." + FilenameExtension;
            protected string Author = "Not me";
            protected string[] KeyWords = { "It's hard to explain", "I'm bored", "Plz kill me", "I hate to build redstone schemes", "My head is on fire" };
            protected string Topic = "Some stuff";
            protected string FilePath = "C:/User/Me/Homework/Really homework/New folder(3)/" + FilenameExtension + "file." + FilenameExtension;

            public virtual void ShowInfoFolder()
            {
            }
        }

        class DocxInfoFolder : InfoFolder
        {
            public override void ShowInfoFolder()
            {
                FilenameExtension = "docx";
                FileName = "It's " + FilenameExtension + "file." + FilenameExtension;
                FilePath = "C:/User/Me/Homework/Really homework/New folder(3)/" + FilenameExtension + "file." + FilenameExtension;
                Console.WriteLine("Filename Extension: ." + FilenameExtension);
                Console.WriteLine("Name of file: " + FileName);
                Console.WriteLine("File's author: " + Author);
                Console.WriteLine("Keywords: ");
                for (int NumberOfWord = 0; NumberOfWord < KeyWords.Length; ++NumberOfWord)
                {
                    Console.WriteLine((NumberOfWord + 1) + " - " + KeyWords[NumberOfWord]);
                }
                Console.WriteLine("Topic of file: " + Topic);
                Console.WriteLine("Path to file: " + FilePath);
            }
        }
        class PdfileInfoFolder : InfoFolder
        {
            public override void ShowInfoFolder()
            {
                FilenameExtension = "pdf";
                FileName = "It's " + FilenameExtension + "file." + FilenameExtension;
                FilePath = "C:/User/Me/Homework/Really homework/New folder(3)/" + FilenameExtension + "file." + FilenameExtension;
                Console.WriteLine("Filename Extension: ." + FilenameExtension);
                Console.WriteLine("Name of file: " + FileName);
                Console.WriteLine("File's author: " + Author);
                Console.WriteLine("Keywords: ");
                for (int NumberOfWord = 0; NumberOfWord < KeyWords.Length; ++NumberOfWord)
                {
                    Console.WriteLine((NumberOfWord + 1) + " - " + KeyWords[NumberOfWord]);
                }
                Console.WriteLine("Topic of file: " + Topic);
                Console.WriteLine("Path to file: " + FilePath);
            }
        }
        class XlsxInfoFolder : InfoFolder
        {
            public override void ShowInfoFolder()
            {
                FilenameExtension = "xlsx";
                FileName = "It's " + FilenameExtension + "file." + FilenameExtension;
                FilePath = "C:/User/Me/Homework/Really homework/New folder(3)/" + FilenameExtension + "file." + FilenameExtension;
                Console.WriteLine("Filename Extension: ." + FilenameExtension);
                Console.WriteLine("Name of file: " + FileName);
                Console.WriteLine("File's author: " + Author);
                Console.WriteLine("Keywords: ");
                for (int NumberOfWord = 0; NumberOfWord < KeyWords.Length; ++NumberOfWord)
                {
                    Console.WriteLine((NumberOfWord + 1) + " - " + KeyWords[NumberOfWord]);
                }
                Console.WriteLine("Topic of file: " + Topic);
                Console.WriteLine("Path to file: " + FilePath);
            }
        }
        class TxtInfoFolder : InfoFolder
        {
            public override void ShowInfoFolder()
            {
                FilenameExtension = "txt";
                FileName = "It's " + FilenameExtension + "file." + FilenameExtension;
                FilePath = "C:/User/Me/Homework/Really homework/New folder(3)/" + FilenameExtension + "file." + FilenameExtension;
                Console.WriteLine("Filename Extension: ." + FilenameExtension);
                Console.WriteLine("Name of file: " + FileName);
                Console.WriteLine("File's author: " + Author);
                Console.WriteLine("Keywords: ");
                for (int NumberOfWord = 0; NumberOfWord < KeyWords.Length; ++NumberOfWord)
                {
                    Console.WriteLine((NumberOfWord + 1) + " - " + KeyWords[NumberOfWord]);
                }
                Console.WriteLine("Topic of file: " + Topic);
                Console.WriteLine("Path to file: " + FilePath);
            }
        }
        class HTMLInfoFolder : InfoFolder
        {
            public override void ShowInfoFolder()
            {
                FilenameExtension = "html";
                FileName = "It's " + FilenameExtension + "file." + FilenameExtension;
                FilePath = "C:/User/Me/Homework/Really homework/New folder(3)/" + FilenameExtension + "file." + FilenameExtension;
                Console.WriteLine("Filename Extension: ." + FilenameExtension);
                Console.WriteLine("Name of file: " + FileName);
                Console.WriteLine("File's author: " + Author);
                Console.WriteLine("Keywords: ");
                for (int NumberOfWord = 0; NumberOfWord < KeyWords.Length; ++NumberOfWord)
                {
                    Console.WriteLine((NumberOfWord + 1) + " - " + KeyWords[NumberOfWord]);
                }
                Console.WriteLine("Topic of file: " + Topic);
                Console.WriteLine("Path to file: " + FilePath);
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Filename Extension ('d' for docx, 'p' for pdf, 'x' for xlsx, 't' for txt, 'h' for html): ");
            char TypeOfFile = Convert.ToChar(Console.ReadLine());
            switch (TypeOfFile) {
                case 'd':
                    Singleton.Instance.ShowDocsInfoFolder();
                    break;
                case 'p':
                    Singleton.Instance.ShowPdfInfoFolder();
                    break;
                case 'x':
                    Singleton.Instance.ShowXlsxInfoFolder();
                    break;
                case 't':
                    Singleton.Instance.ShowTxtInfoFolder();
                    break;
                case 'h':
                    Singleton.Instance.ShowHTMLInfoFolder();
                    break;
                default:
                    Console.WriteLine("Wrong type of file!");
                    break;
            }
            Console.ReadKey();
        }
    }
}
