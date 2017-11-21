namespace ChrisPainter_BirthdayGiftPlanner
{
    partial class frmAddGift
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
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.nud = new System.Windows.Forms.NumericUpDown();
            this.lblRemaining = new System.Windows.Forms.Label();
            this.txtRemaining = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblBudget = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.txtBudget = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nud)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(29, 93);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(80, 32);
            this.lblPrice.TabIndex = 15;
            this.lblPrice.Text = "Price";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(29, 37);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(142, 32);
            this.lblName.TabIndex = 17;
            this.lblName.Text = "Gift Name";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(279, 90);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(393, 38);
            this.txtPrice.TabIndex = 2;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(279, 34);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(393, 38);
            this.txtName.TabIndex = 1;
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(29, 155);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(122, 32);
            this.lblQuantity.TabIndex = 18;
            this.lblQuantity.Text = "Quantity";
            // 
            // nud
            // 
            this.nud.Location = new System.Drawing.Point(279, 153);
            this.nud.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nud.Name = "nud";
            this.nud.Size = new System.Drawing.Size(100, 38);
            this.nud.TabIndex = 3;
            this.nud.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblRemaining
            // 
            this.lblRemaining.AutoSize = true;
            this.lblRemaining.Location = new System.Drawing.Point(29, 334);
            this.lblRemaining.Name = "lblRemaining";
            this.lblRemaining.Size = new System.Drawing.Size(152, 32);
            this.lblRemaining.TabIndex = 25;
            this.lblRemaining.Text = "Remaining";
            // 
            // txtRemaining
            // 
            this.txtRemaining.Location = new System.Drawing.Point(279, 331);
            this.txtRemaining.Name = "txtRemaining";
            this.txtRemaining.ReadOnly = true;
            this.txtRemaining.Size = new System.Drawing.Size(393, 38);
            this.txtRemaining.TabIndex = 6;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(29, 272);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(79, 32);
            this.lblTotal.TabIndex = 22;
            this.lblTotal.Text = "Total";
            // 
            // lblBudget
            // 
            this.lblBudget.AutoSize = true;
            this.lblBudget.Location = new System.Drawing.Point(29, 216);
            this.lblBudget.Name = "lblBudget";
            this.lblBudget.Size = new System.Drawing.Size(106, 32);
            this.lblBudget.TabIndex = 23;
            this.lblBudget.Text = "Budget";
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(279, 269);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(393, 38);
            this.txtTotal.TabIndex = 5;
            // 
            // txtBudget
            // 
            this.txtBudget.Location = new System.Drawing.Point(279, 213);
            this.txtBudget.Name = "txtBudget";
            this.txtBudget.ReadOnly = true;
            this.txtBudget.Size = new System.Drawing.Size(393, 38);
            this.txtBudget.TabIndex = 4;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(331, 402);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(163, 73);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(516, 402);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(163, 73);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // frmAddGift
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1097, 880);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.lblRemaining);
            this.Controls.Add(this.txtRemaining);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblBudget);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.txtBudget);
            this.Controls.Add(this.nud);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtName);
            this.Name = "frmAddGift";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAddGift";
            ((System.ComponentModel.ISupportInitialize)(this.nud)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.NumericUpDown nud;
        private System.Windows.Forms.Label lblRemaining;
        private System.Windows.Forms.TextBox txtRemaining;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblBudget;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.TextBox txtBudget;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
    }
}