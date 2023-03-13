using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using JustFeyn.Ui.Models.Concepts;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net.Http.Headers;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace JustFeyn.Ui.ViewModels.Study
{
    public partial class VideoStudyViewModel : ObservableObject
    {
        protected readonly IFilePicker _filePicker;

        public VideoStudyViewModel(IFilePicker filePicker)
        {
            _filePicker = filePicker;
        }

        [ObservableProperty]
        private ObservableCollection<Concept> _concepts = new ObservableCollection<Concept>()
        {
            new VideoBasedConcept() { Prompt = "What is Cross Entropy Loss?" },
            new VideoBasedConcept() { Prompt = "What is Per-word Cross Entropy Loss?" }
        };  

        [RelayCommand]
        private async Task SelectVideo()
        {
            var filePath = await _filePicker.PickAsync(new PickOptions() { FileTypes = FilePickerFileType.Videos });


        }
    }
}
