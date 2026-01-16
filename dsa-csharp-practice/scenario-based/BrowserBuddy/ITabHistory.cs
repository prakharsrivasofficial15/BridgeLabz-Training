using System;

namespace csharpProject_BridgeLabz.senario_based_questions.Browers_History
{
    internal interface ITabHistroy
    {
        void Visit(string url);
        void Back();
        void Forward();
        void CurrentPage();
    }
}
