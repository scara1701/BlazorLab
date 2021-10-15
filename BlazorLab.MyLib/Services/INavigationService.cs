using BlazorLab.MyLib.Models;

namespace BlazorLab.MyLib.Services
{
    /// <summary>
    /// Interface for navigation commands in UI
    /// </summary>
    public interface INavigationService
    {
        void Navigate(ApplicationPage sourcePage);
        void GoBack();
    }
}
