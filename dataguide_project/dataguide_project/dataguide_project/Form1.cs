using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using DevExpress.XtraEditors.Controls;
using Excel = Microsoft.Office.Interop.Excel;
using SHDocVw;
using mshtml;
using System.Diagnostics;



namespace dataguide_project
{
    public partial class Form1 : Form
    {
        Stopwatch sw = new Stopwatch();
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }


        private void btn_Save_Click_1(object sender, EventArgs e)
        {
            //Process.Start(@"C:\\Program Files\\FnGuide\DataGuide\\FnDGLoader.exe");
            listBoxControl1.Items.Add("데이터가이드 실행파일을 여는 중입니다.");
            
            progressBarControl1.Properties.Step = 5;
            progressBarControl1.Properties.PercentView = true;
            progressBarControl1.Properties.Minimum = 10;
            progressBarControl1.Properties.Maximum = 100;
           
                

            Excel.Application excelApp = null;
            Excel.Workbook wb = null;

            try
            {
                excelApp = new Excel.Application();  
                sw.Start();

                listBoxControl1.Items.Add(DateTime.Now.ToString("yyyy-MM-dd")+ " 엑셀파일을 여는 중입니다.");
                wb = excelApp.Workbooks.Open(txtFileName.Text);

                excelApp.Application.Run("DateChange");
                while (progressBarControl1.Position < progressBarControl1.Properties.Maximum)
                {
                    progressBarControl1.PerformStep();
                    progressBarControl1.Update();
                }

                wb.SaveCopyAs(@"\\10.0.1.48\자료실\기업가치평가실_평가거시지표\DG\" + DateTime.Now.ToString("yyyyMMddhhMMss") + "_데이터가이드.xlsm");
                wb.Close(true);
                excelApp.Quit();
                
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                ReleaseExcelObject(wb);
                ReleaseExcelObject(excelApp);
                listBoxControl1.Items.Add("데이터가이드 정보 저장완료 했습니다.");
                sw.Stop();
                listBoxControl1.Items.Add((sw.ElapsedMilliseconds / 1000).ToString() + "초 걸렸습니다");
                sw.Reset();

            }
        }

        static void ReleaseExcelObject(object obj)
        {
            try
            {
                if (obj != null)
                {
                    Marshal.ReleaseComObject(obj);
                    obj = null;
                }
            }
            catch (Exception ex)
            {
                obj = null;
                throw ex;
            }
            finally
            {
                GC.Collect();
            }
        }

        private void progressBarControl1_EditValueChanged(object sender, EventArgs e)
        {
           

        }

        private void btnUPLD_EXL_Click(object sender, EventArgs e)
        {
            OpenFileDialog pFileDlg = new OpenFileDialog();
            pFileDlg.Filter = "excel files(*.xlsm)|*.xlsm|엑셀파일(*.xlsx)|*.xlsx|All Files(*.*)|*.*";
            pFileDlg.Title = "데이터가이드 엑셀파일을 선택해 주세요.";
            if (pFileDlg.ShowDialog() == DialogResult.OK)
            {
                 txtFileName.Text = pFileDlg.FileName;

            }
        }

        private void txtFileName_EditValueChanged(object sender, EventArgs e)
        {
            
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
                progressBarControl1.EditValue = 0;
                listBoxControl1.Items.Clear();
        }

    }
}
