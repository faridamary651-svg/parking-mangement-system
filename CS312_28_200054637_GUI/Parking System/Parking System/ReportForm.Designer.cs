namespace Parking_System
{
    partial class ReportForm
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
            lblFrom = new Label();
            lblTo = new Label();
            lblRevenue = new Label();
            label4 = new Label();
            lblAverage = new Label();
            lblOccupancy = new Label();
            dtpFrom = new DateTimePicker();
            dtpTo = new DateTimePicker();
            dgvReports = new DataGridView();
            btnGenerate = new Button();
            btnExport = new Button();
            pnlChart1 = new Panel();
            pnlChart2 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dgvReports).BeginInit();
            SuspendLayout();
            // 
            // lblFrom
            // 
            lblFrom.AutoSize = true;
            lblFrom.Location = new Point(12, 5);
            lblFrom.Name = "lblFrom";
            lblFrom.Size = new Size(43, 20);
            lblFrom.TabIndex = 0;
            lblFrom.Text = "From";
            // 
            // lblTo
            // 
            lblTo.AutoSize = true;
            lblTo.Location = new Point(326, 5);
            lblTo.Name = "lblTo";
            lblTo.Size = new Size(25, 20);
            lblTo.TabIndex = 1;
            lblTo.Text = "To";
            // 
            // lblRevenue
            // 
            lblRevenue.AutoSize = true;
            lblRevenue.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRevenue.Location = new Point(12, 58);
            lblRevenue.Name = "lblRevenue";
            lblRevenue.Size = new Size(185, 28);
            lblRevenue.TabIndex = 2;
            lblRevenue.Text = "Total revenue(EGP)";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(245, 58);
            label4.Name = "label4";
            label4.Size = new Size(154, 28);
            label4.TabIndex = 3;
            label4.Text = "Cars that exited";
            // 
            // lblAverage
            // 
            lblAverage.AutoSize = true;
            lblAverage.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAverage.Location = new Point(448, 58);
            lblAverage.Name = "lblAverage";
            lblAverage.Size = new Size(128, 28);
            lblAverage.TabIndex = 4;
            lblAverage.Text = "Average stay";
            // 
            // lblOccupancy
            // 
            lblOccupancy.AutoSize = true;
            lblOccupancy.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblOccupancy.Location = new Point(639, 58);
            lblOccupancy.Name = "lblOccupancy";
            lblOccupancy.Size = new Size(155, 28);
            lblOccupancy.TabIndex = 5;
            lblOccupancy.Text = "Occupancy now";
            // 
            // dtpFrom
            // 
            dtpFrom.Location = new Point(61, 5);
            dtpFrom.Name = "dtpFrom";
            dtpFrom.Size = new Size(250, 27);
            dtpFrom.TabIndex = 6;
            // 
            // dtpTo
            // 
            dtpTo.Location = new Point(368, 5);
            dtpTo.Name = "dtpTo";
            dtpTo.Size = new Size(250, 27);
            dtpTo.TabIndex = 7;
            // 
            // dgvReports
            // 
            dgvReports.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvReports.Location = new Point(12, 162);
            dgvReports.Name = "dgvReports";
            dgvReports.RowHeadersWidth = 51;
            dgvReports.Size = new Size(300, 276);
            dgvReports.TabIndex = 8;
            // 
            // btnGenerate
            // 
            btnGenerate.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGenerate.Location = new Point(639, 6);
            btnGenerate.Name = "btnGenerate";
            btnGenerate.Size = new Size(94, 29);
            btnGenerate.TabIndex = 9;
            btnGenerate.Text = "Generate";
            btnGenerate.UseVisualStyleBackColor = true;
            btnGenerate.Click += btnGenerate_Click;
            // 
            // btnExport
            // 
            btnExport.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExport.Location = new Point(739, 6);
            btnExport.Name = "btnExport";
            btnExport.Size = new Size(133, 29);
            btnExport.TabIndex = 10;
            btnExport.Text = "ExportCSV";
            btnExport.UseVisualStyleBackColor = true;
            btnExport.Click += s;
            // 
            // pnlChart1
            // 
            pnlChart1.Location = new Point(337, 162);
            pnlChart1.Name = "pnlChart1";
            pnlChart1.Size = new Size(418, 125);
            pnlChart1.TabIndex = 11;
            // 
            // pnlChart2
            // 
            pnlChart2.Location = new Point(337, 313);
            pnlChart2.Name = "pnlChart2";
            pnlChart2.Size = new Size(425, 125);
            pnlChart2.TabIndex = 12;
            // 
            // Form7
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(895, 450);
            Controls.Add(pnlChart2);
            Controls.Add(pnlChart1);
            Controls.Add(btnExport);
            Controls.Add(btnGenerate);
            Controls.Add(dgvReports);
            Controls.Add(dtpTo);
            Controls.Add(dtpFrom);
            Controls.Add(lblOccupancy);
            Controls.Add(lblAverage);
            Controls.Add(label4);
            Controls.Add(lblRevenue);
            Controls.Add(lblTo);
            Controls.Add(lblFrom);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form7";
            Text = "Reports";
            Load += Form7_Load;
            ((System.ComponentModel.ISupportInitialize)dgvReports).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblFrom;
        private Label lblTo;
        private Label lblRevenue;
        private Label label4;
        private Label lblAverage;
        private Label lblOccupancy;
        private DateTimePicker dtpFrom;
        private DateTimePicker dtpTo;
        private DataGridView dgvReports;
        private Button btnGenerate;
        private Button btnExport;
        private Panel pnlChart1;
        private Panel pnlChart2;
    }
}