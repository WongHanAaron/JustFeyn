using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JustFeyn.Ui.Models.Concepts
{
    public class VideoBasedConcept : Concept
    {
        /// <summary> The source location for the video concept </summary>
        public string Source { get; set; }

        /// <summary> The start time for when the video resource describes the concept to the user </summary>
        public TimeSpan StartTime { get; set; }
    }
}
