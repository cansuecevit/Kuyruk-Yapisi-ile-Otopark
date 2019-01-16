using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proje1
{
    public partial class Form1 : System.Windows.Forms.Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Otoparkımız op = new Otoparkımız();

        private void btnaddcar_Click(object sender, EventArgs e)
        {
            if (rtxtcircular.Text == "")
            {
                rtxtcircular.Text = op.c.listele();
            }
            else
                MessageBox.Show("Cars added.");
        }

        private void btnatc_Click(object sender, EventArgs e)
        {
            txtatc.Text = op.c.ortalamaITS().ToString();
        }

        private void btnsort_Click(object sender, EventArgs e)
        {
            if (rtxtpriority.Text == "")
            {
                rtxtpriority.Text = op.p.listele();
            }
            else
                MessageBox.Show("Cars sorted.");
        }

        private void btnfind_Click(object sender, EventArgs e)
        {
            if (rtxtfd.Text == "")
            {
                rtxtfd.Text += op.FarklarıBul();
            }
            else
                MessageBox.Show("Farklar bulundu.");
        }


    }
    }

