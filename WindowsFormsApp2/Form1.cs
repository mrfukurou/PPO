using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Globalization;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public List<Tour> tour = new List<Tour>();
        public Function Fn = new Function();
        public List<TextBox> List_Text_Box = new List<TextBox>();

        public Form1()
        {
            InitializeComponent();
            List_Text_Box.Add(City_dpt);
            List_Text_Box.Add(Country);
            List_Text_Box.Add(Name);
            List_Text_Box.Add(Price);
            List_Text_Box.Add(Date);
            List_Text_Box.Add(Night);


        }

        private void Form1_Load(object sender, EventArgs e)
        {

            // TODO: данная строка кода позволяет загрузить данные в таблицу "tiuDataSet1.Tours". При необходимости она может быть перемещена или удалена.
            this.toursTableAdapter.Fill(this.tiuDataSet2.Tours);
            Fn.data_recover(this.TuiTour, this.tour);
            Fn.update(this.TuiTour, this.tour);


        }

        private void save_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Сохранить изменения?",
                "Сохранение",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2);
            if (dr == DialogResult.OK)
            {
                this.Validate();
                this.toursBindingSource.EndEdit();
                this.toursTableAdapter.Update(this.tiuDataSet2.Tours);
                tiuDataSet2.Tables[0].AcceptChanges();
                TuiTour.Refresh();
                Fn.update(this.TuiTour, this.tour);

            }

        }

        private void delete_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Удалить запись?",
                "Удаление",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2);
            if (dr == DialogResult.OK) Fn.delete(this.TuiTour, this.tour);

        }
        private void button_off()
        {
            save_change.Enabled = false;
            cancel.Enabled = false;
            add.Enabled = false;
            City_dpt.Enabled = false;
            Country.Enabled = false;
            Name.Enabled = false;
            Price.Enabled = false;
            Date.Enabled = false;
            Night.Enabled = false;
        }
        private void button_on()
        {
            save_change.Enabled = true;
            cancel.Enabled = true;
            add.Enabled = true;
            City_dpt.Enabled = true;
            Country.Enabled = true;
            Name.Enabled = true;
            Price.Enabled = true;
            Date.Enabled = true;
            Night.Enabled = true;
        }

        private void change_Click(object sender, EventArgs e)
        {
            button_on();
        }

        private void TuiTour_SelectionChanged(object sender, EventArgs e)
        {
            button_off();
            foreach (DataGridViewRow row in TuiTour.SelectedRows)
            {
                Fn.Show(List_Text_Box, row);

            }

        }

        private void save_change_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Изменить запись?",
                "Изменение",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2);
            if (dr == DialogResult.OK)
            {
                foreach (DataGridViewRow row in TuiTour.SelectedRows)
                {
                    Fn.edit(List_Text_Box, row);
                }
                this.Validate();
                this.toursBindingSource.EndEdit();
                this.toursTableAdapter.Update(this.tiuDataSet2.Tours);
                tiuDataSet2.Tables[0].AcceptChanges();
                TuiTour.Refresh();
                Fn.update(this.TuiTour, this.tour);

            }

        }

        private void cancel_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Отменить изменения?",
                "Изменение",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2);
            if (dr == DialogResult.OK)
            {
                foreach (DataGridViewRow row in TuiTour.SelectedRows)
                    Fn.Show(List_Text_Box, row);
            }

        }

        private void add_Click(object sender, EventArgs e)
        {
            if (City_dpt.Text != "" &&Country.Text != "" && Name.Text != "" && Price.Text != "" && Date.Text != "" && Night.Text != "")
            {
                DialogResult dr = MessageBox.Show("Добавить запись?",
                "Добавление",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2);
                if (dr == DialogResult.OK)
                {
                    bool flag = false;
                    for (int i = 0; i < tour.Count; i++)
                    {
                        if (City_dpt.Text == tour[i].City && Country.Text == tour[i].Country1 && Name.Text == tour[i].Name1 && Price.Text == tour[i].Price1 &&Date.Text == tour[i].dateofdep.ToString() && Night.Text == tour[i].numberofnights)
                        {
                            flag = true;
                        }
                    }
                    if (!flag)
                    {
                        this.Validate();
                        this.toursBindingSource.EndEdit();
                        DataRow nRow = tiuDataSet2.Tables[0].NewRow();
                        nRow["Город  отправления"] = City_dpt.Text.ToString();
                        nRow["Страна назначения"] = Country.Text.ToString();
                        nRow["Название тура"] = Name.Text.ToString();
                        CultureInfo MyCultureInfo = new CultureInfo("en-US");
                        nRow["Стоимость"] = Price.Text.ToString();
                        nRow["Дата вылета"] = DateTime.ParseExact(Date.Text.ToString(), "dd.M.yyyy", MyCultureInfo);
                        nRow["Количество ночей"] = Night.Text.ToString();

                        tiuDataSet2.Tables[0].Rows.Add(nRow);
                        toursTableAdapter.Update(tiuDataSet2.Tours);
                        tiuDataSet2.Tables[0].AcceptChanges();
                        TuiTour.Refresh();
                        Fn.update(this.TuiTour, this.tour);

                        City_dpt.Clear();
                        Country.Clear();
                        Name.Clear();
                        Price.Clear();
                        Date.Clear();
                        Night.Clear();
                    }
                    if (flag)
                    {
                        DialogResult er = MessageBox.Show("Такая запись уже существует!",
                            "Добавление",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning,
                            MessageBoxDefaultButton.Button1);
                    }
                }
            }
            else
            {
                DialogResult dr = MessageBox.Show("Некорректный ввод! Поля пусты.",
                "Добавление",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information,
                MessageBoxDefaultButton.Button1);
            }


        }

        private void Search_bt_Click(object sender, EventArgs e)
        {
            if (Search.Text.Length == 0) Search.Text = "Вы не ввели параметр для поиска";
            else
            {
                List<Tour> find = new List<Tour>();
                find = Fn.find_Country(this.tour, Search.Text);
                if (find.Count == 0)
                {
                    DialogResult dr = MessageBox.Show("Записи не найдены",
                    "Поиск",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning,
                    MessageBoxDefaultButton.Button1);
                }
                else
                {
                    search_results.BringToFront();
                    search_results.DataSource = find;
                }
            }

        }

        private void reset_Click(object sender, EventArgs e)
        {
            TuiTour.BringToFront();
            Search.Clear();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in TuiTour.SelectedRows)
            {
                row.Selected = false;
            }
            City_dpt.Clear(); Country.Clear(); Name.Clear(); Price.Clear(); Date.Clear();
            Night.Clear();
        }

        private void search_results_SelectionChanged(object sender, EventArgs e)
        {
            button_off();
            foreach (DataGridViewRow row in search_results.SelectedRows)
            {
                Function.Show_Search_result(List_Text_Box, row);
                foreach (DataGridViewRow Drow in TuiTour.Rows)
                {
                    if (row.Cells["City"].Value.ToString() == Drow.Cells["City_1"].Value.ToString() && row.Cells["Country1"].Value.ToString() == Drow.Cells["Country_1"].Value.ToString() && row.Cells["Name1"].Value.ToString() == Drow.Cells["Name_1"].Value.ToString() && row.Cells["Price1"].Value.ToString() == Drow.Cells["Price_1"].Value.ToString() && row.Cells["dateofdep"].Value.ToString() == Drow.Cells["Date_1"].Value.ToString() && row.Cells["numberofnights"].Value.ToString() == Drow.Cells["Night_1"].Value.ToString())
                    {
                        foreach (DataGridViewRow Drow2 in TuiTour.SelectedRows)
                        {

                            Drow2.Selected = false;
                        }
                        Drow.Selected = true;
                    }
                }
            }
        }
    }
}

