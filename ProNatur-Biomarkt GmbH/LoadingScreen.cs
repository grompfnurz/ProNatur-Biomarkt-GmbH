using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProNatur_Biomarkt_GmbH
{
    public partial class LoadingScreen : Form
    {
        private int loadingBarValue = 0;
        public LoadingScreen()
        {
            InitializeComponent();
        }
        private void LoadingScreen_Load(object sender, EventArgs e)
         {
            loadingBarTimer.Start();
         }       
        private void loadingBarTimer_Tick(object sender, EventArgs e)
        {
            loadingBarValue += 1;
            lblLoadingProgress.Text = loadingBarValue.ToString()+" %";
            loadingProgressBar.Value = loadingBarValue;

            if (loadingBarValue >= loadingProgressBar.Maximum)
            {
                loadingBarTimer.Stop();
            }
        }

        
    }
}
