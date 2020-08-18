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
        List<Button> buttons = new List<Button>();
        int rowcount;
        int collumcount;
        int OW;
        int OH;
        public PuzzleArea()
        {
            InitializeComponent();
            InitializePuzzleArea(600, 600);
        }

        private void InitializePuzzleArea(int Width, int Height)
        {
            this.BackColor = Color.Black;
            this.Text = "Puzzle15";
            this.ClientSize = new Size(Width, Height);
            InitializeBlocks(Width, Height);
            OW = this.Width;
            OH = this.Height;
        }
        private void InitializeBlocks(int Width, int Height)
        {

            //W difference +16
            //H difference +39
            PuzzleBlock block;
            int count = 0;
            rowcount = 4;
            collumcount = 4;
            for (int row = 0; row < rowcount; row++)
            {
                for (int collum = 0; collum < collumcount; collum++)
                {
                    count++;
                    block = new PuzzleBlock(collum, row, Width, collumcount, rowcount, Height, null, false);
                    block.Click += (Block_Click);
                    block.Text = count.ToString();
                    if (count == rowcount*collumcount) { block.Text = null; block.Name = "ZeroBlock"; block.FlatStyle = FlatStyle.Flat; block.BackColor = Color.Black; }
                    buttons.Add(block);
                    this.Controls.Add(block);               
                }
            }
        }
        private void Block_Click(object sender, EventArgs e)
        {
            Button block = (Button)sender;
            //MessageBox.Show(block.Name);
            SwapBlocks(block);
        }
        private void SwapBlocks(Button block)
        {
            PuzzleBlock p = new PuzzleBlock(0, 0, 0, 0, 0, 0,  null, true);
            Button Empty = (Button)this.Controls["ZeroBlock"];
            
            Point oldblocklocation = block.Location;
            if (Math.Sqrt(Math.Pow(block.Left - Empty.Left, 2) + Math.Pow(block.Top - Empty.Top, 2)) == block.Width + p.space)
            {
                block.Location = Empty.Location;
                Empty.Location = oldblocklocation;
            }
        }
        private void PuzzleArea_ResizeEnd(object sender, EventArgs e)
        {
            int collum = 0;
            int row = 0;
            int count = 0;
            int NW = this.Width - 16;
            int NH = this.Height - 39;
            PuzzleBlock block3;
            PuzzleBlock block2 = new PuzzleBlock(0, 0, 0, 0, 0, 0, null, false);
            foreach (var button in buttons)
            {
                this.Width = OW;
                this.Height = OH;
                count++;
                int BT = button.Top - ((OH-39) - ((button.Width * rowcount) + (0 * (rowcount - 1)))) / 2;
                int BL = button.Left - ((OW-16) - ((button.Width * collumcount) + (0 * (collumcount - 1)))) / 2;

                collum = BL / button.Width;
                row = BT / button.Width;

                block3 = new PuzzleBlock(collum, row, NW, collumcount, rowcount, NH, button, false);
                if (count == (rowcount * collumcount)) { button.Text = null; button.Name = "ZeroBlock"; button.FlatStyle = FlatStyle.Flat; button.BackColor = Color.Black; count = 0; }
            }
            this.Width = NW + 16;
            this.Height = NH + 39;

        }
        private void PuzzleArea_ResizeBegin(object sender, EventArgs e)
        {
            OW = this.Width;
            OH = this.Height;
        }
    }
}
