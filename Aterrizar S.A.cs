namespace Prototipo_CAI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btnProdDisponibles_Click(object sender, EventArgs e)
        {
            ProductosDisponibles productosDisponibles = new ProductosDisponibles();
            productosDisponibles.ShowDialog();
        }
    }
}