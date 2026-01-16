using System;

namespace csharpProject_BridgeLabz.senario_based_questions.Browers_History
{
    internal class BrowserUtility: ITab
    {
        private List<Tab> opened = new List<Tab>();
        private Stack<Tab> closed = new Stack<Tab>();
        private Tab currentTab;
        private int tabCount =1;

        public void OpenTab()
        {
            Tab t = new Tab(tabCount++);
            opened.Add(t);
            currentTab = t;
            Console.WriteLine("Opened a tab with Id "+t.GettabId());
        }
        public void CloseTab()
        {
            if(currentTab !=null)
            {
                Console.WriteLine("No tabs opened");
                return;
            }

            opened.Remove(currentTab);
            closed.Push(currentTab);
            Console.WriteLine("Closed Tab with Id "+ currentTab.GettabId());

            if(opened.Count>0)
            {
                currentTab = opened[tabCount-1];
            }
            else
            {
                currentTab = null;
            }
        }

        public void RestoreTab(){
            if(closed.Count ==0)
            {
                Console.WriteLine("No removed tabs");
                return;
            }
            Tab t = closed.Pop();
            opened.Add(t);
            currentTab = t;

            Console.WriteLine("Current opened a restored tab with Id "+currentTab.GettabId());
        }

        public void VisitPage(string url)
        {
            if(currentTab == null)
            {
                Console.WriteLine("No tabs opened");
            }

            currentTab.GetHistory().Visit(url);
            Console.WriteLine("You are on "+url);
        }

        public void BackPage()
        {
            if(currentTab == null)
            {
                Console.WriteLine("No tabs opened");
            }

            currentTab.GetHistory().Back();
        }

        public void ForwardPage()
        {
            if(currentTab == null)
            {
                Console.WriteLine("No tabs opened");
            }

            currentTab.GetHistory().Forward();
        }

        public bool HasActiveTab()
        {
            return currentTab != null;
        }
    }
}