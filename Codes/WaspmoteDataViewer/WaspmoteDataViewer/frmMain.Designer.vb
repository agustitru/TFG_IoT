<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMain
	Inherits System.Windows.Forms.Form

	'Form reemplaza a Dispose para limpiar la lista de componentes.
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

	'Requerido por el Diseñador de Windows Forms
	Private components As System.ComponentModel.IContainer

	'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
	'Se puede modificar usando el Diseñador de Windows Forms.  
	'No lo modifique con el editor de código.
	<System.Diagnostics.DebuggerStepThrough()>
	Private Sub InitializeComponent()
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series2 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Title1 As System.Windows.Forms.DataVisualization.Charting.Title = New System.Windows.Forms.DataVisualization.Charting.Title()
        Dim ChartArea2 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend2 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series3 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series4 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Title2 As System.Windows.Forms.DataVisualization.Charting.Title = New System.Windows.Forms.DataVisualization.Charting.Title()
        Dim ChartArea3 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend3 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series5 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series6 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Title3 As System.Windows.Forms.DataVisualization.Charting.Title = New System.Windows.Forms.DataVisualization.Charting.Title()
        Dim ChartArea4 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend4 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series7 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series8 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Title4 As System.Windows.Forms.DataVisualization.Charting.Title = New System.Windows.Forms.DataVisualization.Charting.Title()
        Me.btnLoadFile = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.txtNode1 = New System.Windows.Forms.TextBox()
        Me.txtNode2 = New System.Windows.Forms.TextBox()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.ChartLight = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.ChartBatt = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.ChartTemp = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.ChartHumidity = New System.Windows.Forms.DataVisualization.Charting.Chart()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.ChartLight, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ChartBatt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ChartTemp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ChartHumidity, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnLoadFile
        '
        Me.btnLoadFile.Location = New System.Drawing.Point(16, 15)
        Me.btnLoadFile.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnLoadFile.Name = "btnLoadFile"
        Me.btnLoadFile.Size = New System.Drawing.Size(109, 26)
        Me.btnLoadFile.TabIndex = 3
        Me.btnLoadFile.Text = "Load File..."
        Me.btnLoadFile.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SplitContainer1.Location = New System.Drawing.Point(16, 48)
        Me.SplitContainer1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtNode1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.txtNode2)
        Me.SplitContainer1.Size = New System.Drawing.Size(1388, 347)
        Me.SplitContainer1.SplitterDistance = 689
        Me.SplitContainer1.SplitterWidth = 5
        Me.SplitContainer1.TabIndex = 6
        '
        'txtNode1
        '
        Me.txtNode1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtNode1.Font = New System.Drawing.Font("Lucida Console", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNode1.Location = New System.Drawing.Point(0, 0)
        Me.txtNode1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtNode1.Multiline = True
        Me.txtNode1.Name = "txtNode1"
        Me.txtNode1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtNode1.Size = New System.Drawing.Size(689, 347)
        Me.txtNode1.TabIndex = 1
        '
        'txtNode2
        '
        Me.txtNode2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtNode2.Font = New System.Drawing.Font("Lucida Console", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNode2.Location = New System.Drawing.Point(0, 0)
        Me.txtNode2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtNode2.Multiline = True
        Me.txtNode2.Name = "txtNode2"
        Me.txtNode2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtNode2.Size = New System.Drawing.Size(694, 347)
        Me.txtNode2.TabIndex = 5
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.ChartLight, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.ChartBatt, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.ChartTemp, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.ChartHumidity, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(16, 402)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1388, 418)
        Me.TableLayoutPanel1.TabIndex = 7
        '
        'ChartLight
        '
        ChartArea1.Name = "ChartArea1"
        Me.ChartLight.ChartAreas.Add(ChartArea1)
        Me.ChartLight.Dock = System.Windows.Forms.DockStyle.Fill
        Legend1.Name = "Legend1"
        Me.ChartLight.Legends.Add(Legend1)
        Me.ChartLight.Location = New System.Drawing.Point(4, 213)
        Me.ChartLight.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ChartLight.Name = "ChartLight"
        Series1.ChartArea = "ChartArea1"
        Series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line
        Series1.Legend = "Legend1"
        Series1.Name = "node_01"
        Series2.ChartArea = "ChartArea1"
        Series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line
        Series2.Legend = "Legend1"
        Series2.Name = "node_02"
        Me.ChartLight.Series.Add(Series1)
        Me.ChartLight.Series.Add(Series2)
        Me.ChartLight.Size = New System.Drawing.Size(686, 201)
        Me.ChartLight.TabIndex = 8
        Me.ChartLight.Text = "Chart3"
        Title1.Name = "Title1"
        Title1.Text = "Light"
        Me.ChartLight.Titles.Add(Title1)
        '
        'ChartBatt
        '
        ChartArea2.Name = "ChartArea1"
        Me.ChartBatt.ChartAreas.Add(ChartArea2)
        Me.ChartBatt.Dock = System.Windows.Forms.DockStyle.Fill
        Legend2.Name = "Legend1"
        Me.ChartBatt.Legends.Add(Legend2)
        Me.ChartBatt.Location = New System.Drawing.Point(698, 213)
        Me.ChartBatt.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ChartBatt.Name = "ChartBatt"
        Series3.ChartArea = "ChartArea1"
        Series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line
        Series3.Legend = "Legend1"
        Series3.Name = "node_01"
        Series4.ChartArea = "ChartArea1"
        Series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line
        Series4.Legend = "Legend1"
        Series4.Name = "node_02"
        Me.ChartBatt.Series.Add(Series3)
        Me.ChartBatt.Series.Add(Series4)
        Me.ChartBatt.Size = New System.Drawing.Size(686, 201)
        Me.ChartBatt.TabIndex = 7
        Me.ChartBatt.Text = "Chart2"
        Title2.Name = "Title1"
        Title2.Text = "Battery level"
        Me.ChartBatt.Titles.Add(Title2)
        '
        'ChartTemp
        '
        ChartArea3.AxisX.LabelStyle.Format = "HH:mm"
        ChartArea3.AxisX.LabelStyle.Interval = 1.0R
        ChartArea3.AxisX.LabelStyle.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Hours
        ChartArea3.Name = "ChartArea1"
        Me.ChartTemp.ChartAreas.Add(ChartArea3)
        Me.ChartTemp.Dock = System.Windows.Forms.DockStyle.Fill
        Legend3.Name = "Legend1"
        Me.ChartTemp.Legends.Add(Legend3)
        Me.ChartTemp.Location = New System.Drawing.Point(4, 4)
        Me.ChartTemp.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ChartTemp.Name = "ChartTemp"
        Series5.ChartArea = "ChartArea1"
        Series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line
        Series5.Legend = "Legend1"
        Series5.Name = "node_01"
        Series6.ChartArea = "ChartArea1"
        Series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line
        Series6.Legend = "Legend1"
        Series6.Name = "node_02"
        Me.ChartTemp.Series.Add(Series5)
        Me.ChartTemp.Series.Add(Series6)
        Me.ChartTemp.Size = New System.Drawing.Size(686, 201)
        Me.ChartTemp.TabIndex = 6
        Me.ChartTemp.Text = "Chart1"
        Title3.Name = "Title1"
        Title3.Text = "Temperature"
        Me.ChartTemp.Titles.Add(Title3)
        '
        'ChartHumidity
        '
        ChartArea4.Name = "ChartArea1"
        Me.ChartHumidity.ChartAreas.Add(ChartArea4)
        Me.ChartHumidity.Dock = System.Windows.Forms.DockStyle.Fill
        Legend4.Name = "Legend1"
        Me.ChartHumidity.Legends.Add(Legend4)
        Me.ChartHumidity.Location = New System.Drawing.Point(698, 4)
        Me.ChartHumidity.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ChartHumidity.Name = "ChartHumidity"
        Series7.ChartArea = "ChartArea1"
        Series7.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line
        Series7.Legend = "Legend1"
        Series7.Name = "node_01"
        Series8.ChartArea = "ChartArea1"
        Series8.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line
        Series8.Legend = "Legend1"
        Series8.Name = "node_02"
        Me.ChartHumidity.Series.Add(Series7)
        Me.ChartHumidity.Series.Add(Series8)
        Me.ChartHumidity.Size = New System.Drawing.Size(686, 201)
        Me.ChartHumidity.TabIndex = 6
        Me.ChartHumidity.Text = "Chart1"
        Title4.Name = "Title1"
        Title4.Text = "Humidity"
        Me.ChartHumidity.Titles.Add(Title4)
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1420, 836)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.btnLoadFile)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "frmMain"
        Me.Text = "Form1"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.Panel2.PerformLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.ChartLight, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChartBatt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChartTemp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChartHumidity, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnLoadFile As Button
	Friend WithEvents OpenFileDialog1 As OpenFileDialog
	Friend WithEvents SplitContainer1 As SplitContainer
	Friend WithEvents txtNode1 As TextBox
	Friend WithEvents txtNode2 As TextBox
	Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
	Friend WithEvents ChartTemp As DataVisualization.Charting.Chart
	Friend WithEvents ChartLight As DataVisualization.Charting.Chart
	Friend WithEvents ChartBatt As DataVisualization.Charting.Chart
	Friend WithEvents ChartHumidity As DataVisualization.Charting.Chart
End Class
