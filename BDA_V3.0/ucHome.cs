using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BDA_V3._0
{
    public partial class ucHome : UserControl
    {
        public ucHome()
        {
            InitializeComponent();
            this.tmrUpdate.Enabled = true;
        }

        private void tmrUpdate_Tick(object sender, EventArgs e)
        {
            lblMaxVoltagePostion.Text = clsGlobe.max_v_posiotn.ToString();
            lblMinVoltagePostion.Text = clsGlobe.min_v_posiotn.ToString();
            lblMaxTemPostion.Text = clsGlobe.max_t_posiotn.ToString();
            lblDataLenght.Text = clsGlobe.Row.ToString();
            lblSOC.Text = clsGlobe.SOC_postion.ToString();
        }
    }
}
