using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Puzzle15
{
    public partial class PuzzleArea : Form
    {
        public PuzzleArea()
        {
            InitializeComponent();
            InitializePuzzleArea();
        }

        private void InitializePuzzleArea()
        {
            this.BackColor = Color.Black;
            this.Text = "Puzzle15";
            InitializeBlocks();
        }

        private void InitializeBlocks()
        {
            PuzzleBlock block;
            for (int i = 1; i < 17; i++)
            {
                block = new PuzzleBlock(i);
                this.Controls.Add(block);
            }
        }

    }
}
