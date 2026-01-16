using System;

namespace csharpProject_BridgeLabz.senario_based_questions.Browers_History{

    internal class HistoryNode
    {
        private string url;
        public HistoryNode Prev;
        public HistoryNode Next;

        public HistoryNode(string url){
            this.url = url;
            Prev = null;
            Next = null;
        }
        public string Geturl(){return url;}
    }
}