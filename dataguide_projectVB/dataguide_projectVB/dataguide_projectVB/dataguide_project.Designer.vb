<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dataguide_project
    Inherits System.Windows.Forms.Form

    'Form은 Dispose를 재정의하여 구성 요소 목록을 정리합니다.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows Form 디자이너에 필요합니다.
    Private components As System.ComponentModel.IContainer

    '참고: 다음 프로시저는 Windows Form 디자이너에 필요합니다.
    '수정하려면 Windows Form 디자이너를 사용하십시오.  
    '코드 편집기를 사용하여 수정하지 마십시오.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.btnUPLD_EXL = New DevExpress.XtraEditors.SimpleButton()
        Me.txtFileName = New DevExpress.XtraEditors.TextEdit()
        Me.btn_Save = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_Clear = New DevExpress.XtraEditors.SimpleButton()
        Me.ListBoxControl1 = New DevExpress.XtraEditors.ListBoxControl()
        Me.txtFileSaveName = New DevExpress.XtraEditors.TextEdit()
        Me.btnEXPT_EXL = New DevExpress.XtraEditors.SimpleButton()
        Me.btnSetting_SAVE = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.txtFileName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ListBoxControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFileSaveName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(12, 14)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(179, 14)
        Me.LabelControl1.TabIndex = 0
        Me.LabelControl1.Text = "데이터가이드 엑셀 데이터 import"
        '
        'btnUPLD_EXL
        '
        Me.btnUPLD_EXL.Location = New System.Drawing.Point(12, 34)
        Me.btnUPLD_EXL.Name = "btnUPLD_EXL"
        Me.btnUPLD_EXL.Size = New System.Drawing.Size(75, 23)
        Me.btnUPLD_EXL.TabIndex = 1
        Me.btnUPLD_EXL.Text = "파일 찾기"
        '
        'txtFileName
        '
        Me.txtFileName.Location = New System.Drawing.Point(92, 36)
        Me.txtFileName.Name = "txtFileName"
        Me.txtFileName.Size = New System.Drawing.Size(361, 20)
        Me.txtFileName.TabIndex = 2
        '
        'btn_Save
        '
        Me.btn_Save.Location = New System.Drawing.Point(107, 92)
        Me.btn_Save.Name = "btn_Save"
        Me.btn_Save.Size = New System.Drawing.Size(240, 60)
        Me.btn_Save.TabIndex = 3
        Me.btn_Save.Text = "프로그램 시작"
        '
        'btn_Clear
        '
        Me.btn_Clear.Location = New System.Drawing.Point(353, 92)
        Me.btn_Clear.Name = "btn_Clear"
        Me.btn_Clear.Size = New System.Drawing.Size(100, 60)
        Me.btn_Clear.TabIndex = 4
        Me.btn_Clear.Text = "Clear"
        '
        'ListBoxControl1
        '
        Me.ListBoxControl1.Location = New System.Drawing.Point(13, 157)
        Me.ListBoxControl1.Name = "ListBoxControl1"
        Me.ListBoxControl1.Size = New System.Drawing.Size(440, 190)
        Me.ListBoxControl1.TabIndex = 6
        '
        'txtFileSaveName
        '
        Me.txtFileSaveName.Location = New System.Drawing.Point(119, 64)
        Me.txtFileSaveName.Name = "txtFileSaveName"
        Me.txtFileSaveName.Size = New System.Drawing.Size(334, 20)
        Me.txtFileSaveName.TabIndex = 7
        '
        'btnEXPT_EXL
        '
        Me.btnEXPT_EXL.Location = New System.Drawing.Point(12, 63)
        Me.btnEXPT_EXL.Name = "btnEXPT_EXL"
        Me.btnEXPT_EXL.Size = New System.Drawing.Size(100, 23)
        Me.btnEXPT_EXL.TabIndex = 8
        Me.btnEXPT_EXL.Text = "파일출력경로"
        '
        'btnSetting_SAVE
        '
        Me.btnSetting_SAVE.Location = New System.Drawing.Point(12, 92)
        Me.btnSetting_SAVE.Name = "btnSetting_SAVE"
        Me.btnSetting_SAVE.Size = New System.Drawing.Size(89, 60)
        Me.btnSetting_SAVE.TabIndex = 9
        Me.btnSetting_SAVE.Text = "설정저장"
        '
        'dataguide_project
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(464, 352)
        Me.Controls.Add(Me.btnSetting_SAVE)
        Me.Controls.Add(Me.btnEXPT_EXL)
        Me.Controls.Add(Me.txtFileSaveName)
        Me.Controls.Add(Me.ListBoxControl1)
        Me.Controls.Add(Me.btn_Clear)
        Me.Controls.Add(Me.btn_Save)
        Me.Controls.Add(Me.txtFileName)
        Me.Controls.Add(Me.btnUPLD_EXL)
        Me.Controls.Add(Me.LabelControl1)
        Me.Name = "dataguide_project"
        Me.Text = "Dataguide_Import"
        CType(Me.txtFileName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ListBoxControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFileSaveName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btnUPLD_EXL As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtFileName As DevExpress.XtraEditors.TextEdit
    Friend WithEvents btn_Save As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_Clear As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents ListBoxControl1 As DevExpress.XtraEditors.ListBoxControl
    Friend WithEvents txtFileSaveName As DevExpress.XtraEditors.TextEdit
    Friend WithEvents btnEXPT_EXL As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnSetting_SAVE As DevExpress.XtraEditors.SimpleButton

End Class
