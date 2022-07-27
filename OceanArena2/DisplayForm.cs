using System;
using OceanLibrary1.Classes;
using OceanLibrary1.Interfaces;
using System.Windows.Forms;
using System.Drawing;

namespace OceanArena2
{
    public class DisplayForm : IOceanView 
    {
        private int numIterations;

        public int numOfOceans;

        private int _numPrey;
        private int _numPredators;
        private int _numObstacles;
        private int _numPirats;

        private Bitmap _obstacleImage = new Bitmap(Properties.Resources.bush);
        private Bitmap _preyImage = new Bitmap(Properties.Resources.prey);
        private Bitmap _predatorImage = new Bitmap(Properties.Resources.predator);
        private Bitmap _piratImage = new Bitmap(Properties.Resources.pirat);


        public int bet=0;
        public int winner=0;
        public int admine = 0;
        public int speed = 1000;
        public int Bet
        {
            get { return bet; }
            set { bet = value; }
        }
        public int Winner
        {
            get { return winner; }
            set { winner = value; }
        }
        #region [Properties]

        public int NumPrey
        {
            get { return _numPrey; }
            set { _numPrey = value; }
        }

        public int NumPredators
        {
            get { return _numPredators; }
            set { _numPredators = value; }
        }

        public int NumObstacle
        {
            get { return _numObstacles; }
            set { _numObstacles = value; }
        }

        public int NumIteration
        {
            get { return numIterations; }
            set { numIterations = value; }
        }
        public int NumPirats
        {
            get { return _numPirats; }
            set { _numPirats = value; }
        }
        public int Speed
        {
            get { return speed; }   
            set { speed = value; }
        }
        #endregion

        public void CountParticipants(Ocean owner)
        {
            int preys = 0;
            int predators = 0;
            int pirats = 0;

            for (int i = 0; i < owner.NumRows; i++)
            {
                for (int j = 0; j < owner.NumCols; j++)
                {
                    if (owner.Cells[i, j].Image == 'f')
                    {
                        preys++;
                    }
                    else if (owner.Cells[i, j].Image == 'S')
                    {
                        predators++;
                    }
                    else if (owner.Cells[i, j].Image == 'p')
                    {
                        pirats++;
                    }
                    else
                    {
                        continue;
                    }
                }
            }

            owner.NumPrey = preys;
            owner.NumPredators = predators;
            owner.NumPirats = pirats;
        }

        public void DisplayStats(Label iterationNum, Label preysNum, Label predatorsNum, Ocean owner, int iteration, Label pirats)
        {
            iterationNum.Text = iteration.ToString();
            preysNum.Text = owner.NumPrey.ToString();
            predatorsNum.Text = owner.NumPredators.ToString();
            pirats.Text = Pirats._eatenFish.ToString();
        }

        public void DisplayOcean(DataGridView gridView, Ocean owner)
        {
            for (int i = 0; i < Constants.DefaultRows; i++)
            {
                for (int j = 0; j < Constants.DefaultCols; j++)
                {
                    if (owner.cells[i, j].Image == 'f')
                    {
                        gridView.Rows[i].Cells[j].Value = _preyImage;
                    }
                    else if (owner.cells[i, j].Image == 'S')
                    {
                        gridView.Rows[i].Cells[j].Value = _predatorImage;
                    }
                    else if (owner.cells[i, j].Image == '#')
                    {
                        gridView.Rows[i].Cells[j].Value = _obstacleImage;
                    }
                    else if (owner.cells[i, j].Image == 'p')
                    {
                        gridView.Rows[i].Cells[j].Value = _piratImage;
                    }
                    else
                    {
                        gridView.Rows[i].Cells[j].Value = null;
                    }
                }
            }
        }
    }
}
