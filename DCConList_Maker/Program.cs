using System.IO;
using System.Collections.Generic;

namespace DCConList_Maker
{
    class Program
    {
        static public string dcConListHeadWords = "dcConsData = [";
        static public string dcConListTailWords = "]";

        static void Main(string[] args)
        {
            string targetDirectory = System.Console.ReadLine();

            StreamWriter writer;
            FileStream fs;

            if (!File.Exists(targetDirectory + "/dccon_list.js"))
            {
                fs = File.Create(targetDirectory + "/dccon_list.js");
                writer = new StreamWriter(fs);
            }
            else {
                writer = new StreamWriter(targetDirectory + "/dccon_list.js");
            }

            
            writer.Write(dcConListHeadWords);

            DirectoryInfo directoryInfo = new DirectoryInfo(targetDirectory);

            FileInfo[] fileList = directoryInfo.GetFiles();
            foreach (FileInfo file in fileList)
            {
                if (file != fileList[fileList.Length - 1])
                    writer.WriteLine("{name:\"" + file.Name + "\", keywords:[\"" + file.Name.Split('.')[0] + "\"], tags:[\"\"]},");
                else
                {
                    writer.WriteLine("{name:\"" + file.Name + "\", keywords:[\"" + file.Name.Split('.')[0] + "\"], tags:[\"\"]}" + dcConListTailWords);
                }
            }
            writer.Close();
        }
    }
}
