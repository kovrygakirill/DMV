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
    public partial class certificateAuto : Form
    {
        private const string connectionString = "Data Source=DESKTOP-8LERM01\\SQLEXPRESS;Initial Catalog=Gai_policeDB;Integrated Security=True";

        static SqlConnection connection = new SqlConnection(connectionString);
        public certificateAuto()
        {
            InitializeComponent();
        }

        private void certificateAuto_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "Gai_policeDBDataSet.Automobile". При необходимости она может быть перемещена или удалена.
            this.AutomobileTableAdapter.Fill(this.Gai_policeDBDataSet.Automobile);

            string strFIO;
            List_Automobile main = this.Owner as List_Automobile;
            if (main != null)
            {
                var row = main.dataGridV.CurrentRow.Index;
                var number = main.dataGridV[3, row].Value.ToString();
                var ownerid = main.dataGridV[0, row].Value.ToString();
                var modelId = main.dataGridV[4, row].Value.ToString();

                SqlDataAdapter adapterOwner = new SqlDataAdapter("SELECT * FROM dbo.OwnerAuto WHERE id = " + ownerid, connection);
                SqlDataAdapter adapterModel = new SqlDataAdapter("SELECT * FROM dbo.ModelAuto WHERE id = " + modelId, connection);

                adapterOwner.Fill(this.Gai_policeDBDataSet, "OwnerAutoo");
                adapterModel.Fill(this.Gai_policeDBDataSet, "ModelAuto");

                DataRow ownerRow = this.Gai_policeDBDataSet.Tables["OwnerAutoo"].Rows[0];
                DataRow modelRow = this.Gai_policeDBDataSet.Tables["ModelAuto"].Rows[0];

                string ownerInfo = $"{ownerRow["name"]} {ownerRow["surname"]} {ownerRow["Patronymic"]}";
                string modelInfo = $"{modelRow["Name_mark"]} {modelRow["Model"]}";

                strFIO = $"Данная справка подверждает, что водитель: {ownerInfo}, имеет транспорт {modelInfo} с номером {number};";

                ReportParameter planData = new ReportParameter("OwnerData", strFIO);
                reportViewer1.LocalReport.SetParameters(new ReportParameter[] { planData });
            }

            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }
    }
}
