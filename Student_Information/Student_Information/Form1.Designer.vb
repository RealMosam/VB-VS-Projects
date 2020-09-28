<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim SrNoLabel As System.Windows.Forms.Label
        Dim IDLabel As System.Windows.Forms.Label
        Dim NameLabel As System.Windows.Forms.Label
        Dim DepartmentLabel As System.Windows.Forms.Label
        Dim YearLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.StudentDataDataSet = New WindowsApplication1.StudentDataDataSet()
        Me.StudentTableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.StudentTableTableAdapter = New WindowsApplication1.StudentDataDataSetTableAdapters.StudentTableTableAdapter()
        Me.TableAdapterManager = New WindowsApplication1.StudentDataDataSetTableAdapters.TableAdapterManager()
        Me.StudentTableBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.StudentTableBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.SrNoTextBox = New System.Windows.Forms.TextBox()
        Me.IDTextBox = New System.Windows.Forms.TextBox()
        Me.NameTextBox = New System.Windows.Forms.TextBox()
        Me.DepartmentTextBox = New System.Windows.Forms.TextBox()
        Me.YearTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PreBnt = New System.Windows.Forms.Button()
        Me.SaveBnt = New System.Windows.Forms.Button()
        Me.DeleteBnt = New System.Windows.Forms.Button()
        Me.AddBnt = New System.Windows.Forms.Button()
        Me.NextBnt = New System.Windows.Forms.Button()
        Me.EditBnt = New System.Windows.Forms.Button()
        SrNoLabel = New System.Windows.Forms.Label()
        IDLabel = New System.Windows.Forms.Label()
        NameLabel = New System.Windows.Forms.Label()
        DepartmentLabel = New System.Windows.Forms.Label()
        YearLabel = New System.Windows.Forms.Label()
        CType(Me.StudentDataDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StudentTableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StudentTableBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StudentTableBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'SrNoLabel
        '
        SrNoLabel.AutoSize = True
        SrNoLabel.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        SrNoLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        SrNoLabel.Location = New System.Drawing.Point(238, 114)
        SrNoLabel.Name = "SrNoLabel"
        SrNoLabel.Size = New System.Drawing.Size(65, 23)
        SrNoLabel.TabIndex = 1
        SrNoLabel.Text = "Sr No:"
        '
        'IDLabel
        '
        IDLabel.AutoSize = True
        IDLabel.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        IDLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        IDLabel.Location = New System.Drawing.Point(238, 161)
        IDLabel.Name = "IDLabel"
        IDLabel.Size = New System.Drawing.Size(38, 23)
        IDLabel.TabIndex = 3
        IDLabel.Text = "ID:"
        '
        'NameLabel
        '
        NameLabel.AutoSize = True
        NameLabel.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        NameLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        NameLabel.Location = New System.Drawing.Point(238, 208)
        NameLabel.Name = "NameLabel"
        NameLabel.Size = New System.Drawing.Size(66, 23)
        NameLabel.TabIndex = 5
        NameLabel.Text = "Name:"
        '
        'DepartmentLabel
        '
        DepartmentLabel.AutoSize = True
        DepartmentLabel.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DepartmentLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        DepartmentLabel.Location = New System.Drawing.Point(238, 255)
        DepartmentLabel.Name = "DepartmentLabel"
        DepartmentLabel.Size = New System.Drawing.Size(118, 23)
        DepartmentLabel.TabIndex = 7
        DepartmentLabel.Text = "Department:"
        AddHandler DepartmentLabel.Click, AddressOf Me.DepartmentLabel_Click
        '
        'YearLabel
        '
        YearLabel.AutoSize = True
        YearLabel.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        YearLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        YearLabel.Location = New System.Drawing.Point(238, 302)
        YearLabel.Name = "YearLabel"
        YearLabel.Size = New System.Drawing.Size(56, 23)
        YearLabel.TabIndex = 9
        YearLabel.Text = "Year:"
        '
        'StudentDataDataSet
        '
        Me.StudentDataDataSet.DataSetName = "StudentDataDataSet"
        Me.StudentDataDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'StudentTableBindingSource
        '
        Me.StudentTableBindingSource.DataMember = "StudentTable"
        Me.StudentTableBindingSource.DataSource = Me.StudentDataDataSet
        '
        'StudentTableTableAdapter
        '
        Me.StudentTableTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.StudentTableTableAdapter = Me.StudentTableTableAdapter
        Me.TableAdapterManager.UpdateOrder = WindowsApplication1.StudentDataDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'StudentTableBindingNavigator
        '
        Me.StudentTableBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.StudentTableBindingNavigator.BindingSource = Me.StudentTableBindingSource
        Me.StudentTableBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.StudentTableBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.StudentTableBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.StudentTableBindingNavigatorSaveItem})
        Me.StudentTableBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.StudentTableBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.StudentTableBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.StudentTableBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.StudentTableBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.StudentTableBindingNavigator.Name = "StudentTableBindingNavigator"
        Me.StudentTableBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.StudentTableBindingNavigator.Size = New System.Drawing.Size(834, 27)
        Me.StudentTableBindingNavigator.TabIndex = 0
        Me.StudentTableBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 24)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(45, 24)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 24)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 24)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 24)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 27)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 27)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 27)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 24)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 24)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 27)
        '
        'StudentTableBindingNavigatorSaveItem
        '
        Me.StudentTableBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.StudentTableBindingNavigatorSaveItem.Image = CType(resources.GetObject("StudentTableBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.StudentTableBindingNavigatorSaveItem.Name = "StudentTableBindingNavigatorSaveItem"
        Me.StudentTableBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 24)
        Me.StudentTableBindingNavigatorSaveItem.Text = "Save Data"
        '
        'SrNoTextBox
        '
        Me.SrNoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StudentTableBindingSource, "SrNo", True))
        Me.SrNoTextBox.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SrNoTextBox.Location = New System.Drawing.Point(381, 112)
        Me.SrNoTextBox.Name = "SrNoTextBox"
        Me.SrNoTextBox.Size = New System.Drawing.Size(179, 27)
        Me.SrNoTextBox.TabIndex = 2
        '
        'IDTextBox
        '
        Me.IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StudentTableBindingSource, "ID", True))
        Me.IDTextBox.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IDTextBox.Location = New System.Drawing.Point(381, 160)
        Me.IDTextBox.Name = "IDTextBox"
        Me.IDTextBox.Size = New System.Drawing.Size(179, 27)
        Me.IDTextBox.TabIndex = 4
        '
        'NameTextBox
        '
        Me.NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StudentTableBindingSource, "Name", True))
        Me.NameTextBox.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NameTextBox.Location = New System.Drawing.Point(381, 208)
        Me.NameTextBox.Name = "NameTextBox"
        Me.NameTextBox.Size = New System.Drawing.Size(179, 27)
        Me.NameTextBox.TabIndex = 6
        '
        'DepartmentTextBox
        '
        Me.DepartmentTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StudentTableBindingSource, "Department", True))
        Me.DepartmentTextBox.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DepartmentTextBox.Location = New System.Drawing.Point(381, 256)
        Me.DepartmentTextBox.Name = "DepartmentTextBox"
        Me.DepartmentTextBox.Size = New System.Drawing.Size(179, 27)
        Me.DepartmentTextBox.TabIndex = 8
        '
        'YearTextBox
        '
        Me.YearTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StudentTableBindingSource, "Year", True))
        Me.YearTextBox.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.YearTextBox.Location = New System.Drawing.Point(381, 304)
        Me.YearTextBox.Name = "YearTextBox"
        Me.YearTextBox.Size = New System.Drawing.Size(179, 27)
        Me.YearTextBox.TabIndex = 10
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 24.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label1.Location = New System.Drawing.Point(223, 49)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(366, 45)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Student Information"
        '
        'PreBnt
        '
        Me.PreBnt.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.PreBnt.Font = New System.Drawing.Font("Times New Roman", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PreBnt.ForeColor = System.Drawing.SystemColors.ControlText
        Me.PreBnt.Location = New System.Drawing.Point(94, 371)
        Me.PreBnt.Name = "PreBnt"
        Me.PreBnt.Size = New System.Drawing.Size(75, 36)
        Me.PreBnt.TabIndex = 12
        Me.PreBnt.Text = "<<<"
        Me.PreBnt.UseVisualStyleBackColor = False
        '
        'SaveBnt
        '
        Me.SaveBnt.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.SaveBnt.Font = New System.Drawing.Font("Times New Roman", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SaveBnt.ForeColor = System.Drawing.SystemColors.ControlText
        Me.SaveBnt.Location = New System.Drawing.Point(198, 371)
        Me.SaveBnt.Name = "SaveBnt"
        Me.SaveBnt.Size = New System.Drawing.Size(92, 36)
        Me.SaveBnt.TabIndex = 12
        Me.SaveBnt.Text = "Save Data"
        Me.SaveBnt.UseVisualStyleBackColor = False
        '
        'DeleteBnt
        '
        Me.DeleteBnt.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DeleteBnt.Font = New System.Drawing.Font("Times New Roman", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DeleteBnt.ForeColor = System.Drawing.SystemColors.ControlText
        Me.DeleteBnt.Location = New System.Drawing.Point(319, 371)
        Me.DeleteBnt.Name = "DeleteBnt"
        Me.DeleteBnt.Size = New System.Drawing.Size(75, 36)
        Me.DeleteBnt.TabIndex = 12
        Me.DeleteBnt.Text = "Delete"
        Me.DeleteBnt.UseVisualStyleBackColor = False
        '
        'AddBnt
        '
        Me.AddBnt.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.AddBnt.Font = New System.Drawing.Font("Times New Roman", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddBnt.ForeColor = System.Drawing.SystemColors.ControlText
        Me.AddBnt.Location = New System.Drawing.Point(423, 371)
        Me.AddBnt.Name = "AddBnt"
        Me.AddBnt.Size = New System.Drawing.Size(75, 36)
        Me.AddBnt.TabIndex = 12
        Me.AddBnt.Text = "Add"
        Me.AddBnt.UseVisualStyleBackColor = False
        '
        'NextBnt
        '
        Me.NextBnt.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.NextBnt.Font = New System.Drawing.Font("Times New Roman", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NextBnt.ForeColor = System.Drawing.SystemColors.ControlText
        Me.NextBnt.Location = New System.Drawing.Point(631, 371)
        Me.NextBnt.Name = "NextBnt"
        Me.NextBnt.Size = New System.Drawing.Size(75, 36)
        Me.NextBnt.TabIndex = 12
        Me.NextBnt.Text = ">>>"
        Me.NextBnt.UseVisualStyleBackColor = False
        '
        'EditBnt
        '
        Me.EditBnt.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.EditBnt.Font = New System.Drawing.Font("Times New Roman", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EditBnt.ForeColor = System.Drawing.SystemColors.ControlText
        Me.EditBnt.Location = New System.Drawing.Point(527, 371)
        Me.EditBnt.Name = "EditBnt"
        Me.EditBnt.Size = New System.Drawing.Size(75, 36)
        Me.EditBnt.TabIndex = 12
        Me.EditBnt.Text = "Edit"
        Me.EditBnt.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(834, 527)
        Me.Controls.Add(Me.NextBnt)
        Me.Controls.Add(Me.EditBnt)
        Me.Controls.Add(Me.AddBnt)
        Me.Controls.Add(Me.DeleteBnt)
        Me.Controls.Add(Me.SaveBnt)
        Me.Controls.Add(Me.PreBnt)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(YearLabel)
        Me.Controls.Add(Me.YearTextBox)
        Me.Controls.Add(DepartmentLabel)
        Me.Controls.Add(Me.DepartmentTextBox)
        Me.Controls.Add(NameLabel)
        Me.Controls.Add(Me.NameTextBox)
        Me.Controls.Add(IDLabel)
        Me.Controls.Add(Me.IDTextBox)
        Me.Controls.Add(SrNoLabel)
        Me.Controls.Add(Me.SrNoTextBox)
        Me.Controls.Add(Me.StudentTableBindingNavigator)
        Me.ForeColor = System.Drawing.SystemColors.Window
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "Form1"
        Me.Text = "Student Information"
        CType(Me.StudentDataDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StudentTableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StudentTableBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StudentTableBindingNavigator.ResumeLayout(False)
        Me.StudentTableBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents StudentDataDataSet As WindowsApplication1.StudentDataDataSet
    Friend WithEvents StudentTableBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents StudentTableTableAdapter As WindowsApplication1.StudentDataDataSetTableAdapters.StudentTableTableAdapter
    Friend WithEvents TableAdapterManager As WindowsApplication1.StudentDataDataSetTableAdapters.TableAdapterManager
    Friend WithEvents StudentTableBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents StudentTableBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents SrNoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents IDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DepartmentTextBox As System.Windows.Forms.TextBox
    Friend WithEvents YearTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PreBnt As System.Windows.Forms.Button
    Friend WithEvents SaveBnt As System.Windows.Forms.Button
    Friend WithEvents DeleteBnt As System.Windows.Forms.Button
    Friend WithEvents AddBnt As System.Windows.Forms.Button
    Friend WithEvents NextBnt As System.Windows.Forms.Button
    Friend WithEvents EditBnt As System.Windows.Forms.Button

End Class
