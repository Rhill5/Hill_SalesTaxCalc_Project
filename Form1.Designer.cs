namespace Hill_SalesTaxCalc_Project
{
    partial class mainFrm
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
            this.mainLbl = new System.Windows.Forms.Label();
            this.txtBasePrice = new System.Windows.Forms.TextBox();
            this.lblBase = new System.Windows.Forms.Label();
            this.lblExtWrt = new System.Windows.Forms.Label();
            this.lblStateSold = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.cboWarranty = new System.Windows.Forms.ComboBox();
            this.cboState = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // mainLbl
            // 
            this.mainLbl.AutoSize = true;
            this.mainLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainLbl.Location = new System.Drawing.Point(18, 39);
            this.mainLbl.Name = "mainLbl";
            this.mainLbl.Size = new System.Drawing.Size(232, 13);
            this.mainLbl.TabIndex = 0;
            this.mainLbl.Text = "Billy Bob\'s Vehicle Sales Tax Calculator\r\n";
            // 
            // txtBasePrice
            // 
            this.txtBasePrice.Location = new System.Drawing.Point(117, 65);
            this.txtBasePrice.Name = "txtBasePrice";
            this.txtBasePrice.Size = new System.Drawing.Size(128, 20);
            this.txtBasePrice.TabIndex = 1;
            this.txtBasePrice.TextChanged += new System.EventHandler(this.txtBasePrice_TextChanged);
            // 
            // lblBase
            // 
            this.lblBase.AutoSize = true;
            this.lblBase.Location = new System.Drawing.Point(18, 68);
            this.lblBase.Name = "lblBase";
            this.lblBase.Size = new System.Drawing.Size(96, 13);
            this.lblBase.TabIndex = 2;
            this.lblBase.Text = "Base Vehicle Price";
            // 
            // lblExtWrt
            // 
            this.lblExtWrt.AutoSize = true;
            this.lblExtWrt.Location = new System.Drawing.Point(16, 94);
            this.lblExtWrt.Name = "lblExtWrt";
            this.lblExtWrt.Size = new System.Drawing.Size(98, 13);
            this.lblExtWrt.TabIndex = 4;
            this.lblExtWrt.Text = "Extended Warranty";
            // 
            // lblStateSold
            // 
            this.lblStateSold.AutoSize = true;
            this.lblStateSold.Location = new System.Drawing.Point(58, 126);
            this.lblStateSold.Name = "lblStateSold";
            this.lblStateSold.Size = new System.Drawing.Size(56, 13);
            this.lblStateSold.TabIndex = 6;
            this.lblStateSold.Text = "State Sold";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(200, 121);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 7;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(119, 181);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 8;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(200, 181);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.Location = new System.Drawing.Point(75, 152);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(62, 13);
            this.lblTotalPrice.TabIndex = 10;
            this.lblTotalPrice.Text = "placeholder";
            // 
            // cboWarranty
            // 
            this.cboWarranty.FormattingEnabled = true;
            this.cboWarranty.Items.AddRange(new object[] {
            "No Warranty",
            "One Year",
            "Two Year",
            "Three Year"});
            this.cboWarranty.Location = new System.Drawing.Point(116, 91);
            this.cboWarranty.Name = "cboWarranty";
            this.cboWarranty.Size = new System.Drawing.Size(128, 21);
            this.cboWarranty.TabIndex = 11;
            this.cboWarranty.SelectedIndexChanged += new System.EventHandler(this.cboWarranty_SelectedIndexChanged);
            // 
            // cboState
            // 
            this.cboState.FormattingEnabled = true;
            this.cboState.Items.AddRange(new object[] {
            "WA",
            "OR"});
            this.cboState.Location = new System.Drawing.Point(116, 118);
            this.cboState.Name = "cboState";
            this.cboState.Size = new System.Drawing.Size(50, 21);
            this.cboState.TabIndex = 12;
            this.cboState.SelectedIndexChanged += new System.EventHandler(this.cboState_SelectedIndexChanged);
            // 
            // mainFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 321);
            this.Controls.Add(this.cboState);
            this.Controls.Add(this.cboWarranty);
            this.Controls.Add(this.lblTotalPrice);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.lblStateSold);
            this.Controls.Add(this.lblExtWrt);
            this.Controls.Add(this.lblBase);
            this.Controls.Add(this.txtBasePrice);
            this.Controls.Add(this.mainLbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "mainFrm";
            this.Text = "Billy Bob\'s Vehicle Sales Tax Calculator";
            this.Load += new System.EventHandler(this.mainFrm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label mainLbl;
        private System.Windows.Forms.TextBox txtBasePrice;
        private System.Windows.Forms.Label lblBase;
        private System.Windows.Forms.Label lblExtWrt;
        private System.Windows.Forms.Label lblStateSold;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblTotalPrice;
        private System.Windows.Forms.ComboBox cboWarranty;
        private System.Windows.Forms.ComboBox cboState;
    }
}

