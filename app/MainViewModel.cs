using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace app;

[ObservableObject]
public partial class MainViewModel
{
    [ObservableProperty] 
    int _count = 0;
    [RelayCommand]
    void Hit() => Count++;
}