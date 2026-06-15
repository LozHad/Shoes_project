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

            var colArticle = new DataGridViewTextBoxColumn();
            colArticle.Name = "colArticle";
            colArticle.FillWeight = 15;
            colArticle.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            var colQuantity = new DataGridViewTextBoxColumn();
            colQuantity.Name = "colQuantity";
            colQuantity.FillWeight = 5;
            colQuantity.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

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
            colDeliveryPoint.FillWeight = 35;
            colDeliveryPoint.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            var colCode = new DataGridViewTextBoxColumn();
            colCode.Name = "colCode";
            colCode.FillWeight = 10;
            colCode.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            var colStatus = new DataGridViewTextBoxColumn();
            colStatus.Name = "colStatus";
            colStatus.FillWeight = 15;
            colStatus.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvOrders.Columns.AddRange([
                colArticle, colQuantity, colOrderDate, colDeliveryDate, colDeliveryPoint, colCode, colStatus
            ]);

            LoadProducts();
        }

        private void LoadProducts()
        {
            using var db = new ShopDpContext();
            dgvOrders.SuspendLayout();
            dgvOrders.Rows.Clear();

            var userOrdersData = db.ProductsOrders
                .Include(i => i.Order)
                    .ThenInclude(i => i.Status)
                .Include(i => i.Order)
                    .ThenInclude(i => i.DeliveryPoint)
                .Include(i => i.Product)
                .Where(i => i.Order.IdUser == CurrentUser.Id)
                .ToList();

            foreach (var item in userOrdersData)
            {
                int rowIndex = dgvOrders.Rows.Add();
                var row = dgvOrders.Rows[rowIndex];

                row.Cells["colArticle"].Value = item.Product.Art;
                row.Cells["colQuantity"].Value = item.Quantity;
                row.Cells["colOrderDate"].Value = item.Order.OrderDate;
                row.Cells["colDeliveryDate"].Value = item.Order.DeliveryDate;
                row.Cells["colDeliveryPoint"].Value = item.Order.DeliveryPoint.DeliveryAddress;
                row.Cells["colCode"].Value = item.Order.Code;
                row.Cells["colStatus"].Value = item.Order.Status.StatusName;
            }

            dgvOrders.ResumeLayout();
            dgvOrders.AutoResizeRows(DataGridViewAutoSizeRowsMode.AllCells);
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

        private void BtnBackToMenu_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
