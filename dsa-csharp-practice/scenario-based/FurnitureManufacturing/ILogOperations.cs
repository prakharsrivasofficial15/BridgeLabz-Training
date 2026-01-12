using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgelabzTraining.senario_based.Wooden_Rod_System
{
    internal interface ILogOperations
    {
        woodlog[] ReadLogsFromUser();
        woodlog[] FindOptimalLogs(woodlog[] logs, int rodLength, double allowedWaste);
    }

}
