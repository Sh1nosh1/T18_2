using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace T18_2
{
    /// <summary>
    /// Product class DOCHandler from AbstractHandler
    /// </summary>
    class DOCHandler : AbstractHandler
    {
        /// <summary>
        /// Overriden methods from AbstractHandler in DOCHandler
        /// </summary>
        public override void Open() => WriteLine("Open document format - DOC");
        public override void Create() => WriteLine("Create document format - DOC");
        public override void Change() => WriteLine("Change document format - DOC");
        public override void Save() => Write("Save document format - DOC");
    }
}
