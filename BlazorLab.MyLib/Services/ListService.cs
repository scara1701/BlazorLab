using BlazorLab.MyLib.Models;
using System.Collections.Generic;

namespace BlazorLab.MyLib.Services
{
    /// <summary>
    /// Returns a list of a count based upon the number passed from the UI
    /// </summary>
    public static class ListService
    {
        public static List<MyObject> MyObjects(IGetNumberService getNumberService)
        {
            var TheList = new List<MyObject>();
            for (int i = 0; i < getNumberService.GetNumber(); i++)
            {
                TheList.Add(new MyObject());
            }

            return TheList;
        }
    }
}
