Imports System.Globalization

Public Class Frame
	Public Property SerialID As String
	Public Property NodeID As String
	Public Property Sequence As String

	Public Property Payload As Measure

	Public Sub New(sFrame As String)

		'Separem parts per #
		Dim asParts() As String = sFrame.Split("#"c)
		Dim nNumFields As Integer = Asc(asParts(0).Substring(1, 1))

		'Verificar el nombre de camps de sensor
		If nNumFields <> asParts.Length - 5 Then
			Throw New ApplicationException("Trama incompleta")
		End If

		SerialID = asParts(1)
		NodeID = asParts(2)
		Sequence = asParts(3)

		Dim measure As New Measure

		For nPart As Integer = 4 To asParts.GetUpperBound(0) - 1
			Dim sSensor As String = asParts(nPart)
			Dim asSensorParts() As String = sSensor.Split({":"c}, 2)
			Select Case asSensorParts(0)
				Case "STR"
					measure.DateOfMeasure = Date.ParseExact(asSensorParts(1), "ddd, yy/MM/dd, HH:mm:ss", CultureInfo.InvariantCulture)
				Case "DICA"
					measure.Humidity = Single.Parse(asSensorParts(1), Globalization.NumberStyles.AllowDecimalPoint, CultureInfo.InvariantCulture)
				Case "BAT"
					measure.Battery = Integer.Parse(asSensorParts(1))
				Case "DICL"
					measure.Light = Integer.Parse(asSensorParts(1))
				Case "WT"
					measure.Temperature = Single.Parse(asSensorParts(1), Globalization.NumberStyles.AllowDecimalPoint, CultureInfo.InvariantCulture)
				Case Else

			End Select

			Payload = measure

		Next

	End Sub

	Public Overrides Function ToString() As String
		Return $"{Me.NodeID} {Payload.ToString}"
	End Function
End Class
