using System;
using System.Windows.Forms;
using OceanLibrary1.Classes;

namespace OceanArena2
{
    public partial class Form2 : Form
    {
        public Form4 settings = new Form4();
        public DisplayForm display = new DisplayForm();
        public Form7 boats = new Form7();

        public Form2()
        {
            InitializeComponent();
            label6.Text = "Please, choose your predicted winner:";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            display.bet = 1;
            this.Hide();
            Form3 arena = new Form3() { superbet=display.bet};
            SetDefaultSettings(arena, settings.textBox4, settings.textBox3, settings.textBox2, settings.textBox1, settings.textBox5, settings.textBox6);
            arena.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            display.bet = 0;
            this.Hide();
            Form3 arena = new Form3() { superbet = display.bet };
            SetDefaultSettings(arena, settings.textBox4, settings.textBox3, settings.textBox2, settings.textBox1, settings.textBox5, settings.textBox6) ;
            arena.ShowDialog();
            arena.label10.Text = Convert.ToString(arena.display.NumPirats);
        }
        private void SetDefaultSettings(Form3 ocean, TextBox iteratinonTextBox, TextBox obstaclesTextBox, TextBox predatorsTextBox, TextBox preysTextBox, TextBox piratsTextBox, TextBox iterSpeed)
        {
            ocean.display.NumIteration = Int32.Parse(iteratinonTextBox.Text);
            ocean.display.NumObstacle = Int32.Parse(obstaclesTextBox.Text);
            ocean.display.NumPredators = Int32.Parse(predatorsTextBox.Text);
            ocean.display.NumPrey = Int32.Parse(preysTextBox.Text);
            ocean.display.NumPirats = Int32.Parse(piratsTextBox.Text);
            ocean.display.Speed = Int32.Parse(iterSpeed.Text);
        }

        private void Form2_Load(object sender, EventArgs e)
        {
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 arena = new Form3() { superbet = display.bet };
            SetDefaultSettings(arena, settings.textBox4, settings.textBox3, settings.textBox2, settings.textBox1, settings.textBox5, settings.textBox6);
            boats.ShowDialog();
        }
    }
}
