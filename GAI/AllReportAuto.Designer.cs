namespace GAI
{
    partial class AllReportAuto
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource4 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.List_automobilesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Gai_policeDBDataSet1 = new GAI.Gai_policeDBDataSet1();
            this.AutomobileBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Gai_policeDBDataSet = new GAI.Gai_policeDBDataSet();
            this.ModelAutoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.AutomobileTableAdapter = new GAI.Gai_policeDBDataSetTableAdapters.AutomobileTableAdapter();
            this.ModelAutoTableAdapter = new GAI.Gai_policeDBDataSetTableAdapters.ModelAutoTableAdapter();
            this.List_automobilesTableAdapter = new GAI.Gai_policeDBDataSet1TableAdapters.List_automobilesTableAdapter();
            this.buttonFilter = new System.Windows.Forms.Button();
            this.comboBoxPlaceBuy = new System.Windows.Forms.ComboBox();
            this.placeBuyAutoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.placeBuyAutoTableAdapter = new GAI.Gai_policeDBDataSetTableAdapters.PlaceBuyAutoTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxMark = new System.Windows.Forms.ComboBox();
            this.comboBoxEmployee = new System.Windows.Forms.ComboBox();
            this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employeeTableAdapter = new GAI.Gai_policeDBDataSetTableAdapters.EmployeeTableAdapter();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxNumber = new System.Windows.Forms.TextBox();
            this.comboBoxOwner = new System.Windows.Forms.ComboBox();
            this.ownerAutoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.ownerAutoTableAdapter = new GAI.Gai_policeDBDataSetTableAdapters.OwnerAutoTableAdapter();
            this.dateTimePickerFrom = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dateTimePickerTo = new System.Windows.Forms.DateTimePicker();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.List_automobilesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Gai_policeDBDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AutomobileBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Gai_policeDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ModelAutoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.placeBuyAutoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ownerAutoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // List_automobilesBindingSource
            // 
            this.List_automobilesBindingSource.DataMember = "List_automobiles";
            this.List_automobilesBindingSource.DataSource = this.Gai_policeDBDataSet1;
            // 
            // Gai_policeDBDataSet1
            // 
            this.Gai_policeDBDataSet1.DataSetName = "Gai_policeDBDataSet1";
            this.Gai_policeDBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // AutomobileBindingSource
            // 
            this.AutomobileBindingSource.DataMember = "Automobile";
            this.AutomobileBindingSource.DataSource = this.Gai_policeDBDataSet;
            // 
            // Gai_policeDBDataSet
            // 
            this.Gai_policeDBDataSet.DataSetName = "Gai_policeDBDataSet";
            this.Gai_policeDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ModelAutoBindingSource
            // 
            this.ModelAutoBindingSource.DataMember = "ModelAuto";
            this.ModelAutoBindingSource.DataSource = this.Gai_policeDBDataSet;
            // 
            // AutomobileTableAdapter
            // 
            this.AutomobileTableAdapter.ClearBeforeFill = true;
            // 
            // ModelAutoTableAdapter
            // 
            this.ModelAutoTableAdapter.ClearBeforeFill = true;
            // 
            // List_automobilesTableAdapter
            // 
            this.List_automobilesTableAdapter.ClearBeforeFill = true;
            // 
            // buttonFilter
            // 
            this.buttonFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonFilter.Location = new System.Drawing.Point(833, 24);
            this.buttonFilter.Name = "buttonFilter";
            this.buttonFilter.Size = new System.Drawing.Size(110, 68);
            this.buttonFilter.TabIndex = 3;
            this.buttonFilter.Text = "Filter ";
            this.buttonFilter.UseVisualStyleBackColor = true;
            this.buttonFilter.Click += new System.EventHandler(this.buttonFilter_Click);
            // 
            // comboBoxPlaceBuy
            // 
            this.comboBoxPlaceBuy.DataSource = this.placeBuyAutoBindingSource;
            this.comboBoxPlaceBuy.DisplayMember = "Town";
            this.comboBoxPlaceBuy.FormattingEnabled = true;
            this.comboBoxPlaceBuy.Location = new System.Drawing.Point(140, 24);
            this.comboBoxPlaceBuy.Name = "comboBoxPlaceBuy";
            this.comboBoxPlaceBuy.Size = new System.Drawing.Size(121, 24);
            this.comboBoxPlaceBuy.TabIndex = 4;
            this.comboBoxPlaceBuy.ValueMember = "Town";
            // 
            // placeBuyAutoBindingSource
            // 
            this.placeBuyAutoBindingSource.DataMember = "PlaceBuyAuto";
            this.placeBuyAutoBindingSource.DataSource = this.Gai_policeDBDataSet;
            // 
            // placeBuyAutoTableAdapter
            // 
            this.placeBuyAutoTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(56, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "Town:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(7, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 24);
            this.label2.TabIndex = 6;
            this.label2.Text = "Name mark:";
            // 
            // comboBoxMark
            // 
            this.comboBoxMark.DataSource = this.ModelAutoBindingSource;
            this.comboBoxMark.DisplayMember = "Name_mark";
            this.comboBoxMark.FormattingEnabled = true;
            this.comboBoxMark.Location = new System.Drawing.Point(140, 70);
            this.comboBoxMark.Name = "comboBoxMark";
            this.comboBoxMark.Size = new System.Drawing.Size(121, 24);
            this.comboBoxMark.TabIndex = 7;
            this.comboBoxMark.ValueMember = "Name_mark";
            // 
            // comboBoxEmployee
            // 
            this.comboBoxEmployee.DataSource = this.employeeBindingSource;
            this.comboBoxEmployee.DisplayMember = "Surname";
            this.comboBoxEmployee.FormattingEnabled = true;
            this.comboBoxEmployee.Location = new System.Drawing.Point(430, 24);
            this.comboBoxEmployee.Name = "comboBoxEmployee";
            this.comboBoxEmployee.Size = new System.Drawing.Size(121, 24);
            this.comboBoxEmployee.TabIndex = 8;
            this.comboBoxEmployee.ValueMember = "Surname";
            // 
            // employeeBindingSource
            // 
            this.employeeBindingSource.DataMember = "Employee";
            this.employeeBindingSource.DataSource = this.Gai_policeDBDataSet;
            // 
            // employeeTableAdapter
            // 
            this.employeeTableAdapter.ClearBeforeFill = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(306, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 24);
            this.label3.TabIndex = 9;
            this.label3.Text = "Employee:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(279, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 24);
            this.label4.TabIndex = 10;
            this.label4.Text = "Number Auto:";
            // 
            // textBoxNumber
            // 
            this.textBoxNumber.Location = new System.Drawing.Point(430, 70);
            this.textBoxNumber.Name = "textBoxNumber";
            this.textBoxNumber.Size = new System.Drawing.Size(121, 22);
            this.textBoxNumber.TabIndex = 11;
            // 
            // comboBoxOwner
            // 
            this.comboBoxOwner.DataSource = this.ownerAutoBindingSource;
            this.comboBoxOwner.DisplayMember = "Surname";
            this.comboBoxOwner.FormattingEnabled = true;
            this.comboBoxOwner.Location = new System.Drawing.Point(667, 49);
            this.comboBoxOwner.Name = "comboBoxOwner";
            this.comboBoxOwner.Size = new System.Drawing.Size(121, 24);
            this.comboBoxOwner.TabIndex = 12;
            this.comboBoxOwner.ValueMember = "Surname";
            // 
            // ownerAutoBindingSource
            // 
            this.ownerAutoBindingSource.DataMember = "OwnerAuto";
            this.ownerAutoBindingSource.DataSource = this.Gai_policeDBDataSet;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(575, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 24);
            this.label5.TabIndex = 13;
            this.label5.Text = "Owner:";
            // 
            // ownerAutoTableAdapter
            // 
            this.ownerAutoTableAdapter.ClearBeforeFill = true;
            // 
            // dateTimePickerFrom
            // 
            this.dateTimePickerFrom.CustomFormat = "";
            this.dateTimePickerFrom.Location = new System.Drawing.Point(140, 131);
            this.dateTimePickerFrom.Name = "dateTimePickerFrom";
            this.dateTimePickerFrom.Size = new System.Drawing.Size(200, 22);
            this.dateTimePickerFrom.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(91, 131);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 24);
            this.label6.TabIndex = 15;
            this.label6.Text = "C:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(392, 129);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 24);
            this.label7.TabIndex = 16;
            this.label7.Text = "По:";
            // 
            // dateTimePickerTo
            // 
            this.dateTimePickerTo.CustomFormat = "";
            this.dateTimePickerTo.Location = new System.Drawing.Point(456, 131);
            this.dateTimePickerTo.Name = "dateTimePickerTo";
            this.dateTimePickerTo.Size = new System.Drawing.Size(200, 22);
            this.dateTimePickerTo.TabIndex = 17;
            // 
            // reportViewer1
            // 
            reportDataSource4.Name = "DataSet1";
            reportDataSource4.Value = this.List_automobilesBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource4);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "GAI.reportAutomobiles.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(11, 171);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(942, 395);
            this.reportViewer1.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(686, 129);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 24);
            this.label8.TabIndex = 19;
            // 
            // AllReportAuto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(955, 578);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.dateTimePickerTo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dateTimePickerFrom);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBoxOwner);
            this.Controls.Add(this.textBoxNumber);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxEmployee);
            this.Controls.Add(this.comboBoxMark);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxPlaceBuy);
            this.Controls.Add(this.buttonFilter);
            this.Name = "AllReportAuto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AllReportAuto";
            this.Load += new System.EventHandler(this.AllReportAuto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.List_automobilesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Gai_policeDBDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AutomobileBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Gai_policeDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ModelAutoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.placeBuyAutoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ownerAutoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource AutomobileBindingSource;
        private Gai_policeDBDataSet Gai_policeDBDataSet;
        private Gai_policeDBDataSetTableAdapters.AutomobileTableAdapter AutomobileTableAdapter;
        private System.Windows.Forms.BindingSource ModelAutoBindingSource;
        private Gai_policeDBDataSetTableAdapters.ModelAutoTableAdapter ModelAutoTableAdapter;
        private System.Windows.Forms.BindingSource List_automobilesBindingSource;
        private Gai_policeDBDataSet1 Gai_policeDBDataSet1;
        private Gai_policeDBDataSet1TableAdapters.List_automobilesTableAdapter List_automobilesTableAdapter;
        private System.Windows.Forms.Button buttonFilter;
        private System.Windows.Forms.ComboBox comboBoxPlaceBuy;
        private System.Windows.Forms.BindingSource placeBuyAutoBindingSource;
        private Gai_policeDBDataSetTableAdapters.PlaceBuyAutoTableAdapter placeBuyAutoTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxMark;
        private System.Windows.Forms.ComboBox comboBoxEmployee;
        private System.Windows.Forms.BindingSource employeeBindingSource;
        private Gai_policeDBDataSetTableAdapters.EmployeeTableAdapter employeeTableAdapter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxNumber;
        private System.Windows.Forms.ComboBox comboBoxOwner;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.BindingSource ownerAutoBindingSource;
        private Gai_policeDBDataSetTableAdapters.OwnerAutoTableAdapter ownerAutoTableAdapter;
        private System.Windows.Forms.DateTimePicker dateTimePickerFrom;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dateTimePickerTo;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Label label8;
    }
}