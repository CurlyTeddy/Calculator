using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Caculator
{
    /// <summary>
    /// The interface regulates the method that all buttons should implement
    /// </summary>
    public interface IButton
    {
        /// <summary>
        /// The method template
        /// </summary>
        void Execute();
    }
}
