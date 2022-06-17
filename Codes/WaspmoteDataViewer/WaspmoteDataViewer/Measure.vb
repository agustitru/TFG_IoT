Public Class Measure
	Public Property Humidity As Single
	Public Property Temperature As Single
	Public Property Battery As Integer
	Public Property Light As Integer

	Public Property DateOfMeasure As Date

	Public Overrides Function ToString() As String
		Return $"d:{DateOfMeasure} h:{Humidity} t:{Temperature} l:{Light}"

	End Function

End Class
