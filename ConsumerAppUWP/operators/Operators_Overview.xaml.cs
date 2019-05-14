using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using ConsumerAppUWP.ViewModels;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace ConsumerAppUWP.operators
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Operators_Overview : Page
    {
        private ObservableCollection<NavigationItem> menu = new ObservableCollection<NavigationItem>();

        public Operators_Overview()
        {
            this.InitializeComponent();
            this.Loaded += MainPage_Loaded;
        }
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            menu.Clear();
            menu.Add(new NavigationItem { PageLink = typeof(MainPage), MenuText = typeof(MainPage).Name, MenuIcon = "K2" });
            menu.Add(new NavigationItem { PageLink = typeof(MainPage), MenuText = typeof(MainPage).Name, MenuIcon = "K3" });
            menu.Add(new NavigationItem { PageLink = typeof(MainPage), MenuText = typeof(MainPage).Name, MenuIcon = "K4" });
            menu.Add(new NavigationItem { PageLink = typeof(MainPage), MenuText = typeof(MainPage).Name, MenuIcon = "K5" });
            menu.Add(new NavigationItem { PageLink = typeof(MainPage), MenuText = typeof(MainPage).Name, MenuIcon = "K6" });
            menu.Add(new NavigationItem { PageLink = typeof(MainPage), MenuText = typeof(MainPage).Name, MenuIcon = "K7" });
            menu.Add(new NavigationItem { PageLink = typeof(MainPage), MenuText = typeof(MainPage).Name, MenuIcon = "K8" });
            menu.Add(new NavigationItem { PageLink = typeof(MainPage), MenuText = typeof(MainPage).Name, MenuIcon = "K11" });
            menu.Add(new NavigationItem { PageLink = typeof(MainPage), MenuText = typeof(MainPage).Name, MenuIcon = "K12" });
        }

        private void MainPage_Loaded(object sender, RoutedEventArgs e)
        {
            listmenu.SelectedIndex = 0;
        }

        private void Button_Click_Pane(object sender, RoutedEventArgs e)
        {
            this.RootSpiltView.IsPaneOpen = !this.RootSpiltView.IsPaneOpen;
        }

        private void Button_Click_Back(object sender, RoutedEventArgs e)
        {
            if (splitviewContent.CanGoBack)
            {
                splitviewContent.GoBack();
            }
        }

        private void ListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var naviitem = listmenu.SelectedItem as NavigationItem;
            splitviewContent.Navigate(naviitem.PageLink);
        }

        private void splitviewContent_Navigated(object sender, NavigationEventArgs e)
        {
            var page = splitviewContent.CurrentSourcePageType.Name;
            switch (page)
            {
                case "Page1":
                    listmenu.SelectedIndex = 0;
                    break;

                case "Page2":
                    listmenu.SelectedIndex = 1;
                    break;

                case "Page3":
                    listmenu.SelectedIndex = 2;
                    break;

                case "Page4":
                    listmenu.SelectedIndex = 3;
                    break;

                case "Page5":
                    listmenu.SelectedIndex = 3;
                    break;

                case "Page6":
                    listmenu.SelectedIndex = 3;
                    break;

                case "Page7":
                    listmenu.SelectedIndex = 3;
                    break;

                case "Page8":
                    listmenu.SelectedIndex = 3;
                    break;

                case "Page9":
                    listmenu.SelectedIndex = 3;
                    break;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MainPage), null);
        }
    }
}
