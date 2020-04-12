using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public class Function
    {
        public void data_recover(DataGridView table, List<Tour> tu)
        {
            int count = 0;
            foreach (DataGridViewRow row in table.Rows)
            {
                Tour t = new Tour();
                t.ToTour(row);
                tu.Add(t);
                tu.Insert(count, t);
                count++;
            }
        }
        public void edit(List<TextBox> lst, DataGridViewRow row)
        {
            row.Cells["City_1"].Value = lst[0].Text;
            row.Cells["Country_1"].Value = lst[1].Text;
            row.Cells["Name_1"].Value = lst[2].Text;
            row.Cells["Price_1"].Value = lst[3].Text;
            row.Cells["Date_1"].Value = lst[4].Text;
            row.Cells["Night_1"].Value = lst[5].Text;
        }
        public void update(DataGridView a, List<Tour> l)
        {
            l.Clear();
            foreach (DataGridViewRow row in a.Rows)
            {
                Tour buf = new Tour();
                buf.ToTour(row);
                l.Add(buf);
            }
        }
        public void delete(DataGridView a, List<Tour> l)
        {
            Tour buf = new Tour();
            foreach (DataGridViewRow row in a.SelectedRows)
            {
                a.Rows.Remove(row);
            }
            this.update(a, l);
        }
        public List<Tour> find_Country(List<Tour> l, string s)
        {
            List<Tour> find = new List<Tour>();
            foreach (Tour tur in l)
            {
                if (tur.Country1.Contains(s))
                {
                    find.Add(tur);
                }
            }
            return find;
        }
        public void Show(List<TextBox> f, DataGridViewRow row)
        {
            f[0].Text = row.Cells["City_1"].Value.ToString();
            f[1].Text = row.Cells["Country_1"].Value.ToString();
            f[2].Text = row.Cells["Name_1"].Value.ToString();
            f[3].Text = row.Cells["Price_1"].Value.ToString();
            f[4].Text = row.Cells["Date_1"].Value.ToString();
            f[5].Text = row.Cells["Night_1"].Value.ToString();
        }
        public static void Show_Search_result(List<TextBox> f, DataGridViewRow row)
        {
            f[0].Text = row.Cells["City"].Value.ToString();
            f[1].Text = row.Cells["Country1"].Value.ToString();
            f[2].Text = row.Cells["Name1"].Value.ToString();
            f[3].Text = row.Cells["Price1"].Value.ToString();
            f[4].Text = row.Cells["dateofdep"].Value.ToString();
            f[5].Text = row.Cells["numberofnights"].Value.ToString();
         }
    }
}
