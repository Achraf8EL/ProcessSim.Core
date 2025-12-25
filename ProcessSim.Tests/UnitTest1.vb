Option Strict On
Option Explicit On

Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports ProcessSim.Core.CSharp

<TestClass()>
Public Class UnitConverterTests

    <TestMethod()>
    Public Sub MlToL_1000ml_Equals_1L()
        Dim actual = UnitConverter.MlToL(1000)
        Assert.AreEqual(1.0, actual, 0.000000000001)
    End Sub

    <TestMethod()>
    Public Sub LToMl_1L_Equals_1000ml()
        Dim actual = UnitConverter.LToMl(1)
        Assert.AreEqual(1000.0, actual, 0.000000000001)
    End Sub

    <TestMethod()>
    Public Sub CelsiusToKelvin_0C_Equals_273_15K()
        Dim actual = UnitConverter.CelsiusToKelvin(0)
        Assert.AreEqual(273.15, actual, 0.000000000001)
    End Sub

    <TestMethod()>
    Public Sub KelvinToCelsius_273_15K_Equals_0C()
        Dim actual = UnitConverter.KelvinToCelsius(273.15)
        Assert.AreEqual(0.0, actual, 0.000000000001)
    End Sub

    <TestMethod()>
    Public Sub MgPerMlToGPerL_2_Equals_2()
        Dim actual = UnitConverter.MgPerMlToGPerL(2)
        Assert.AreEqual(2.0, actual, 0.000000000001)
    End Sub

    <TestMethod()>
    <ExpectedException(GetType(ArgumentOutOfRangeException))>
    Public Sub MlToL_Negative_Throws()
        UnitConverter.MlToL(-1)
    End Sub

End Class
