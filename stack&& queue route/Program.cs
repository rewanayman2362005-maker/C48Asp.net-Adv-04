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
            #region 4. Try TryDequeue on the now-empty queue — what happens?
            //Queue<string> documents = new Queue<string>();
            //documents.Enqueue("Report.pdf");
            //documents.Enqueue("Invoice.pdf");
            //documents.Enqueue("Letter.docx");
            //documents.Enqueue("Resume.pdf");
            //documents.Enqueue("Photo.jpg");
            //if (documents.TryDequeue(out string? result))
            //{
            //    Console.WriteLine("Printing: " + result);
            //}
            //else
            //{
            //    Console.WriteLine("\nTryDequeue: Queue is empty.");
            //}
            #endregion
            #region 1. Push 5 URLs: "google.com", "github.com", "stackoverflow.com", "youtube.c   "claude.ai"
            //Stack<string> browserHistory = new Stack<string>();
            //browserHistory.Push("google.com");
            //browserHistory.Push("github.com");
            //browserHistory.Push("stackoverflow.com");
            //browserHistory.Push("youtube.com");
            //browserHistory.Push("claude.ai");
            #endregion
            #region 2. Use Peek to see the current page (top of stack)
            //Stack<string> browserHistory = new Stack<string>();
            //browserHistory.Push("google.com");
            //browserHistory.Push("github.com");
            //browserHistory.Push("stackoverflow.com");
            //browserHistory.Push("youtube.com");
            //browserHistory.Push("claude.ai");
            //Console.WriteLine("Current page: {0}", browserHistory.Peek());
            #endregion
            #region 3.Press "back" 3 times using Pop — print each page you leave
            ////Stack<string> browserHistory = new Stack<string>();
            ////browserHistory.Push("google.com");
            ////browserHistory.Push("github.com");
            ////browserHistory.Push("stackoverflow.com");
            ////browserHistory.Push("youtube.com");
            ////browserHistory.Push("claude.ai");
            //for (int i = 0; i < 3; i++)
            //{
            //    string page = history.Pop();
            //    Console.WriteLine("Leaving: " + page);
            //}
            #endregion
        }
    }
}
