using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace twozerofoureight
{
    public partial class TwoZeroFourEightScoreView : Form , View
    {
        
        public TwoZeroFourEightScoreView()
        {
            InitializeComponent();
        }

        public void Notify(Model m)
        {
            lblscoree.Text = Convert.ToString(((TwoZeroFourEightModel)m).Score);
        }

 // no use
        private void lblscoree_Click(int s)
        {
            
        }
       
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void lblScore_Click(object sender, EventArgs e)
        {

        }
       
    }
}
