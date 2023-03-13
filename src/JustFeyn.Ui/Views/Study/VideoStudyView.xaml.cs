using JustFeyn.Ui.ViewModels.Study;

namespace JustFeyn.Ui.Views.Study;

public partial class VideoStudyView : ContentPage
{
	public VideoStudyView(VideoStudyViewModel viewModel)
    {
        BindingContext = viewModel;

        InitializeComponent();
	}
}