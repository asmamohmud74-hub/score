using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace socre
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textTestScore1_TextChanged(object sender, EventArgs e)
        {
         
        }

        private void textTestScore2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double score1 = double.Parse(textTestScore1.Text);
            double score2 = double.Parse(textTestScore2.Text);
            double score3 = double.Parse(textTestScore3.Text);
            double average = (score1 + score2 + score3) / 3;
            txtAverage.Text = average.ToString("0.0");


        }

       
        

        }
        
           
        }
    
    

