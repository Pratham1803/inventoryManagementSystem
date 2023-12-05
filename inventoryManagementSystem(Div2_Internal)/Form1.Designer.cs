namespace inventoryManagementSystem_Div2_Internal_
{
    partial class Form1
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabInsert = new System.Windows.Forms.TabPage();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.txtBrand = new System.Windows.Forms.TextBox();
            this.txtPricePerProduct = new System.Windows.Forms.TextBox();
            this.txtQuan = new System.Windows.Forms.TextBox();
            this.txtSerialNum = new System.Windows.Forms.TextBox();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabUpdate = new System.Windows.Forms.TabPage();
            this.txtUpMoreQuan = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtUpQuan = new System.Windows.Forms.TextBox();
            this.txtUpPrice = new System.Windows.Forms.TextBox();
            this.txtUpBrand = new System.Windows.Forms.TextBox();
            this.txtUpSrNo = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbUpdateProduct = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tabDisplay = new System.Windows.Forms.TabPage();
            this.dgDisplay = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabInsert.SuspendLayout();
            this.tabUpdate.SuspendLayout();
            this.tabDisplay.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgDisplay)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabInsert);
            this.tabControl1.Controls.Add(this.tabUpdate);
            this.tabControl1.Controls.Add(this.tabDisplay);
            this.tabControl1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(2, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(625, 452);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabController_tabChanged);
            // 
            // tabInsert
            // 
            this.tabInsert.BackColor = System.Drawing.Color.Gainsboro;
            this.tabInsert.Controls.Add(this.btnReset);
            this.tabInsert.Controls.Add(this.btnInsert);
            this.tabInsert.Controls.Add(this.txtBrand);
            this.tabInsert.Controls.Add(this.txtPricePerProduct);
            this.tabInsert.Controls.Add(this.txtQuan);
            this.tabInsert.Controls.Add(this.txtSerialNum);
            this.tabInsert.Controls.Add(this.txtProductName);
            this.tabInsert.Controls.Add(this.label5);
            this.tabInsert.Controls.Add(this.label4);
            this.tabInsert.Controls.Add(this.label3);
            this.tabInsert.Controls.Add(this.label2);
            this.tabInsert.Controls.Add(this.label1);
            this.tabInsert.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabInsert.Location = new System.Drawing.Point(4, 28);
            this.tabInsert.Name = "tabInsert";
            this.tabInsert.Padding = new System.Windows.Forms.Padding(3);
            this.tabInsert.Size = new System.Drawing.Size(617, 420);
            this.tabInsert.TabIndex = 0;
            this.tabInsert.Text = "Add Record";
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(242, 306);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(113, 49);
            this.btnReset.TabIndex = 11;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Clicked);
            // 
            // btnInsert
            // 
            this.btnInsert.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsert.Location = new System.Drawing.Point(364, 306);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(113, 49);
            this.btnInsert.TabIndex = 10;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Clicked);
            // 
            // txtBrand
            // 
            this.txtBrand.Location = new System.Drawing.Point(242, 236);
            this.txtBrand.Name = "txtBrand";
            this.txtBrand.Size = new System.Drawing.Size(235, 27);
            this.txtBrand.TabIndex = 9;
            // 
            // txtPricePerProduct
            // 
            this.txtPricePerProduct.Location = new System.Drawing.Point(242, 188);
            this.txtPricePerProduct.Name = "txtPricePerProduct";
            this.txtPricePerProduct.Size = new System.Drawing.Size(235, 27);
            this.txtPricePerProduct.TabIndex = 8;
            this.txtPricePerProduct.Tag = "";
            this.txtPricePerProduct.Text = "0";
            this.txtPricePerProduct.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtPricePerProduct.TextChanged += new System.EventHandler(this.txtBox_numEnter);
            // 
            // txtQuan
            // 
            this.txtQuan.Location = new System.Drawing.Point(242, 136);
            this.txtQuan.Name = "txtQuan";
            this.txtQuan.Size = new System.Drawing.Size(235, 27);
            this.txtQuan.TabIndex = 7;
            this.txtQuan.Text = "0";
            this.txtQuan.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtQuan.TextChanged += new System.EventHandler(this.txtBox_numEnter);
            // 
            // txtSerialNum
            // 
            this.txtSerialNum.Location = new System.Drawing.Point(242, 80);
            this.txtSerialNum.Name = "txtSerialNum";
            this.txtSerialNum.Size = new System.Drawing.Size(235, 27);
            this.txtSerialNum.TabIndex = 6;
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(242, 30);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(235, 27);
            this.txtProductName.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(140, 244);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 19);
            this.label5.TabIndex = 4;
            this.label5.Text = "Brand :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(85, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Serial Number :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(87, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Price/Product :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(121, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Quantity :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(86, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Product name :";
            // 
            // tabUpdate
            // 
            this.tabUpdate.BackColor = System.Drawing.Color.LightGray;
            this.tabUpdate.Controls.Add(this.txtUpMoreQuan);
            this.tabUpdate.Controls.Add(this.label11);
            this.tabUpdate.Controls.Add(this.btnUpdate);
            this.tabUpdate.Controls.Add(this.txtUpQuan);
            this.tabUpdate.Controls.Add(this.txtUpPrice);
            this.tabUpdate.Controls.Add(this.txtUpBrand);
            this.tabUpdate.Controls.Add(this.txtUpSrNo);
            this.tabUpdate.Controls.Add(this.label10);
            this.tabUpdate.Controls.Add(this.label9);
            this.tabUpdate.Controls.Add(this.label8);
            this.tabUpdate.Controls.Add(this.label7);
            this.tabUpdate.Controls.Add(this.cmbUpdateProduct);
            this.tabUpdate.Controls.Add(this.label6);
            this.tabUpdate.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabUpdate.Location = new System.Drawing.Point(4, 28);
            this.tabUpdate.Name = "tabUpdate";
            this.tabUpdate.Padding = new System.Windows.Forms.Padding(3);
            this.tabUpdate.Size = new System.Drawing.Size(617, 420);
            this.tabUpdate.TabIndex = 1;
            this.tabUpdate.Text = "Update Inventory";
            // 
            // txtUpMoreQuan
            // 
            this.txtUpMoreQuan.Location = new System.Drawing.Point(160, 257);
            this.txtUpMoreQuan.Name = "txtUpMoreQuan";
            this.txtUpMoreQuan.Size = new System.Drawing.Size(138, 27);
            this.txtUpMoreQuan.TabIndex = 14;
            this.txtUpMoreQuan.Text = "0";
            this.txtUpMoreQuan.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtUpMoreQuan.TextChanged += new System.EventHandler(this.txtBox_numEnter);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(22, 260);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(113, 19);
            this.label11.TabIndex = 13;
            this.label11.Text = "Add  Quantity :";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(383, 251);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(204, 47);
            this.btnUpdate.TabIndex = 12;
            this.btnUpdate.Text = "Update Record";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Clicked);
            // 
            // txtUpQuan
            // 
            this.txtUpQuan.Location = new System.Drawing.Point(449, 112);
            this.txtUpQuan.Name = "txtUpQuan";
            this.txtUpQuan.ReadOnly = true;
            this.txtUpQuan.Size = new System.Drawing.Size(138, 27);
            this.txtUpQuan.TabIndex = 10;
            this.txtUpQuan.Text = "0";
            this.txtUpQuan.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtUpQuan.TextChanged += new System.EventHandler(this.txtBox_numEnter);
            // 
            // txtUpPrice
            // 
            this.txtUpPrice.Location = new System.Drawing.Point(449, 186);
            this.txtUpPrice.Name = "txtUpPrice";
            this.txtUpPrice.ReadOnly = true;
            this.txtUpPrice.Size = new System.Drawing.Size(138, 27);
            this.txtUpPrice.TabIndex = 9;
            this.txtUpPrice.Text = "0";
            this.txtUpPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtUpPrice.TextChanged += new System.EventHandler(this.txtBox_numEnter);
            // 
            // txtUpBrand
            // 
            this.txtUpBrand.Location = new System.Drawing.Point(94, 186);
            this.txtUpBrand.Name = "txtUpBrand";
            this.txtUpBrand.ReadOnly = true;
            this.txtUpBrand.Size = new System.Drawing.Size(204, 27);
            this.txtUpBrand.TabIndex = 8;
            // 
            // txtUpSrNo
            // 
            this.txtUpSrNo.Location = new System.Drawing.Point(94, 112);
            this.txtUpSrNo.Name = "txtUpSrNo";
            this.txtUpSrNo.ReadOnly = true;
            this.txtUpSrNo.Size = new System.Drawing.Size(204, 27);
            this.txtUpSrNo.TabIndex = 7;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(26, 186);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 19);
            this.label10.TabIndex = 6;
            this.label10.Text = "Brand :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(330, 189);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(113, 19);
            this.label9.TabIndex = 5;
            this.label9.Text = "Price/Product :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(330, 115);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 19);
            this.label8.TabIndex = 4;
            this.label8.Text = "Quantity  :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(22, 115);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 19);
            this.label7.TabIndex = 3;
            this.label7.Text = "Sr. No. :";
            // 
            // cmbUpdateProduct
            // 
            this.cmbUpdateProduct.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUpdateProduct.FormattingEnabled = true;
            this.cmbUpdateProduct.Location = new System.Drawing.Point(241, 45);
            this.cmbUpdateProduct.Name = "cmbUpdateProduct";
            this.cmbUpdateProduct.Size = new System.Drawing.Size(272, 27);
            this.cmbUpdateProduct.TabIndex = 2;
            this.cmbUpdateProduct.SelectedIndexChanged += new System.EventHandler(this.cmbUpdateProduct_valueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(99, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 19);
            this.label6.TabIndex = 1;
            this.label6.Text = "Select Product :";
            // 
            // tabDisplay
            // 
            this.tabDisplay.Controls.Add(this.dgDisplay);
            this.tabDisplay.Location = new System.Drawing.Point(4, 28);
            this.tabDisplay.Name = "tabDisplay";
            this.tabDisplay.Size = new System.Drawing.Size(617, 420);
            this.tabDisplay.TabIndex = 2;
            this.tabDisplay.Text = "Display";
            this.tabDisplay.UseVisualStyleBackColor = true;
            // 
            // dgDisplay
            // 
            this.dgDisplay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDisplay.Location = new System.Drawing.Point(10, 10);
            this.dgDisplay.Name = "dgDisplay";
            this.dgDisplay.Size = new System.Drawing.Size(595, 395);
            this.dgDisplay.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 447);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Inventory Management System";
            this.tabControl1.ResumeLayout(false);
            this.tabInsert.ResumeLayout(false);
            this.tabInsert.PerformLayout();
            this.tabUpdate.ResumeLayout(false);
            this.tabUpdate.PerformLayout();
            this.tabDisplay.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgDisplay)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabInsert;
        private System.Windows.Forms.TabPage tabUpdate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBrand;
        private System.Windows.Forms.TextBox txtPricePerProduct;
        private System.Windows.Forms.TextBox txtQuan;
        private System.Windows.Forms.TextBox txtSerialNum;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.TabPage tabDisplay;
        private System.Windows.Forms.TextBox txtUpQuan;
        private System.Windows.Forms.TextBox txtUpPrice;
        private System.Windows.Forms.TextBox txtUpBrand;
        private System.Windows.Forms.TextBox txtUpSrNo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbUpdateProduct;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.DataGridView dgDisplay;
        private System.Windows.Forms.TextBox txtUpMoreQuan;
        private System.Windows.Forms.Label label11;
    }
}