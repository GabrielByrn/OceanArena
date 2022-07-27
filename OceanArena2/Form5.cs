using OceanLibrary1.Interfaces;
using OceanLibrary1.Classes;
using System.Windows.Forms;

namespace OceanArena2
{
    public partial class Form5 : Form
    {
        public Ocean ocean = new Ocean();
        public IOceanView oceanView = new DisplayForm();
        public DisplayForm display = new DisplayForm();

        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, System.EventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, System.EventArgs e)
        {

        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, System.EventArgs e)
        {

        }

        private void button2_Click(object sender, System.EventArgs e)
        {
            this.Hide();
            Form1 start=new Form1();    
            start.ShowDialog();
        }
    }
}
