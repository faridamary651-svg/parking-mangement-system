namespace Parking_System
{
    partial class SlotsForm
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
            dgv = new DataGridView();
            this.cmbZoneFilter = new ComboBox();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnClear = new Button();
            btnAdd = new Button();
            textBox5 = new TextBox();
            txtPhone = new TextBox();
            textBox1 = new TextBox();
            this.lblZone = new Label();
            this.lblSlot = new Label();
            lblOwner = new Label();
            lblZoneFilter = new Label();
            lblSearch = new Label();
            cmdStatus = new ComboBox();
            colSlot = new DataGridViewTextBoxColumn();
            colZone = new DataGridViewTextBoxColumn();
            colStatus = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgv).BeginInit();
            SuspendLayout();
            // 
            // dgv
            // 
            dgv.AllowUserToAddRows = false;
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.BackgroundColor = SystemColors.ButtonFace;
            dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv.Columns.AddRange(new DataGridViewColumn[] { colSlot, colZone, colStatus });
            dgv.Location = new Point(12, 65);
            dgv.Name = "dgv";
            dgv.RowHeadersWidth = 51;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.Size = new Size(530, 372);
            dgv.TabIndex = 31;
            // 
            // cmbZoneFilter
            // 
            this.cmbZoneFilter.FormattingEnabled = true;
            this.cmbZoneFilter.Location = new Point(310, 12);
            this.cmbZoneFilter.Name = "cmbZoneFilter";
            this.cmbZoneFilter.Size = new Size(151, 28);
            this.cmbZoneFilter.TabIndex = 30;
            // 
            // btnUpdate
            // 
            btnUpdate.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdate.Location = new Point(694, 296);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 29);
            btnUpdate.TabIndex = 29;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDelete.Location = new Point(582, 367);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 28;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            btnClear.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClear.Location = new Point(694, 367);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(94, 29);
            btnClear.TabIndex = 27;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdd.Location = new Point(582, 296);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 26;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(663, 240);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(125, 27);
            textBox5.TabIndex = 25;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(663, 169);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(125, 27);
            txtPhone.TabIndex = 24;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(79, 14);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 21;
            // 
            // lblZone
            // 
            this.lblZone.AutoSize = true;
            this.lblZone.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.lblZone.Location = new Point(592, 244);
            this.lblZone.Name = "lblZone";
            this.lblZone.Size = new Size(49, 23);
            this.lblZone.TabIndex = 20;
            this.lblZone.Text = "Zone";
            // 
            // lblSlot
            // 
            this.lblSlot.AutoSize = true;
            this.lblSlot.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.lblSlot.Location = new Point(592, 170);
            this.lblSlot.Name = "lblSlot";
            this.lblSlot.Size = new Size(39, 23);
            this.lblSlot.TabIndex = 19;
            this.lblSlot.Text = "Slot";
            // 
            // lblOwner
            // 
            lblOwner.AutoSize = true;
            lblOwner.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblOwner.Location = new Point(481, 15);
            lblOwner.Name = "lblOwner";
            lblOwner.Size = new Size(57, 23);
            lblOwner.TabIndex = 18;
            lblOwner.Text = "Status";
            // 
            // lblZoneFilter
            // 
            lblZoneFilter.AutoSize = true;
            lblZoneFilter.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblZoneFilter.Location = new Point(235, 18);
            lblZoneFilter.Name = "lblZoneFilter";
            lblZoneFilter.Size = new Size(49, 23);
            lblZoneFilter.TabIndex = 17;
            lblZoneFilter.Text = "Zone";
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Location = new Point(23, 17);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(53, 20);
            lblSearch.TabIndex = 16;
            lblSearch.Text = "Search";
            // 
            // cmdStatus
            // 
            cmdStatus.FormattingEnabled = true;
            cmdStatus.Location = new Point(567, 13);
            cmdStatus.Name = "cmdStatus";
            cmdStatus.Size = new Size(151, 28);
            cmdStatus.TabIndex = 32;
            // 
            // colSlot
            // 
            colSlot.HeaderText = "Slot";
            colSlot.MinimumWidth = 6;
            colSlot.Name = "colSlot";
            colSlot.ReadOnly = true;
            // 
            // colZone
            // 
            colZone.HeaderText = "Zone";
            colZone.MinimumWidth = 6;
            colZone.Name = "colZone";
            colZone.ReadOnly = true;
            // 
            // colStatus
            // 
            colStatus.HeaderText = "Status";
            colStatus.MinimumWidth = 6;
            colStatus.Name = "colStatus";
            colStatus.ReadOnly = true;
            // 
            // SlotsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(cmdStatus);
            Controls.Add(dgv);
            Controls.Add(this.cmbZoneFilter);
            Controls.Add(btnUpdate);
            Controls.Add(btnDelete);
            Controls.Add(btnClear);
            Controls.Add(btnAdd);
            Controls.Add(textBox5);
            Controls.Add(txtPhone);
            Controls.Add(textBox1);
            Controls.Add(this.lblZone);
            Controls.Add(this.lblSlot);
            Controls.Add(lblOwner);
            Controls.Add(lblZoneFilter);
            Controls.Add(lblSearch);
            Name = "SlotsForm";
            Text = "Slots";
            ((System.ComponentModel.ISupportInitialize)dgv).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgv;
        private ComboBox cmbZoneFilter;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnClear;
        private Button btnAdd;
        private TextBox textBox5;
        private TextBox txtPhone;
        private TextBox textBox1;
        private Label lblZone;
        private Label lblSlot;
        private Label lblOwner;
        private Label lblZoneFilter;
        private Label lblSearch;
        private ComboBox cmdStatus;
        private DataGridViewTextBoxColumn colSlot;
        private DataGridViewTextBoxColumn colZone;
        private DataGridViewTextBoxColumn colStatus;
    }
}