/*
public class Report
    {
        public string Title { get; set; }
        public string Content { get; set; }

        public void SaveToFile(string path)
        {
            System.IO.File.WriteAllText(path, Content);
        }

        public void Print()
        {
            Console.WriteLine($"---{Title}---\n{Content}");
        }
    }
*/

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prob1
{
    public class Report
    {
        public string Title { get; set; }
        public string Content { get; set; }
    }

    public class ReportPrinter
    {
        public void Print(Report report)
        {
            Console.WriteLine($"{report.Title} //  {report.Content}");
        }
    }

    public class ReportSaver
    {
        public void SaveToFile(Report report, string path)
        {
            System.IO.File.WriteAllText(path, report.Content);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            var report = new Report { Title = "Monthly Report", Content = "..."};
            var printer = new ReportPrinter();
            var saver = new ReportSaver();

            printer.Print(report);
            saver.SaveToFile(report, "report.txt");
        }
    }
}
