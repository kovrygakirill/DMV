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
    public partial class Owner : Form
    {
        private const string connectionString = "Data Source=DESKTOP-8LERM01\\SQLEXPRESS;Initial Catalog=Gai_policeDB;Integrated Security=True";
        SqlConnection con = new SqlConnection(connectionString);
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataSet ds = new DataSet();

        BindingSource bs = new BindingSource();
        public Owner()
        {
            InitializeComponent();
        }
            
        private void Owner_Load(object sender, EventArgs e)
        {
            string command = "SELECT * FROM OwnerAuto";
            adapter.SelectCommand = new SqlCommand(command, con);
            ds.Clear();
            adapter.Fill(ds, "OwnerAuto");

            dataGridView.DataSource = ds.Tables["OwnerAuto"];
            dataGridView.Columns["Id"].Visible = false;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            bs.DataSource = ds.Tables["OwnerAuto"];

            textBox1.DataBindings.Add(new Binding("Text", bs, "Name"));
            textBox2.DataBindings.Add(new Binding("Text", bs, "Surname"));
            textBox3.DataBindings.Add(new Binding("Text", bs, "Patronymic"));
            textBox4.DataBindings.Add(new Binding("Text", bs, "Birthday"));

            updatePosition();
            records();
        }

        private void updatePosition()
        {
            List_Automobile main = this.Owner as List_Automobile;
            if (main != null) //Если открыта форма 2 (Сотрудники). То обновляем comboBox1
            {
                bs.Position = main.Owner_ComBox.SelectedIndex;
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
            try {
                bool check = checkBirthday();
                if (!check)
                {
                    MessageBox.Show("Not included in the restriction 120 > Age > 18, Data not save", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    bs.CancelEdit();
                    records();
                    return;
                }

                SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
                bs.EndEdit();
                adapter.Update(ds, "OwnerAuto");
                List_Automobile main = this.Owner as List_Automobile;
                if (main != null) //Если открыта форма 2 (Сотрудники). То обновляем comboBox1
                {
                    main.Owner_ComBox.DataSource = null;
                    main.Owner_ComBox.DataSource = ds.Tables["OwnerAuto"];
                    main.Owner_ComBox.DisplayMember = "Surname";
                    main.Owner_ComBox.ValueMember = "Id";
                    main.Owner_ComBox.SelectedIndex = bs.Position;

                    main.dataGVComBoxColumns["Owner"].DataSource = null;
                    main.dataGVComBoxColumns["Owner"].DataSource = ds.Tables["OwnerAuto"];
                    main.dataGVComBoxColumns["Owner"].DisplayMember = "Surname";
                    main.dataGVComBoxColumns["Owner"].ValueMember = "Id";
                }
                MessageBox.Show("Data save", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                button5.Enabled = true;

            } catch (FormatException ex)
            {
                MessageBox.Show(ex.Message + " data not save", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                bs.CancelEdit();
                button5.Enabled = true;
            } catch (System.Data.SqlClient.SqlException ex)
            {
                MessageBox.Show(ex.Message + " data not save", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //DataTable dt = this.dataGridView.DataSource as DataTable;
                //dt.RejectChanges();
                bs.CancelEdit();
            }
            records();
        }

        private bool checkBirthday()
        {
            string a = textBox4.Text.ToString();
            DateTime dateToday = DateTime.Today;
            DateTime birthDay = Convert.ToDateTime(a);

            int age = (dateToday.Year - birthDay.Year - 1) +
                (((dateToday.Month > birthDay.Month) ||
                ((dateToday.Month == birthDay.Month) && (dateToday.Day >= birthDay.Day))) ? 1 : 0);

            return age >= 18 && dateToday.Year - birthDay.Year < 120 ? true : false;
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
