using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HuffMantree
{
    public class node
    {
        private node left = null;
        private node right = null;
        public int weightcount;
        public char now;
        public List<int> code = new List<int>();
    }
    class Program
    {
        static void Main(string[] args)
        {
            System.IO.StreamReader file = new System.IO.StreamReader(@"数据.txt");
            string line;
            Dictionary<char, int> Fre = new Dictionary<char, int>();
            while ((line = file.ReadLine()) != null)
            {
                foreach (char temp in line)
                {
                    if (Fre.ContainsKey(temp)) Fre[temp] += 1;
                    else { Fre.Add(temp, 1); }
                }
            }
            while (Fre.ToArray().Length > 2)
            {

            }
        }
    }
}
