using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Office.Interop.Excel;
using _Excel = Microsoft.Office.Interop.Excel;
using System.Runtime.InteropServices;

namespace BDA_V3._0
{
    public static class clsGlobe
    {
        public static Books _book = new Books();
        public static Sheet _sheet = new Sheet();
        public static path _path = new path();
        public static SOC _SOC = new SOC();
        public static MaxVoltage lmaxVoltage = new MaxVoltage();
        public static MinVoltage lminVoltage = new MinVoltage();
        public static MaxTem lmaxTem = new MaxTem();
        public static _clsgGlobe _ClsGlobe = new _clsgGlobe();
        public static int Row = 1;
        public static int fileNum;
        public static bool _ComOpen = false;
        public static double max_v_posiotn = 0;
        public static double min_v_posiotn = 0;
        public static double max_t_posiotn = 0;
        public static double SOC_postion = 0;
        public static double ChartMaximumSize;
        public static double ChartMinimumSize;
        public static string FileType = "未偵測";
        public static string ExportPath;
    }
    public enum ePage
    {
        Null,
        home,
        database,
        chart,
        setting
    }
    public class _clsgGlobe
    {
        _Application excel = new _Excel.Application();

        public void subExcelLoadLenght(Worksheet ws)
        {
            //計算列表長度
            if (clsGlobe.Row == 1)
            {
                for (int _count = 1; _count < 3000; _count++)
                {
                    if (ws.Cells[_count, 110].value != null)
                    {
                        clsGlobe.Row += 1;
                    }
                    else
                    {
                        break;
                    }
                }
            }
        } //讀取長度
        public void subExcelPostion_maxV(Worksheet ws)
        {
            if (clsGlobe.max_v_posiotn == 0)
            {
                for (int _count = 1; _count < 200; _count++)
                {
                    if (ws.Cells[1, _count].value != "最高单体电压编号" && ws.Cells[1, _count].value != "最高單體電壓編號")
                    {
                        _count += 1;
                    }
                    else if (ws.Cells[1, _count].value == "最高单体电压编号")
                    {
                        clsGlobe.max_v_posiotn = _count - 1;
                        break;
                    }
                    else if (ws.Cells[1, _count].value == "最高單體電壓編號")
                    {
                        clsGlobe.max_v_posiotn = _count - 1;
                        break;
                    }
                }
            }
        } //讀取最高電壓位置
        public void subExcelPostion_minV(Worksheet ws)
        {
            if (clsGlobe.min_v_posiotn == 0)
            {
                for (int _count = 1; _count < 200; _count++)
                {
                    if (ws.Cells[1, _count].value != "最低单体电压" && ws.Cells[1, _count].value != "最低單體電壓")
                    {
                        _count += 1;
                    }
                    else if(ws.Cells[1, _count].value == "最低单体电压")
                    {
                        clsGlobe.min_v_posiotn = _count;
                        break;
                    }
                    else if (ws.Cells[1, _count].value == "最低單體電壓")
                    {
                        clsGlobe.min_v_posiotn = _count;
                        break;
                    }
                }
            }
        } //讀取最低電壓位置
        public void subExcelPostion_maxT(Worksheet ws)
        {
            if (clsGlobe.max_t_posiotn == 0)
            {
                for (int _count = 1; _count < 200; _count++)
                {
                    if (ws.Cells[1, _count].value != "最高单体温度编号" && ws.Cells[1, _count].value != "最高單體溫度")
                    {
                        _count += 1;
                    }
                    else if(ws.Cells[1, _count].value == "最高单体温度编号")
                    {
                        clsGlobe.max_t_posiotn = _count - 1;
                        break;
                    }
                    else if (ws.Cells[1, _count].value == "最高單體溫度")
                    {
                        clsGlobe.max_t_posiotn = _count;
                        break;
                    }
                }
            }
        } //讀取最高溫度位置
        public void subExcelPostion_SOC(Worksheet ws)
        {
            if (clsGlobe.SOC_postion == 0)
            {
                for (int _count = 1; _count < 200; _count++)
                {
                    if (ws.Cells[1, _count].value != "SOC" && ws.Cells[1, _count].value != "SOH")
                    {
                        _count += 1;
                    }
                    else if (ws.Cells[1, _count].value == "SOC")
                    {
                        clsGlobe.SOC_postion = _count;
                        break;
                    }
                    else if (ws.Cells[1, _count].value == "SOH")
                    {
                        clsGlobe.SOC_postion = _count - 1;
                        break;
                    }
                }
            }
        } //讀取最高溫度位置
        public void _subExcel() 
        {
            if(clsGlobe.fileNum != 0)
            {
                try
                {
                    for (int i = 0; i <= clsGlobe.fileNum - 1; i++)
                    {
                        clsGlobe._book._ListWorkbook[i] = excel.Workbooks.Open(clsGlobe._path._Lpath[i]);
                        clsGlobe._sheet._ListWorksheets[i] = clsGlobe._book._ListWorkbook[i].Worksheets[1];
                    }
                }
                catch(Exception)
                {
                    
                }
            }
        } //excel設定

