namespace Parking_System
{
    partial class mainForm
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
            label1 = new Label();
            lbltotalslots = new Label();
            lblOccupied = new Label();
            lblfree = new Label();
            toolStrip1 = new ToolStrip();
            meunVehicles = new ToolStripLabel();
            menuSlots = new ToolStripLabel();
            menuEntry = new ToolStripLabel();
            menuTickets = new ToolStripLabel();
            menuReports = new ToolStripLabel();
            menuExit = new ToolStripLabel();
            lblRevenue = new Label();
            panel2 = new Panel();
            lblNumOccupied = new Label();
            panel3 = new Panel();
            lblNumRevenue = new Label();
            panel4 = new Panel();
            lblNumSlot = new Label();
            panel5 = new Panel();
            lblNumFree = new Label();
            toolStrip1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(331, 9);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 0;
            label1.Text = "label1";
            // 
            // lbltotalslots
            // 
            lbltotalslots.AutoSize = true;
            lbltotalslots.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbltotalslots.Location = new Point(18, 11);
            lbltotalslots.Name = "lbltotalslots";
            lbltotalslots.Size = new Size(101, 28);
            lbltotalslots.TabIndex = 1;
            lbltotalslots.Text = "total slots";
            // 
            // lblOccupied
            // 
            lblOccupied.AutoSize = true;
            lblOccupied.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblOccupied.Location = new Point(17, 9);
            lblOccupied.Name = "lblOccupied";
            lblOccupied.Size = new Size(97, 28);
            lblOccupied.TabIndex = 2;
            lblOccupied.Text = "Occupied";
            // 
            // lblfree
            // 
            lblfree.AutoSize = true;
            lblfree.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblfree.Location = new Point(20, 8);
            lblfree.Name = "lblfree";
            lblfree.Size = new Size(51, 28);
            lblfree.TabIndex = 3;
            lblfree.Text = "Free";
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { meunVehicles, menuSlots, menuEntry, menuTickets, menuReports, menuExit });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(1264, 28);
            toolStrip1.TabIndex = 4;
            toolStrip1.Text = "toolStrip1";
            // 
            // meunVehicles
            // 
            meunVehicles.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            meunVehicles.Name = "meunVehicles";
            meunVehicles.Size = new Size(79, 25);
            meunVehicles.Text = "Vehicles";
            // 
            // menuSlots
            // 
            menuSlots.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            menuSlots.Name = "menuSlots";
            menuSlots.Size = new Size(53, 25);
            menuSlots.Text = "Slots";
            // 
            // menuEntry
            // 
            menuEntry.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            menuEntry.Name = "menuEntry";
            menuEntry.Size = new Size(93, 25);
            menuEntry.Text = "Entry/Exit";
            // 
            // menuTickets
            // 
            menuTickets.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            menuTickets.Name = "menuTickets";
            menuTickets.Size = new Size(69, 25);
            menuTickets.Text = "Tickets";
            // 
            // menuReports
            // 
            menuReports.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            menuReports.Name = "menuReports";
            menuReports.Size = new Size(78, 25);
            menuReports.Text = "Reports";
            // 
            // menuExit
            // 
            menuExit.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            menuExit.Name = "menuExit";
            menuExit.Size = new Size(42, 25);
            menuExit.Text = "Exit";
            // 
            // lblRevenue
            // 
            lblRevenue.AutoSize = true;
            lblRevenue.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRevenue.Location = new Point(15, 11);
            lblRevenue.Name = "lblRevenue";
            lblRevenue.Size = new Size(129, 25);
            lblRevenue.TabIndex = 5;
            lblRevenue.Text = "Revenue(EGP)";
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Controls.Add(lblNumOccupied);
            panel2.Controls.Add(lblOccupied);
            panel2.Location = new Point(235, 44);
            panel2.Name = "panel2";
            panel2.Size = new Size(231, 101);
            panel2.TabIndex = 0;
            // 
            // lblNumOccupied
            // 
            lblNumOccupied.AutoSize = true;
            lblNumOccupied.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNumOccupied.Location = new Point(17, 53);
            lblNumOccupied.Name = "lblNumOccupied";
            lblNumOccupied.Size = new Size(28, 28);
            lblNumOccupied.TabIndex = 3;
            lblNumOccupied.Text = "--";
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.Fixed3D;
            panel3.Controls.Add(lblNumRevenue);
            panel3.Controls.Add(lblRevenue);
            panel3.Location = new Point(472, 44);
            panel3.Name = "panel3";
            panel3.Size = new Size(250, 101);
            panel3.TabIndex = 0;
            // 
            // lblNumRevenue
            // 
            lblNumRevenue.AutoSize = true;
            lblNumRevenue.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNumRevenue.Location = new Point(15, 47);
            lblNumRevenue.Name = "lblNumRevenue";
            lblNumRevenue.Size = new Size(26, 25);
            lblNumRevenue.TabIndex = 6;
            lblNumRevenue.Text = "--";
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.Control;
            panel4.BorderStyle = BorderStyle.Fixed3D;
            panel4.Controls.Add(lblNumSlot);
            panel4.Controls.Add(lbltotalslots);
            panel4.Location = new Point(12, 44);
            panel4.Name = "panel4";
            panel4.Size = new Size(217, 101);
            panel4.TabIndex = 0;
            // 
            // lblNumSlot
            // 
            lblNumSlot.AutoSize = true;
            lblNumSlot.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNumSlot.Location = new Point(23, 57);
            lblNumSlot.Name = "lblNumSlot";
            lblNumSlot.Size = new Size(28, 28);
            lblNumSlot.TabIndex = 2;
            lblNumSlot.Text = "--";
            // 
            // panel5
            // 
            panel5.BorderStyle = BorderStyle.Fixed3D;
            panel5.Controls.Add(lblNumFree);
            panel5.Controls.Add(lblfree);
            panel5.Location = new Point(737, 44);
            panel5.Name = "panel5";
            panel5.Size = new Size(250, 101);
            panel5.TabIndex = 2;
            // 
            // lblNumFree
            // 
            lblNumFree.AutoSize = true;
            lblNumFree.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNumFree.Location = new Point(20, 44);
            lblNumFree.Name = "lblNumFree";
            lblNumFree.Size = new Size(28, 28);
            lblNumFree.TabIndex = 4;
            lblNumFree.Text = "--";
            // 
            // mainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1264, 480);
            Controls.Add(panel2);
            Controls.Add(panel3);
            Controls.Add(panel4);
            Controls.Add(panel5);
            Controls.Add(toolStrip1);
            Controls.Add(label1);
            Name = "mainForm";
            Text = "Parking management system";
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lbltotalslots;
        private Label lblOccupied;
        private Label lblfree;
        private ToolStrip toolStrip1;
        private ToolStripLabel meunVehicles;
        private ToolStripLabel menuSlots;
        private ToolStripLabel menuEntry;
        private ToolStripLabel menuTickets;
        private ToolStripLabel menuReports;
        private ToolStripLabel menuExit;
        private Label lblRevenue;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
        private Label lblNumSlot;
        private Label lblNumOccupied;
        private Label lblNumRevenue;
        private Label lblNumFree;
    }
}