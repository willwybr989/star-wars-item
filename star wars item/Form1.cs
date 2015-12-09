using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace star_wars_item
{
    public partial class Form1 : Form
    {
        Graphics g;

        public Form1()
        {
            InitializeComponent();
            g = this.CreateGraphics();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public void ExhaustPort(float x, float y, float width, float height)
        {
            //Scaleing values 
            float scaleX = width/50; 
            float scaleY = height/290;

            //Sets color for pen and makes it usable 
            Pen exPen = new Pen(Color.White);

            //Graphic perameters 
            g.DrawRectangle(exPen, 0 * scaleX + x, 0*scaleY + y, 50*scaleX , 290*scaleY  );

            //Bottom Hole in port 
            g.DrawArc(exPen, 0 * scaleX + x, 240 * scaleY + y, 50 * scaleX, 50 * scaleY, -37, 255);

            //side Lines
            g.DrawLine(exPen, 44 * scaleX + x, 0*scaleY + y, 44 * scaleX + x, 250 * scaleY + y);
            g.DrawLine(exPen, 6 * scaleX + x, 0 * scaleY + y, 6 * scaleX + x, 250 * scaleY + y);

            //Angled lines on Triangle 
            g.DrawLine(exPen, 6 * scaleX + x, 0 * scaleY + y, 20 * scaleX + x, 24 * scaleY + y);
            g.DrawLine(exPen, 44 * scaleX + x, 0 * scaleY + y, 30 * scaleX + x, 24 * scaleY + y);

            //Bottom lines on Triangle 
            g.DrawLine(exPen, 20 * scaleX + x, 24 * scaleY + y, 6 * scaleX + x, 24 * scaleY + y);
            g.DrawLine(exPen, 30 * scaleX + x, 24 * scaleY + y, 44 * scaleX + x, 24 * scaleY + y);

        }

        private void Form1_Click(object sender, EventArgs e)
        {
            ExhaustPort(0, 0, 50, 290);
        }
    }
}
