using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JustFeyn.Ui.Models.Concepts
{
    /// <summary> The base model for a concept to be learned </summary>
    public abstract class Concept
    {
        /// <summary> The prompt to be asked to the user for them to recall the answer for </summary>
        public string Prompt { get; set; }
    }
}
