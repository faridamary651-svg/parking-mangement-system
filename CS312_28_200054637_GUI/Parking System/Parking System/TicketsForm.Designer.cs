namespace Parking_System
{
    partial class TicketsForm
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
            btnDelete = new Button();
            dtpTo = new DateTimePicker();
            dtpFrom = new DateTimePicker();
            lblTo = new Label();
            lblFrom = new Label();
            cmdStatus = new ComboBox();
            lblOwner = new Label();
            textBox1 = new TextBox();
            lblPlate = new Label();
            dgv = new DataGridView();
            colTicket = new DataGridViewTextBoxColumn();
            colPlate = new DataGridViewTextBoxColumn();
            colSolt = new DataGridViewTextBoxColumn();
            colEntry = new DataGridViewTextBoxColumn();
            colExit = new DataGridViewTextBoxColumn();
            colFee = new DataGridViewTextBoxColumn();
            colPaid = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgv).BeginInit();
            SuspendLayout();
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDelete.Location = new Point(871, 10);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 14;
            btnDelete.Text = "Delete ticket";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += this.btnGenerate_Click;
            // 
            // dtpTo
            // 
            dtpTo.Location = new Point(704, 10);
            dtpTo.Name = "dtpTo";
            dtpTo.Size = new Size(161, 27);
            dtpTo.TabIndex = 13;
            dtpTo.ValueChanged += this.dtpTo_ValueChanged;
            // 
            // dtpFrom
            // 
            dtpFrom.Location = new Point(508, 10);
            dtpFrom.Name = "dtpFrom";
            dtpFrom.Size = new Size(159, 27);
            dtpFrom.TabIndex = 12;
            dtpFrom.ValueChanged += this.dtpFrom_ValueChanged;
            // 
            // lblTo
            // 
            lblTo.AutoSize = true;
            lblTo.Location = new Point(673, 15);
            lblTo.Name = "lblTo";
            lblTo.Size = new Size(25, 20);
            lblTo.TabIndex = 11;
            lblTo.Text = "To";
            lblTo.Click += this.lblTo_Click;
            // 
            // lblFrom
            // 
            lblFrom.AutoSize = true;
            lblFrom.Location = new Point(460, 15);
            lblFrom.Name = "lblFrom";
            lblFrom.Size = new Size(43, 20);
            lblFrom.TabIndex = 10;
            lblFrom.Text = "From";
            
            // 
            // cmdStatus
            // 
            cmdStatus.FormattingEnabled = true;
            cmdStatus.Location = new Point(303, 8);
            cmdStatus.Name = "cmdStatus";
            cmdStatus.Size = new Size(151, 28);
            cmdStatus.TabIndex = 34;
            // 
            // lblOwner
            // 
            lblOwner.AutoSize = true;
            lblOwner.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblOwner.Location = new Point(221, 13);
            lblOwner.Name = "lblOwner";
            lblOwner.Size = new Size(57, 23);
            lblOwner.TabIndex = 33;
            lblOwner.Text = "Status";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(73, 12);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 36;
            // 
            // lblPlate
            // 
            lblPlate.AutoSize = true;
            lblPlate.Location = new Point(2, 15);
            lblPlate.Name = "lblPlate";
            lblPlate.Size = new Size(42, 20);
            lblPlate.TabIndex = 35;
            lblPlate.Text = "Plate";
            // 
            // dgv
            // 
            dgv.AllowUserToAddRows = false;
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.BackgroundColor = SystemColors.ButtonFace;
            dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv.Columns.AddRange(new DataGridViewColumn[] { colTicket, colPlate, colSolt, colEntry, colExit, colFee, colPaid });
            dgv.Location = new Point(2, 109);
            dgv.Name = "dgv";
            dgv.RowHeadersWidth = 51;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.Size = new Size(963, 286);
            dgv.TabIndex = 37;
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
            colEntry.HeaderText = "Entry ";
            colEntry.MinimumWidth = 6;
            colEntry.Name = "colEntry";
            colEntry.ReadOnly = true;
            // 
            // colExit
            // 
            colExit.HeaderText = "Exit";
            colExit.MinimumWidth = 6;
            colExit.Name = "colExit";
            colExit.ReadOnly = true;
            // 
            // colFee
            // 
            colFee.HeaderText = "Fee ";
            colFee.MinimumWidth = 6;
            colFee.Name = "colFee";
            colFee.ReadOnly = true;
            // 
            // colPaid
            // 
            colPaid.HeaderText = "Paid";
            colPaid.MinimumWidth = 6;
            colPaid.Name = "colPaid";
            colPaid.ReadOnly = true;
            // 
            // TicketsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(965, 398);
            Controls.Add(dgv);
            Controls.Add(textBox1);
            Controls.Add(lblPlate);
            Controls.Add(cmdStatus);
            Controls.Add(lblOwner);
            Controls.Add(btnDelete);
            Controls.Add(dtpTo);
            Controls.Add(dtpFrom);
            Controls.Add(lblTo);
            Controls.Add(lblFrom);
            Name = "TicketsForm";
            Text = "Tickets history";
            ((System.ComponentModel.ISupportInitialize)dgv).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnDelete;
        private DateTimePicker dtpTo;
        private DateTimePicker dtpFrom;
        private Label lblTo;
        private Label lblFrom;
        private ComboBox cmdStatus;
        private Label lblOwner;
        private TextBox textBox1;
        private Label lblPlate;
        private DataGridView dgv;
        private DataGridViewTextBoxColumn colTicket;
        private DataGridViewTextBoxColumn colPlate;
        private DataGridViewTextBoxColumn colSolt;
        private DataGridViewTextBoxColumn colEntry;
        private DataGridViewTextBoxColumn colExit;
        private DataGridViewTextBoxColumn colFee;
        private DataGridViewTextBoxColumn colPaid;
    }
}