        public void subClearBlackGroundWorker()
        {
            excel.Workbooks.Close();
            excel.Quit();
            Marshal.FinalReleaseComObject(excel);
        }
        public void subSetWorkbook()
        {
            clsGlobe._book._ListWorkbook.Add(clsGlobe._book.wb1);
            clsGlobe._book._ListWorkbook.Add(clsGlobe._book.wb2);
            clsGlobe._book._ListWorkbook.Add(clsGlobe._book.wb3);
            clsGlobe._book._ListWorkbook.Add(clsGlobe._book.wb4);
            clsGlobe._book._ListWorkbook.Add(clsGlobe._book.wb5);
            clsGlobe._book._ListWorkbook.Add(clsGlobe._book.wb6);
            clsGlobe._book._ListWorkbook.Add(clsGlobe._book.wb7);
            clsGlobe._book._ListWorkbook.Add(clsGlobe._book.wb8);
            clsGlobe._book._ListWorkbook.Add(clsGlobe._book.wb9);
            clsGlobe._book._ListWorkbook.Add(clsGlobe._book.wb10);
            clsGlobe._book._ListWorkbook.Add(clsGlobe._book.wb11);
            clsGlobe._book._ListWorkbook.Add(clsGlobe._book.wb12);
            clsGlobe._book._ListWorkbook.Add(clsGlobe._book.wb13);
            clsGlobe._book._ListWorkbook.Add(clsGlobe._book.wb14);
            clsGlobe._book._ListWorkbook.Add(clsGlobe._book.wb15);
            clsGlobe._book._ListWorkbook.Add(clsGlobe._book.wb16);
            clsGlobe._book._ListWorkbook.Add(clsGlobe._book.wb17);
            clsGlobe._book._ListWorkbook.Add(clsGlobe._book.wb18);
            clsGlobe._book._ListWorkbook.Add(clsGlobe._book.wb19);
            clsGlobe._book._ListWorkbook.Add(clsGlobe._book.wb20);
        }   // workbook 列表設置
        public void subSetWorksheet()
        {
            clsGlobe._sheet._ListWorksheets.Add(clsGlobe._sheet.ws1);
            clsGlobe._sheet._ListWorksheets.Add(clsGlobe._sheet.ws2);
            clsGlobe._sheet._ListWorksheets.Add(clsGlobe._sheet.ws3);
            clsGlobe._sheet._ListWorksheets.Add(clsGlobe._sheet.ws4);
            clsGlobe._sheet._ListWorksheets.Add(clsGlobe._sheet.ws5);
            clsGlobe._sheet._ListWorksheets.Add(clsGlobe._sheet.ws6);
            clsGlobe._sheet._ListWorksheets.Add(clsGlobe._sheet.ws7);
            clsGlobe._sheet._ListWorksheets.Add(clsGlobe._sheet.ws8);
            clsGlobe._sheet._ListWorksheets.Add(clsGlobe._sheet.ws9);
            clsGlobe._sheet._ListWorksheets.Add(clsGlobe._sheet.ws10);
            clsGlobe._sheet._ListWorksheets.Add(clsGlobe._sheet.ws11);
            clsGlobe._sheet._ListWorksheets.Add(clsGlobe._sheet.ws12);
            clsGlobe._sheet._ListWorksheets.Add(clsGlobe._sheet.ws13);
            clsGlobe._sheet._ListWorksheets.Add(clsGlobe._sheet.ws14);
            clsGlobe._sheet._ListWorksheets.Add(clsGlobe._sheet.ws15);
            clsGlobe._sheet._ListWorksheets.Add(clsGlobe._sheet.ws16);
            clsGlobe._sheet._ListWorksheets.Add(clsGlobe._sheet.ws17);
            clsGlobe._sheet._ListWorksheets.Add(clsGlobe._sheet.ws18);
            clsGlobe._sheet._ListWorksheets.Add(clsGlobe._sheet.ws19);
            clsGlobe._sheet._ListWorksheets.Add(clsGlobe._sheet.ws20);
        }  // worksheet 列表設置

