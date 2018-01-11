using System.IO;
using Aspose.Cells;
using System;

namespace Aspose.Cells.Examples.CSharp.Articles
{
    public class LoadWorkbookWithPrinterSize
    {
        public static void Run() 
        {
            //Output directory
            string outputDir = RunExamples.Get_OutputDirectory();

            // Create a sample workbook and add some data inside the first worksheet
            Workbook workbook = new Workbook();
            Worksheet worksheet = workbook.Worksheets[0];
            worksheet.Cells["P30"].PutValue("This is sample data.");

            // Save the workbook in memory stream
            MemoryStream ms = new MemoryStream();
            workbook.Save(ms, SaveFormat.Xlsx);
            ms.Position = 0;

            // Now load the workbook from memory stream with A5 paper size
            LoadOptions opts = new LoadOptions(LoadFormat.Xlsx);
            opts.SetPaperSize(PaperSizeType.PaperA5);
            workbook = new Workbook(ms, opts);

            // Save the workbook in pdf format
            workbook.Save(outputDir + "outputLoadWorkbookWithPrinterSize-A5.pdf");

            // Now load the workbook again from memory stream with A3 paper size
            ms.Position = 0;
            opts = new LoadOptions(LoadFormat.Xlsx);
            opts.SetPaperSize(PaperSizeType.PaperA3);
            workbook = new Workbook(ms, opts);

            // Save the workbook in pdf format
            workbook.Save(outputDir + "outputLoadWorkbookWithPrinterSize-A3.pdf");

            Console.WriteLine("LoadWorkbookWithPrinterSize executed successfully.");
        }
    }
}
