using System;
using System.Windows.Forms;

namespace APPEET
{
    public partial class loading : Form
    {
        public loading()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int progress = rnd.Next(15);
            this.progress_bar.Width += progress;
            if (this.progress_bar.Width >= 900)
            {
                timer1.Stop();
                auth f1 = new auth();
                f1.Show();
                this.Hide();
            }
        }
    }
}
