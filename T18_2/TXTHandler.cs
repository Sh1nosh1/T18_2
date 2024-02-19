using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace T18_2
{
    /// <summary>
    /// Product class from AbstractHandler
    /// </summary>
    class TXTHandler : AbstractHandler
    {
        /// <summary>
        /// Overriden methods from AbstractHandler in TXTHandler
        /// </summary>
        public override void Open() => WriteLine("Open document format - TXT");
        public override void Create() => WriteLine("Create document format - TXT");
        public override void Change() => WriteLine("Change document format - TXT");
        public override void Save() => Write("Save document format - TXT");
    }
}
