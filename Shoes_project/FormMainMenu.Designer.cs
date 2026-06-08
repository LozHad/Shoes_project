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
            dgvMainMenu = new DataGridView();
            btnProducts = new Button();
            btnOrders = new Button();
            panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMainMenu).BeginInit();
            SuspendLayout();
            // 
            // lblUserName
            // 
            lblUserName.AutoSize = true;
            lblUserName.Dock = DockStyle.Right;
            lblUserName.Location = new Point(170, 0);
            lblUserName.Margin = new Padding(4, 0, 4, 0);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(45, 19);
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
            btnBackToLogin.Location = new Point(215, 0);
            btnBackToLogin.Margin = new Padding(4);
            btnBackToLogin.Name = "btnBackToLogin";
            btnBackToLogin.Size = new Size(193, 38);
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
            panelTop.Location = new Point(13, 13);
            panelTop.Margin = new Padding(4);
            panelTop.Name = "panelTop";
            panelTop.Padding = new Padding(0, 0, 0, 13);
            panelTop.Size = new Size(408, 51);
            panelTop.TabIndex = 1;
            // 
            // dgvMainMenu
            // 
            dgvMainMenu.AllowUserToAddRows = false;
            dgvMainMenu.AllowUserToDeleteRows = false;
            dgvMainMenu.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvMainMenu.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvMainMenu.BackgroundColor = Color.White;
            dgvMainMenu.BorderStyle = BorderStyle.None;
            dgvMainMenu.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMainMenu.ColumnHeadersVisible = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvMainMenu.DefaultCellStyle = dataGridViewCellStyle1;
            dgvMainMenu.Dock = DockStyle.Fill;
            dgvMainMenu.Location = new Point(13, 64);
            dgvMainMenu.Margin = new Padding(4);
            dgvMainMenu.MultiSelect = false;
            dgvMainMenu.Name = "dgvMainMenu";
            dgvMainMenu.ReadOnly = true;
            dgvMainMenu.RowHeadersVisible = false;
            dgvMainMenu.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMainMenu.Size = new Size(408, 584);
            dgvMainMenu.TabIndex = 2;
            // 
            // btnProducts
            // 
            btnProducts.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnProducts.BackColor = Color.MediumSpringGreen;
            btnProducts.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnProducts.Location = new Point(142, 288);
            btnProducts.Margin = new Padding(4);
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
            btnOrders.Location = new Point(142, 358);
            btnOrders.Margin = new Padding(4);
            btnOrders.Name = "btnOrders";
            btnOrders.Size = new Size(150, 50);
            btnOrders.TabIndex = 4;
            btnOrders.Text = "Заказы";
            btnOrders.UseVisualStyleBackColor = false;
            btnOrders.Click += BtnOrders_Click;
            // 
            // FormMainMenu
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(434, 661);
            Controls.Add(btnOrders);
            Controls.Add(btnProducts);
            Controls.Add(dgvMainMenu);
            Controls.Add(panelTop);
            Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            Name = "FormMainMenu";
            Padding = new Padding(13);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Меню";
            panelTop.ResumeLayout(false);
            panelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMainMenu).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label lblUserName;
        private Button btnBackToLogin;
        private Panel panelTop;
        private DataGridView dgvMainMenu;
        private Button btnProducts;
        private Button btnOrders;
    }
}