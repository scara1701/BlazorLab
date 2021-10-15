using BlazorLab.MyLib.Models;
using System;

namespace BlazorLab.MyLib.Services
{
    public class NavigationService : INavigationService
    {

        public void GoBack()
        {
            Navigate(ApplicationPage.MainPage);
        }

        public void Navigate(ApplicationPage sourcePage)
        {
            NavigateEventArgs args = new NavigateEventArgs();
            args.Page = sourcePage;
            OnNavigate(args);
        }

        public event EventHandler<NavigateEventArgs> NavigateEvent;

        protected virtual void OnNavigate(NavigateEventArgs e)
        {
            EventHandler<NavigateEventArgs> handler = NavigateEvent;
            if (handler != null)
            {
                handler(this, e);

            }
        }

        public class NavigateEventArgs : EventArgs
        {
            public ApplicationPage Page { get; set; }
        }
    }
}
