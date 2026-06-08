using Microsoft.EntityFrameworkCore;
using Shoes_project.Models;
using Shoes_project.Properties;

namespace Shoes_project
{

    public partial class FormOrders : Form
    {
        private FormMainMenu menu;
        public User CurrentUser { get; private set; }

        public FormOrders(User user, FormMainMenu mainMenu)
        {
            InitializeComponent();

            CurrentUser = user;

            lblUserName.Text = CurrentUser.FullName;

            this.menu = mainMenu;

            var colArticle = new DataGridViewImageColumn();
            colArticle.Name = "colArticle";
            colArticle.FillWeight = 20;
            colArticle.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            var colOrderDate = new DataGridViewTextBoxColumn();
            colOrderDate.Name = "colOrderDate";
            colOrderDate.FillWeight = 10;
            colOrderDate.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            var colDeliveryDate = new DataGridViewTextBoxColumn();
            colDeliveryDate.Name = "colDeliveryDate";
            colDeliveryDate.FillWeight = 10;
            colDeliveryDate.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            var colDeliveryPoint = new DataGridViewTextBoxColumn();
            colDeliveryPoint.Name = "colDeliveryPoint";
            colDeliveryPoint.FillWeight = 20;
            colDeliveryPoint.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            var colCode = new DataGridViewTextBoxColumn();
            colCode.Name = "colCode";
            colCode.FillWeight = 20;
            colCode.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            var colStatus = new DataGridViewTextBoxColumn();
            colStatus.Name = "colStatus";
            colStatus.FillWeight = 20;
            colStatus.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvOrders.Columns.AddRange([
                colArticle, colOrderDate, colDeliveryDate, colDeliveryPoint, colCode, colStatus
            ]);

            LoadProducts();
        }

        private void LoadProducts()
        {
            try
            {
                using (var db = new ShopDpContext())
                {
                    dgvOrders.SuspendLayout();
                    dgvOrders.Rows.Clear();

                    var userOrdersData = db.ProductsOrders
                    .Include(i => i.Order)
                    .Include(i => i.Product)
                    .Where(i => i.Order.IdUser == CurrentUser.Id)
                    .ToList();

                    foreach (var item in userOrdersData)
                    {
                        int rowIndex = dgvOrders.Rows.Add();
                        var row = dgvOrders.Rows[rowIndex];

                        row.Cells["colArticle"].Value = item.Quantity + item.Product.Art;
                        row.Cells["colOrderDate"].Value = item.Order.OrderDate;
                        row.Cells["colDeliveryDate"].Value = item.Order.DeliveryDate;
                        row.Cells["colDeliveryPoint"].Value = item.Order.DeliveryPoint;
                        row.Cells["colCode"].Value = item.Order.Code;
                        row.Cells["colStatus"].Value = item.Order.Status;
                    }

                    dgvOrders.ResumeLayout();
                    dgvOrders.AutoResizeRows(DataGridViewAutoSizeRowsMode.AllCells);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnBackToMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            if (menu != null)
            {
                menu.Show();
            }
            else
            {
                this.DialogResult = DialogResult.Cancel;
            }
        }
    }
}
