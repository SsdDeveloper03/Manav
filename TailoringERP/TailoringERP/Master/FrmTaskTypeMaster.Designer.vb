<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmTaskTypeMaster
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.gcData = New DevExpress.XtraGrid.GridControl()
        Me.gvData = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.gbTask = New System.Windows.Forms.GroupBox()
        Me.ColorPickEdit1 = New DevExpress.XtraEditors.ColorPickEdit()
        Me.txtTaskType = New System.Windows.Forms.TextBox()
        Me.txtTaskDetail = New System.Windows.Forms.TextBox()
        Me.lblTaskDetail = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblTaskType = New System.Windows.Forms.Label()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.txt_TaskType = New System.Windows.Forms.TextBox()
        Me.lblF_LedgerName = New System.Windows.Forms.Label()
        CType(Me.gcData, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbTask.SuspendLayout()
        CType(Me.ColorPickEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gcData
        '
        Me.gcData.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gcData.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.gcData.Location = New System.Drawing.Point(11, 228)
        Me.gcData.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.gcData.LookAndFeel.UseDefaultLookAndFeel = False
        Me.gcData.MainView = Me.gvData
        Me.gcData.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.gcData.Name = "gcData"
        Me.gcData.Size = New System.Drawing.Size(1201, 383)
        Me.gcData.TabIndex = 9
        Me.gcData.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvData})
        '
        'gvData
        '
        Me.gvData.Appearance.FooterPanel.Font = New System.Drawing.Font("Calibri", 11.25!)
        Me.gvData.Appearance.FooterPanel.Options.UseFont = True
        Me.gvData.Appearance.HeaderPanel.Font = New System.Drawing.Font("Calibri", 11.25!)
        Me.gvData.Appearance.HeaderPanel.Options.UseFont = True
        Me.gvData.Appearance.Row.Font = New System.Drawing.Font("Calibri", 11.25!)
        Me.gvData.Appearance.Row.Options.UseFont = True
        Me.gvData.GridControl = Me.gcData
        Me.gvData.Name = "gvData"
        Me.gvData.OptionsBehavior.Editable = False
        Me.gvData.OptionsBehavior.ReadOnly = True
        Me.gvData.OptionsLayout.Columns.StoreAllOptions = True
        Me.gvData.OptionsView.ShowAutoFilterRow = True
        Me.gvData.OptionsView.ShowFooter = True
        Me.gvData.OptionsView.ShowGroupPanel = False
        '
        'btnExit
        '
        Me.btnExit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnExit.BackColor = System.Drawing.SystemColors.Control
        Me.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(480, 625)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(88, 36)
        Me.btnExit.TabIndex = 5
        Me.btnExit.Text = "Cl&ose"
        Me.btnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnCancel.BackColor = System.Drawing.SystemColors.Control
        Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnCancel.Location = New System.Drawing.Point(379, 625)
        Me.btnCancel.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(99, 36)
        Me.btnCancel.TabIndex = 4
        Me.btnCancel.Text = "&Cancel"
        Me.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'btnDelete
        '
        Me.btnDelete.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnDelete.BackColor = System.Drawing.SystemColors.Control
        Me.btnDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.ForeColor = System.Drawing.Color.Red
        Me.btnDelete.Location = New System.Drawing.Point(280, 625)
        Me.btnDelete.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(96, 36)
        Me.btnDelete.TabIndex = 3
        Me.btnDelete.Text = "&Delete"
        Me.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'btnSave
        '
        Me.btnSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnSave.BackColor = System.Drawing.SystemColors.Control
        Me.btnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.Color.DarkGreen
        Me.btnSave.Location = New System.Drawing.Point(192, 625)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(85, 36)
        Me.btnSave.TabIndex = 2
        Me.btnSave.Text = "&Save"
        Me.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'btnEdit
        '
        Me.btnEdit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnEdit.BackColor = System.Drawing.SystemColors.Control
        Me.btnEdit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEdit.ForeColor = System.Drawing.Color.Maroon
        Me.btnEdit.Location = New System.Drawing.Point(93, 625)
        Me.btnEdit.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(96, 36)
        Me.btnEdit.TabIndex = 1
        Me.btnEdit.Text = "&Modify"
        Me.btnEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnEdit.UseVisualStyleBackColor = False
        '
        'btnAdd
        '
        Me.btnAdd.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnAdd.BackColor = System.Drawing.SystemColors.Control
        Me.btnAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.ForeColor = System.Drawing.Color.Blue
        Me.btnAdd.Location = New System.Drawing.Point(11, 625)
        Me.btnAdd.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(80, 36)
        Me.btnAdd.TabIndex = 0
        Me.btnAdd.Text = "&New"
        Me.btnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'gbTask
        '
        Me.gbTask.Controls.Add(Me.ColorPickEdit1)
        Me.gbTask.Controls.Add(Me.txtTaskType)
        Me.gbTask.Controls.Add(Me.txtTaskDetail)
        Me.gbTask.Controls.Add(Me.lblTaskDetail)
        Me.gbTask.Controls.Add(Me.Label2)
        Me.gbTask.Controls.Add(Me.lblTaskType)
        Me.gbTask.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbTask.Location = New System.Drawing.Point(11, 6)
        Me.gbTask.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.gbTask.Name = "gbTask"
        Me.gbTask.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.gbTask.Size = New System.Drawing.Size(1201, 214)
        Me.gbTask.TabIndex = 275
        Me.gbTask.TabStop = False
        Me.gbTask.Text = "Task Entry"
        '
        'ColorPickEdit1
        '
        Me.ColorPickEdit1.EditValue = System.Drawing.Color.Empty
        Me.ColorPickEdit1.Location = New System.Drawing.Point(153, 171)
        Me.ColorPickEdit1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ColorPickEdit1.Name = "ColorPickEdit1"
        Me.ColorPickEdit1.Properties.AutomaticColor = System.Drawing.Color.Black
        Me.ColorPickEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ColorPickEdit1.Size = New System.Drawing.Size(212, 22)
        Me.ColorPickEdit1.TabIndex = 2
        '
        'txtTaskType
        '
        Me.txtTaskType.Location = New System.Drawing.Point(153, 37)
        Me.txtTaskType.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtTaskType.Name = "txtTaskType"
        Me.txtTaskType.Size = New System.Drawing.Size(211, 30)
        Me.txtTaskType.TabIndex = 0
        '
        'txtTaskDetail
        '
        Me.txtTaskDetail.Location = New System.Drawing.Point(153, 84)
        Me.txtTaskDetail.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtTaskDetail.Multiline = True
        Me.txtTaskDetail.Name = "txtTaskDetail"
        Me.txtTaskDetail.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtTaskDetail.Size = New System.Drawing.Size(309, 67)
        Me.txtTaskDetail.TabIndex = 1
        '
        'lblTaskDetail
        '
        Me.lblTaskDetail.AutoSize = True
        Me.lblTaskDetail.Location = New System.Drawing.Point(24, 105)
        Me.lblTaskDetail.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTaskDetail.Name = "lblTaskDetail"
        Me.lblTaskDetail.Size = New System.Drawing.Size(92, 23)
        Me.lblTaskDetail.TabIndex = 286
        Me.lblTaskDetail.Text = "Task Detail"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(27, 172)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 23)
        Me.Label2.TabIndex = 285
        Me.Label2.Text = "Select Color"
        '
        'lblTaskType
        '
        Me.lblTaskType.AutoSize = True
        Me.lblTaskType.Location = New System.Drawing.Point(27, 41)
        Me.lblTaskType.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTaskType.Name = "lblTaskType"
        Me.lblTaskType.Size = New System.Drawing.Size(84, 23)
        Me.lblTaskType.TabIndex = 282
        Me.lblTaskType.Text = "Task Type"
        '
        'btnRefresh
        '
        Me.btnRefresh.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnRefresh.BackColor = System.Drawing.SystemColors.Control
        Me.btnRefresh.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRefresh.Location = New System.Drawing.Point(1107, 625)
        Me.btnRefresh.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(105, 36)
        Me.btnRefresh.TabIndex = 7
        Me.btnRefresh.Text = "Re&fresh"
        Me.btnRefresh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnRefresh.UseVisualStyleBackColor = False
        '
        'txt_TaskType
        '
        Me.txt_TaskType.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txt_TaskType.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_TaskType.Location = New System.Drawing.Point(716, 629)
        Me.txt_TaskType.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txt_TaskType.MaxLength = 50
        Me.txt_TaskType.Name = "txt_TaskType"
        Me.txt_TaskType.Size = New System.Drawing.Size(180, 30)
        Me.txt_TaskType.TabIndex = 6
        '
        'lblF_LedgerName
        '
        Me.lblF_LedgerName.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblF_LedgerName.AutoSize = True
        Me.lblF_LedgerName.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblF_LedgerName.ForeColor = System.Drawing.Color.Black
        Me.lblF_LedgerName.Location = New System.Drawing.Point(608, 634)
        Me.lblF_LedgerName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblF_LedgerName.Name = "lblF_LedgerName"
        Me.lblF_LedgerName.Size = New System.Drawing.Size(84, 23)
        Me.lblF_LedgerName.TabIndex = 278
        Me.lblF_LedgerName.Text = "Task Type"
        '
        'FrmTaskTypeMaster
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1223, 676)
        Me.Controls.Add(Me.txt_TaskType)
        Me.Controls.Add(Me.lblF_LedgerName)
        Me.Controls.Add(Me.btnRefresh)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.gcData)
        Me.Controls.Add(Me.gbTask)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "FrmTaskTypeMaster"
        Me.Text = "Task Master"
        CType(Me.gcData, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbTask.ResumeLayout(False)
        Me.gbTask.PerformLayout()
        CType(Me.ColorPickEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents gcData As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvData As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents btnExit As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents btnEdit As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents gbTask As GroupBox
    Friend WithEvents txtTaskDetail As TextBox
    Friend WithEvents lblTaskDetail As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblTaskType As Label
    Friend WithEvents btnRefresh As Button
    Friend WithEvents txt_TaskType As TextBox
    Friend WithEvents lblF_LedgerName As Label
    Friend WithEvents ColorPickEdit1 As DevExpress.XtraEditors.ColorPickEdit
    Friend WithEvents txtTaskType As TextBox
End Class