        public void subMaxVoltageList()
        {
            clsGlobe.lmaxVoltage.lMaxVoltage.Add(clsGlobe.lmaxVoltage.MaxV_1);
            clsGlobe.lmaxVoltage.lMaxVoltage.Add(clsGlobe.lmaxVoltage.MaxV_2);
            clsGlobe.lmaxVoltage.lMaxVoltage.Add(clsGlobe.lmaxVoltage.MaxV_3);
            clsGlobe.lmaxVoltage.lMaxVoltage.Add(clsGlobe.lmaxVoltage.MaxV_4);
            clsGlobe.lmaxVoltage.lMaxVoltage.Add(clsGlobe.lmaxVoltage.MaxV_5);
            clsGlobe.lmaxVoltage.lMaxVoltage.Add(clsGlobe.lmaxVoltage.MaxV_6);
            clsGlobe.lmaxVoltage.lMaxVoltage.Add(clsGlobe.lmaxVoltage.MaxV_7);
            clsGlobe.lmaxVoltage.lMaxVoltage.Add(clsGlobe.lmaxVoltage.MaxV_8);
            clsGlobe.lmaxVoltage.lMaxVoltage.Add(clsGlobe.lmaxVoltage.MaxV_9);
            clsGlobe.lmaxVoltage.lMaxVoltage.Add(clsGlobe.lmaxVoltage.MaxV_10);
            clsGlobe.lmaxVoltage.lMaxVoltage.Add(clsGlobe.lmaxVoltage.MaxV_11);
            clsGlobe.lmaxVoltage.lMaxVoltage.Add(clsGlobe.lmaxVoltage.MaxV_12);
            clsGlobe.lmaxVoltage.lMaxVoltage.Add(clsGlobe.lmaxVoltage.MaxV_13);
            clsGlobe.lmaxVoltage.lMaxVoltage.Add(clsGlobe.lmaxVoltage.MaxV_14);
            clsGlobe.lmaxVoltage.lMaxVoltage.Add(clsGlobe.lmaxVoltage.MaxV_15);
            clsGlobe.lmaxVoltage.lMaxVoltage.Add(clsGlobe.lmaxVoltage.MaxV_16);
            clsGlobe.lmaxVoltage.lMaxVoltage.Add(clsGlobe.lmaxVoltage.MaxV_17);
            clsGlobe.lmaxVoltage.lMaxVoltage.Add(clsGlobe.lmaxVoltage.MaxV_18);
            clsGlobe.lmaxVoltage.lMaxVoltage.Add(clsGlobe.lmaxVoltage.MaxV_19);
            clsGlobe.lmaxVoltage.lMaxVoltage.Add(clsGlobe.lmaxVoltage.MaxV_20);
        }
        public void subMinVoltageList()
        {
            clsGlobe.lminVoltage.lMinVoltage.Add(clsGlobe.lminVoltage.MinV_1);
            clsGlobe.lminVoltage.lMinVoltage.Add(clsGlobe.lminVoltage.MinV_2);
            clsGlobe.lminVoltage.lMinVoltage.Add(clsGlobe.lminVoltage.MinV_3);
            clsGlobe.lminVoltage.lMinVoltage.Add(clsGlobe.lminVoltage.MinV_4);
            clsGlobe.lminVoltage.lMinVoltage.Add(clsGlobe.lminVoltage.MinV_5);
            clsGlobe.lminVoltage.lMinVoltage.Add(clsGlobe.lminVoltage.MinV_6);
            clsGlobe.lminVoltage.lMinVoltage.Add(clsGlobe.lminVoltage.MinV_7);
            clsGlobe.lminVoltage.lMinVoltage.Add(clsGlobe.lminVoltage.MinV_8);
            clsGlobe.lminVoltage.lMinVoltage.Add(clsGlobe.lminVoltage.MinV_9);
            clsGlobe.lminVoltage.lMinVoltage.Add(clsGlobe.lminVoltage.MinV_10);
            clsGlobe.lminVoltage.lMinVoltage.Add(clsGlobe.lminVoltage.MinV_11);
            clsGlobe.lminVoltage.lMinVoltage.Add(clsGlobe.lminVoltage.MinV_12);
            clsGlobe.lminVoltage.lMinVoltage.Add(clsGlobe.lminVoltage.MinV_13);
            clsGlobe.lminVoltage.lMinVoltage.Add(clsGlobe.lminVoltage.MinV_14);
            clsGlobe.lminVoltage.lMinVoltage.Add(clsGlobe.lminVoltage.MinV_15);
            clsGlobe.lminVoltage.lMinVoltage.Add(clsGlobe.lminVoltage.MinV_16);
            clsGlobe.lminVoltage.lMinVoltage.Add(clsGlobe.lminVoltage.MinV_17);
            clsGlobe.lminVoltage.lMinVoltage.Add(clsGlobe.lminVoltage.MinV_18);
            clsGlobe.lminVoltage.lMinVoltage.Add(clsGlobe.lminVoltage.MinV_19);
            clsGlobe.lminVoltage.lMinVoltage.Add(clsGlobe.lminVoltage.MinV_20);
        }

