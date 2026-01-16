using System;

namespace csharpProject_BridgeLabz.senario_based_questions.Browers_History
{
    internal interface ITab
    {
        void OpenTab();
        void CloseTab();
        void RestoreTab();
        void VisitPage(string url);
        void BackPage();
        void ForwardPage();
        bool HasActiveTab();
    }
}