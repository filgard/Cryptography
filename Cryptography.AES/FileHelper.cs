using System;
using System.Collections.Generic;
using System.IO;


namespace Cryptography.AES
{
    public static class FileHelper
    {
        private static List<string> fileContent = new List<string>();

        public static List<string> FileContent
        {
            get { return fileContent; }
        }
        public static void GetKeyMatrix(sbyte[][] w)
        {
            for (int a = 0; a < w[0].Length; a++)
                fileContent.Add("w[" + a + "] = " + string.Join(" ", w[a]));
            fileContent.Add(Environment.NewLine);
        }
        public static void GetMatrixState(sbyte[][] state)
        {
            for (int a = 0; a < state[0].Length; a++)
                fileContent.Add("\t" + string.Join(" ", state[a]));
            fileContent.Add(Environment.NewLine);
        }
        public static void GetDescription(string space, string desciption = null)
        {
            fileContent.Add(string.Format(space, desciption));
        }
        public static void SaveToFile()
        {
            string solutionPath = Path.GetDirectoryName(Path.GetDirectoryName(Directory.GetCurrentDirectory()));
           // File.WriteAllLines(@"D:\Development\Visual Studio 2015\Projects\Cryptography\Cryptography.CClient\AesRegistry.txt", FileHelper.fileContent);
            File.WriteAllLines(string.Concat(solutionPath, "\\AesRegistry.txt"), FileHelper.FileContent);
        }
    }
}
