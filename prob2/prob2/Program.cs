/*
    public class Report
    {
        public string Title {  get; set; }
        public string Content {  get; set; }
    }
    public class ReportPrinter
    {
        public void Print(Report report)
        {
            Console.WriteLine($"{report.Title}  //  {report.Content}");
        }
    }

    public class ReportSaver
    {
        public void SaveToFile(Report report, string path)
        {
            System.IO.File.WriteAllText(path, report.Title);
        }
    }
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace prob2
{
    public class Report
    {
        public string Title { get; set; }
        public string Content { get; set; }
    }

    public interface IReportPrinter
    {
        void Print(Report report);
    }

    public interface IReportSaver
    {
        void Save(Report report, string path);
    }

    public class ConsoleReportPrinter : IReportPrinter
    {
        public void Print(Report report)
        {
            Console.WriteLine($"{report.Title} //  {report.Content}");
        }
    }

    public class FileReportSaver : IReportSaver
    {
        public void Save(Report report, string path)
        {
            File.WriteAllText(path, report.Content);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            var report = new Report
            {
                Title = "Weekly",
                Content = "Content"
            };

            IReportPrinter printer = new ConsoleReportPrinter();
            IReportSaver saver = new FileReportSaver();

            printer.Print(report);
            saver.Save(report, "report.txt");
        }
    }
}
