using System;
using OceanLibrary1.Classes;
using OceanLibrary1.Interfaces;
using System.Windows.Forms;
using System.Reflection;

namespace OceanArena2
{
    public partial class Form3 : Form
    {
        public Ocean ocean = new Ocean();
        public IOceanView oceanView = new DisplayForm();
        public DisplayForm display = new DisplayForm();
        public int superbet;
        public int admin;

        int iteration = 0;

        public Form3()
        {
            InitializeComponent();
            DoubleBuffered();
        }


        private void Form3_Load(object sender, EventArgs e)
        {
            dataGridView1.MultiSelect = false;
            MakeField(dataGridView1, ocean);
            timer1.Interval = display.Speed;
            ocean.Initialize(display);
            DisplayIteration();
            
        }
        private void MakeField(DataGridView gridView, Ocean owner)
        {
            for (int i = 0; i < owner.NumCols; i++)
            {
                DataGridViewImageColumn imageCol = new DataGridViewImageColumn();
                imageCol.ImageLayout = DataGridViewImageCellLayout.Stretch;
                imageCol.DefaultCellStyle.NullValue = null;

                gridView.Columns.Add(imageCol);
                gridView.Columns[i].Width = 16;
            }

            for (int i = 0; i < owner.NumRows; i++)
            {
                gridView.Rows.Add();
                gridView.Rows[i].Height = 16;
            }
        }
        private void DisplayIteration()
        {
            display.CountParticipants(ocean);
            display.DisplayStats(label3, label5, label6, ocean, iteration, label11) ;
            display.DisplayOcean(dataGridView1, ocean);

            iteration++;
        }

        private new void DoubleBuffered()
        {
            typeof(DataGridView).InvokeMember("DoubleBuffered", BindingFlags.SetProperty
            | BindingFlags.Instance | BindingFlags.NonPublic, null,
            dataGridView1, new object[]
            {
                true
            });
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            int who = 0;
            if (ocean.NumPrey > 0 && ocean.NumPredators > 0)
            {
                if (iteration <= display.NumIteration)
                {
                    ocean.Run(iteration);

                    DisplayIteration();
                }
                if (iteration == display.NumIteration)
                {                  
                label1.Visible = true;
                button2.Visible = true;
                    if(who== 0)
                    {
                        label1.Visible = false;
                    label2.Text = "It is a draw";
                    display.Winner = 3;
                    }
                
                }
            }           

            if (ocean.NumPrey == 0 )
            {
                who = 1;
                label1.Visible = true;
                button2.Visible = true;
                label2.Text = "Predators";
                display.Winner = 1;
            }
            if (ocean.NumPredators == 0)
            {
                who = 1;
                label1.Visible = true;
                button2.Visible = true;
                display.Winner = 0;
                label2.Text = "Preys";
            }

        }

       private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form5 finish = new Form5();
            Form6 finish2 = new Form6();
            if (admin == 1)
            {
                finish.label4.Text = "You are a great administrator!";
                finish.ShowDialog();

            }
            else { 
                if (superbet == display.Winner)
                {
                    finish.label1.Visible = true;
                    finish.ShowDialog();
                } 
                else
                {
                if (display.Winner != 3)
                {
                    finish2.ShowDialog();
                }
                else
                {
                    finish.label1.Visible = true;
                    finish.label4.Text = "Well...You didn`t lose or win";
                    finish.ShowDialog();
                }
                }
            
            }
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_SelectionChanged_1(object sender, EventArgs e)
        {
            try
            {
                ((DataGridView)sender).SelectedCells[0].Selected = false;
            }
            catch { }
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
    }
}
