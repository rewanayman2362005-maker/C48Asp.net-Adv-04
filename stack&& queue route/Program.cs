using System.Diagnostics.Metrics;

namespace stack___queue_route
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 1. Print the queue contents and Count 
            //Queue<string> documents = new Queue<string>();
            //documents.Enqueue("Report.pdf");
            //documents.Enqueue("Invoice.pdf");
            //documents.Enqueue("Letter.docx");
            //documents.Enqueue("Resume.pdf");
            //documents.Enqueue( "Photo.jpg");
            //foreach (var document in documents)
            //{
            //    Console.WriteLine(document);
            //}
            //Console.WriteLine("Count: {0}", documents.Count);
            #endregion
            #region 2. Use Peek to see which document will print next (without removing)
            //Queue<string> documents = new Queue<string>();
            //documents.Enqueue("Report.pdf");
            //documents.Enqueue("Invoice.pdf");
            //documents.Enqueue("Letter.docx");
            //documents.Enqueue("Resume.pdf");
            //documents.Enqueue("Photo.jpg");

            //Console.WriteLine("Next document to print: {0}", documents.Peek());
            #endregion
            #region  3. Process the queue: Dequeue each document and print "Printing: [name]"
            //Console.WriteLine("\nProcessing Queue:");
            //Queue<string> documents = new Queue<string>();
            //documents.Enqueue("Report.pdf");
            //documents.Enqueue("Invoice.pdf");
            //documents.Enqueue("Letter.docx");
            //documents.Enqueue("Resume.pdf");
            //documents.Enqueue("Photo.jpg");
            //while (documents.Count > 0)
            //{
            //    string document = documents.Dequeue();
            //    Console.WriteLine("Printing: " + document);
   
            //}
            #endregion
        }
    }
}
