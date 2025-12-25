Option Strict On
Option Explicit On

Public NotInheritable Class UnitConverter
    Private Sub New()
    End Sub

    Public Shared Function MgPerMlToGPerL(value As Double) As Double
        If value < 0 Then Throw New ArgumentOutOfRangeException(NameOf(value))
        Return value
    End Function

    Public Shared Function GPerLToMgPerMl(value As Double) As Double
        If value < 0 Then Throw New ArgumentOutOfRangeException(NameOf(value))
        Return value
    End Function

    Public Shared Function MlToL(value As Double) As Double
        If value < 0 Then Throw New ArgumentOutOfRangeException(NameOf(value))
        Return value / 1000.0
    End Function

    Public Shared Function LToMl(value As Double) As Double
        If value < 0 Then Throw New ArgumentOutOfRangeException(NameOf(value))
        Return value * 1000.0
    End Function

    Public Shared Function CelsiusToKelvin(value As Double) As Double
        Return value + 273.15
    End Function

    Public Shared Function KelvinToCelsius(value As Double) As Double
        Return value - 273.15
    End Function
End Class