        public void subMaxTemList()
        {
            clsGlobe.lmaxTem.lMaxTem.Add(clsGlobe.lmaxTem.MaxT_1);
            clsGlobe.lmaxTem.lMaxTem.Add(clsGlobe.lmaxTem.MaxT_2);
            clsGlobe.lmaxTem.lMaxTem.Add(clsGlobe.lmaxTem.MaxT_3);
            clsGlobe.lmaxTem.lMaxTem.Add(clsGlobe.lmaxTem.MaxT_4);
            clsGlobe.lmaxTem.lMaxTem.Add(clsGlobe.lmaxTem.MaxT_5);
            clsGlobe.lmaxTem.lMaxTem.Add(clsGlobe.lmaxTem.MaxT_6);
            clsGlobe.lmaxTem.lMaxTem.Add(clsGlobe.lmaxTem.MaxT_7);
            clsGlobe.lmaxTem.lMaxTem.Add(clsGlobe.lmaxTem.MaxT_8);
            clsGlobe.lmaxTem.lMaxTem.Add(clsGlobe.lmaxTem.MaxT_9);
            clsGlobe.lmaxTem.lMaxTem.Add(clsGlobe.lmaxTem.MaxT_10);
            clsGlobe.lmaxTem.lMaxTem.Add(clsGlobe.lmaxTem.MaxT_11);
            clsGlobe.lmaxTem.lMaxTem.Add(clsGlobe.lmaxTem.MaxT_12);
            clsGlobe.lmaxTem.lMaxTem.Add(clsGlobe.lmaxTem.MaxT_13);
            clsGlobe.lmaxTem.lMaxTem.Add(clsGlobe.lmaxTem.MaxT_14);
            clsGlobe.lmaxTem.lMaxTem.Add(clsGlobe.lmaxTem.MaxT_15);
            clsGlobe.lmaxTem.lMaxTem.Add(clsGlobe.lmaxTem.MaxT_16);
            clsGlobe.lmaxTem.lMaxTem.Add(clsGlobe.lmaxTem.MaxT_17);
            clsGlobe.lmaxTem.lMaxTem.Add(clsGlobe.lmaxTem.MaxT_18);
            clsGlobe.lmaxTem.lMaxTem.Add(clsGlobe.lmaxTem.MaxT_19);
            clsGlobe.lmaxTem.lMaxTem.Add(clsGlobe.lmaxTem.MaxT_20);
        }
        public void subReadFile_Max_V(List<List<double>> list)
        {
            for (int i = 0; i <= clsGlobe.fileNum - 1; i++)
            {
                for (int j = 2; j < clsGlobe.Row - 2; j++)
                {
                    if (clsGlobe._sheet._ListWorksheets[i].Cells[j, clsGlobe.max_v_posiotn].value != null)
                    {
                        list[i].Add(clsGlobe._sheet._ListWorksheets[i].Cells[j, clsGlobe.max_v_posiotn].value);
                    }
                    else
                    {
                        break;
                    }
                }
            }
        }
        public void subReadFile_Min_V(List<List<double>> list)
        {
            for (int i = 0; i <= clsGlobe.fileNum - 1; i++)
            {
                for (int j = 2; j < clsGlobe.Row - 2; j++)
                {
                    if (clsGlobe._sheet._ListWorksheets[i].Cells[j, clsGlobe.min_v_posiotn].value != null)
                    {
                        list[i].Add(clsGlobe._sheet._ListWorksheets[i].Cells[j, clsGlobe.min_v_posiotn].value);
                    }
                    else
                    {
                        break;
                    }
                }
            }
        }
        public void subReadFile_Max_T(List<List<double>> list)
        {
            for (int i = 0; i <= clsGlobe.fileNum - 1; i++)
            {
                for (int j = 2; j < clsGlobe.Row - 2; j++)
                {
                    if (clsGlobe._sheet._ListWorksheets[i].Cells[j, clsGlobe.max_t_posiotn].value != null)
                    {
                        list[i].Add(clsGlobe._sheet._ListWorksheets[i].Cells[j, clsGlobe.max_t_posiotn].value);
                    }
                    else
                    {
                        break;
                    }
                }
            }
        }
        public void subRead_SOC(List<double> list)
        {
            for(int i = 2; i <= clsGlobe.Row-2 ; i++)
            {
                if (clsGlobe._sheet._ListWorksheets[0].Cells[i, clsGlobe.SOC_postion].value != null)
                {
                    list.Add(clsGlobe._sheet._ListWorksheets[0].Cells[i, clsGlobe.SOC_postion].value2);
                }
                else
                {
                    break;
                }
            }
        }
        public void subCatch()
        {
            for(int i = 0; i <= clsGlobe.fileNum -1; i++)
            {
                clsGlobe.lmaxVoltage.mMaxVoltage.Add(clsGlobe.lmaxVoltage.lMaxVoltage[i].Max());
                clsGlobe.lminVoltage.mMinVoltage.Add(clsGlobe.lminVoltage.lMinVoltage[i].Min());
                clsGlobe.lmaxTem.mMaxTem.Add(clsGlobe.lmaxTem.lMaxTem[i].Max());
            }
        }
    }
}
public class Books
{
    public List<Workbook> _ListWorkbook = new List<Workbook>(); 
    public Workbook wb1;
    public Workbook wb2;
    public Workbook wb3;
    public Workbook wb4;
    public Workbook wb5;
    public Workbook wb6;
    public Workbook wb7;
    public Workbook wb8;
    public Workbook wb9;
    public Workbook wb10;
    public Workbook wb11;
    public Workbook wb12;
    public Workbook wb13;
    public Workbook wb14;
    public Workbook wb15;
    public Workbook wb16;
    public Workbook wb17;
    public Workbook wb18;
    public Workbook wb19;
    public Workbook wb20;
}
public class Sheet
{
    public List<Worksheet> _ListWorksheets = new List<Worksheet>();
    public Worksheet ws1;
    public Worksheet ws2;
    public Worksheet ws3;
    public Worksheet ws4;
    public Worksheet ws5;
    public Worksheet ws6;
    public Worksheet ws7;
    public Worksheet ws8;
    public Worksheet ws9;
    public Worksheet ws10;
    public Worksheet ws11;
    public Worksheet ws12;
    public Worksheet ws13;
    public Worksheet ws14;
    public Worksheet ws15;
    public Worksheet ws16;
    public Worksheet ws17;
    public Worksheet ws18;
    public Worksheet ws19;
    public Worksheet ws20;
}
public class path
{
    public List<string> _Lpath = new List<string>();
}
public class MaxVoltage
{
    public List<List<double>> lMaxVoltage = new List<List<double>>();
    public List<double> mMaxVoltage = new List<double>();
    public List<double> MaxV_1 = new List<double>();
    public List<double> MaxV_2 = new List<double>();
    public List<double> MaxV_3 = new List<double>();
    public List<double> MaxV_4 = new List<double>();
    public List<double> MaxV_5 = new List<double>();
    public List<double> MaxV_6 = new List<double>();
    public List<double> MaxV_7 = new List<double>();
    public List<double> MaxV_8 = new List<double>();
    public List<double> MaxV_9 = new List<double>();
    public List<double> MaxV_10 = new List<double>();
    public List<double> MaxV_11 = new List<double>();
    public List<double> MaxV_12 = new List<double>();
    public List<double> MaxV_13 = new List<double>();
    public List<double> MaxV_14 = new List<double>();
    public List<double> MaxV_15 = new List<double>();
    public List<double> MaxV_16 = new List<double>();
    public List<double> MaxV_17 = new List<double>();
    public List<double> MaxV_18 = new List<double>();
    public List<double> MaxV_19 = new List<double>();
    public List<double> MaxV_20 = new List<double>();
}

