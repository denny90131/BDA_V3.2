using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
using _Excel = Microsoft.Office.Interop.Excel;

namespace BDA_V3._0
{
    public partial class Form1 : Form
    {
        private ucHome _ucHome;
        private ucSetting _ucSetting;
        private ucDatabase _ucDatabase;
        private ucChart _ucChart;
        public Form1()
        {
            InitializeComponent();
            _ucHome = new ucHome();
            _ucSetting = new ucSetting();
            _ucDatabase = new ucDatabase();
            _ucChart = new ucChart();
            clsGlobe._ClsGlobe.subSetWorkbook();
            clsGlobe._ClsGlobe.subSetWorksheet();
            clsGlobe._ClsGlobe.subMaxVoltageList();
            clsGlobe._ClsGlobe.subMinVoltageList();
            clsGlobe._ClsGlobe.subMaxTemList();
            this.btnDatabase.Enabled = false;
            this.btnChart.Enabled = false;
            this.btnDetLenght.Enabled = false;
            this.btnDetPostion.Enabled = false;
            this.btnRead.Enabled = false;
            mSelectedPage = ePage.home;
        }
        private ePage _prePage;
        private ePage mSelectedPage
        {
            get { return _prePage; }
            set
            {
                if (_prePage != value && value != ePage.Null)
                {
                    this.pnlDisplay.Controls.Clear();
                    this.tmrUpdate.Enabled = true;
                    switch (value)
                    {
                        case ePage.home:
                            {
                                pnlDisplay.Controls.Add(_ucHome);
                                break;
                            }
                        case ePage.setting:
                            {
                                pnlDisplay.Controls.Add(_ucSetting);
                                break;
                            }
                        case ePage.database:
                            {
                                clsGlobe._ClsGlobe.subCatch();
                                _ucDatabase.subClearDatatable();
                                _ucDatabase.subDatabase();
                                _ucDatabase.subDisplay();
                                pnlDisplay.Controls.Add(_ucDatabase);
                                break;
                            }
                        case ePage.chart:
                            {
                                pnlDisplay.Controls.Add(_ucChart);
                                break;
                            }
                    }
                }
            }
        }
        private async void subButton(System.Windows.Forms.Button oClick)
        {
            switch (oClick.Name)
            {
                //瀏覽檔案
                case "btnSearch":
                    {
                        subSearch();
                        Task bulid_file = new Task(() => clsGlobe._ClsGlobe._subExcel());
                        btnSearch.Enabled = false;
                        bulid_file.Start();
                        bulid_file.GetAwaiter().OnCompleted(() =>
                        {
                            clsGlobe._ComOpen = false;
                            btnDetLenght.Enabled = true;
                            btnDetPostion.Enabled = true;
                            btnClear.Enabled = true;
                            btnRead.Enabled = true;
                        });
                        break;
                    }
                //偵測位置
                case "btnDetPostion":
                    {
                        clsGlobe._ComOpen = true;
                        subUpdateText();
                        btnDetPostion.Enabled = false;
                        if (clsGlobe.fileNum != 0)
                        {
                            clsGlobe._ClsGlobe.subExcelPostion_maxV(clsGlobe._sheet._ListWorksheets[0]);
                            clsGlobe._ClsGlobe.subExcelPostion_minV(clsGlobe._sheet._ListWorksheets[0]);
                            clsGlobe._ClsGlobe.subExcelPostion_maxT(clsGlobe._sheet._ListWorksheets[0]);
                            clsGlobe._ClsGlobe.subExcelPostion_SOC(clsGlobe._sheet._ListWorksheets[0]);
                            MessageBox.Show("位置偵測完畢，請至主畫面確認是否正確");
                        }
                        clsGlobe._ComOpen = false;
                        break;
                    }
                //偵測長度
                case "btnDetLenght":
                    {
                        clsGlobe._ComOpen = true;
                        subUpdateText();
                        if (clsGlobe.fileNum != 0)
                        {
                            Task taskDetLenght = new Task(() => clsGlobe._ClsGlobe.subExcelLoadLenght(clsGlobe._sheet._ListWorksheets[0]));
                            taskDetLenght.Start();
                            taskDetLenght.GetAwaiter().OnCompleted(() =>
                            {
                                MessageBox.Show("長度偵測完畢，請至主畫面確認是否正確");
                            });
                        }
                        clsGlobe._ComOpen = false;
                        break;
                    }
                case "btnRead":
                    {
                        if (clsGlobe.max_v_posiotn != 0 && clsGlobe.min_v_posiotn != 0 && clsGlobe.max_t_posiotn != 0)
                        {
                            btnRead.Enabled = false;
                            clsGlobe._ComOpen = true;
                            subUpdateText();
                            if(clsGlobe.SOC_postion != 0)
                            {
                                if (clsGlobe.FileType == "BCU")
                                {
                                    Task t1 = new Task(() => clsGlobe._ClsGlobe.subReadFile_Max_V(clsGlobe.lmaxVoltage.lMaxVoltage));
                                    Task t2 = new Task(() => clsGlobe._ClsGlobe.subReadFile_Min_V(clsGlobe.lminVoltage.lMinVoltage));
                                    Task t3 = new Task(() => clsGlobe._ClsGlobe.subReadFile_Max_T(clsGlobe.lmaxTem.lMaxTem));
                                    Task t4 = new Task(() => clsGlobe._ClsGlobe.subRead_SOC(clsGlobe._SOC.lSOC));

                                    t1.Start();
                                    t2.Start();
                                    t3.Start();
                                    t4.Start();
                                    t1.GetAwaiter().OnCompleted(() =>
                                    {
                                        progressBar1.Value = 30;

                                    });
                                    t2.GetAwaiter().OnCompleted(() =>
                                    {
                                        progressBar1.Value = 60;
                                    });
                                    t3.GetAwaiter().OnCompleted(() =>
                                    {
                                        progressBar1.Value = 80;

                                    });
                                    t4.GetAwaiter().OnCompleted(() =>
                                    {
                                        progressBar1.Value = 95;
                                    });
                                    await Task.WhenAll(t1, t2, t3, t4);
                                    progressBar1.Value = 100;
                                    clsGlobe._ComOpen = false;
                                    MessageBox.Show("讀取成功");
                                    btnDatabase.Enabled = true;
                                    btnChart.Enabled = true;
                                    btnSetting.Enabled = false;
                                }
                            }
                            else
                            {
                                if(clsGlobe.FileType == "BMU")
                                {
                                    Task t1 = new Task(() => clsGlobe._ClsGlobe.subReadFile_Max_V(clsGlobe.lmaxVoltage.lMaxVoltage));
                                    Task t2 = new Task(() => clsGlobe._ClsGlobe.subReadFile_Min_V(clsGlobe.lminVoltage.lMinVoltage));
                                    Task t3 = new Task(() => clsGlobe._ClsGlobe.subReadFile_Max_T(clsGlobe.lmaxTem.lMaxTem));
                                    t1.Start();
                                    t2.Start();
                                    t3.Start();
                                    t1.GetAwaiter().OnCompleted(() =>
                                    {
                                        progressBar1.Value = 30;

                                    });
                                    t2.GetAwaiter().OnCompleted(() =>
                                    {
                                        progressBar1.Value = 60;
                                    });
                                    t3.GetAwaiter().OnCompleted(() =>
                                    {
                                        progressBar1.Value = 90;
                                    });
                                    await Task.WhenAll(t1, t2, t3);
                                    progressBar1.Value = 100;
                                    clsGlobe._ComOpen = false;
                                    MessageBox.Show("讀取成功");
                                    btnDatabase.Enabled = true;
                                    btnChart.Enabled = true;
                                    btnSetting.Enabled = false;
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("資料位置輸入錯誤");
                            break;
                        }
                        break;
                    }
                case "btnClear":
                    {
                        _ucChart.subClearChart_Form(clsGlobe.fileNum - 1);
                        //clsGlobe.Row = 1;
                        //clsGlobe.max_v_posiotn = 0;
                        //clsGlobe.min_v_posiotn = 0;
                        //clsGlobe.max_t_posiotn = 0;
                        //clsGlobe.SOC_postion = 0;
                        clsGlobe.fileNum = 0;
                        clsGlobe.FileType = "未偵測";
                        clsGlobe.lmaxTem.lMaxTem.Clear();
                        clsGlobe.lmaxVoltage.lMaxVoltage.Clear();
                        clsGlobe.lminVoltage.lMinVoltage.Clear();
                        clsGlobe.lmaxVoltage.mMaxVoltage.Clear();
                        clsGlobe.lminVoltage.mMinVoltage.Clear();
                        clsGlobe.lmaxVoltage.mMaxVoltage.Clear();
                        clsGlobe._SOC.lSOC.Clear();
                        progressBar1.Value = 0;
                        this.btnDetLenght.Enabled = false;
                        this.btnSearch.Enabled = true;
                        this.btnSetting.Enabled = true;
                        this.btnChart.Enabled = false;
                        this.btnRead.Enabled = false;
                        this.btnDatabase.Enabled = false;
                        clsGlobe._ClsGlobe.subMaxVoltageList();
                        clsGlobe._ClsGlobe.subMinVoltageList();
                        clsGlobe._ClsGlobe.subMaxTemList();
                        mSelectedPage = ePage.home;
                        break;
                    }
            }
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            subButton(btnSearch);
        }
        private void btnDetPostion_Click(object sender, EventArgs e)
        {
            subButton(btnDetPostion);
        }
        private void btnDetLenght_Click(object sender, EventArgs e)
        {
            subButton(btnDetLenght);
        }

        public void subSearch()
        {
            clsGlobe.fileNum = 0;
            clsGlobe._ComOpen = true;
            clsGlobe._path._Lpath.Clear();
            clsGlobe._ComOpen = true;
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Title = $"讀取檔案";
            openFile.Multiselect = true;
            openFile.Filter = "xls Files(*.xls; *.xlsx;*.csv;)| *.xls; *.xlsx; *.csv;";
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                foreach (String _file in openFile.FileNames)
                {
                    clsGlobe._path._Lpath.Add(_file);
                    clsGlobe.fileNum += 1;
                    if (_file.Contains("BCE"))
                    {
                        clsGlobe.FileType = "BCU";
                    }
                    else if (_file.Contains("BME"))
                    {
                        clsGlobe.FileType = "BMU";
                    }
                    else
                    {
                        clsGlobe.FileType = "未偵測";
                    }
                }
            }
        }
        private void tmrUpdate_Tick(object sender, EventArgs e)
        {
            subUpdateText();
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            subButton(btnClear);
        }
        private void subUpdateText()
        {
            lblFileNum.Text = clsGlobe.fileNum.ToString();
            lblStatus.ForeColor = (clsGlobe._ComOpen == true) ? Color.Red : Color.Green;
            lblFileType.Text = clsGlobe.FileType;
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            mSelectedPage = ePage.home;
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            subButton(btnRead);
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            mSelectedPage = ePage.setting;
        }

        private void btnDatabase_Click(object sender, EventArgs e)
        {
            mSelectedPage = ePage.database;
        }

        private void btnChart_Click(object sender, EventArgs e)
        {
            mSelectedPage = ePage.chart;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            clsGlobe._ClsGlobe.subClearBlackGroundWorker();
        }
    }
}
