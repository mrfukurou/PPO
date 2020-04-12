using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public class Tour
    {
        public int code { get; set; }
        public string City { get; set; }
        public string Country1 { get; set; }
        public string Name1 { get; set; }
        public string Price1 { get; set; }
        public DateTime dateofdep { get; set; }
        public string numberofnights { get; set; }
        public Tour() { }
        public void ToTour(DataGridViewRow row)
        {
            this.City = row.Cells["City_1"].Value.ToString();
            this.Country1 = row.Cells["Country_1"].Value.ToString();
            this.Name1 = row.Cells["Name_1"].Value.ToString();
            this.Price1 = row.Cells["Price_1"].Value.ToString();
            this.dateofdep = Convert.ToDateTime(row.Cells["Date_1"].Value);
            this.numberofnights = row.Cells["Night_1"].Value.ToString();
        }
    }
}
