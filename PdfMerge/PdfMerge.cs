using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using org.pdfclown.documents;
using org.pdfclown.files;
using org.pdfclown.objects;
using org.pdfclown.tools;

namespace PdfMerge
{
    class PdfMerge
    {
        static void Main(string[] args)
        {
            // Opening the PDF file...
            string mainFilePath = args[1];
            using (File mainFile = new File(mainFilePath))
            {
                Document mainDocument = mainFile.Document;
                Pages mainPages = mainDocument.Pages;
                int mainPagesCount = mainPages.Count;

                // Opening the source file...
                string sourceFilePath = args[1];
                using (File sourceFile = new File(sourceFilePath))
                {
                    // Append the chosen source document to the main document!
                    new PageManager(mainDocument).Add(sourceFile.Document);
                }
              

                try
                { file.Save(outputFilePath, SerializationModeEnum.Standard); }
                catch (Exception e)
                {
                    Console.WriteLine("File writing failed: " + e.Message);
                    Console.WriteLine(e.StackTrace);
                }
                Console.WriteLine("\nOutput: " + outputFilePath);


            }
        }

        
    }
}
