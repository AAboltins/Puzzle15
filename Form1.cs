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
            int Height = 700;
            int Width = 700;
            this.ClientSize = new Size(Width, Height);
            InitializeBlocks(Width, Height);
        }
        private void InitializeBlocks(int Width, int Height)
        {
            PuzzleBlock block;
            int count = 0;
            int rowcount = 12;
            int collumcount = 12;
            for (int row = 0; row < rowcount; row++)
            {
                for (int collum = 0; collum < collumcount; collum++)
                {
                    count++;
                    block = new PuzzleBlock(collum, row, Width, count, collumcount, rowcount, Height);
                    this.Controls.Add(block);
                }
            }
            
        }
        private void PuzzleArea_Load(object sender, EventArgs e)
        {

        }
    }
}
