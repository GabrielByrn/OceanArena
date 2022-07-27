using System;
using OceanLibrary1.Classes;
using System.Windows.Forms;

namespace OceanArena2
{
    public partial class Form4 : Form
    {
        public DisplayForm display = new DisplayForm();

        public Form4()
        {
            InitializeComponent();
            textBox1.Text = Constants.DefaultNumPreys.ToString();
            textBox2.Text = Constants.DefaultNumPredators.ToString();
            textBox3.Text = Constants.DefaultNumObstacles.ToString();
            textBox4.Text = Constants.DefaultNumIterations.ToString();
            textBox5.Text = Constants.DefaultNumPirats.ToString();
            textBox6.Text = Constants.TimerInterval.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            display.admine = 1;
            Form3 arena = new Form3() { admin = display.admine };

            SetNewSettings(arena, textBox4, textBox3, textBox2, textBox1, textBox5, textBox6);
            this.Hide();
            arena.Show();

        }
        private void SetNewSettings(Form3 ocean, TextBox iteratinonTextBox, TextBox obstaclesTextBox, TextBox predatorsTextBox, TextBox preysTextBox, TextBox boatsTextBox, TextBox iterSpeed)
        {
            ocean.display.NumIteration = Int32.Parse(iteratinonTextBox.Text);
            ocean.display.NumObstacle = Int32.Parse(obstaclesTextBox.Text);
            ocean.display.NumPredators = Int32.Parse(predatorsTextBox.Text);
            ocean.display.NumPrey = Int32.Parse(preysTextBox.Text);
            ocean.display.NumPirats= Int32.Parse(boatsTextBox.Text);
            ocean.display.Speed = Int32.Parse(iterSpeed.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 arena = new Form3();
            this.Hide();
            Form2 bet=new Form2() { settings = this};
            SetNewSettings(arena, textBox4, textBox3, textBox2, textBox1, textBox5, textBox6);
            bet.label3.Text = Convert.ToString(arena.display.NumPrey);
            bet.label5.Text = Convert.ToString(arena.display.NumPredators);
            bet.label7.Text = Convert.ToString(arena.display.NumPirats);
            bet.Show();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
