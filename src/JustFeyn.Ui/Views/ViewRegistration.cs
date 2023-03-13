using JustFeyn.Ui.Views.Study;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JustFeyn.Ui.Views
{
    public static class ViewRegistration
    {
        public static void RegisterViews(this MauiAppBuilder builder)
            => builder.Services.RegisterViews();

        public static void RegisterViews(this IServiceCollection collection)
        {
            var views = typeof(ViewRegistration).Assembly.GetTypes().Where(t => t.Name.EndsWith("View"));
            foreach  (var view in views)
            {
                collection.AddTransient(view);
            }
        }
    }
}
