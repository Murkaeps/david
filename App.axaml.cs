using Avalonia;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Markup.Xaml;
using AvaloniaApplication13.Repositories;
using AvaloniaApplication13.Services;
using AvaloniaApplication13.ViewModels;
using AvaloniaApplication13.Views;
using Microsoft.Extensions.DependencyInjection;

namespace AvaloniaApplication13;

public partial class App : Application
{
    public override void Initialize()
    {
        AvaloniaXamlLoader.Load(this);
    }

    public override void OnFrameworkInitializationCompleted()
    {
        var service = new ServiceCollection();
        service.AddDbContextFactory<AppDbContext>();
        service.AddTransient<INoteRepository, NoteRepository>();
        service.AddTransient<INoteService, NoteService>();
        service.AddTransient<MainViewModel>();

        var provide = service.BuildServiceProvider();

        if (ApplicationLifetime is IClassicDesktopStyleApplicationLifetime desktop)
        {
            desktop.MainWindow = new MainWindow
            {
                DataContext = provide.GetRequiredService<MainViewModel>()
            };
        }

        base.OnFrameworkInitializationCompleted();
    }
}