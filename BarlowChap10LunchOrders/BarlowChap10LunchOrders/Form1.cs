namespace BarlowChap10LunchOrders
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public int addOnCount;
        public double price;
        public double taxCost;
        public double totalPrice;
        public double subTotal;
        public const double addOnCost = 0.75;
        public const double tax = 0.075;

        private void radBtnBurger_CheckedChanged(object sender, EventArgs e)
        {
            if (radBtnBurger.Checked)
            {
                price = 6.95; 
            }
        }

        private void radBtnPizza_CheckedChanged(object sender, EventArgs e)
        {
            if (radBtnPizza.Checked)
            {
                price = 5.95;
            }
        }

        private void radBtnSalad_CheckedChanged(object sender, EventArgs e)
        {
            if (radBtnSalad.Checked)
            {
                price = 4.95;
            }
        }

        private void chkBoxLTO_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBoxLTO.Checked)
            {
                addOnCount++;
            }
        }

        private void chkBoxKMM_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBoxKMM.Checked)
            {
                addOnCount++;
            }
        }

        private void chkBoxFrenchFries_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBoxFrenchFries.Checked)
            {
                addOnCount++;
            }

        }

        private void btnPlaceOrder_Click(object sender, EventArgs e)
        {
            subTotal = price + (addOnCount * addOnCost);
            taxCost = subTotal * tax;
            totalPrice = subTotal + taxCost;

            txtBoxSubTotal.Text = subTotal.ToString("C"); 
            txtBoxTax.Text = taxCost.ToString("C");
            txtBoxOrderTotal.Text = totalPrice.ToString("C");
        }
    }
}