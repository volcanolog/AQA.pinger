<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Форма переопределяет dispose для очистки списка компонентов.
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

    'Является обязательной для конструктора форм Windows Forms
    Private components As System.ComponentModel.IContainer

    'Примечание: следующая процедура является обязательной для конструктора форм Windows Forms
    'Для ее изменения используйте конструктор форм Windows Form.  
    'Не изменяйте ее в редакторе исходного кода.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.ds = New System.Data.DataSet()
        Me.topics = New System.Data.DataTable()
        Me.colId = New System.Data.DataColumn()
        Me.DataColumn2 = New System.Data.DataColumn()
        Me.DataColumn3 = New System.Data.DataColumn()
        Me.DataColumn4 = New System.Data.DataColumn()
        Me.DataColumn5 = New System.Data.DataColumn()
        Me.DataColumn6 = New System.Data.DataColumn()
        Me.dg = New System.Windows.Forms.DataGridView()
        Me.IdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.forum = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SubjectDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewLinkColumn()
        Me.replies = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TdateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.author = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.llSite = New System.Windows.Forms.LinkLabel()
        Me.llTopic = New System.Windows.Forms.LinkLabel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbTimer = New System.Windows.Forms.ComboBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.t = New System.Windows.Forms.Timer(Me.components)
        Me.lbSize = New System.Windows.Forms.Label()
        CType(Me.ds, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.topics, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'ds
        '
        Me.ds.DataSetName = "NewDataSet"
        Me.ds.Tables.AddRange(New System.Data.DataTable() {Me.topics})
        '
        'topics
        '
        Me.topics.Columns.AddRange(New System.Data.DataColumn() {Me.colId, Me.DataColumn2, Me.DataColumn3, Me.DataColumn4, Me.DataColumn5, Me.DataColumn6})
        Me.topics.Constraints.AddRange(New System.Data.Constraint() {New System.Data.UniqueConstraint("Constraint1", New String() {"id"}, True)})
        Me.topics.PrimaryKey = New System.Data.DataColumn() {Me.colId}
        Me.topics.TableName = "tb"
        '
        'colId
        '
        Me.colId.AllowDBNull = False
        Me.colId.ColumnName = "id"
        Me.colId.DataType = GetType(Integer)
        '
        'DataColumn2
        '
        Me.DataColumn2.ColumnName = "subject"
        '
        'DataColumn3
        '
        Me.DataColumn3.Caption = "Date"
        Me.DataColumn3.ColumnName = "tdate"
        '
        'DataColumn4
        '
        Me.DataColumn4.Caption = "Форум"
        Me.DataColumn4.ColumnName = "forum"
        '
        'DataColumn5
        '
        Me.DataColumn5.Caption = "Последний автор"
        Me.DataColumn5.ColumnName = "author"
        '
        'DataColumn6
        '
        Me.DataColumn6.ColumnName = "replies"
        Me.DataColumn6.DataType = GetType(Short)
        '
        'dg
        '
        Me.dg.AllowUserToAddRows = False
        Me.dg.AllowUserToDeleteRows = False
        Me.dg.AllowUserToOrderColumns = True
        Me.dg.AllowUserToResizeRows = False
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dg.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dg.AutoGenerateColumns = False
        Me.dg.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dg.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        Me.dg.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dg.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdDataGridViewTextBoxColumn, Me.forum, Me.SubjectDataGridViewTextBoxColumn, Me.replies, Me.TdateDataGridViewTextBoxColumn, Me.author})
        Me.dg.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dg.DataMember = "tb"
        Me.dg.DataSource = Me.ds
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dg.DefaultCellStyle = DataGridViewCellStyle4
        Me.dg.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dg.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.dg.Location = New System.Drawing.Point(0, 0)
        Me.dg.MultiSelect = False
        Me.dg.Name = "dg"
        Me.dg.ReadOnly = True
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        Me.dg.RowHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.dg.RowHeadersVisible = False
        Me.dg.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.dg.RowsDefaultCellStyle = DataGridViewCellStyle6
        Me.dg.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.SystemColors.Control
        Me.dg.RowTemplate.DefaultCellStyle.NullValue = Nothing
        Me.dg.RowTemplate.DefaultCellStyle.Padding = New System.Windows.Forms.Padding(2)
        Me.dg.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dg.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dg.Size = New System.Drawing.Size(805, 431)
        Me.dg.TabIndex = 3
        '
        'IdDataGridViewTextBoxColumn
        '
        Me.IdDataGridViewTextBoxColumn.DataPropertyName = "id"
        Me.IdDataGridViewTextBoxColumn.HeaderText = "id"
        Me.IdDataGridViewTextBoxColumn.Name = "IdDataGridViewTextBoxColumn"
        Me.IdDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdDataGridViewTextBoxColumn.Visible = False
        '
        'forum
        '
        Me.forum.DataPropertyName = "forum"
        Me.forum.HeaderText = "Форум"
        Me.forum.Name = "forum"
        Me.forum.ReadOnly = True
        '
        'SubjectDataGridViewTextBoxColumn
        '
        Me.SubjectDataGridViewTextBoxColumn.DataPropertyName = "subject"
        Me.SubjectDataGridViewTextBoxColumn.FillWeight = 300.0!
        Me.SubjectDataGridViewTextBoxColumn.HeaderText = "Тема сообщения"
        Me.SubjectDataGridViewTextBoxColumn.Name = "SubjectDataGridViewTextBoxColumn"
        Me.SubjectDataGridViewTextBoxColumn.ReadOnly = True
        Me.SubjectDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.SubjectDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'replies
        '
        Me.replies.DataPropertyName = "replies"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.replies.DefaultCellStyle = DataGridViewCellStyle3
        Me.replies.FillWeight = 30.0!
        Me.replies.HeaderText = "Ответов"
        Me.replies.Name = "replies"
        Me.replies.ReadOnly = True
        '
        'TdateDataGridViewTextBoxColumn
        '
        Me.TdateDataGridViewTextBoxColumn.DataPropertyName = "tdate"
        Me.TdateDataGridViewTextBoxColumn.HeaderText = "Дата"
        Me.TdateDataGridViewTextBoxColumn.Name = "TdateDataGridViewTextBoxColumn"
        Me.TdateDataGridViewTextBoxColumn.ReadOnly = True
        '
        'author
        '
        Me.author.DataPropertyName = "author"
        Me.author.HeaderText = "Последний Автор"
        Me.author.Name = "author"
        Me.author.ReadOnly = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.lbSize)
        Me.Panel1.Controls.Add(Me.llSite)
        Me.Panel1.Controls.Add(Me.llTopic)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.cbTimer)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 431)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(805, 35)
        Me.Panel1.TabIndex = 4
        '
        'llSite
        '
        Me.llSite.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.llSite.AutoSize = True
        Me.llSite.Location = New System.Drawing.Point(662, 13)
        Me.llSite.Name = "llSite"
        Me.llSite.Size = New System.Drawing.Size(41, 13)
        Me.llSite.TabIndex = 3
        Me.llSite.TabStop = True
        Me.llSite.Text = "AQA.ru"
        '
        'llTopic
        '
        Me.llTopic.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.llTopic.AutoSize = True
        Me.llTopic.Location = New System.Drawing.Point(709, 13)
        Me.llTopic.Name = "llTopic"
        Me.llTopic.Size = New System.Drawing.Size(93, 13)
        Me.llTopic.TabIndex = 2
        Me.llTopic.TabStop = True
        Me.llTopic.Text = "Сайт программы"
        Me.llTopic.TextAlign = System.Drawing.ContentAlignment.BottomRight
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(105, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Обновлять каждые"
        '
        'cbTimer
        '
        Me.cbTimer.FormattingEnabled = True
        Me.cbTimer.Items.AddRange(New Object() {"10 секунд", "15 секунд", "30 секунд", "45 секунд", "1 мунуту", "3 минуты", "5 минут", "10 минут", "15 минут", "30 минут", "1 час", "2 часа", "3 часа"})
        Me.cbTimer.Location = New System.Drawing.Point(125, 6)
        Me.cbTimer.Name = "cbTimer"
        Me.cbTimer.Size = New System.Drawing.Size(139, 21)
        Me.cbTimer.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.dg)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(805, 431)
        Me.Panel2.TabIndex = 5
        '
        't
        '
        Me.t.Enabled = True
        Me.t.Interval = 10000
        '
        'lbSize
        '
        Me.lbSize.AutoSize = True
        Me.lbSize.Location = New System.Drawing.Point(280, 10)
        Me.lbSize.Name = "lbSize"
        Me.lbSize.Size = New System.Drawing.Size(46, 13)
        Me.lbSize.TabIndex = 4
        Me.lbSize.Text = "Трафик"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(805, 466)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "AQA.pinger"
        CType(Me.ds, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.topics, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ds As System.Data.DataSet
    Friend WithEvents topics As System.Data.DataTable
    Friend WithEvents colId As System.Data.DataColumn
    Friend WithEvents DataColumn2 As System.Data.DataColumn
    Friend WithEvents DataColumn3 As System.Data.DataColumn
    Friend WithEvents dg As System.Windows.Forms.DataGridView
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents DataColumn4 As System.Data.DataColumn
    Friend WithEvents t As System.Windows.Forms.Timer
    Friend WithEvents DataColumn5 As System.Data.DataColumn
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cbTimer As System.Windows.Forms.ComboBox
    Friend WithEvents llTopic As System.Windows.Forms.LinkLabel
    Friend WithEvents llSite As System.Windows.Forms.LinkLabel
    Friend WithEvents DataColumn6 As System.Data.DataColumn
    Friend WithEvents IdDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents forum As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SubjectDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewLinkColumn
    Friend WithEvents replies As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TdateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents author As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents lbSize As System.Windows.Forms.Label

End Class