public class MinVoltage
{
    public List<List<double>> lMinVoltage = new List<List<double>>();
    public List<double> mMinVoltage = new List<double>();
    public List<double> MinV_1 = new List<double>();
    public List<double> MinV_2 = new List<double>();
    public List<double> MinV_3 = new List<double>();
    public List<double> MinV_4 = new List<double>();
    public List<double> MinV_5 = new List<double>();
    public List<double> MinV_6 = new List<double>();
    public List<double> MinV_7 = new List<double>();
    public List<double> MinV_8 = new List<double>();
    public List<double> MinV_9 = new List<double>();
    public List<double> MinV_10 = new List<double>();
    public List<double> MinV_11 = new List<double>();
    public List<double> MinV_12 = new List<double>();
    public List<double> MinV_13 = new List<double>();
    public List<double> MinV_14 = new List<double>();
    public List<double> MinV_15 = new List<double>();
    public List<double> MinV_16 = new List<double>();
    public List<double> MinV_17 = new List<double>();
    public List<double> MinV_18 = new List<double>();
    public List<double> MinV_19 = new List<double>();
    public List<double> MinV_20 = new List<double>();
}

public class MaxTem
{
    public List<List<double>> lMaxTem = new List<List<double>>();
    public List<double> mMaxTem = new List<double>();
    public List<double> MaxT_1 = new List<double>();
    public List<double> MaxT_2 = new List<double>();
    public List<double> MaxT_3 = new List<double>();
    public List<double> MaxT_4 = new List<double>();
    public List<double> MaxT_5 = new List<double>();
    public List<double> MaxT_6 = new List<double>();
    public List<double> MaxT_7 = new List<double>();
    public List<double> MaxT_8 = new List<double>();
    public List<double> MaxT_9 = new List<double>();
    public List<double> MaxT_10 = new List<double>();
    public List<double> MaxT_11 = new List<double>();
    public List<double> MaxT_12 = new List<double>();
    public List<double> MaxT_13 = new List<double>();
    public List<double> MaxT_14 = new List<double>();
    public List<double> MaxT_15 = new List<double>();
    public List<double> MaxT_16 = new List<double>();
    public List<double> MaxT_17 = new List<double>();
    public List<double> MaxT_18 = new List<double>();
    public List<double> MaxT_19 = new List<double>();
    public List<double> MaxT_20 = new List<double>();
}
public class SOC
{
    public List<double> lSOC = new List<double>();
}

