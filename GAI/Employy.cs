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
    public partial class Employy : Form
    {
        private const string connectionString = "Data Source=DESKTOP-8LERM01\\SQLEXPRESS;Initial Catalog=Gai_policeDB;Integrated Security=True";
        SqlConnection con = new SqlConnection(connectionString);
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataSet ds = new DataSet();

        BindingSource bs = new BindingSource();

        public Employy()
        {
            InitializeComponent();
        }

        private void Employy_Load(object sender, EventArgs e)
        {
            string command = "SELECT * FROM Employee";
            adapter.SelectCommand = new SqlCommand(command,con);
            ds.Clear();
            adapter.Fill(ds, "Employee");

            dataGridView1.DataSource = ds.Tables["Employee"];
            dataGridView1.Columns["Id"].Visible = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            bs.DataSource = ds.Tables["Employee"];


            textBox1.DataBindings.Add(new Binding("Text", bs, "Name"));
            textBox2.DataBindings.Add(new Binding("Text", bs, "Surname"));
            textBox3.DataBindings.Add(new Binding("Text", bs, "Patronymic"));
            textBox4.DataBindings.Add(new Binding("Text", bs, "Telephone"));

            updatePosition();
            records();
        }

        private void updatePosition()
        {
            List_Automobile main = this.Owner as List_Automobile;
            if (main != null) //Если открыта форма 2 (Сотрудники). То обновляем comboBox1
            {
                bs.Position = main.Employee_ComBox.SelectedIndex;
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
                adapter.Update(ds, "Employee");
                List_Automobile main = this.Owner as List_Automobile;
                if (main != null) //Если открыта форма 2 (Сотрудники). То обновляем comboBox1
                {
                    main.Employee_ComBox.DataSource = null;
                    main.Employee_ComBox.DataSource = ds.Tables["Employee"];
                    main.Employee_ComBox.DisplayMember = "Surname";
                    main.Employee_ComBox.ValueMember = "Id";
                    main.Employee_ComBox.SelectedIndex = bs.Position;

                    main.dataGVComBoxColumns["Employee"].DataSource = null;
                    main.dataGVComBoxColumns["Employee"].DataSource = ds.Tables["Employee"];
                    main.dataGVComBoxColumns["Employee"].DisplayMember = "Surname";
                    main.dataGVComBoxColumns["Employee"].ValueMember = "Id";
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
            dataGridView1.ClearSelection();
            dataGridView1.Rows[bs.Position].Selected = true;
        }

        private void dataGridView_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            bs.Position = dataGridView1.CurrentCell.RowIndex;
            records();
        }
    }
}
