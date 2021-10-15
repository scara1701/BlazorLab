using System;

namespace BlazorLab.MyLib.Models
{
    public class MyObject
    {
        public int ObjectID { get; set; }
        public Guid RandomGuid { get; set; }
        /// <summary>
        /// Object properties are random filled upon creation
        /// </summary>
        public MyObject()
        {
            ObjectID = new Random().Next();
            RandomGuid = Guid.NewGuid();
        }
    }
}
