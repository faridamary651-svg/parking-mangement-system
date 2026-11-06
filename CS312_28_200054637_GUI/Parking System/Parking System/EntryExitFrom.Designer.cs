namespace Parking_System
{
    partial class EntryExitFrom
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
            grpEntry = new GroupBox();
            grpExit = new GroupBox();
            lblVehicle = new Label();
            lblSlot = new Label();
            lblRate = new Label();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            btnEntry = new Button();
            btnExit = new Button();
            dgv = new DataGridView();
            colTicket = new DataGridViewTextBoxColumn();
            colPlate = new DataGridViewTextBoxColumn();
            colSolt = new DataGridViewTextBoxColumn();
            colEntry = new DataGridViewTextBoxColumn();
            colDuration = new DataGridViewTextBoxColumn();
            colFee = new DataGridViewTextBoxColumn();
            grpEntry.SuspendLayout();
            grpExit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv).BeginInit();
            SuspendLayout();
            // 
            // grpEntry
            // 
            grpEntry.Controls.Add(btnEntry);
            grpEntry.Controls.Add(comboBox1);
            grpEntry.Controls.Add(comboBox2);
            grpEntry.Controls.Add(lblVehicle);
            grpEntry.Controls.Add(lblSlot);
            grpEntry.Location = new Point(0, 0);
            grpEntry.Name = "grpEntry";
            grpEntry.Size = new Size(879, 87);
            grpEntry.TabIndex = 0;
            grpEntry.TabStop = false;
            grpEntry.Text = "Entry";
            // 
            // grpExit
            // 
            grpExit.Controls.Add(btnExit);
            grpExit.Controls.Add(lblRate);
            grpExit.Location = new Point(0, 114);
            grpExit.Name = "grpExit";
            grpExit.Size = new Size(879, 105);
            grpExit.TabIndex = 1;
            grpExit.TabStop = false;
            grpExit.Text = "Exit";
            // 
            // lblVehicle
            // 
            lblVehicle.AutoSize = true;
            lblVehicle.Location = new Point(11, 39);
            lblVehicle.Name = "lblVehicle";
            lblVehicle.Size = new Size(56, 20);
            lblVehicle.TabIndex = 0;
            lblVehicle.Text = "Vehicle";
            // 
            // lblSlot
            // 
            lblSlot.AutoSize = true;
            lblSlot.Location = new Point(244, 42);
            lblSlot.Name = "lblSlot";
            lblSlot.Size = new Size(35, 20);
            lblSlot.TabIndex = 2;
            lblSlot.Text = "Slot";
           
            // 
            // lblRate
            // 
            lblRate.AutoSize = true;
            lblRate.Location = new Point(295, 60);
            lblRate.Name = "lblRate";
            lblRate.Size = new Size(39, 20);
            lblRate.TabIndex = 3;
            lblRate.Text = "Rate";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(73, 39);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 4;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(285, 39);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(151, 28);
            comboBox2.TabIndex = 5;
            // 
            // btnEntry
            // 
            btnEntry.Location = new Point(462, 35);
            btnEntry.Name = "btnEntry";
            btnEntry.Size = new Size(142, 29);
            btnEntry.TabIndex = 4;
            btnEntry.Text = "Register entry";
            btnEntry.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(12, 51);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(250, 29);
            btnExit.TabIndex = 4;
            btnExit.Text = "process exit for selected ticket";
            btnExit.UseVisualStyleBackColor = true;
            // 
            // dgv
            // 
            dgv.AllowUserToAddRows = false;
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.BackgroundColor = SystemColors.ButtonFace;
            dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv.Columns.AddRange(new DataGridViewColumn[] { colTicket, colPlate, colSolt, colEntry, colDuration, colFee });
            dgv.Location = new Point(0, 241);
            dgv.Name = "dgv";
            dgv.RowHeadersWidth = 51;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.Size = new Size(879, 170);
            dgv.TabIndex = 16;
            // 
            // colTicket
            // 
            colTicket.HeaderText = "Ticket";
            colTicket.MinimumWidth = 6;
            colTicket.Name = "colTicket";
            colTicket.ReadOnly = true;
            // 
            // colPlate
            // 
            colPlate.HeaderText = "Plate";
            colPlate.MinimumWidth = 6;
            colPlate.Name = "colPlate";
            colPlate.ReadOnly = true;
            // 
            // colSolt
            // 
            colSolt.HeaderText = "Slot";
            colSolt.MinimumWidth = 6;
            colSolt.Name = "colSolt";
            colSolt.ReadOnly = true;
            // 
            // colEntry
            // 
            colEntry.HeaderText = "Entry time";
            colEntry.MinimumWidth = 6;
            colEntry.Name = "colEntry";
            colEntry.ReadOnly = true;
            // 
            // colDuration
            // 
            colDuration.HeaderText = "Duration";
            colDuration.MinimumWidth = 6;
            colDuration.Name = "colDuration";
            colDuration.ReadOnly = true;
            // 
            // colFee
            // 
            colFee.HeaderText = "Fee so far(EGP)";
            colFee.MinimumWidth = 6;
            colFee.Name = "colFee";
            colFee.ReadOnly = true;
            // 
            // EntryExitFrom
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(882, 411);
            Controls.Add(dgv);
            Controls.Add(grpExit);
            Controls.Add(grpEntry);
            Name = "EntryExitFrom";
            Text = "Entry and Exit";
            grpEntry.ResumeLayout(false);
            grpEntry.PerformLayout();
            grpExit.ResumeLayout(false);
            grpExit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpEntry;
        private Label lblVehicle;
        private GroupBox grpExit;
        private Label lblSlot;
        private Label lblRate;
        private ComboBox comboBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private ComboBox comboBox2;
        private Button btnEntry;
        private Button btnExit;
        private DataGridView dgv;
        private DataGridViewTextBoxColumn colTicket;
        private DataGridViewTextBoxColumn colPlate;
        private DataGridViewTextBoxColumn colSolt;
        private DataGridViewTextBoxColumn colEntry;
        private DataGridViewTextBoxColumn colDuration;
        private DataGridViewTextBoxColumn colFee;
    }
}