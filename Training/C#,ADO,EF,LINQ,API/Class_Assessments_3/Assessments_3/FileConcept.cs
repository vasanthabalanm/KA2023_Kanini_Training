using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessments_3
{
    internal class FileConcept
    {
        public void createfile()
        {
            string path = "D:\\bala\\kanini\\c#\\FileQuestion\\file1.txt";
            FileStream fileStream = File.Create(path);
            Console.WriteLine("this file is now created");
            
        }

    
        public void Writefile()
        {
            string path = "D:\\bala\\kanini\\c#\\FileQuestion\\file1.txt";
            FileStream fileStream = new FileStream (path,FileMode.Create,FileAccess.Write);
            StreamWriter fileWriter = new StreamWriter(fileStream);
            string str1 = Console.ReadLine();
            string str2 = Console.ReadLine();
            fileWriter.WriteLine(str1);
            fileWriter.WriteLine(str2);
            fileWriter.Flush();
            fileWriter.Close();
            fileStream.Close();
        }
        public void Readfile()
        {
            string path = "D:\\bala\\kanini\\c#\\FileQuestion\\file1.txt";
            FileStream fileStream = new FileStream(path, FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(fileStream);
            reader.BaseStream.Seek(0, SeekOrigin.Begin);    
            string str = reader.ReadLine();
            string str1 = "fox";
            while (str != null)
            { 
                if (!str.Contains(str1))
                {
                    Console.WriteLine(str);
                }
                str = reader.ReadLine();
                FileConcept concept = new FileConcept();
                //concept.Written(str);

            }
            reader.Close();
            fileStream.Close();
        }
        public void Written()
        {
            string path = "D:\\bala\\kanini\\c#\\FileQuestion\\file1.txt";
            FileStream fileStream = new FileStream(path, FileMode.Create, FileAccess.Write);
            StreamWriter fileWriter = new StreamWriter(fileStream);
            string str = Console.ReadLine();
            fileWriter.WriteLine(str);
            fileWriter.Flush();
            fileWriter.Close();
            fileStream.Close();
        }
    }
}
