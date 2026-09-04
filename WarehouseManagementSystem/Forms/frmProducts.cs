using WarehouseManagementSystem.Services;

namespace WarehouseManagementSystem
{
    public partial class frmProducts : Form
    {
        public frmProducts()
        {
            InitializeComponent();
        }

        private void frmProducts_Load(object sender, EventArgs e)
        {
            ProductService productService = new ProductService();
            dgvProductList.DataSource = productService.GetProductList();
        }
    }
}
