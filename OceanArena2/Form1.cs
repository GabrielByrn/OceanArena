using System;
using OceanLibrary1.Classes;
using System.Windows.Forms;

namespace OceanArena2
{
    public partial class Form1 : Form
    {
        Form4 admin = new Form4();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 bet = new Form2() { settings = admin};
            Form3 arena = new Form3();
            SetDefaultFightSettings(arena);    
            bet.label3.Text = Convert.ToString(arena.display.NumPrey);
            bet.label5.Text = Convert.ToString(arena.display.NumPredators);
            bet.label7.Text = Convert.ToString(arena.display.NumPirats);
            bet.ShowDialog();
    
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            admin.ShowDialog();
        }

        private void SetDefaultFightSettings(Form3 arena)
        {
            arena.display.NumIteration = Constants.DefaultNumIterations;
            arena.display.NumObstacle = Constants.DefaultNumObstacles;
            arena.display.NumPredators = Constants.DefaultNumPredators;
            arena.display.NumPrey = Constants.DefaultNumPreys;
            arena.display.NumPirats = Constants.DefaultNumPirats;
            arena.display.Speed = Constants.TimerInterval;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
