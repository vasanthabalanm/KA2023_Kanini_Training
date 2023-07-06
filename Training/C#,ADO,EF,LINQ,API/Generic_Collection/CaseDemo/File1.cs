using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseDemo
{
    internal class File1
    {
        public void CreateFile()
        {
            FileInfo f1 = new FileInfo("D:\\bala\\kanini\\c#\\files7.txt");
            using StreamWriter streamWriter = f1.CreateText();
            //FileInfo f2 = new FileInfo("D:\\bala\\kanini\\c#\\files2.txt");
            //using StreamWriter streamWriters = f2.CreateText();
            Console.WriteLine("created");
            streamWriter.WriteLine("hello");
            Console.WriteLine("wriitn");
        }
        public void DeleteFile()
        {
            FileInfo f1 = new FileInfo("D:\\bala\\kanini\\c#\\files1.txt");
            f1.Delete();
        }
        public void Coping()
        {
            FileInfo f1 = new FileInfo("D:\\bala\\kanini\\c#\\files1.txt");
            //FileInfo f2 = new FileInfo("D:\\bala\\kanini\\c#\\movingfileconcept");
            //f1.CopyTo("D:\\bala\\kanini\\c#\\movingfileconcept\\files3.txt");
            f1.MoveTo("D:\\bala\\kanini\\c#\\movingfileconcept\\files7.txt");

        }

        public void Writedata()
        {
            FileStream fileStream = new FileStream("D:\\bala\\kanini\\c#\\wow.txt",FileMode.Create,FileAccess.Write);
            StreamWriter streamWriter = new StreamWriter(fileStream);
            String str = Console.ReadLine();
            streamWriter.WriteLine(str);
            streamWriter.Flush();
            streamWriter.Close();
            fileStream.Close();
        }

        public void ReadDatas()
        {
            FileStream fileStream = new FileStream("D:\\bala\\kanini\\c#\\ok.txt", FileMode.Open, FileAccess.Read);
            StreamReader streamReader = new StreamReader(fileStream);
            streamReader.BaseStream.Seek(0,SeekOrigin.Begin);
            string str = streamReader.ReadLine();
            while(str!=null) 
            {
                Console.WriteLine(str);
                str = streamReader.ReadLine();
            }
            streamReader.Close();   
            fileStream.Close();
        }
    }
}
