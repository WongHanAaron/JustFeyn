using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace JustFeyn.Ui.Services
{
    public static class ServiceRegistration
    {
        public static void RegisterServices(this MauiAppBuilder builder)
            => builder.Services.RegisterServices();

        public static void RegisterServices(this IServiceCollection collection)
        {
            collection.AddSingleton<IFileSystem>(FileSystem.Current);
            collection.AddSingleton<IFilePicker>(FilePicker.Default);
        }
    }
}
