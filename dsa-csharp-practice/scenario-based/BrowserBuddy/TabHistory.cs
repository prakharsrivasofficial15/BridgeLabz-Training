using System;

namespace csharpProject_BridgeLabz.senario_based_questions.Browers_History
{
    internal class TabHistory:ITabHistroy
    {
        protected HistoryNode head;
        protected HistoryNode current;

        public void Visit(string url)
        {
            HistoryNode newNode = new HistoryNode(url);

            if (head == null){
                head = newNode;
                current = newNode;
                return ;
            }

            current.Next = null;
            newNode.Prev = current;
            current.Next = newNode;
            current = newNode;
        }

        public void Back()
        {
            if(current !=null && current.Prev !=null)
            {
                current = current.Prev;
                Console.WriteLine("Back to "+ current.Geturl());
            }
            else
            {
                Console.WriteLine("No previous page");
            }
        }

        public void Forward()
        {
            if(current!= null && current.Next != null){
                current  = current.Next;
                Console.WriteLine("ON to "+ current.Geturl());
            }
            else{
                Console.WriteLine("No Next Page");
            }
        }

        public void CurrentPage()
        {
            if(current != null)
            {
                Console.WriteLine("Current page is "+ current.Geturl());
            }
            else
            {
                Console.WriteLine("No Page opened");
            }
        }
    }
}