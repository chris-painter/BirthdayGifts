namespace ChrisPainter_BirthdayGiftPlanner
{
    partial class frmMain
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
            this.dgvPerson = new System.Windows.Forms.DataGridView();
            this.dgvGift = new System.Windows.Forms.DataGridView();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.txtRelationship = new System.Windows.Forms.TextBox();
            this.lblRelationship = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblBirthday = new System.Windows.Forms.Label();
            this.txtBirthday = new System.Windows.Forms.TextBox();
            this.lblDaystoBirthday = new System.Windows.Forms.Label();
            this.txtDaystoBirthday = new System.Windows.Forms.TextBox();
            this.lblRemaining = new System.Windows.Forms.Label();
            this.txtRemaining = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblBudget = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.txtBudget = new System.Windows.Forms.TextBox();
            this.btnAddTop = new System.Windows.Forms.Button();
            this.btnRemoveTop = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnEditBottom = new System.Windows.Forms.Button();
            this.btnAddBottom = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnDataFill = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPerson)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGift)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPerson
            // 
            this.dgvPerson.AllowUserToAddRows = false;
            this.dgvPerson.AllowUserToDeleteRows = false;
            this.dgvPerson.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPerson.Location = new System.Drawing.Point(26, 50);
            this.dgvPerson.Name = "dgvPerson";
            this.dgvPerson.RowTemplate.Height = 40;
            this.dgvPerson.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPerson.Size = new System.Drawing.Size(1315, 550);
            this.dgvPerson.TabIndex = 0;
            this.dgvPerson.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPerson_CellClick);
            this.dgvPerson.SelectionChanged += new System.EventHandler(this.dgvPerson_SelectionChanged);
            // 
            // dgvGift
            // 
            this.dgvGift.AllowUserToAddRows = false;
            this.dgvGift.AllowUserToDeleteRows = false;
            this.dgvGift.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGift.Location = new System.Drawing.Point(26, 864);
            this.dgvGift.Name = "dgvGift";
            this.dgvGift.RowTemplate.Height = 40;
            this.dgvGift.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvGift.Size = new System.Drawing.Size(1315, 361);
            this.dgvGift.TabIndex = 1;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(270, 629);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(393, 38);
            this.txtName.TabIndex = 2;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(20, 632);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(90, 32);
            this.lblName.TabIndex = 3;
            this.lblName.Text = "Name";
            // 
            // txtRelationship
            // 
            this.txtRelationship.Location = new System.Drawing.Point(270, 685);
            this.txtRelationship.Name = "txtRelationship";
            this.txtRelationship.Size = new System.Drawing.Size(393, 38);
            this.txtRelationship.TabIndex = 2;
            // 
            // lblRelationship
            // 
            this.lblRelationship.AutoSize = true;
            this.lblRelationship.Location = new System.Drawing.Point(20, 688);
            this.lblRelationship.Name = "lblRelationship";
            this.lblRelationship.Size = new System.Drawing.Size(174, 32);
            this.lblRelationship.TabIndex = 3;
            this.lblRelationship.Text = "Relationship";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 688);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 32);
            this.label1.TabIndex = 3;
            this.label1.Text = "Relationship";
            // 
            // lblBirthday
            // 
            this.lblBirthday.AutoSize = true;
            this.lblBirthday.Location = new System.Drawing.Point(20, 750);
            this.lblBirthday.Name = "lblBirthday";
            this.lblBirthday.Size = new System.Drawing.Size(120, 32);
            this.lblBirthday.TabIndex = 5;
            this.lblBirthday.Text = "Birthday";
            // 
            // txtBirthday
            // 
            this.txtBirthday.Location = new System.Drawing.Point(270, 747);
            this.txtBirthday.Name = "txtBirthday";
            this.txtBirthday.Size = new System.Drawing.Size(393, 38);
            this.txtBirthday.TabIndex = 4;
            // 
            // lblDaystoBirthday
            // 
            this.lblDaystoBirthday.AutoSize = true;
            this.lblDaystoBirthday.Location = new System.Drawing.Point(20, 809);
            this.lblDaystoBirthday.Name = "lblDaystoBirthday";
            this.lblDaystoBirthday.Size = new System.Drawing.Size(231, 32);
            this.lblDaystoBirthday.TabIndex = 7;
            this.lblDaystoBirthday.Text = "Days To Birthday";
            // 
            // txtDaystoBirthday
            // 
            this.txtDaystoBirthday.Location = new System.Drawing.Point(270, 806);
            this.txtDaystoBirthday.Name = "txtDaystoBirthday";
            this.txtDaystoBirthday.ReadOnly = true;
            this.txtDaystoBirthday.Size = new System.Drawing.Size(393, 38);
            this.txtDaystoBirthday.TabIndex = 6;
            // 
            // lblRemaining
            // 
            this.lblRemaining.AutoSize = true;
            this.lblRemaining.Location = new System.Drawing.Point(698, 750);
            this.lblRemaining.Name = "lblRemaining";
            this.lblRemaining.Size = new System.Drawing.Size(152, 32);
            this.lblRemaining.TabIndex = 14;
            this.lblRemaining.Text = "Remaining";
            // 
            // txtRemaining
            // 
            this.txtRemaining.Location = new System.Drawing.Point(948, 747);
            this.txtRemaining.Name = "txtRemaining";
            this.txtRemaining.ReadOnly = true;
            this.txtRemaining.Size = new System.Drawing.Size(393, 38);
            this.txtRemaining.TabIndex = 13;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(698, 688);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(79, 32);
            this.lblTotal.TabIndex = 10;
            this.lblTotal.Text = "Total";
            // 
            // lblBudget
            // 
            this.lblBudget.AutoSize = true;
            this.lblBudget.Location = new System.Drawing.Point(698, 632);
            this.lblBudget.Name = "lblBudget";
            this.lblBudget.Size = new System.Drawing.Size(106, 32);
            this.lblBudget.TabIndex = 12;
            this.lblBudget.Text = "Budget";
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(948, 685);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(393, 38);
            this.txtTotal.TabIndex = 8;
            // 
            // txtBudget
            // 
            this.txtBudget.Location = new System.Drawing.Point(948, 629);
            this.txtBudget.Name = "txtBudget";
            this.txtBudget.Size = new System.Drawing.Size(393, 38);
            this.txtBudget.TabIndex = 9;
            // 
            // btnAddTop
            // 
            this.btnAddTop.Location = new System.Drawing.Point(1367, 50);
            this.btnAddTop.Name = "btnAddTop";
            this.btnAddTop.Size = new System.Drawing.Size(163, 73);
            this.btnAddTop.TabIndex = 15;
            this.btnAddTop.Text = "Add";
            this.btnAddTop.UseVisualStyleBackColor = true;
            this.btnAddTop.Click += new System.EventHandler(this.btnAddTop_Click);
            // 
            // btnRemoveTop
            // 
            this.btnRemoveTop.Location = new System.Drawing.Point(1367, 139);
            this.btnRemoveTop.Name = "btnRemoveTop";
            this.btnRemoveTop.Size = new System.Drawing.Size(163, 73);
            this.btnRemoveTop.TabIndex = 16;
            this.btnRemoveTop.Text = "Remove";
            this.btnRemoveTop.UseVisualStyleBackColor = true;
            this.btnRemoveTop.Click += new System.EventHandler(this.btnRemoveTop_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(1367, 231);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(163, 73);
            this.btnPrint.TabIndex = 17;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(1367, 1045);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(163, 73);
            this.btnRemove.TabIndex = 20;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnEditBottom
            // 
            this.btnEditBottom.Location = new System.Drawing.Point(1367, 953);
            this.btnEditBottom.Name = "btnEditBottom";
            this.btnEditBottom.Size = new System.Drawing.Size(163, 73);
            this.btnEditBottom.TabIndex = 19;
            this.btnEditBottom.Text = "Edit";
            this.btnEditBottom.UseVisualStyleBackColor = true;
            this.btnEditBottom.Click += new System.EventHandler(this.btnEditBottom_Click);
            // 
            // btnAddBottom
            // 
            this.btnAddBottom.Location = new System.Drawing.Point(1367, 864);
            this.btnAddBottom.Name = "btnAddBottom";
            this.btnAddBottom.Size = new System.Drawing.Size(163, 73);
            this.btnAddBottom.TabIndex = 18;
            this.btnAddBottom.Text = "Add";
            this.btnAddBottom.UseVisualStyleBackColor = true;
            this.btnAddBottom.Click += new System.EventHandler(this.btnAddBottom_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(1367, 629);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(163, 73);
            this.btnUpdate.TabIndex = 21;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(1367, 1256);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(163, 73);
            this.btnExit.TabIndex = 22;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnDataFill
            // 
            this.btnDataFill.Location = new System.Drawing.Point(1178, 1256);
            this.btnDataFill.Name = "btnDataFill";
            this.btnDataFill.Size = new System.Drawing.Size(163, 73);
            this.btnDataFill.TabIndex = 23;
            this.btnDataFill.Text = "Data Fill";
            this.btnDataFill.UseVisualStyleBackColor = true;
            this.btnDataFill.Click += new System.EventHandler(this.btnDataFill_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1600, 1358);
            this.Controls.Add(this.btnDataFill);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnEditBottom);
            this.Controls.Add(this.btnAddBottom);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnRemoveTop);
            this.Controls.Add(this.btnAddTop);
            this.Controls.Add(this.lblRemaining);
            this.Controls.Add(this.txtRemaining);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblBudget);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.txtBudget);
            this.Controls.Add(this.lblDaystoBirthday);
            this.Controls.Add(this.txtDaystoBirthday);
            this.Controls.Add(this.lblBirthday);
            this.Controls.Add(this.txtBirthday);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblRelationship);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtRelationship);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.dgvGift);
            this.Controls.Add(this.dgvPerson);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Birthday Gift Planner - Chris Painter";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPerson)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGift)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPerson;
        private System.Windows.Forms.DataGridView dgvGift;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtRelationship;
        private System.Windows.Forms.Label lblRelationship;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblBirthday;
        private System.Windows.Forms.TextBox txtBirthday;
        private System.Windows.Forms.Label lblDaystoBirthday;
        private System.Windows.Forms.TextBox txtDaystoBirthday;
        private System.Windows.Forms.Label lblRemaining;
        private System.Windows.Forms.TextBox txtRemaining;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblBudget;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.TextBox txtBudget;
        private System.Windows.Forms.Button btnAddTop;
        private System.Windows.Forms.Button btnRemoveTop;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnEditBottom;
        private System.Windows.Forms.Button btnAddBottom;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnDataFill;
    }
}

