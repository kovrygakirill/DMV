using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace GAI
{
    public partial class PlaceBuy : Form
    {
        private const string connectionString = "Data Source=DESKTOP-8LERM01\\SQLEXPRESS;Initial Catalog=Gai_policeDB;Integrated Security=True";
        SqlConnection con = new SqlConnection(connectionString);
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataSet ds = new DataSet();

        BindingSource bs = new BindingSource();
        public PlaceBuy()
        {
            InitializeComponent();
        }

        private void PlaceBuy_Load(object sender, EventArgs e)
        {
            string command = "SELECT * FROM PlaceBuyAuto";
            adapter.SelectCommand = new SqlCommand(command, con);
            ds.Clear();
            adapter.Fill(ds, "PlaceBuyAuto");

            dataGridView.DataSource = ds.Tables["PlaceBuyAuto"];
            dataGridView.Columns["Id"].Visible = false;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;


            bs.DataSource = ds.Tables["PlaceBuyAuto"];

            textBox1.DataBindings.Add(new Binding("Text", bs, "Region"));
            textBox2.DataBindings.Add(new Binding("Text", bs, "Town"));
            textBox3.DataBindings.Add(new Binding("Text", bs, "Street"));
            textBox4.DataBindings.Add(new Binding("Text", bs, "house"));

            records();
            updatePosition();
        }

        private void updatePosition()
        {
            List_Automobile main = this.Owner as List_Automobile;
            if (main != null) //Если открыта форма 2 (Сотрудники). То обновляем comboBox1
            {
                bs.Position = main.Registration_ComBox.SelectedIndex;
                dgUpdate();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bs.MoveFirst();
            dgUpdate();
            records();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bs.MoveLast();
            dgUpdate();
            records();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            bs.MovePrevious();
            dgUpdate();
            records();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            bs.MoveNext();
            dgUpdate();
            records();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            bs.AddNew();
            dgUpdate();
            records();
            button5.Enabled = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            bs.RemoveCurrent();
            records();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
                bs.EndEdit();
                adapter.Update(ds, "PlaceBuyAuto");
                List_Automobile main = this.Owner as List_Automobile;
                if (main != null) //Если открыта форма 2 (Сотрудники). То обновляем comboBox1
                {
                    main.Registration_ComBox.DataSource = null;
                    main.Registration_ComBox.DataSource = ds.Tables["PlaceBuyAuto"];
                    main.Registration_ComBox.DisplayMember = "Town";
                    main.Registration_ComBox.ValueMember = "Id";
                    main.Registration_ComBox.SelectedIndex = bs.Position;

                    main.dataGVComBoxColumns["PlaceBuy"].DataSource = null;
                    main.dataGVComBoxColumns["PlaceBuy"].DataSource = ds.Tables["PlaceBuyAuto"];
                    main.dataGVComBoxColumns["PlaceBuy"].DisplayMember = "Town";
                    main.dataGVComBoxColumns["PlaceBuy"].ValueMember = "Id";
                }
                MessageBox.Show("Data save", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                button5.Enabled = true;

            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message + " data not save", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                bs.CancelEdit();
                button5.Enabled = true;
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                MessageBox.Show(ex.Message + " data not save", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //DataTable dt = this.dataGridView.DataSource as DataTable;
                //dt.RejectChanges();
                bs.CancelEdit();
            }
            records();
        }

        private void records()
        {
            record.Text = "Record " + (bs.Position + 1) + " of " + bs.Count;
        }

        private void dgUpdate()
        {
            dataGridView.ClearSelection();
            dataGridView.Rows[bs.Position].Selected = true;
        }

        private void dataGridView_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            bs.Position = dataGridView.CurrentCell.RowIndex;
            records();
        }
    }
}
