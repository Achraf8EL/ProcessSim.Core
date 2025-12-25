Option Strict On
Option Explicit On

Public NotInheritable Class ChromatoModel
    Private Sub New()
    End Sub

    ' Exemple simple : coefficient de rétention k = (tR - t0) / t0
    Public Shared Function RetentionFactor(tR As Double, t0 As Double) As Double
        If t0 <= 0 Then Throw New ArgumentOutOfRangeException(NameOf(t0), "t0 doit être > 0.")
        If tR < t0 Then Throw New ArgumentOutOfRangeException(NameOf(tR), "tR doit être >= t0.")
        Return (tR - t0) / t0
    End Function

    ' Exemple simple : Rendement = fraction_liée * efficacité
    ' fractionBound et efficiency sont dans [0 ; 1]
    Public Shared Function YieldFraction(fractionBound As Double, efficiency As Double) As Double
        If fractionBound < 0 OrElse fractionBound > 1 Then Throw New ArgumentOutOfRangeException(NameOf(fractionBound))
        If efficiency < 0 OrElse efficiency > 1 Then Throw New ArgumentOutOfRangeException(NameOf(efficiency))
        Return fractionBound * efficiency
    End Function

    ' "Breakthrough curve" toy model : C/C0 = 1 - exp(-k * t)
    Public Shared Function BreakthroughRatio(k As Double, t As Double) As Double
        If k < 0 Then Throw New ArgumentOutOfRangeException(NameOf(k))
        If t < 0 Then Throw New ArgumentOutOfRangeException(NameOf(t))
        Return 1.0 - Math.Exp(-k * t)
    End Function
End Class
