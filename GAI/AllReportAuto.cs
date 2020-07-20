using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using System.Data.SqlClient;

namespace GAI
{
    public partial class AllReportAuto : Form
    {
        private const string connectionString = "Data Source=DESKTOP-8LERM01\\SQLEXPRESS;Initial Catalog=Gai_policeDB;Integrated Security=True";

        static SqlConnection connection = new SqlConnection(connectionString);

        SqlDataAdapter adapterAuto = new SqlDataAdapter("SELECT * FROM dbo.List_automobiles", connection);
        public AllReportAuto()
        {
            InitializeComponent();
        }

        private void AllReportAuto_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "Gai_policeDBDataSet.OwnerAuto". При необходимости она может быть перемещена или удалена.
            this.ownerAutoTableAdapter.Fill(this.Gai_policeDBDataSet.OwnerAuto);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "Gai_policeDBDataSet.Employee". При необходимости она может быть перемещена или удалена.
            this.employeeTableAdapter.Fill(this.Gai_policeDBDataSet.Employee);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "Gai_policeDBDataSet.PlaceBuyAuto". При необходимости она может быть перемещена или удалена.
            this.placeBuyAutoTableAdapter.Fill(this.Gai_policeDBDataSet.PlaceBuyAuto);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "Gai_policeDBDataSet1.List_automobiles". При необходимости она может быть перемещена или удалена.
            //this.List_automobilesTableAdapter.Fill(this.Gai_policeDBDataSet1.List_automobiles);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "Gai_policeDBDataSet.Automobile". При необходимости она может быть перемещена или удалена.
            this.AutomobileTableAdapter.Fill(this.Gai_policeDBDataSet.Automobile);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "Gai_policeDBDataSet.ModelAuto". При необходимости она может быть перемещена или удалена.
            this.ModelAutoTableAdapter.Fill(this.Gai_policeDBDataSet.ModelAuto);

            List_Automobile main = this.Owner as List_Automobile;
            if (main != null)
            {
                adapterAuto.Fill(this.Gai_policeDBDataSet1.List_automobiles);

                this.reportViewer1.RefreshReport();
            }

            initializationDataTimePicker();
            label8.Text = "Всего автомобилей: " +  this.Gai_policeDBDataSet1.Tables["List_automobiles"].Rows.Count.ToString();
            clearComboxs();
            this.reportViewer1.RefreshReport();
        }

        private void buttonFilter_Click(object sender, EventArgs e)
        {
            DataTable dt = this.Gai_policeDBDataSet1.List_automobiles;

            dt.Clear();

            string i = this.Gai_policeDBDataSet1.List_automobiles.Columns[0].ColumnName.ToString();

            List_Automobile main = this.Owner as List_Automobile;
            if (main != null)
            {
                string resultRequest = "SELECT * FROM dbo.List_automobiles";
                resultRequest = comboBoxPlaceBuy.Text == "" ? resultRequest : stringRequestComBox(comboBoxPlaceBuy, resultRequest, dt.Columns[2].ColumnName.ToString());
                resultRequest = comboBoxMark.Text == "" ? resultRequest : stringRequestComBox(comboBoxMark, resultRequest, dt.Columns[4].ColumnName.ToString());
                resultRequest = comboBoxEmployee.Text == "" ? resultRequest : stringRequestComBox(comboBoxEmployee, resultRequest, dt.Columns[5].ColumnName.ToString());
                resultRequest = comboBoxOwner.Text == "" ? resultRequest : stringRequestComBox(comboBoxOwner, resultRequest, dt.Columns[0].ColumnName.ToString());
                resultRequest = textBoxNumber.Text == "" ? resultRequest : stringRequestTexBox(textBoxNumber, resultRequest, dt.Columns[3].ColumnName.ToString());
                resultRequest = stringRequestDateTime(dateTimePickerFrom,dateTimePickerTo, resultRequest, dt.Columns[1].ColumnName.ToString());


                adapterAuto = new SqlDataAdapter(resultRequest, connection);
                adapterAuto.Fill(this.Gai_policeDBDataSet1.List_automobiles);

                label8.Text = "Всего автомобилей: " + this.Gai_policeDBDataSet1.Tables["List_automobiles"].Rows.Count.ToString();
                clearComboxs();

                this.reportViewer1.RefreshReport();
            }
        }

        private void clearComboxs()
        {
            comboBoxPlaceBuy.Text = "";
            comboBoxMark.Text = "";
            comboBoxEmployee.Text = "";
            comboBoxOwner.Text = "";
        }

        private string stringRequestComBox(ComboBox cb, string str, string filterName)
        {
            if (str == "SELECT * FROM dbo.List_automobiles")
            {
                str += String.Format(" WHERE {0} = '{1}'", filterName, cb.SelectedValue);
            }
            else
            {
                str += String.Format(" AND {0} = '{1}'", filterName, cb.SelectedValue);
            }

            return str;
        }

        private string stringRequestTexBox(TextBox tb, string str, string filterName)
        {
            if (str == "SELECT * FROM dbo.List_automobiles")
            {
                str += String.Format(" WHERE {0} = {1}", filterName, tb.Text);
            }
            else
            {
                str += String.Format(" AND {0} = {1}", filterName, tb.Text);
            }

            return str;
        }

        private string stringRequestDateTime(DateTimePicker from, DateTimePicker to,string str, string filterName)
        {
            if (str == "SELECT * FROM dbo.List_automobiles")
            {
                str += String.Format(" WHERE {0} BETWEEN '{1}' AND '{2}'", filterName, from.Value.ToString(), to.Value.ToString());
            }
            else
            {
                str += String.Format(" AND {0} BETWEEN '{1}' AND '{2}'", filterName, from.Value.ToString(), to.Value.ToString());
            }

            return str;
        }

        private void initializationDataTimePicker()
        {
            dateTimePickerFrom.MinDate = new DateTime(1900, 1, 1);
            dateTimePickerFrom.MaxDate = DateTime.Today;

            // Set the CustomFormat string.
            //dateTimePickerFrom.CustomFormat = "yyyy MMMM dd";
            //dateTimePickerFrom.Format = DateTimePickerFormat.Custom;
            dateTimePickerFrom.Value = new DateTime(1900, 1, 1);

            dateTimePickerTo.MinDate = new DateTime(1900, 1, 1);
            dateTimePickerTo.MaxDate = DateTime.Today;

            // Set the CustomFormat string.
            //dateTimePickerTo.CustomFormat = "yyyy MMMM dd";
            //dateTimePickerTo.Format = DateTimePickerFormat.Custom;
        }
    }
}
