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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.labelID = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.prodID = new System.Windows.Forms.TextBox();
            this.labelQty = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.prodQty = new System.Windows.Forms.NumericUpDown();
            this.labelName = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.prodName = new System.Windows.Forms.TextBox();
            this.labelDesc = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.prodDesc = new System.Windows.Forms.TextBox();
            this.labelCategory = new System.Windows.Forms.Label();
            this.prodCategory = new System.Windows.Forms.ComboBox();
            this.labelPrice = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.prodPrice = new System.Windows.Forms.NumericUpDown();
            this.paneldgv = new System.Windows.Forms.Panel();
            this.refreshBtn = new System.Windows.Forms.Button();
            this.productsDGV = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saveBtn = new System.Windows.Forms.Button();
            this.editBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.prodQty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prodPrice)).BeginInit();
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
            // prodID
            // 
            this.prodID.BackColor = System.Drawing.SystemColors.Control;
            this.prodID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.prodID.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.prodID.Location = new System.Drawing.Point(54, 39);
            this.prodID.Name = "prodID";
            this.prodID.Size = new System.Drawing.Size(76, 18);
            this.prodID.TabIndex = 3;
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
            // prodQty
            // 
            this.prodQty.BackColor = System.Drawing.SystemColors.Control;
            this.prodQty.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.prodQty.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.prodQty.Location = new System.Drawing.Point(266, 39);
            this.prodQty.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.prodQty.Name = "prodQty";
            this.prodQty.Size = new System.Drawing.Size(76, 21);
            this.prodQty.TabIndex = 4;
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
            // prodName
            // 
            this.prodName.BackColor = System.Drawing.SystemColors.Control;
            this.prodName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.prodName.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.prodName.Location = new System.Drawing.Point(104, 92);
            this.prodName.Name = "prodName";
            this.prodName.Size = new System.Drawing.Size(238, 18);
            this.prodName.TabIndex = 7;
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
            // prodDesc
            // 
            this.prodDesc.BackColor = System.Drawing.SystemColors.Control;
            this.prodDesc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.prodDesc.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.prodDesc.Location = new System.Drawing.Point(104, 142);
            this.prodDesc.Name = "prodDesc";
            this.prodDesc.Size = new System.Drawing.Size(238, 18);
            this.prodDesc.TabIndex = 7;
            // 
            // labelCategory
            // 
            this.labelCategory.AutoSize = true;
            this.labelCategory.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelCategory.Location = new System.Drawing.Point(18, 198);
            this.labelCategory.Name = "labelCategory";
            this.labelCategory.Size = new System.Drawing.Size(72, 19);
            this.labelCategory.TabIndex = 8;
            this.labelCategory.Text = "Category :";
            // 
            // prodCategory
            // 
            this.prodCategory.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.prodCategory.FormattingEnabled = true;
            this.prodCategory.Location = new System.Drawing.Point(104, 194);
            this.prodCategory.Name = "prodCategory";
            this.prodCategory.Size = new System.Drawing.Size(238, 25);
            this.prodCategory.TabIndex = 9;
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelPrice.Location = new System.Drawing.Point(18, 245);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(51, 21);
            this.labelPrice.TabIndex = 0;
            this.labelPrice.Text = "Price :";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.Desktop;
            this.panel5.Location = new System.Drawing.Point(104, 265);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(238, 1);
            this.panel5.TabIndex = 2;
            // 
            // prodPrice
            // 
            this.prodPrice.BackColor = System.Drawing.SystemColors.Control;
            this.prodPrice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.prodPrice.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.prodPrice.Location = new System.Drawing.Point(104, 238);
            this.prodPrice.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.prodPrice.Name = "prodPrice";
            this.prodPrice.Size = new System.Drawing.Size(238, 21);
            this.prodPrice.TabIndex = 4;
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
            this.refreshBtn.Click += new System.EventHandler(this.refreshBtn_Click);
            // 
            // productsDGV
            // 
            this.productsDGV.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.productsDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.productsDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productsDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.name,
            this.description,
            this.category,
            this.quantity,
            this.price});
            this.productsDGV.Dock = System.Windows.Forms.DockStyle.Top;
            this.productsDGV.EnableHeadersVisualStyles = false;
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
            this.id.Width = 50;
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
            // category
            // 
            this.category.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.category.HeaderText = "Category";
            this.category.Name = "category";
            this.category.Width = 98;
            // 
            // quantity
            // 
            this.quantity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.quantity.HeaderText = "Qty";
            this.quantity.Name = "quantity";
            this.quantity.Width = 60;
            // 
            // price
            // 
            this.price.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.price.HeaderText = "Price";
            this.price.Name = "price";
            this.price.Width = 69;
            // 
            // saveBtn
            // 
            this.saveBtn.BackColor = System.Drawing.Color.RoyalBlue;
            this.saveBtn.FlatAppearance.BorderSize = 0;
            this.saveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.saveBtn.Location = new System.Drawing.Point(54, 293);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(81, 35);
            this.saveBtn.TabIndex = 11;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = false;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // editBtn
            // 
            this.editBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.editBtn.FlatAppearance.BorderSize = 0;
            this.editBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.editBtn.Location = new System.Drawing.Point(231, 293);
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
            this.deleteBtn.Location = new System.Drawing.Point(139, 356);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(81, 35);
            this.deleteBtn.TabIndex = 13;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = false;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
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
            this.Controls.Add(this.prodCategory);
            this.Controls.Add(this.labelCategory);
            this.Controls.Add(this.prodDesc);
            this.Controls.Add(this.prodName);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.labelDesc);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.prodPrice);
            this.Controls.Add(this.prodQty);
            this.Controls.Add(this.prodID);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.labelQty);
            this.Controls.Add(this.labelID);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ProductsForm";
            this.Text = "Products";
            this.Load += new System.EventHandler(this.ProductsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.prodQty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prodPrice)).EndInit();
            this.paneldgv.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.productsDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelID;
        private Panel panel1;
        private TextBox prodID;
        private Label labelQty;
        private Panel panel2;
        private NumericUpDown prodQty;
        private Label labelName;
        private Panel panel3;
        private TextBox prodName;
        private Label labelDesc;
        private Panel panel4;
        private TextBox prodDesc;
        private Label labelCategory;
        private ComboBox prodCategory;
        private Label labelPrice;
        private Panel panel5;
        private NumericUpDown prodPrice;
        private Panel paneldgv;
        private Button refreshBtn;
        private DataGridView productsDGV;
        private Button saveBtn;
        private Button editBtn;
        private Button deleteBtn;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn name;
        private DataGridViewTextBoxColumn description;
        private DataGridViewTextBoxColumn category;
        private DataGridViewTextBoxColumn quantity;
        private DataGridViewTextBoxColumn price;
    }
}