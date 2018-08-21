using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _4_FileParser
{
    public class Parser
    {
        string path;

        public string Path { get => path; set => path = value; }

        public Parser(string path)
        {
            Path = path;
        }
        public string GetText()
        {
            StreamReader sr = new StreamReader(path);
            string filetext = sr.ReadToEnd();
            sr.Close();
            return filetext;
        }
        public int CountSubstring(string str)
        {
            string filetext = GetText();
            int amount = new Regex(str).Matches(filetext).Count;
            return amount;
        }

        public void ReplaceString(string original, string newstring)
        {
            string filetext = GetText();
            string newtext = filetext.Replace(original, newstring);
            
            StreamWriter sw = new StreamWriter(path);
            sw.Write(newtext);
            sw.Close();
            Console.WriteLine("Replacing completed!");
        }
    }

}
