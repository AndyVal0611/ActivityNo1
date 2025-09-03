namespace Activity5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("SalesInteger");
            comboBox1.Items.Add("PriceDecimal");
            comboBox1.Items.Add("QuantityInteger");
            comboBox1.Items.Add("NameItemString");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int QuantityInteger;
            decimal PriceDecimal;
            string NameItemsString;
            decimal SalesInteger;

            QuantityInteger = 5;
            PriceDecimal = 40.5m;
            SalesInteger = PriceDecimal * QuantityInteger;
            NameItemsString = "Book of Knowledge";

            if (comboBox1.Text == "SalesInteger")
            {
                listBox1.Items.Add(comboBox1.Text + " " + SalesInteger.ToString("C"));
            }
            else if (comboBox1.Text == "PriceDecimal")
            {
                listBox1.Items.Add(comboBox1.Text + " " + PriceDecimal.ToString("C"));
            }
            else if (comboBox1.Text == "QuantityInteger")
            {
                listBox1.Items.Add(comboBox1.Text + " " + QuantityInteger.ToString());
            }
            else if (comboBox1.Text == "NameItemString")
            {
                listBox1.Items.Add(comboBox1.Text + " " + NameItemsString);
            }
            else
            {
                MessageBox.Show("Please select a variable name from the ComboBox.");
            }
        }
    }
}
