using Puzzle15.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace Puzzle15
{
    public partial class PuzzleArea : Form
    {
        List<Button> buttons = new List<Button>();
        int rowcount;
        int collumcount;
        int OW;
        int OH;
        int switchplayers = 1;
        bool shuffle = false;
        public Point oldblockloaction;
        Button SwappedBlock;
        Random rand = new Random();
        public PuzzleArea()
        {
            InitializeComponent();
            InitializePuzzleArea();
            InitializeBlocks();
            ShuffleBlocks();
        }
        private void InitializePuzzleArea()
        {
            this.BackColor = Color.Black;
            this.Text = "Puzzle15";
            this.ClientSize = new Size(600, 600);
        }
        private void InitializeBlocks()
        {
            PuzzleBlock block;
            int count = 0;
            rowcount = 4;
            collumcount = 4;
            for (int row = 0; row < rowcount; row++)
            {
                for (int collum = 0; collum < collumcount; collum++)
                {
                    count++;

                    block = new PuzzleBlock(collum, row, this.Width - 16, collumcount, rowcount, this.Height - 39 - 24, null, false);
                    OW = this.Width;
                    OH = this.Height;
                    block.BackgroundImage = (Image)Properties.Resources.ResourceManager.GetObject("frame_19");
                    block.BackgroundImageLayout = ImageLayout.Stretch;
                    block.Click += (Block_Click);
                    block.MouseEnter += (Block_MouseEnter);
                    block.MouseLeave += (Block_MouseLeave);
                    block.Text = count.ToString();
                    block.Name = "Block" + block.Text;
                    block.Font = new Font(block.Font.Name, 10,block.Font.Style);
                    if (count == rowcount * collumcount) { block.Text = null; block.Name = "ZeroBlock"; block.FlatStyle = FlatStyle.Flat; block.BackColor = Color.Black; block.Visible = false; }
                    buttons.Add(block);

                    this.Controls.Add(block);
                }
            }

        }

        private void Block_Click(object sender, EventArgs e)
        {
            Button block = (Button)sender;
            SwapBlocks(block);
            CheckForWin();
        }
        private void SwapBlocks(Button block)
        {

            PuzzleBlock p = new PuzzleBlock(0, 0, 0, 0, 0, 0, null, true);
            Button Empty = (Button)this.Controls["ZeroBlock"];
            oldblockloaction = block.Location;
            SwappedBlock = block;
            if (shuffle == false)
            {
                if (Math.Sqrt(Math.Pow(block.Left - Empty.Left, 2) + Math.Pow(block.Top - Empty.Top, 2)) == block.Width + p.space)
                {
                    int randNumber2;
                    switchplayers *= -1;
                    randNumber2 = rand.Next(1, 4);
                    string soundName = "block" + randNumber2.ToString();
                    if (switchplayers == 1) { Player(soundName); }
                    else { Player2(soundName); }
                    animation.Start();
                }
            }
            else
            {
                block.Location = Empty.Location;
                Empty.Location = oldblockloaction;
                shuffle = false;
            }
        }
        private void Player(string soundName)
        {
            System.IO.Stream dstr = (System.IO.Stream)Properties.Resources.ResourceManager.GetObject(soundName);
            System.Media.SoundPlayer ssnd = new System.Media.SoundPlayer(dstr);
            ssnd.Play();
        }
        private void Player2(string soundName)
        {
            System.IO.Stream str = (System.IO.Stream)Properties.Resources.ResourceManager.GetObject(soundName);
            System.Media.SoundPlayer snd = new System.Media.SoundPlayer(str);
            snd.Play();
        }
        private void PuzzleArea_ResizeEnd(object sender, EventArgs e)
        {
            if (OW == this.Width && OH == this.Height){}
            else{ResizeBlocks();}
        }
        private void ResizeBlocks()
        {
            //Centering, Changing size, Saving Combination
            //Next thing to do - rewrite this method more efficient USING Points List
            if (SettingFrame.Visible == true)
            {
                SettingFrame.Left = (this.Width - 16 - SettingFrame.Width) / 2;
                SettingFrame.Top = (this.Height - 39 - 24 - SettingFrame.Width) / 2;
            }
            int collum = 0;
            int row = 0;
            int count = 0;
            int NW = this.Width - 16;
            int NH = this.Height - 39 - 24;
            PuzzleBlock block3;
            foreach (var button in buttons)
            {
                count++;
                int BT = button.Top - ((OH - 39 - 24) - ((button.Width * rowcount) + (0 * (rowcount - 1)))) / 2;
                int BL = button.Left - ((OW - 16) - ((button.Width * collumcount) + (0 * (collumcount - 1)))) / 2;
                collum = BL / button.Width;
                row = BT / button.Width;
                block3 = new PuzzleBlock(collum, row, NW, collumcount, rowcount, NH, button, false);
                if (count == (rowcount * collumcount) + 1)
                {
                    break;
                }
            }
            this.Width = NW + 16;
            this.Height = NH + 39 + 24;
        }
        private void ResizeBlocks2()
        {
            {
                //Centering, Changing size, Saving Combination
                //Next thing to do - rewrite this method more efficient USING Points List
                if (SettingFrame.Visible == true)
                {
                    SettingFrame.Left = (this.Width - 16 - SettingFrame.Width) / 2;
                    SettingFrame.Top = (this.Height - 39 - 24 - SettingFrame.Width) / 2;
                }
                int collum = 0;
                int row = 0;
                int count = 0;
                int NW = this.Width - 16;
                int NH = this.Height - 39 - 24;
                PuzzleBlock block3;
                for (int i = 0; i < rowcount * collumcount; i++ )
                {
                    Button button = buttons[i];
                    count++;
                    int BT = button.Top - ((OH - 39 - 24) - ((button.Width * rowcount) + (0 * (rowcount - 1)))) / 2;
                    int BL = button.Left - ((OW - 16) - ((button.Width * collumcount) + (0 * (collumcount - 1)))) / 2;
                    collum = BL / button.Width;
                    row = BT / button.Width;
                    block3 = new PuzzleBlock(collum, row, NW, collumcount, rowcount, NH, button, false);
                    buttons[i] = button;
                }
                this.Width = NW + 16;
                this.Height = NH + 39 + 24;
            }
        }
        private void PuzzleArea_ResizeBegin(object sender, EventArgs e)
        {
            OW = this.Width;
            OH = this.Height;
        }
        private void ShuffleBlocks()
        {
            int randNumber;
            string blockName;
            Button block;
            for (int i = 0; i < 2 * rowcount * collumcount; i++)
            {
                randNumber = rand.Next(1, rowcount * collumcount);
                blockName = "Block" + randNumber.ToString();
                block = (Button)this.Controls[blockName];
                shuffle = true;
                SwapBlocks(block);
            }
        }
        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShuffleBlocks();
        }
        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SettingFrame.Left = (this.Width - 16 - SettingFrame.Width) / 2;
            SettingFrame.Top = (this.Height - 39 - 24 - SettingFrame.Width) / 2;
            SettingFrame.Visible = true;
        }
        private void CheckForWin()
        {
            bool Win = true;
            int orginalcollum = 0;
            int orginalrow = 0;
            for (int index = 0; index < (rowcount * collumcount); index++)
            {
                if (orginalcollum == collumcount)
                {
                    orginalcollum = 0;
                    orginalrow++;
                }
                int collum;
                int row;
                int BT = buttons[index].Top - ((this.Height - 39 - 24) - ((buttons[index].Width * rowcount) + (0 * (rowcount - 1)))) / 2;
                int BL = buttons[index].Left - ((this.Width - 16) - ((buttons[index].Width * collumcount) + (0 * (collumcount - 1)))) / 2;
                collum = BL / buttons[index].Width;
                row = BT / buttons[index].Width;
                int a = rowcount * collumcount;
                if (index == (rowcount * collumcount) - 2 && Win == true) { break; }
                else if (collum != orginalcollum || row != orginalrow) { Win = false; }
                orginalcollum++;
            }
            if (Win) { MessageBox.Show("You solved the puzzle yee"); }
        }
        private void animation_Tick(object sender, EventArgs e)
        {
            Button Empty = (Button)this.Controls["ZeroBlock"];
            for (int animationspeed = 0; animationspeed < 9; animationspeed++)
            {
                if (SwappedBlock.Top == Empty.Top)
                {
                    if (SwappedBlock.Left > Empty.Left) { SwappedBlock.Left -= 1; }
                    else { SwappedBlock.Left += 1; }
                }
                else
                {
                    if (SwappedBlock.Top > Empty.Top) { SwappedBlock.Top -= 1; }
                    else { SwappedBlock.Top += 1; }

                }
                if (SwappedBlock.Location == Empty.Location)
                {
                    Empty.Location = oldblockloaction;
                    animation.Stop();
                    break;
                }
            }
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            exitsettings.BackgroundImage = (Image)Properties.Resources.ResourceManager.GetObject("xhovering");
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            exitsettings.BackgroundImage = (Image)Properties.Resources.ResourceManager.GetObject("xnothovering");
        }

        private void exitsettings_Click(object sender, EventArgs e)
        {
            SettingFrame.Left = 1000;
            SettingFrame.Top = 1000;
            SettingFrame.Visible = false;
        }

        private void settingschanged()
        {
            bool smallerblockcount = false;
            PuzzleBlock block;
            Button Empty = (Button)this.Controls["ZeroBlock"];
            //this.Controls["ZeroBlock"].Left = 1000;
            int count = 0;
            for (int row = 0; row < rowcount; row++)
            {
                for (int collum = 0; collum < collumcount; collum++)
                {
                    if (rowcount * collumcount <= buttons.Count)
                    {
                        smallerblockcount = true;
                        if (count == (rowcount * collumcount) - 1)
                        {
                            block = new PuzzleBlock(collum, row, this.Width - 16, collumcount, rowcount, this.Height - 39 - 24, Empty, false);
                        }
                        else
                        {
                            block = new PuzzleBlock(collum, row, this.Width - 16, collumcount, rowcount, this.Height - 39 - 24, buttons[count], false);
                            block.Click += (Block_Click);
                            block.MouseEnter += (Block_MouseEnter);
                            block.MouseLeave += (Block_MouseLeave);
                        }
                    }
                    else if (rowcount * collumcount > buttons.Count)
                    {
                        if (count == (rowcount * collumcount) - 1)
                        {
                            Empty.Text = null; Empty.Name = "ZeroBlock"; Empty.FlatStyle = FlatStyle.Flat; Empty.BackColor = Color.Black; Empty.Visible = false;
                            block = new PuzzleBlock(collum, row, this.Width - 16, collumcount, rowcount, this.Height - 39 - 24, Empty, false);
                            block.Click += (Block_Click);
                            block.MouseEnter += (Block_MouseEnter);
                            block.MouseLeave += (Block_MouseLeave);
                            buttons.Add(Empty);
                        }
                        else
                        {
                            if (count <= buttons.Count - 2)
                            {
                                block = new PuzzleBlock(collum, row, this.Width - 16, collumcount, rowcount, this.Height - 39 - 24, buttons[count], false);
                                block.Click += (Block_Click);
                                block.MouseEnter += (Block_MouseEnter);
                                block.MouseLeave += (Block_MouseLeave);
                            }
                            else
                            {
                                if(count == buttons.Count - 1)
                                {
                                    buttons.RemoveAt(buttons.Count - 1);
                                }
                                block = new PuzzleBlock(collum, row, this.Width - 16, collumcount, rowcount, this.Height - 39 - 24, null, false);
                                block.Click += (Block_Click);
                                block.Font = new Font(block.Font.Name, 10, block.Font.Style);
                                block.MouseEnter += (Block_MouseEnter);
                                block.MouseLeave += (Block_MouseLeave);
                                block.BackgroundImage = (Image)Properties.Resources.ResourceManager.GetObject("frame_19");
                                block.BackgroundImageLayout = ImageLayout.Stretch;
                                block.Text = (count + 1).ToString();
                                block.Name = "Block" + block.Text;
                                buttons.Add(block);
                                this.Controls.Add(block);
                            }
                        }
                    }
                    count++;
                    OW = this.Width;
                    OH = this.Height;
                }
            }
            if (smallerblockcount == true)
            {
                for (int i = (collumcount * rowcount) - 1; i < buttons.Count - 1; i++)
                {
                    buttons[i].Left = 5000;
                }
                smallerblockcount = false;
            }
            ShuffleBlocks();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            decimal input = inputrow.Value;
            rowcount = Convert.ToInt32(input);
            decimal input2 = inputcollum.Value;
            collumcount = Convert.ToInt32(input2);
            settingschanged();
        }
        private void Block_MouseLeave(object sender, EventArgs e)
        {
            Button block = (Button)sender;
            block.BackgroundImage = (Image)Properties.Resources.ResourceManager.GetObject("frame_19");
        }
        private void Block_MouseEnter(object sender, EventArgs e)
        {
            Button block = (Button)sender;
            block.BackgroundImage = (Image)Properties.Resources.ResourceManager.GetObject("frame_hover");
        }
    }       
}    
