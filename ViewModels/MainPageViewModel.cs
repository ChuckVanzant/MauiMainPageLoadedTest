using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace MauiMainPageLoadedTest.ViewModels;

public partial class MainPageViewModel : ObservableObject, IViewModel
{
    private bool MainPageInitialized;

    public MainPageViewModel()
    {
        Debug.WriteLine($"MainPageViewModel initialized");
    }

    [ObservableProperty]
    public bool degFChecked;

    [ObservableProperty]
    public bool degCChecked;


    [RelayCommand]
    public async Task MainPageLoaded()
    {

        if (!MainPageInitialized)
        {
            MainPageInitialized = true;
            await Task.Delay(TimeSpan.FromMilliseconds(1000));
        }

        Debug.WriteLine($"MainPageLoaded initialized: {MainPageInitialized}");
    }

    [RelayCommand]
    public void ChangeTrackData(string arg)
    {
        Debug.WriteLine($"ChangeTrackData: {arg}  DegFChecked: {DegFChecked}  DegCChecked: {DegCChecked} ");
    }
}
