Imports System
Imports System.IO
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms
Imports System.Runtime.InteropServices
Imports DevExpress.XtraEditors.Controls
Imports Excel = Microsoft.Office.Interop.Excel
Imports SHDocVw
Imports mshtml
Imports System.Diagnostics

Public Class dataguide_project
    Private Sub initForm()
        Dim res As Integer
        Dim sb As String
        Dim intSize As Integer
        sb = Space(1024)
        intSize = 1024

        res = GetPrivateProfileString("APP_PATH", "Path1", "", sb, intSize, ".\temp.ini")
        txtFileName.Text = sb.ToString
        res = GetPrivateProfileString("APP_PATH", "Path2", "", sb, intSize, ".\temp.ini")
        txtFileSaveName.Text = sb.ToString
    End Sub

    Private sw As Stopwatch = New Stopwatch()

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        initForm()
    End Sub

    Private Sub ListBoxControl1_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles ListBoxControl1.SelectedIndexChanged

    End Sub

    Private Sub btn_Save_Click(sender As System.Object, e As System.EventArgs) Handles btn_Save.Click

        If String.IsNullOrEmpty(txtFileSaveName.Text) Or String.IsNullOrEmpty(txtFileName.Text) Then
            MsgBox("파일찾기나 파일출력 경로를 넣어주세요")
            Exit Sub
        End If

        ListBoxControl1.Items.Add("데이터가이드 실행파일을 여는 중입니다.")
        Dim excelApp As Excel.Application = Nothing
        Dim wb As Excel.Workbook = Nothing

        Try
            excelApp = New Excel.Application()
            sw.Start()
            ListBoxControl1.Items.Add(DateTime.Now.ToString("yyyy-MM-dd") & " 엑셀파일을 여는 중입니다.")
            wb = excelApp.Workbooks.Open(txtFileName.Text)
            excelApp.Application.Run("DateChange")

            wb.SaveAs(txtFileName.Text & DateTime.Now.ToString("yyyyMMddHHmmss") & "_데이터가이드.xlsm")
            wb.Close(True)
            excelApp.Quit()
        Catch ex As Exception
            Throw ex
        Finally
            ReleaseExcelObject(wb)
            ReleaseExcelObject(excelApp)
            ListBoxControl1.Items.Add("데이터가이드 정보 저장완료 했습니다.")
            sw.[Stop]()
            ListBoxControl1.Items.Add((sw.ElapsedMilliseconds / 1000).ToString() & "초 걸렸습니다")
            sw.Reset()
        End Try
    End Sub

    Private Shared Sub ReleaseExcelObject(ByVal obj As Object)
        Try

            If obj IsNot Nothing Then
                Marshal.ReleaseComObject(obj)
                obj = Nothing
            End If

        Catch ex As Exception
            obj = Nothing
            Throw ex
        Finally
            GC.Collect()
        End Try
    End Sub

    Private Sub btn_Clear_Click(sender As System.Object, e As System.EventArgs) Handles btn_Clear.Click
        ListBoxControl1.Items.Clear()
    End Sub

    ''' <summary>
    ''' 매크로를 돌릴 엑셀파일 경로 선택
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnUPLD_EXL_Click(sender As System.Object, e As System.EventArgs) Handles btnUPLD_EXL.Click
        Dim pFileDlg As OpenFileDialog = New OpenFileDialog()
        pFileDlg.Filter = "excel files(*.xlsm)|*.xlsm|엑셀파일(*.xlsx)|*.xlsx|All Files(*.*)|*.*"
        pFileDlg.Title = "데이터가이드 엑셀파일을 선택해 주세요."

        If pFileDlg.ShowDialog() = DialogResult.OK Then
            txtFileName.Text = pFileDlg.FileName
        End If
    End Sub

    ''' <summary>
    ''' 데이터가이드 실행후 새로 저장할 엑셀파일 저장할 폴더경로 선택
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnEXPT_EXL_Click(sender As System.Object, e As System.EventArgs) Handles btnEXPT_EXL.Click

        Dim dlg As FolderBrowserDialog = New FolderBrowserDialog()

        If (dlg.ShowDialog() = DialogResult.OK) Then
            txtFileSaveName.Text = dlg.SelectedPath
        End If
    End Sub

    Private Sub btnSetting_SAVE_Click(sender As System.Object, e As System.EventArgs) Handles btnSetting_SAVE.Click
        Dim strFile As String

        strFile = ".\temp.ini"
        WritePrivateProfileString("APP_PATH", "Path1", txtFileName.Text, strFile)
        WritePrivateProfileString("APP_PATH", "Path2", txtFileSaveName.Text, strFile)
        MsgBox("경로 설정되었습니다.")
        initForm()

    End Sub

    Public Declare Function WritePrivateProfileString Lib "kernel32" _
    Alias "WritePrivateProfileStringA" _
    (ByVal lpApplicationName As String, _
    ByVal lpKeyName As String, _
    ByVal lpString As String, _
    ByVal lpFileName As String) As Long

    Private Declare Auto Function GetPrivateProfileString Lib "kernel32" (ByVal lpAppName As String, _
    ByVal lpKeyName As String, _
    ByVal lpDefault As String, _
    ByVal lpReturnedString As String, _
    ByVal nSize As Integer, _
    ByVal lpFileName As String) As Integer

End Class
