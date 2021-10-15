namespace BlazorLab.MyLib.Services
{
    public static class CommunicationService
    {
        public static INavigationService NavigationService { get; set; }
        public static IDialogService DialogService { get; set; }
        public static IGetNumberService GetNumberService { get; set; }
    }
}
