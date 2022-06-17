Imports System.IO.Ports
Imports System.Text
Imports System.IO
Imports System.Windows.Forms.DataVisualization.Charting

Public Class frmMain
	Private MesuresNode1 As New List(Of Measure)
	Private MesuresNode2 As New List(Of Measure)


	Private Delegate Sub PintaTextDelegate(sText As String)
	Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		Me.Text = My.Application.Info.Title
	End Sub



	Private Sub PintaText(sText As String)
		If txtNode1.InvokeRequired Then
			Dim MyDelegate = New PintaTextDelegate(AddressOf PintaText)
			txtNode1.Invoke(MyDelegate, sText)
		Else
			txtNode1.Text &= sText
		End If
	End Sub

	Private Sub btnLoadFile_Click(sender As Object, e As EventArgs) Handles btnLoadFile.Click
		OpenFileDialog1.FileName = ""
		OpenFileDialog1.Filter = "Text files|*.txt"

		If OpenFileDialog1.ShowDialog(Me) = DialogResult.OK Then
			'llegim contingut de l'arxiu
			Dim sNomFitxer As String = OpenFileDialog1.FileName
			Dim sText As String = File.ReadAllText(sNomFitxer, Encoding.Default)

			'separem frames
			Dim asFrames() As String = Strings.Split(sText, "<=>",, Microsoft.VisualBasic.CompareMethod.Text)
			ChartTemp.Series(0).Dispose()
			ChartTemp.Series(1).Dispose()
			ChartTemp.Series.Clear()
			ChartTemp.Series.Add("node_01").ChartType = SeriesChartType.Line
			ChartTemp.Series.Add("node_02").ChartType = SeriesChartType.Line

			ChartHumidity.Series(0).Dispose()
			ChartHumidity.Series(1).Dispose()
			ChartHumidity.Series.Clear()
			ChartHumidity.Series.Add("node_01").ChartType = SeriesChartType.Line
			ChartHumidity.Series.Add("node_02").ChartType = SeriesChartType.Line

			ChartLight.Series(0).Dispose()
			ChartLight.Series(1).Dispose()
			ChartLight.Series.Clear()
			ChartLight.Series.Add("node_01").ChartType = SeriesChartType.Line
			ChartLight.Series.Add("node_02").ChartType = SeriesChartType.Line

			ChartBatt.Series(0).Dispose()
			ChartBatt.Series(1).Dispose()
			ChartBatt.Series.Clear()
			ChartBatt.Series.Add("node_01").ChartType = SeriesChartType.Line
			ChartBatt.Series.Add("node_02").ChartType = SeriesChartType.Line



			Dim sTextNode1 As String = ""
			Dim sTextNode2 As String = ""

			For Each sFrame As String In asFrames
				If sFrame.Length > 0 Then
					Dim frame As Frame = New Frame(sFrame)
					If frame.NodeID = "node_01" Then
						sTextNode1 &= (frame.ToString) & vbNewLine
						MesuresNode1.Add(frame.Payload)

						ChartTemp.Series(0).Points.AddXY(frame.Payload.DateOfMeasure, frame.Payload.Temperature)
						ChartHumidity.Series(0).Points.AddXY(frame.Payload.DateOfMeasure, frame.Payload.Humidity)
						ChartLight.Series(0).Points.AddXY(frame.Payload.DateOfMeasure, frame.Payload.Light)
						ChartBatt.Series(0).Points.AddXY(frame.Payload.DateOfMeasure, frame.Payload.Battery)

					ElseIf frame.NodeID = "node_02" Then
						sTextNode2 &= (frame.ToString) & vbNewLine
						MesuresNode2.Add(frame.Payload)

						ChartTemp.Series(1).Points.AddXY(frame.Payload.DateOfMeasure, frame.Payload.Temperature)
						ChartHumidity.Series(1).Points.AddXY(frame.Payload.DateOfMeasure, frame.Payload.Humidity)
						ChartLight.Series(1).Points.AddXY(frame.Payload.DateOfMeasure, frame.Payload.Light)
						ChartBatt.Series(1).Points.AddXY(frame.Payload.DateOfMeasure, frame.Payload.Battery)
					End If
				End If
			Next

			txtNode1.Text = sTextNode1
			txtNode2.Text = sTextNode2

			ChartTemp.Series(0).XValueType = ChartValueType.Time
			ChartTemp.ChartAreas(0).AxisX.LabelStyle.Format = "HH:mm"
			ChartTemp.ChartAreas(0).AxisX.MajorGrid.IntervalType = DateTimeIntervalType.Hours
			ChartTemp.ChartAreas(0).AxisX.LabelStyle.IntervalType = DateTimeIntervalType.Hours
			ChartTemp.ChartAreas(0).AxisX.LabelStyle.Interval = 1


			ChartHumidity.Series(0).XValueType = ChartValueType.Time
			ChartHumidity.ChartAreas(0).AxisX.LabelStyle.Format = "HH:mm"
			ChartHumidity.ChartAreas(0).AxisX.MajorGrid.IntervalType = DateTimeIntervalType.Hours
			ChartHumidity.ChartAreas(0).AxisX.LabelStyle.IntervalType = DateTimeIntervalType.Hours
			ChartHumidity.ChartAreas(0).AxisX.LabelStyle.Interval = 1

			ChartLight.Series(0).XValueType = ChartValueType.Time
			ChartLight.ChartAreas(0).AxisX.LabelStyle.Format = "HH:mm"
			ChartLight.ChartAreas(0).AxisX.MajorGrid.IntervalType = DateTimeIntervalType.Hours
			ChartLight.ChartAreas(0).AxisX.LabelStyle.IntervalType = DateTimeIntervalType.Hours
			ChartLight.ChartAreas(0).AxisX.LabelStyle.Interval = 1

			ChartBatt.Series(0).XValueType = ChartValueType.Time
			ChartBatt.ChartAreas(0).AxisX.LabelStyle.Format = "HH:mm"
			ChartBatt.ChartAreas(0).AxisX.MajorGrid.IntervalType = DateTimeIntervalType.Hours
			ChartBatt.ChartAreas(0).AxisX.LabelStyle.IntervalType = DateTimeIntervalType.Hours
			ChartBatt.ChartAreas(0).AxisX.LabelStyle.Interval = 1

		End If
	End Sub

	Private Sub ChartHumidity_Click(sender As Object, e As EventArgs) Handles ChartHumidity.Click

	End Sub
End Class
