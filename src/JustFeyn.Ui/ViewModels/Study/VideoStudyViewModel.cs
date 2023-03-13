using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JustFeyn.Ui.ViewModels.Study
{
    public class VideoStudyViewModel
    {
        protected readonly IFilePicker _filePicker;

        public VideoStudyViewModel(IFilePicker filePicker)
        {
            _filePicker = filePicker;
        }


    }
}
