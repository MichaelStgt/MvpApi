﻿using System.Collections.Generic;
using System.Threading.Tasks;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Navigation;
using MvpApi.Common.Models;
using MvpApi.Uwp.Views;
using Template10.Common;

namespace MvpApi.Uwp.ViewModels
{
    public class ProfilePageViewModel : PageViewModelBase
    {
        #region Fields
        
        #endregion

        public ProfilePageViewModel()
        {
            
        }

        #region Properties

        public ProfileViewModel Mvp => (App.ShellPage.DataContext as ShellPageViewModel)?.Mvp;

        public string ProfileImagePath => (App.ShellPage.DataContext as ShellPageViewModel)?.ProfileImagePath;

        #endregion

        #region Event Handlers

        public void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            BootStrapper.Current.NavigationService.Navigate(typeof(LoginPage));
        }

        public void LogoutButton_Click(object sender, RoutedEventArgs e)
        {
            // Passing a bool true parameter performs logout
            BootStrapper.Current.NavigationService.Navigate(typeof(LoginPage), true);
        }

        #endregion
        
        #region Navigation

        public override async Task OnNavigatedToAsync(object parameter, NavigationMode mode, IDictionary<string, object> state)
        {
            if (App.ShellPage.DataContext is ShellPageViewModel shellVm && shellVm.IsLoggedIn)
            {

            }
            else
            {
                await NavigationService.NavigateAsync(typeof(LoginPage));
            }
        }

        public override Task OnNavigatedFromAsync(IDictionary<string, object> pageState, bool suspending)
        {
            return base.OnNavigatedFromAsync(pageState, suspending);
        }

        #endregion
    }
}
