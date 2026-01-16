using System;

namespace csharpProject_BridgeLabz.senario_based_questions.Browers_History
{
    internal class BrowserMenu
    {
        ITab tabs= new BrowserUtility();

        public void BrowserStart()
        {
            bool flag = true;
            while(flag)
            {
                Console.WriteLine("WELCOME TO THE BROWSER");
                Console.WriteLine("1. Open a tab");
                Console.WriteLine("2. Close a tab");
                Console.WriteLine("3. Restore a tab");
                Console.WriteLine("4. Exit");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch(choice)
                {
                    case 1:
                        tabs.OpenTab();
                        TabMenu(tabs);
                        break;
                    case 2:
                        tabs.CloseTab();
                        break;
                    case 3:
                        tabs.RestoreTab();
                        TabMenu(tabs);
                        break;
                    case 4:
                        flag = false;
                        break;
                    default:
                        flag = false;
                        Console.Error.WriteLine("Invalid Input");
                        break; 
                }
            }  
        }

        public void TabMenu(ITab tab)
        {
            if(!tab.HasActiveTab())
            {
                Console.WriteLine("No active tabs");
                return ;
            }
            bool flag  = true;

            while(flag)
            {
                Console.WriteLine("TAB MENU");
                Console.WriteLine("1. Visit Page");
                Console.WriteLine("2. Visit Previous Page");
                Console.WriteLine("3. Visit Next Page");
                Console.WriteLine("4. Exit");

                int choose  = Convert.ToInt32(Console.ReadLine());

                switch(choose)
                {
                    case 1:
                        String url = Console.ReadLine();
                        tab.VisitPage(url);
                        break;
                    case 2:
                        tab.BackPage();
                        break;
                    case 3:
                        tab.ForwardPage();
                        break;
                    case 4:
                        flag = false;
                        break;
                    default:
                        flag = false;
                        Console.Error.WriteLine("Invalid Input");
                        break;
                }
            }
        }
    }  
}