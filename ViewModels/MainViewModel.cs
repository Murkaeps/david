using AvaloniaApplication13.Models;
using AvaloniaApplication13.Services;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.ObjectModel;
using System.Threading.Tasks;

namespace AvaloniaApplication13.ViewModels;

public partial class MainViewModel : ViewModelBase
{
    [ObservableProperty]
    private string _title = "";
    [ObservableProperty]
    private string _contet = "";
    [ObservableProperty]
    private Note? _selectedNotes;
    private INoteService noteService;
    private ObservableCollection<Note> Notes = [];

    public MainViewModel(INoteService _ns) 
    { 
        noteService = _ns;
        _ = Load(); 
    }

    private async Task Load()
    {
        Notes.Clear();
        var nts = await noteService.GetAllAsync();
        foreach (var n in nts) Notes.Add(n);
    }


    [RelayCommand] private async Task AddNote()
    {
        await noteService.AddAsync(Title, Contet);
    }

    [RelayCommand] private async Task DeleteAsync()
    {
        if (SelectedNotes == null) return;
        await noteService.DeleteAsync(SelectedNotes);
    }
}
