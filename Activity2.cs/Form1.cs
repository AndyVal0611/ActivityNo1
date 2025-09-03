using System.Windows.Forms;

namespace Activity2.cs
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private int qty_total = 0;
        private double discount_totalgiven = 0;
        private double discounted_total = 0;

        private void Form1_Load(object sender, EventArgs e)
        {
            // codes for disabling the textboxes
            itemnameTxtbox.Enabled = true;
            priceTxtbox.Enabled = true;
            discounted_txtbox.Enabled = true;
            totalqty_txtbox.Enabled = true;
            totaldiscg_txtbox.Enabled = true;
            totaldiscamt_txtbox.Enabled = true;
            changetxtbox.Enabled = true;
            discount_txtbox.Enabled = true;

            // codes for inserting pictures or image inside the picturebox tool
            pictureBox20.Image = Image.FromFile(@"C:\Users\andy1\source\repos\AndyVal0611\ActivityNo1\cake20.jpg");
            pictureBox19.Image = Image.FromFile(@"C:\Users\andy1\source\repos\AndyVal0611\ActivityNo1\cake19.jpg");
            pictureBox18.Image = Image.FromFile(@"C:\Users\andy1\source\repos\AndyVal0611\ActivityNo1\cake18.jpg");
            pictureBox17.Image = Image.FromFile(@"C:\Users\andy1\source\repos\AndyVal0611\ActivityNo1\cake17.jpg");
            pictureBox16.Image = Image.FromFile(@"C:\Users\andy1\source\repos\AndyVal0611\ActivityNo1\cake16.jpg");

            // codes for inserting name of the image inside the label tool
            name1lbl.Text = "Chocolate";
            name2lbl.Text = "Oreo Cheese";
            name3lbl.Text = "Carrot";
            name4lbl.Text = "Choco Cheese";
            name5lbl.Text = "Truffle";
            name6lbl.Text = "Classic";
            name7lbl.Text = "Red Velvet";
            name8lbl.Text = "Banana Cream";
            name9lbl.Text = "Vanilla";
            name10lbl.Text = "Caramel";
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            // SENIOR CITIZEN
            // Declaration of variables within a method of an object
            int qty;
            double price, discount_amt, discounted_amt;
            // convert string
            qty = Convert.ToInt32(qty_txtbox.Text);
            price = Convert.ToDouble(priceTxtbox.Text);
            // create a formula
            discount_amt = (qty * price) * 0.30;
            discounted_amt = (qty * price) - discount_amt;
            // converting numeric data
            discount_txtbox.Text = discount_amt.ToString("n");
            discounted_txtbox.Text = discounted_amt.ToString("n");
            // codes for unchecking the other radio buttons
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            radioButton4.Checked = false;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            // WITH DISC. CARD
            // Declaration of variables within a method of an object
            int qty;
            double price, discount_amt, discounted_amt;
            // convert string
            qty = Convert.ToInt32(qty_txtbox.Text);
            price = Convert.ToDouble(priceTxtbox.Text);
            // create a formula
            discount_amt = (qty * price) * 0.10;
            discounted_amt = (qty * price) - discount_amt;
            // converting numeric data
            discount_txtbox.Text = discount_amt.ToString("n");
            discounted_txtbox.Text = discounted_amt.ToString("n");
            // codes for unchecking the other radio buttons
            radioButton1.Checked = false;
            radioButton3.Checked = false;
            radioButton4.Checked = false;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            // EMPLOYEE DISC
            // Declaration of variables within a method of an object
            int qty;
            double price, discount_amt, discounted_amt;
            // convert string
            qty = Convert.ToInt32(qty_txtbox.Text);
            price = Convert.ToDouble(priceTxtbox.Text);
            // create a formula
            discount_amt = (qty * price) * 0.15;
            discounted_amt = (qty * price) - discount_amt;
            // converting numeric data
            discount_txtbox.Text = discount_amt.ToString("n");
            discounted_txtbox.Text = discounted_amt.ToString("n");
            // codes for unchecking the other radio buttons
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            radioButton4.Checked = false;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            // NO DISCOUNT
            // Declaration of variables within a method of an object
            int qty;
            double price, discount_amt, discounted_amt;
            // convert string
            qty = Convert.ToInt32(qty_txtbox.Text);
            price = Convert.ToDouble(priceTxtbox.Text);
            // create a formula
            discount_amt = (qty * price) * 0;
            discounted_amt = (qty * price) - discount_amt;
            // converting numeric data
            discount_txtbox.Text = discount_amt.ToString("n");
            discounted_txtbox.Text = discounted_amt.ToString("n");
            // codes for unchecking the other radio buttons
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            radioButton1.Checked = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // EMPLOYEE DISC
            // Declaration of variables within a method of an object
            int qty;
            double discount_amt, discounted_amt, cash_rendered, change;
            qty = Convert.ToInt32(qty_txtbox.Text);
            discount_amt = Convert.ToDouble(discount_txtbox.Text);
            discounted_amt = Convert.ToDouble(discounted_txtbox.Text);
            cash_rendered = Convert.ToDouble(cashrendered_txtbox.Text);
            // codes to accumulate
            qty_total += qty;
            discount_totalgiven += discount_amt;
            discounted_total += discounted_amt;
            change = cash_rendered - discounted_amt;
            // converting numeric data
            discount_txtbox.Text = discount_amt.ToString("n");
            discounted_txtbox.Text = discounted_amt.ToString("n");
            // convert to string
            totalqty_txtbox.Text = qty_total.ToString();
            totaldiscg_txtbox.Text = discount_totalgiven.ToString("n");
            totaldiscamt_txtbox.Text = discounted_total.ToString("n");
            changetxtbox.Text = change.ToString("n");
            cashrendered_txtbox.Text = cash_rendered.ToString("n");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Exit
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            itemnameTxtbox.Clear();
            priceTxtbox.Clear();
            qty_txtbox.Clear();
            discount_txtbox.Clear();
            discounted_txtbox.Clear();
            changetxtbox.Clear();
            cashrendered_txtbox.Clear();
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            // Code for inserting or assigning a value to the Text property of a textbox
            itemnameTxtbox.Text = "Chocolate Cake";
            priceTxtbox.Text = "200.00";
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            // Code for inserting or assigning a value to the Text property of a textbox
            itemnameTxtbox.Text = "Oreo Cheesecake";
            priceTxtbox.Text = "220.00";
        }

        private void pictureBox3_Click_1(object sender, EventArgs e)
        {
            // Code for inserting or assigning a value to the Text property of a textbox
            itemnameTxtbox.Text = "Carrot Cake";
            priceTxtbox.Text = "180.00";
        }

        private void pictureBox4_Click_1(object sender, EventArgs e)
        {
            // Code for inserting or assigning a value to the Text property of a textbox
            itemnameTxtbox.Text = "Chocolate Cheesecake";
            priceTxtbox.Text = "210.00";
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            // Code for inserting or assigning a value to the Text property of a textbox
            itemnameTxtbox.Text = "Truffle Cake";
            priceTxtbox.Text = "230.00";
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            // Code for inserting or assigning a value to the Text property of a textbox
            itemnameTxtbox.Text = "Classic Cheesecake";
            priceTxtbox.Text = "190.00";
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            // Code for inserting or assigning a value to the Text property of a textbox
            itemnameTxtbox.Text = "Red Velvet Cake";
            priceTxtbox.Text = "200.00";
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            // Code for inserting or assigning a value to the Text property of a textbox
            itemnameTxtbox.Text = "Banana Cream Cake";
            priceTxtbox.Text = "170.00";
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            // Code for inserting or assigning a value to the Text property of a textbox
            itemnameTxtbox.Text = "Vanilla Cheesecake";
            priceTxtbox.Text = "185.00";
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            // Code for inserting or assigning a value to the Text property of a textbox
            itemnameTxtbox.Text = "Caramel Cake";
            priceTxtbox.Text = "195.00";
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            // Code for inserting or assigning a value to the Text property of a textbox
            itemnameTxtbox.Text = "Strawberry Cheesecake";
            priceTxtbox.Text = "210.00";
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            // Code for inserting or assigning a value to the Text property of a textbox
            itemnameTxtbox.Text = "Blueberry Cheesecake";
            priceTxtbox.Text = "215.00";
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            // Code for inserting or assigning a value to the Text property of a textbox
            itemnameTxtbox.Text = "Mango Cheesecake";
            priceTxtbox.Text = "205.00";
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            // Code for inserting or assigning a value to the Text property of a textbox
            itemnameTxtbox.Text = "Salted Caramel Cake";
            priceTxtbox.Text = "225.00";
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            // Code for inserting or assigning a value to the Text property of a textbox
            itemnameTxtbox.Text = "Chocolate Mousse Cake";
            priceTxtbox.Text = "240.00";
        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            // Code for inserting or assigning a value to the Text property of a textbox
            itemnameTxtbox.Text = "Birthday Cake";
            priceTxtbox.Text = "220.00";
        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {
            // Code for inserting or assigning a value to the Text property of a textbox
            itemnameTxtbox.Text = "Snickers Cheesecake";
            priceTxtbox.Text = "250.00";
        }

        private void pictureBox18_Click(object sender, EventArgs e)
        {
            // Code for inserting or assigning a value to the Text property of a textbox
            itemnameTxtbox.Text = "Peach Cake";
            priceTxtbox.Text = "220.00";
        }

        private void pictureBox19_Click(object sender, EventArgs e)
        {
            // Code for inserting or assigning a value to the Text property of a textbox
            itemnameTxtbox.Text = "Twix Cheesecake";
            priceTxtbox.Text = "250.00";
        }

        private void pictureBox20_Click(object sender, EventArgs e)
        {
            // Code for inserting or assigning a value to the Text property of a textbox
            itemnameTxtbox.Text = "Lemon Cheesecake";
            priceTxtbox.Text = "240.00";
        }
    }
}