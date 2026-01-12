using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetalFactoryPipe
{
    internal interface IPipeCut
    {
        PipeCut[] FindBestCut(PipeCut[] availableCuts, int rodLength);
    }
}
