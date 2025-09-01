namespace Activity4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Add engineering programs to the ComboBox
            ProgramsTextBox.Items.Add("BS In Aeronautical Engineering");
            ProgramsTextBox.Items.Add("BS In Civil Engineering");
            ProgramsTextBox.Items.Add("BS In Computer Engineering");
            ProgramsTextBox.Items.Add("BS In Electrical Engineering");
            ProgramsTextBox.Items.Add("BS In Electronics Engineering");
            ProgramsTextBox.Items.Add("BS In Industrial Engineering");
            ProgramsTextBox.Items.Add("BS In Mechanical Engineering");
        }

        private void browseButton_Click(object sender, EventArgs e)
        {
            // Instance of OpenFileDialog
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            // Image file types
            openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
            openFileDialog1.Title = "Select an Image File";

            // Show the dialog and check if the user selected a file
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // Get the selected file's path
                string imagePath = openFileDialog1.FileName;

                // Set the PictureBox to display the selected image
                pictureBox1.ImageLocation = imagePath;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Clear all textboxes for New/Cancel button
            SNameTextBox.Text = "";
            ProgramsTextBox.Text = "";
            SNumTextBox.Text = "";
            yearLevelTextBox.Text = "";
            scholarTextBox.Text = "";
            courseNumberTextBox.Text = "";
            courseCodeTextBox.Text = "";
            courseDescTextBox.Text = "";
            unitLectureTextBox.Text = "";
            unitLaboratoryTextBox.Text = "";
            timeTextBox.Text = "";
            dayTextBox.Text = "";
            creditUnitsTextBox.Text = "";
            totalNumberUnitsTextBox.Text = "";
            laboratoryFeeTextBox.Text = "";
            totalTuitionFeeTextBox.Text = "";
            totalMiscFeeTextBox.Text = "";
            ciscoLabFeeTextBox.Text = "";
            examBookletFeeTextBox.Text = "";
            totalTuitionAndFeeTextBox.Text = "";
            totalTuition.Text = "";
            totalMisc.Text = "";    
            totalNum.Text = "";
            totalTuitionFee.Text = "";
            computerLabFeeTextBox.Text = "";
            ciscoLabFee2TextBox.Text = "";
            examBookletTextBox.Text = "";
            totalOtherSchoolFeesTextBox.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Transfer data to the corresponding ListBox
            courseCodeListBox.Items.Add(courseCodeTextBox.Text);
            courseDescListBox.Items.Add(courseDescTextBox.Text);
            unitLecListBox.Items.Add(unitLectureTextBox.Text);
            unitLabListBox.Items.Add(unitLaboratoryTextBox.Text);
            creditUnitsListBox.Items.Add(creditUnitsTextBox.Text);
            timeListBox.Items.Add(timeTextBox.Text);
            dayListBox.Items.Add(dayTextBox.Text);

            // Transfer data to other summary textboxes
            totalTuitionFeeTextBox.Text = totalTuition.Text;
            totalMiscFeeTextBox.Text = totalMisc.Text;
            totalOtherSchoolFeesTextBox.Text = totalOtherSchoolFeesTextBox.Text;
            computerLabFeeTextBox.Text = computerLabFeeTextBox.Text;
            ciscoLabFeeTextBox.Text = ciscoLabFee2TextBox.Text;
            examBookletFeeTextBox.Text = examBookletTextBox.Text;
        }
    }
}
