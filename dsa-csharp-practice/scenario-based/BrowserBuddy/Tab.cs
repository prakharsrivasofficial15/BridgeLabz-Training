using System;

namespace csharpProject_BridgeLabz.senario_based_questions.Browers_History
{
    internal class Tab
    {
        private int tabId;
        private TabHistory history;

        public Tab(int Id)
        {
            this.tabId = Id;
            history = new TabHistory();
        }

        public int GettabId(){return tabId;}
        public TabHistory GetHistory(){return history;}
    }
}