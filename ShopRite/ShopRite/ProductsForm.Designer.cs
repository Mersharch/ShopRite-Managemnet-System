namespace ShopRite
{
    partial class ProductsForm
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
            this.labelID = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.idTxt = new System.Windows.Forms.TextBox();
            this.labelQty = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.qtyNum = new System.Windows.Forms.NumericUpDown();
            this.labelName = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.nameTxt = new System.Windows.Forms.TextBox();
            this.labelDesc = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.descTxt = new System.Windows.Forms.TextBox();
            this.labelBrand = new System.Windows.Forms.Label();
            this.brandCombo = new System.Windows.Forms.ComboBox();
            this.labelCategory = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.labelPrice = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.priceNum = new System.Windows.Forms.NumericUpDown();
            this.paneldgv = new System.Windows.Forms.Panel();
            this.refreshBtn = new System.Windows.Forms.Button();
            this.productsDGV = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saveBtn = new System.Windows.Forms.Button();
            this.editBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.qtyNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceNum)).BeginInit();
            this.paneldgv.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productsDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelID.Location = new System.Drawing.Point(18, 43);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(30, 21);
            this.labelID.TabIndex = 0;
            this.labelID.Text = "id :";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Desktop;
            this.panel1.Location = new System.Drawing.Point(54, 63);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(76, 1);
            this.panel1.TabIndex = 2;
            // 
            // idTxt
            // 
            this.idTxt.BackColor = System.Drawing.SystemColors.Control;
            this.idTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.idTxt.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.idTxt.Location = new System.Drawing.Point(54, 39);
            this.idTxt.Name = "idTxt";
            this.idTxt.Size = new System.Drawing.Size(76, 18);
            this.idTxt.TabIndex = 3;
            // 
            // labelQty
            // 
            this.labelQty.AutoSize = true;
            this.labelQty.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelQty.Location = new System.Drawing.Point(221, 43);
            this.labelQty.Name = "labelQty";
            this.labelQty.Size = new System.Drawing.Size(42, 21);
            this.labelQty.TabIndex = 0;
            this.labelQty.Text = "Qty :";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Desktop;
            this.panel2.Location = new System.Drawing.Point(266, 63);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(76, 1);
            this.panel2.TabIndex = 2;
            // 
            // qtyNum
            // 
            this.qtyNum.BackColor = System.Drawing.SystemColors.Control;
            this.qtyNum.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.qtyNum.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.qtyNum.Location = new System.Drawing.Point(266, 39);
            this.qtyNum.Name = "qtyNum";
            this.qtyNum.Size = new System.Drawing.Size(76, 21);
            this.qtyNum.TabIndex = 4;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelName.Location = new System.Drawing.Point(18, 94);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(52, 19);
            this.labelName.TabIndex = 5;
            this.labelName.Text = "Name :";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Desktop;
            this.panel3.Location = new System.Drawing.Point(104, 114);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(238, 1);
            this.panel3.TabIndex = 6;
            // 
            // nameTxt
            // 
            this.nameTxt.BackColor = System.Drawing.SystemColors.Control;
            this.nameTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nameTxt.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nameTxt.Location = new System.Drawing.Point(104, 92);
            this.nameTxt.Name = "nameTxt";
            this.nameTxt.Size = new System.Drawing.Size(238, 18);
            this.nameTxt.TabIndex = 7;
            // 
            // labelDesc
            // 
            this.labelDesc.AutoSize = true;
            this.labelDesc.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelDesc.Location = new System.Drawing.Point(18, 144);
            this.labelDesc.Name = "labelDesc";
            this.labelDesc.Size = new System.Drawing.Size(45, 19);
            this.labelDesc.TabIndex = 5;
            this.labelDesc.Text = "Desc :";
            this.labelDesc.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.Desktop;
            this.panel4.Location = new System.Drawing.Point(104, 164);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(238, 1);
            this.panel4.TabIndex = 6;
            // 
            // descTxt
            // 
            this.descTxt.BackColor = System.Drawing.SystemColors.Control;
            this.descTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.descTxt.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.descTxt.Location = new System.Drawing.Point(104, 142);
            this.descTxt.Name = "descTxt";
            this.descTxt.Size = new System.Drawing.Size(238, 18);
            this.descTxt.TabIndex = 7;
            // 
            // labelBrand
            // 
            this.labelBrand.AutoSize = true;
            this.labelBrand.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelBrand.Location = new System.Drawing.Point(18, 194);
            this.labelBrand.Name = "labelBrand";
            this.labelBrand.Size = new System.Drawing.Size(52, 19);
            this.labelBrand.TabIndex = 8;
            this.labelBrand.Text = "Brand :";
            // 
            // brandCombo
            // 
            this.brandCombo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.brandCombo.FormattingEnabled = true;
            this.brandCombo.Location = new System.Drawing.Point(104, 190);
            this.brandCombo.Name = "brandCombo";
            this.brandCombo.Size = new System.Drawing.Size(238, 25);
            this.brandCombo.TabIndex = 9;
            // 
            // labelCategory
            // 
            this.labelCategory.AutoSize = true;
            this.labelCategory.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelCategory.Location = new System.Drawing.Point(18, 244);
            this.labelCategory.Name = "labelCategory";
            this.labelCategory.Size = new System.Drawing.Size(72, 19);
            this.labelCategory.TabIndex = 8;
            this.labelCategory.Text = "Category :";
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(104, 240);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(238, 25);
            this.comboBox1.TabIndex = 9;
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelPrice.Location = new System.Drawing.Point(18, 291);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(51, 21);
            this.labelPrice.TabIndex = 0;
            this.labelPrice.Text = "Price :";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.Desktop;
            this.panel5.Location = new System.Drawing.Point(104, 311);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(238, 1);
            this.panel5.TabIndex = 2;
            // 
            // priceNum
            // 
            this.priceNum.BackColor = System.Drawing.SystemColors.Control;
            this.priceNum.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.priceNum.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.priceNum.Location = new System.Drawing.Point(104, 284);
            this.priceNum.Name = "priceNum";
            this.priceNum.Size = new System.Drawing.Size(238, 21);
            this.priceNum.TabIndex = 4;
            // 
            // paneldgv
            // 
            this.paneldgv.Controls.Add(this.refreshBtn);
            this.paneldgv.Controls.Add(this.productsDGV);
            this.paneldgv.Dock = System.Windows.Forms.DockStyle.Right;
            this.paneldgv.Location = new System.Drawing.Point(380, 0);
            this.paneldgv.Name = "paneldgv";
            this.paneldgv.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.paneldgv.Size = new System.Drawing.Size(598, 449);
            this.paneldgv.TabIndex = 10;
            // 
            // refreshBtn
            // 
            this.refreshBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.refreshBtn.FlatAppearance.BorderSize = 0;
            this.refreshBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.refreshBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.refreshBtn.Location = new System.Drawing.Point(482, 402);
            this.refreshBtn.Name = "refreshBtn";
            this.refreshBtn.Size = new System.Drawing.Size(81, 35);
            this.refreshBtn.TabIndex = 14;
            this.refreshBtn.Text = "Refresh";
            this.refreshBtn.UseVisualStyleBackColor = false;
            // 
            // productsDGV
            // 
            this.productsDGV.BackgroundColor = System.Drawing.SystemColors.Control;
            this.productsDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productsDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.name,
            this.description,
            this.brand,
            this.category,
            this.quantity,
            this.price});
            this.productsDGV.Dock = System.Windows.Forms.DockStyle.Top;
            this.productsDGV.Location = new System.Drawing.Point(0, 3);
            this.productsDGV.Name = "productsDGV";
            this.productsDGV.RowTemplate.Height = 25;
            this.productsDGV.Size = new System.Drawing.Size(598, 384);
            this.productsDGV.TabIndex = 0;
            // 
            // id
            // 
            this.id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.Width = 43;
            // 
            // name
            // 
            this.name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.name.HeaderText = "Name";
            this.name.Name = "name";
            // 
            // description
            // 
            this.description.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.description.HeaderText = "Description";
            this.description.Name = "description";
            // 
            // brand
            // 
            this.brand.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.brand.HeaderText = "Brand";
            this.brand.Name = "brand";
            this.brand.Width = 63;
            // 
            // category
            // 
            this.category.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.category.HeaderText = "Category";
            this.category.Name = "category";
            this.category.Width = 80;
            // 
            // quantity
            // 
            this.quantity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.quantity.HeaderText = "Qty";
            this.quantity.Name = "quantity";
            this.quantity.Width = 51;
            // 
            // price
            // 
            this.price.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.price.HeaderText = "Price";
            this.price.Name = "price";
            this.price.Width = 58;
            // 
            // saveBtn
            // 
            this.saveBtn.BackColor = System.Drawing.Color.RoyalBlue;
            this.saveBtn.FlatAppearance.BorderSize = 0;
            this.saveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.saveBtn.Location = new System.Drawing.Point(54, 339);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(81, 35);
            this.saveBtn.TabIndex = 11;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = false;
            // 
            // editBtn
            // 
            this.editBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.editBtn.FlatAppearance.BorderSize = 0;
            this.editBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.editBtn.Location = new System.Drawing.Point(231, 339);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(81, 35);
            this.editBtn.TabIndex = 12;
            this.editBtn.Text = "Edit";
            this.editBtn.UseVisualStyleBackColor = false;
            // 
            // deleteBtn
            // 
            this.deleteBtn.BackColor = System.Drawing.Color.Red;
            this.deleteBtn.FlatAppearance.BorderSize = 0;
            this.deleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.deleteBtn.Location = new System.Drawing.Point(139, 402);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(81, 35);
            this.deleteBtn.TabIndex = 13;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = false;
            // 
            // ProductsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 449);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.editBtn);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.paneldgv);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.brandCombo);
            this.Controls.Add(this.labelCategory);
            this.Controls.Add(this.labelBrand);
            this.Controls.Add(this.descTxt);
            this.Controls.Add(this.nameTxt);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.labelDesc);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.priceNum);
            this.Controls.Add(this.qtyNum);
            this.Controls.Add(this.idTxt);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.labelQty);
            this.Controls.Add(this.labelID);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ProductsForm";
            this.Text = "Products";
            ((System.ComponentModel.ISupportInitialize)(this.qtyNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceNum)).EndInit();
            this.paneldgv.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.productsDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelID;
        private Panel panel1;
        private TextBox idTxt;
        private Label labelQty;
        private Panel panel2;
        private NumericUpDown qtyNum;
        private Label labelName;
        private Panel panel3;
        private TextBox nameTxt;
        private Label labelDesc;
        private Panel panel4;
        private TextBox descTxt;
        private Label labelBrand;
        private ComboBox brandCombo;
        private Label labelCategory;
        private ComboBox comboBox1;
        private Label labelPrice;
        private Panel panel5;
        private NumericUpDown priceNum;
        private Panel paneldgv;
        private Button refreshBtn;
        private DataGridView productsDGV;
        private Button saveBtn;
        private Button editBtn;
        private Button deleteBtn;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn name;
        private DataGridViewTextBoxColumn description;
        private DataGridViewTextBoxColumn brand;
        private DataGridViewTextBoxColumn category;
        private DataGridViewTextBoxColumn quantity;
        private DataGridViewTextBoxColumn price;
    }
}