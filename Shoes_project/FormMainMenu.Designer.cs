namespace Shoes_project
{
    partial class FormMainMenu
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMainMenu));
            lblUserName = new Label();
            btnBackToLogin = new Button();
            panelTop = new Panel();
            dgvProducts = new DataGridView();
            btnProducts = new Button();
            btnOrders = new Button();
            panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).BeginInit();
            SuspendLayout();
            // 
            // lblUserName
            // 
            lblUserName.AutoSize = true;
            lblUserName.Dock = DockStyle.Right;
            lblUserName.Location = new Point(176, 0);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(38, 15);
            lblUserName.TabIndex = 6;
            lblUserName.Text = "label1";
            lblUserName.TextAlign = ContentAlignment.MiddleRight;
            // 
            // btnBackToLogin
            // 
            btnBackToLogin.BackColor = Color.MediumSpringGreen;
            btnBackToLogin.Dock = DockStyle.Right;
            btnBackToLogin.FlatAppearance.BorderSize = 0;
            btnBackToLogin.FlatStyle = FlatStyle.Flat;
            btnBackToLogin.Location = new Point(214, 0);
            btnBackToLogin.Name = "btnBackToLogin";
            btnBackToLogin.Size = new Size(150, 30);
            btnBackToLogin.TabIndex = 5;
            btnBackToLogin.Text = "Выйти";
            btnBackToLogin.UseVisualStyleBackColor = false;
            btnBackToLogin.Click += BtnBackToLogin_Click_1;
            // 
            // panelTop
            // 
            panelTop.Controls.Add(lblUserName);
            panelTop.Controls.Add(btnBackToLogin);
            panelTop.Dock = DockStyle.Top;
            panelTop.Location = new Point(10, 10);
            panelTop.Name = "panelTop";
            panelTop.Padding = new Padding(0, 0, 0, 10);
            panelTop.Size = new Size(364, 40);
            panelTop.TabIndex = 1;
            // 
            // dgvProducts
            // 
            dgvProducts.AllowUserToAddRows = false;
            dgvProducts.AllowUserToDeleteRows = false;
            dgvProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProducts.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvProducts.BackgroundColor = Color.White;
            dgvProducts.BorderStyle = BorderStyle.None;
            dgvProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProducts.ColumnHeadersVisible = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvProducts.DefaultCellStyle = dataGridViewCellStyle1;
            dgvProducts.Dock = DockStyle.Fill;
            dgvProducts.Location = new Point(10, 50);
            dgvProducts.MultiSelect = false;
            dgvProducts.Name = "dgvProducts";
            dgvProducts.ReadOnly = true;
            dgvProducts.RowHeadersVisible = false;
            dgvProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProducts.Size = new Size(364, 501);
            dgvProducts.TabIndex = 2;
            // 
            // btnProducts
            // 
            btnProducts.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnProducts.BackColor = Color.MediumSpringGreen;
            btnProducts.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnProducts.Location = new Point(117, 227);
            btnProducts.Name = "btnProducts";
            btnProducts.Size = new Size(150, 50);
            btnProducts.TabIndex = 3;
            btnProducts.Text = "Товары";
            btnProducts.UseVisualStyleBackColor = false;
            btnProducts.Click += BtnProducts_Click;
            // 
            // btnOrders
            // 
            btnOrders.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnOrders.BackColor = Color.MediumAquamarine;
            btnOrders.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnOrders.Location = new Point(117, 283);
            btnOrders.Name = "btnOrders";
            btnOrders.Size = new Size(150, 50);
            btnOrders.TabIndex = 4;
            btnOrders.Text = "Заказы";
            btnOrders.UseVisualStyleBackColor = false;
            btnOrders.Click += BtnOrders_Click;
            // 
            // FormMainMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(384, 561);
            Controls.Add(btnOrders);
            Controls.Add(btnProducts);
            Controls.Add(dgvProducts);
            Controls.Add(panelTop);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormMainMenu";
            Padding = new Padding(10);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Меню";
            panelTop.ResumeLayout(false);
            panelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label lblUserName;
        private Button btnBackToLogin;
        private Panel panelTop;
        private DataGridView dgvProducts;
        private Button btnProducts;
        private Button btnOrders;
    }
}