namespace TutorialSix
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void submit_Click(object sender, EventArgs e)
        {
            CheckBox mycheckbox = new CheckBox();
            if (male.Checked == true)
            {
                display.Visible = true;
                if (news.Checked == true)
                {
                    display.Text = "Mr. " + name.Text + " You know about us from\n" + news.Text + ", " + spec.Text;
                }
                else if (friends.Checked == true)
                {
                    display.Text = "Mr. " + name.Text + " You know about us from\n" + friends.Text + ", " + spec.Text;
                }
                else if (website.Checked == true)
                {
                    display.Text = "Mr. " + name.Text + " You know about us from\n" + website.Text + ", " + spec.Text;
                }
                else if (oth.Checked == true)
                {
                    display.Text = "Mr. " + name.Text + " You know about us from\n" + oth.Text + ", " + spec.Text;
                }
            }
            else if (female.Checked == true)
            {
                display.Visible = true;
                if (news.Checked == true)
                {
                    display.Text = "Miss. " + name.Text + " You know about us from\n" + news.Text + ", " + spec.Text;
                }
                else if (friends.Checked == true)
                {
                    display.Text = "Miss. " + name.Text + " You know about us from\n" + friends.Text + ", " + spec.Text;
                }
                else if (website.Checked == true)
                {
                    display.Text = "Miss. " + name.Text + " You know about us from\n" + website.Text + ", " + spec.Text;
                }
                else if (oth.Checked == true)
                {
                    display.Text = "Miss. " + name.Text + " You know about us from\n" + oth.Text + ", " + spec.Text;
                }
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
