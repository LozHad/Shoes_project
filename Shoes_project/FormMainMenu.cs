using Shoes_project.Models;

namespace Shoes_project
{
    public partial class FormMainMenu : Form
    {
        public User CurrentUser { get; private set; }
        public bool IsGuest { get; private set; }

        public FormMainMenu(User user, bool guest)
        {
            InitializeComponent();

            CurrentUser = user;
            IsGuest = guest;

            lblUserName.Text = IsGuest ? "Гость" : CurrentUser.FullName;
        }

        private void BtnProducts_Click(object sender, EventArgs e)
        {
            FormProducts formProducts = new FormProducts(CurrentUser, IsGuest, this);
            formProducts.Show();
        }

        private void BtnOrders_Click(object sender, EventArgs e)
        {
            if (IsGuest == true)
            {
                MessageBox.Show("Для просмотра заказов необходимо авторизоваться!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            //FormOrders formOrders = new FormOrders(CurrentUser);
            //formOrders.Show();

            //this.Close();
        }

        private void BtnBackToLogin_Click_1(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
