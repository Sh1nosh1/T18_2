using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace T18_2
{
    /// <summary>
    /// Abstract class (document handler)
    /// </summary>
    abstract class AbstractHandler
    {
        /// <summary>
        /// Abstract method to open document
        /// </summary>
        public abstract void Open();
        /// <summary>
        /// Abctract method to create document
        /// </summary>
        public abstract void Create();
        /// <summary>
        /// Abctract method to change document
        /// </summary>
        public abstract void Change();
        /// <summary>
        /// Abctract method to save document
        /// </summary>
        public abstract void Save();

    }
}
