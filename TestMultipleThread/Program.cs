using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestMultipleThread
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Report report = new Report();
            report.CreateExcelDoc("D:\\test.xlsx");
        }
    }
}