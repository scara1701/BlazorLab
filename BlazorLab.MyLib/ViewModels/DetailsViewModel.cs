using BlazorLab.MyLib.Models;
using BlazorLab.MyLib.Services;
using Microsoft.Toolkit.Mvvm.Input;
using System.Collections.Generic;

namespace BlazorLab.MyLib.ViewModels
{
    public interface IDetailsViewModel
    {
        RelayCommand GoBackCommand { get; set; }
        List<MyObject> TheList { get; }
    }
    public class DetailsViewModel : BaseViewModel, IDetailsViewModel
    {
        IGetNumberService _getNumberService;
        INavigationService _navigationService;
        public RelayCommand GoBackCommand { get; set; }
        public DetailsViewModel()
        {
            _getNumberService = CommunicationService.GetNumberService;
            _navigationService = CommunicationService.NavigationService;
            GoBackCommand = new RelayCommand(() => GoBack());
        }


        public List<MyObject> TheList
        {
            get { return ListService.MyObjects(_getNumberService); }
        }


        private void GoBack()
        {
            _navigationService.GoBack();
        }
    }
}
