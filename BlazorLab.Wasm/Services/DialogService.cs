using BlazorLab.MyLib.Models;
using BlazorLab.MyLib.Services;
using BlazorLab.MyLib.ViewModels;
using System;
using System.Threading.Tasks;

namespace BlazorLab.Wasm.Services
{
    public class DialogService : IDialogService
    {
        public Task<object> GetObject(SelectObjectViewModel selectObjectViewModel)
        {
            throw new NotImplementedException();
        }

        public Task<string> SelectFile(UIPopupOpenFile uIPopupOpenFile)
        {
            throw new NotImplementedException();
        }

        public Task ShowMessage(UIPopupMessage uIPopupMessage)
        {
            throw new NotImplementedException();
        }
    }
}
