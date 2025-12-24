using Microsoft.EntityFrameworkCore;
using Shoes.Properties;
using System.Data;

namespace Shoes
{
    public partial class FormOrder : Form
    {
        public User CurrentUser { get; private set; }
        public bool IsGuest { get; private set; }


        public FormOrder()
        {
            InitializeComponent();
            User user = new User();
            bool guest = false;

            var colInfo = new DataGridViewTextBoxColumn();
            colInfo.Name = "colInfo";
            colInfo.FillWeight = 60;
            colInfo.DefaultCellStyle.WrapMode = DataGridViewTriState.True;

            var colData = new DataGridViewTextBoxColumn();
            colData.Name = "colDate";
            colData.FillWeight = 10;
            colData.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            colData.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvOrder.Columns.AddRange(
            [
               colInfo, colData
            ]);

            CurrentUser = user;
            IsGuest = guest;

            lblUserName.Text = IsGuest ? "Гость" : CurrentUser.FullName;

            LoadProducts();
        }

        private void LoadProducts()
        {
            try
            {
                using (var db = new ShopDbContext())
                {
                    var orders = db.Orders
                        .Include(i => i.Status)
                        .Include(i => i.ProductsOrders).ThenInclude(i => i.Product)
                        .Include(i => i.DeliveryPoint)
                        .ToList();
                    dgvOrder.SuspendLayout();
                    dgvOrder.Rows.Clear();
                    foreach (var order in orders)
                    {
                        int rowindex = dgvOrder.Rows.Add();
                        var row = dgvOrder.Rows[rowindex];

                        row.Cells["colInfo"].Value = FormatProductInfo(order);

                        row.Cells["colDiscount"].Value = $"{order.DeliveryDate}";
                        row.Cells["colDiscount"].Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string FormatProductInfo(Order order)
        {
            var arts = order.ProductsOrders.Select(s => s.Product.Art).Distinct().ToList();
            string txt="";

            foreach (string art in arts)
            {
                txt+= art + " ";
            }


            return $"{txt} " + Environment.NewLine +
                $"Статус заказа {order.Status}" + Environment.NewLine +
                $"Адрес пункта выдачи: {order.Status}" + Environment.NewLine +
                $"Дата заказа: {order.OrderDate}";

        }
    }
}
