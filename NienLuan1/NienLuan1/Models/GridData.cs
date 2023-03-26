using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Xml.Linq;

namespace NienLuan1.Models
{
    public class GridData
    {
        public string[] Monday;
        public string[] Tuesday;
        public string[] Wednesday;
        public string[] Thursday;
        public string[] Friday;
        public string[] Saturday;
        public string[] Sunday;
        public Shift[] Shift;
        public GridData()
        {
            Monday = new string[10];
            Tuesday = new string[10];
            Wednesday = new string[10];
            Thursday = new string[10];
            Friday = new string[10];
            Saturday = new string[10];
            Sunday = new string[10];
            Shift = new Shift[10];
        }
        public GridData(GridData gridData)
        {
            Monday = new string[10];
            Tuesday = new string[10];
            Wednesday = new string[10];
            Thursday = new string[10];
            Friday = new string[10];
            Saturday = new string[10];
            Sunday = new string[10];
            Shift = new Shift[10];
            gridData.Monday?.CopyTo(Monday, 0);
            gridData.Tuesday?.CopyTo(Tuesday, 0);
            gridData.Wednesday?.CopyTo(Wednesday, 0);
            gridData.Thursday?.CopyTo(Thursday, 0);
            gridData.Friday?.CopyTo(Friday, 0);
            gridData.Saturday?.CopyTo(Saturday, 0);
            gridData.Sunday?.CopyTo(Sunday, 0);
            gridData.Shift?.CopyTo(Shift, 0);
        }
    }
    
}
