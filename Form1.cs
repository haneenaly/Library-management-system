namespace LibraryMS
{
    public partial class Form1 : Form
    {
        static class Program
        {
            /// <summary>
            /// The main entry point for the application.
            /// </summary>
            static void Main()
            {
               
                Application.Run(new Form1()); // Start with the Login form
            }
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            load.Width += 11;

            if (load.Width >= 575)
            {
                timer1.Stop();

                Login lform = new Login();
                lform.Show();
                this.Hide();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
