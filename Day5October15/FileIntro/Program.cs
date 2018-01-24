using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileIntro
{
    class Program
    {
        static void Main(string[] args)
        {

            CreateBinaryFile();
            ReadBinaryFile();
            
            //CreateTextFile();
            //ReadTextFile();
        }
        static void CreateTextFile()
        { 
            //createFileStream

            FileStream fileStream = new FileStream(@"D:\AbinashMishra\Day5October15\MyFiles\letter.txt", FileMode.Create, FileAccess.Write);
            StreamWriter streamWrite = new StreamWriter(fileStream);
            //streamWrite.WriteLine("Sometimes it seems Harry doesn't know a thing about magic!");

            string data = "";
            while (data != "#")
            {
                data = Console.ReadLine();

                streamWrite.WriteLine(data);
            }
            streamWrite.Close();
            fileStream.Close();
            Console.WriteLine("Data written to file.");
        }
        static void ReadTextFile()
        {
            FileStream fileStream = new FileStream(@"D:\AbinashMishra\Day5October15\MyFiles\reader.txt", FileMode.Open, FileAccess.Read);
            StreamReader streamReader = new StreamReader(fileStream);
            string data = "";
            while (data != "#")
            {
                data = streamReader.ReadLine();
                Console.WriteLine(data);
            }

            streamReader.Close();
            fileStream.Close();
        }
        static void CreateBinaryFile()
        {
            FileStream fileStream = new FileStream(@"D:\AbinashMishra\Day5October15\MyFiles\letterBinary.txt", FileMode.Create, FileAccess.Write);
            BinaryWriter binaryWrite = new BinaryWriter(fileStream);

            int ecode = 101;
            string name = "Hello There";
            int salary = 1200;
            int did = 101;


            binaryWrite.Write(ecode);
            binaryWrite.Write(name);
            binaryWrite.Write(salary);
            binaryWrite.Write(did);

            binaryWrite.Close();
            fileStream.Close();
        }


        static void ReadBinaryFile()
        {
            FileStream fileStream = new FileStream(@"D:\AbinashMishra\Day5October15\MyFiles\letterBinary.txt", FileMode.Open, FileAccess.Read);
            BinaryReader binaryReader = new BinaryReader(fileStream);
            
            int ecode = binaryReader.ReadInt32();
            string ename = binaryReader.ReadString();
            int salary = binaryReader.ReadInt32();
            int did = binaryReader.ReadInt32();

            Console.WriteLine(ecode + "\n" + ename + "\n" + salary + "\n" + did);
        }
    }


    
}
