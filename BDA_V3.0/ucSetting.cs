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
    public partial class ucSetting : UserControl
    {
        public ucSetting()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            try
            {
                if(txtMaxTPostion.Text != string.Empty && txtMinVPostion.Text != string.Empty && txtMaxTPostion.Text!=string.Empty && txtDataLenght.Text != string.Empty)
                {
                    clsGlobe.max_v_posiotn = Convert.ToDouble(txtMaxVPostion.Text);
                    clsGlobe.min_v_posiotn = Convert.ToDouble(txtMinVPostion.Text);
                    clsGlobe.max_t_posiotn = Convert.ToDouble(txtMaxTPostion.Text);
                    clsGlobe.Row = Convert.ToInt32(txtDataLenght.Text);
                }
                else
                {
                    MessageBox.Show("數值尚未輸入完整");
                }
            }
            catch
            {
                MessageBox.Show("資料設定錯誤");
            }
        }

        private void ucSetting_Load(object sender, EventArgs e)
        {
            txtMaxVPostion.Text = clsGlobe.max_v_posiotn.ToString();
            txtMinVPostion.Text = clsGlobe.min_v_posiotn.ToString();
            txtMaxTPostion.Text = clsGlobe.max_t_posiotn.ToString();
            txtDataLenght.Text = clsGlobe.Row.ToString();
        }
    }
}
