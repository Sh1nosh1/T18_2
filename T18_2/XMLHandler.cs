using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace T18_2
{
    /// <summary>
    /// Production class XMLHandler from AbstractHandler
    /// </summary>
    class XMLHandler : AbstractHandler
    {
        /// <summary>
        /// Overriden methods from AbstractHandler in XMLHandler
        /// </summary>
        public override void Open() => WriteLine("Open document format - XML");
        public override void Create() => WriteLine("Create document format - XML");
        public override void Change() => WriteLine("Change document format - XML");
        public override void Save() => Write("Save document format - XML");
    }
}
