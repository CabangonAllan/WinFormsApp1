using System.Drawing.Text;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private CashierClass cashier;
        private Form2 form;
        public Form1()
        {
            InitializeComponent();
           
            form = new Form2();
            form.Show();
            cashier = new CashierClass();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
             

            label1.Text = cashier.CashiergeneratedNumber("P - ");
            CashierClass.getNumberInQueue = label1.Text;
            CashierClass.CashierQueue.Enqueue(CashierClass.getNumberInQueue);

        }
    }
}