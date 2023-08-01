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
    public partial class ucDatabase : UserControl
    {
        DataTable dt = new DataTable();
        public ucDatabase()
        {
            InitializeComponent();
        }
        public void subDatabase()
        {
            dt.Columns.Add("編號");
            dt.Columns.Add("最高單體電壓");
            dt.Columns.Add("最低單體電壓");
            dt.Columns.Add("最高單體溫度");
            for(int i = 0; i <= clsGlobe.fileNum-1; i++)
            {
                dt.Rows.Add(i+1,clsGlobe.lmaxVoltage.mMaxVoltage[i], clsGlobe.lminVoltage.mMinVoltage[i], clsGlobe.lmaxTem.mMaxTem[i]);
            }
        }
        public void subClearDatatable()
        {
            dt.Columns.Clear();
            dt.Rows.Clear();
            dt.Clear();
        }
        public void subDisplay()
        {
            dataGridView1.DataSource = dt;
        }
    }
}
