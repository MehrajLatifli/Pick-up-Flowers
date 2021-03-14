using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PickupFlowers
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            if (sender is PictureBox pictureBox1)
            {


                pictureBox1.Dispose();
                Random random = new Random();
                int randomX = random.Next(this.Size.Width - 200);
                int randomY = random.Next(this.Size.Height - 200);

                PictureBox pictureBoxNew = new PictureBox();


                pictureBoxNew.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                 | System.Windows.Forms.AnchorStyles.Left)
                 | System.Windows.Forms.AnchorStyles.Right)));
                pictureBoxNew.BackColor = System.Drawing.Color.Transparent;
                pictureBoxNew.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
                pictureBoxNew.Cursor = System.Windows.Forms.Cursors.Hand;
                pictureBoxNew.Image = global::PickupFlowers.Properties.Resources.y1;
                pictureBoxNew.Location = new System.Drawing.Point(randomX, randomY);
                pictureBoxNew.Name = "pictureBox2";
                pictureBoxNew.Size = new System.Drawing.Size(142, 134);
                pictureBoxNew.TabIndex = 1;
                pictureBoxNew.TabStop = false;
                pictureBoxNew.Click += new System.EventHandler(this.pictureBox1_Click);
                pictureBoxNew.MouseHover += new System.EventHandler(this.pictureBox1_MouseHover);



            


                    pictureBoxNew.Click += pictureBox1_MouseHover;
                    Controls.Add(pictureBoxNew);
                  


                
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }

}

