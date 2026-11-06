namespace Parking_System
{
    partial class VehiclesForm
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
            lblSearch = new Label();
            lblPlate = new Label();
            lblOwner = new Label();
            lblPhone = new Label();
            lblType = new Label();
            textBox1 = new TextBox();
            txtPlate = new TextBox();
            txtOwner = new TextBox();
            txtPhone = new TextBox();
            textBox5 = new TextBox();
            btnAdd = new Button();
            btnClear = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            cmbFilter = new ComboBox();
            dgv = new DataGridView();
            colPlate = new DataGridViewTextBoxColumn();
            colOwner = new DataGridViewTextBoxColumn();
            colPhone = new DataGridViewTextBoxColumn();
            colType = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgv).BeginInit();
            SuspendLayout();
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Location = new Point(23, 18);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(53, 20);
            lblSearch.TabIndex = 0;
            lblSearch.Text = "Search";
            // 
            // lblPlate
            // 
            lblPlate.AutoSize = true;
            lblPlate.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPlate.Location = new Point(584, 93);
            lblPlate.Name = "lblPlate";
            lblPlate.Size = new Size(48, 23);
            lblPlate.TabIndex = 1;
            lblPlate.Text = "Plate";
            // 
            // lblOwner
            // 
            lblOwner.AutoSize = true;
            lblOwner.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblOwner.Location = new Point(582, 143);
            lblOwner.Name = "lblOwner";
            lblOwner.Size = new Size(61, 23);
            lblOwner.TabIndex = 2;
            lblOwner.Text = "Owner";
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPhone.Location = new Point(582, 195);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(59, 23);
            lblPhone.TabIndex = 3;
            lblPhone.Text = "Phone";
            // 
            // lblType
            // 
            lblType.AutoSize = true;
            lblType.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblType.Location = new Point(582, 248);
            lblType.Name = "lblType";
            lblType.Size = new Size(46, 23);
            lblType.TabIndex = 4;
            lblType.Text = "Type";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(79, 15);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 5;
            // 
            // txtPlate
            // 
            txtPlate.Location = new Point(663, 89);
            txtPlate.Name = "txtPlate";
            txtPlate.Size = new Size(125, 27);
            txtPlate.TabIndex = 6;
            // 
            // txtOwner
            // 
            txtOwner.Location = new Point(663, 136);
            txtOwner.Name = "txtOwner";
            txtOwner.Size = new Size(125, 27);
            txtOwner.TabIndex = 7;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(663, 188);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(125, 27);
            txtPhone.TabIndex = 8;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(663, 241);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(125, 27);
            textBox5.TabIndex = 9;
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdd.Location = new Point(582, 297);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 10;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            btnClear.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClear.Location = new Point(694, 368);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(94, 29);
            btnClear.TabIndex = 11;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDelete.Location = new Point(582, 368);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 12;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            btnUpdate.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdate.Location = new Point(694, 297);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 29);
            btnUpdate.TabIndex = 13;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            // 
            // cmbFilter
            // 
            cmbFilter.FormattingEnabled = true;
            cmbFilter.Location = new Point(232, 15);
            cmbFilter.Name = "cmbFilter";
            cmbFilter.Size = new Size(151, 28);
            cmbFilter.TabIndex = 14;
            // 
            // dgv
            // 
            dgv.AllowUserToAddRows = false;
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.BackgroundColor = SystemColors.ButtonFace;
            dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv.Columns.AddRange(new DataGridViewColumn[] { colPlate, colOwner, colPhone, colType });
            dgv.Location = new Point(12, 66);
            dgv.Name = "dgv";
            dgv.RowHeadersWidth = 51;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.Size = new Size(530, 372);
            dgv.TabIndex = 15;
            // 
            // colPlate
            // 
            colPlate.HeaderText = "Plate";
            colPlate.MinimumWidth = 6;
            colPlate.Name = "colPlate";
            colPlate.ReadOnly = true;
            // 
            // colOwner
            // 
            colOwner.HeaderText = "Owner";
            colOwner.MinimumWidth = 6;
            colOwner.Name = "colOwner";
            colOwner.ReadOnly = true;
            // 
            // colPhone
            // 
            colPhone.HeaderText = "Phone";
            colPhone.MinimumWidth = 6;
            colPhone.Name = "colPhone";
            colPhone.ReadOnly = true;
            // 
            // colType
            // 
            colType.HeaderText = "Type";
            colType.MinimumWidth = 6;
            colType.Name = "colType";
            colType.ReadOnly = true;
            // 
            // VehiclesForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(831, 450);
            Controls.Add(dgv);
            Controls.Add(cmbFilter);
            Controls.Add(btnUpdate);
            Controls.Add(btnDelete);
            Controls.Add(btnClear);
            Controls.Add(btnAdd);
            Controls.Add(textBox5);
            Controls.Add(txtPhone);
            Controls.Add(txtOwner);
            Controls.Add(txtPlate);
            Controls.Add(textBox1);
            Controls.Add(lblType);
            Controls.Add(lblPhone);
            Controls.Add(lblOwner);
            Controls.Add(lblPlate);
            Controls.Add(lblSearch);
            Name = "VehiclesForm";
            Text = "Vehicles";
            ((System.ComponentModel.ISupportInitialize)dgv).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblSearch;
        private Label lblPlate;
        private Label lblOwner;
        private Label lblPhone;
        private Label lblType;
        private TextBox textBox1;
        private TextBox txtPlate;
        private TextBox txtOwner;
        private TextBox txtPhone;
        private TextBox textBox5;
        private Button btnAdd;
        private Button btnClear;
        private Button btnDelete;
        private Button btnUpdate;
        private ComboBox cmbFilter;
        private DataGridView dgv;
        private DataGridViewTextBoxColumn colPlate;
        private DataGridViewTextBoxColumn colOwner;
        private DataGridViewTextBoxColumn colPhone;
        private DataGridViewTextBoxColumn colType;
    }
}