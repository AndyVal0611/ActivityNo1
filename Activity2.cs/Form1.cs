using System.Windows.Forms;

namespace Activity2.cs
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // codes for disabling the textboxes
            itemnametxtbox.Enabled = false;
            pricetextbox.Enabled = false;
            discounted_totaltxtbox.Enabled = false;
            totalqty_txtbox.Enabled = false;
            totaldiscg_txtbox.Enabled = false;
            totaldiscamt_txtbox.Enabled = false;
            changetxtbox.Enabled = false;

            // codes for inserting pictures or image inside the picturebox tool
            pictureBox20.Image = Image.FromFile(@"C:\\Users\valde\source\repos\ActivityNo1\cake20.jpg");
            pictureBox19.Image = Image.FromFile(@"C:\\Users\valde\source\repos\ActivityNo1\cake19.jpg");
            pictureBox18.Image = Image.FromFile(@"C:\\Users\valde\source\repos\ActivityNo1\cake18.jpg");
            pictureBox17.Image = Image.FromFile(@"C:\\Users\valde\source\repos\ActivityNo1\cake17.jpg");
            pictureBox16.Image = Image.FromFile(@"C:\\Users\valde\source\repos\ActivityNo1\cake16.jpg");

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
    }
}