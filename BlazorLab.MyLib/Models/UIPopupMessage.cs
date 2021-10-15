namespace BlazorLab.MyLib.Models
{
    public class UIPopupMessage
    {
        public DialogType DialogType { get; set; }
        public string Title { get; set; }
        public string Message { get; set; }
        public UIPopupMessage(string title, string message, DialogType dialogType)
        {
            DialogType = dialogType;
            Title = title;
            Message = message;
        }
    }
}
