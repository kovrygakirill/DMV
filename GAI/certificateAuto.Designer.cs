namespace GAI
{
    partial class certificateAuto
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
            this.AutomobileBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Gai_policeDBDataSet = new GAI.Gai_policeDBDataSet();
            this.AutomobileTableAdapter = new GAI.Gai_policeDBDataSetTableAdapters.AutomobileTableAdapter();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.AutomobileBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Gai_policeDBDataSet)).BeginInit();
            this.SuspendLayout();
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
            // AutomobileTableAdapter
            // 
            this.AutomobileTableAdapter.ClearBeforeFill = true;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "GAI.Certificate.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(888, 504);
            this.reportViewer1.TabIndex = 0;
            // 
            // certificateAuto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(888, 504);
            this.Controls.Add(this.reportViewer1);
            this.Name = "certificateAuto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "certificateAuto";
            this.Load += new System.EventHandler(this.certificateAuto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AutomobileBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Gai_policeDBDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource AutomobileBindingSource;
        private Gai_policeDBDataSet Gai_policeDBDataSet;
        private Gai_policeDBDataSetTableAdapters.AutomobileTableAdapter AutomobileTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
    }
}