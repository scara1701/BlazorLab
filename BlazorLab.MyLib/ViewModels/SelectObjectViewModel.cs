using Microsoft.Toolkit.Mvvm.Input;
using System;
using System.Collections.Generic;

namespace BlazorLab.MyLib.ViewModels
{
    public class SelectObjectViewModel : BaseViewModel
	{
		public Action CloseAction { get; set; }
		public RelayCommand CloseCommandButton { get; set; }

		private object selectedObject;

		public object SelectedObject
		{
			get { return selectedObject; }
			set
			{
				selectedObject = value;
				OnPropertyChanged(nameof(SelectedObject));
			}
		}
		private object selectedObjectInList;

		public object SelectedObjectInList
		{
			get { return selectedObjectInList; }
			set
			{
				selectedObjectInList = value;
				OnPropertyChanged(nameof(SelectedObjectInList));
			}
		}

		private List<string> stringList;

		public List<string> StringList
		{
			get { return stringList; }
			set
			{
				stringList = value;
				OnPropertyChanged(nameof(stringList));
			}
		}

		public SelectObjectViewModel()
		{
			StringList = new List<string>();
			StringList.Add("Option 1");
			StringList.Add("Option 2");
			StringList.Add("Option 3");
			StringList.Add("Option 4");
			StringList.Add("Option 5");
			CloseCommandButton = new RelayCommand(() => CloseCommand());
		}

		private void CloseCommand()
		{
			SelectedObject = SelectedObjectInList;
			CloseAction();
		}
	}
}
