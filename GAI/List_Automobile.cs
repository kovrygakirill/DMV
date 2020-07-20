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
    public partial class List_Automobile : Form
    {
        private const string connectionString = "Data Source=DESKTOP-8LERM01\\SQLEXPRESS;Initial Catalog=Gai_policeDB;Integrated Security=True";
        SqlConnection con = new SqlConnection(connectionString);
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataSet ds = new DataSet();

        BindingSource bs = new BindingSource();

        public List_Automobile()
        {
            InitializeComponent();
        }

        private void List_Automobile_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "gai_policeDBDataSet.Automobile". При необходимости она может быть перемещена или удалена.
            this.automobileTableAdapter.Fill(this.gai_policeDBDataSet.Automobile);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "gai_policeDBDataSet.Employee". При необходимости она может быть перемещена или удалена.
            this.employeeTableAdapter.Fill(this.gai_policeDBDataSet.Employee);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "gai_policeDBDataSet.ModelAuto". При необходимости она может быть перемещена или удалена.
            this.modelAutoTableAdapter.Fill(this.gai_policeDBDataSet.ModelAuto);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "gai_policeDBDataSet.PlaceBuyAuto". При необходимости она может быть перемещена или удалена.
            this.placeBuyAutoTableAdapter.Fill(this.gai_policeDBDataSet.PlaceBuyAuto);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "gai_policeDBDataSet.OwnerAuto". При необходимости она может быть перемещена или удалена.
            this.ownerAutoTableAdapter.Fill(this.gai_policeDBDataSet.OwnerAuto);

            string command = "SELECT * FROM Automobile";
            adapter.SelectCommand = new SqlCommand(command, con);
            ds.Clear();
            adapter.Fill(ds, "Automobile");

            //dataGridView.DataSource = ds.Tables["Automobile"];
            //dataGridView.Columns["Id"].Visible = false;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            bs.DataSource = ds.Tables["Automobile"];

            textBox1.DataBindings.Add(new Binding("Text", bs, "DateAdded"));
            textBox2.DataBindings.Add(new Binding("Text", bs, "NumberAuto"));
            comboBox1.DataBindings.Add(new Binding("SelectedValue", bs, "OwnerAutoId"));
            comboBox2.DataBindings.Add(new Binding("SelectedValue", bs, "PlaceRegistrationId"));
            comboBox3.DataBindings.Add(new Binding("SelectedValue", bs, "ModelAutoId"));
            comboBox4.DataBindings.Add(new Binding("SelectedValue", bs, "EmployeeId"));

            //label8.Text = comboBox1.ValueMember;
            //comboBox1.SelectedValue = 4;
            records();
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
                adapter.Update(ds, "Automobile");

                dataGridView.DataSource = bs;
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

        private void OwnerButton_Click(object sender, EventArgs e)
        {
            Owner form = new Owner();
            form.Owner = this;
            form.ShowDialog();
        }

        private void RegistrationButton_Click(object sender, EventArgs e)
        {
            PlaceBuy form = new PlaceBuy();
            form.Owner = this;
            form.ShowDialog();
        }

        private void ModelButton_Click(object sender, EventArgs e)
        {
            Model form = new Model();
            form.Owner = this;
            form.ShowDialog();
        }

        private void EmployeeButton_Click(object sender, EventArgs e)
        {
            Employy form = new Employy();
            form.Owner = this;
            form.ShowDialog();
        }

        public ComboBox Owner_ComBox
        {
            get { return comboBox1; }
            set { comboBox1 = value; }
        }

        public ComboBox Registration_ComBox
        {
            get { return comboBox2; }
            set { comboBox2 = value; }
        }

        public ComboBox Model_ComBox
        {
            get { return comboBox3; }
            set { comboBox3 = value; }
        }

        public ComboBox Employee_ComBox
        {
            get { return comboBox4; }
            set { comboBox4 = value; }
        }

        public SqlDataAdapter Adapter
        {
            get { return adapter; }
        }

        public DataSet Ds
        {
            get { return ds; }
        }

        public BindingSource Bs
        {
            get { return bs; }
        }

        public DataGridView dataGridV
        {
            get { return dataGridView; }
        }

        public Dictionary<string, DataGridViewComboBoxColumn> dataGVComBoxColumns
        {
            get {
                return new Dictionary<string, DataGridViewComboBoxColumn>{
                    { "Owner", dataGridViewComBoxColumn1}, { "PlaceBuy", dataGridViewComBoxColumn2}, {"Model", dataGridViewComBoxColumn3}, {"Employee",dataGridViewComBoxColumn4 } };
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            AllReportAuto form = new AllReportAuto();
            form.Owner = this;
            form.ShowDialog();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            certificateAuto form = new certificateAuto();
            form.Owner = this;
            form.ShowDialog();
        }
    }
}
