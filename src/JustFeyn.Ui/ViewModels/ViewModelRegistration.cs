using JustFeyn.Ui.ViewModels.Study;
using JustFeyn.Ui.Views.Study;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace JustFeyn.Ui.ViewModels
{
    /// <summary> Registers the view models to the ServiceCollection for the app builder </summary>
    public static class ViewModelRegistration
    {
        /// <summary> Performs the registration on all view models with the maui app builder </summary>
        public static void RegisterViewModels(this MauiAppBuilder builder)
            => builder.Services.RegisterViewModels();

        /// <summary> Performs the registration on all view models on the service collection </summary>
        public static void RegisterViewModels(this IServiceCollection collection)
        {
            collection.AddTransient<VideoStudyViewModel>();
        }
    }
}
