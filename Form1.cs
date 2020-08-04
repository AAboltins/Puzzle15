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
            int  formwidth = 700;
            this.ClientSize = new Size(formwidth, formwidth);
            InitializeBlocks(formwidth);
        }
        private void InitializeBlocks(int formwidth)
        {
            PuzzleBlock block;
            for (int i = 1; i < 17; i++)
            {
                block = new PuzzleBlock(i, formwidth);
                this.Controls.Add(block);
            }
        }

    }
}
