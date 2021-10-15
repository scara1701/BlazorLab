using BlazorLab.MyLib.Models;
using BlazorLab.MyLib.ViewModels;
using System.Threading.Tasks;

namespace BlazorLab.MyLib.Services
{
    /// <summary>
    /// Interface for dialog popups
    /// </summary>
    public interface IDialogService
    {
        /// <summary>
        /// Shows a messagebox
        /// </summary>
        /// <param name="uIPopupMessage"></param>
        /// <returns></returns>
        Task ShowMessage(UIPopupMessage uIPopupMessage);
        /// <summary>
        /// Shows openfiledialog
        /// </summary>
        /// <param name="uIPopupOpenFile"></param>
        /// <returns>Path of selected file</returns>
        Task<string> SelectFile(UIPopupOpenFile uIPopupOpenFile);
        /// <summary>
        /// Shows dialog for object selection
        /// </summary>
        /// <param name="selectObjectViewModel"></param>
        /// <returns>Selected object</returns>
        Task<object> GetObject(SelectObjectViewModel selectObjectViewModel);
    }
}
