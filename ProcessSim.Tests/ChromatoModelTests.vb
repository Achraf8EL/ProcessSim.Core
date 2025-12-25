Option Strict On
Option Explicit On

Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports ProcessSim.Core

<TestClass()>
Public Class ChromatoModelTests

    <TestMethod()>
    Public Sub RetentionFactor_TR10_T0_2_Equals_4()
        Dim k = ChromatoModel.RetentionFactor(10, 2)
        Assert.AreEqual(4.0, k, 0.000000000001)
    End Sub

    <TestMethod()>
    <ExpectedException(GetType(ArgumentOutOfRangeException))>
    Public Sub RetentionFactor_T0_Zero_Throws()
        ChromatoModel.RetentionFactor(10, 0)
    End Sub

    <TestMethod()>
    Public Sub YieldFraction_0_8_And_0_9_Equals_0_72()
        Dim y = ChromatoModel.YieldFraction(0.8, 0.9)
        Assert.AreEqual(0.72, y, 0.000000000001)
    End Sub

    <TestMethod()>
    Public Sub BreakthroughRatio_k1_t0_Equals_0()
        Dim r = ChromatoModel.BreakthroughRatio(1, 0)
        Assert.AreEqual(0.0, r, 0.000000000001)
    End Sub

    <TestMethod()>
    Public Sub BreakthroughRatio_k1_t1_CloseTo_0_6321205588()
        Dim r = ChromatoModel.BreakthroughRatio(1, 1)
        Assert.AreEqual(0.6321205588, r, 0.000000001)
    End Sub

End Class
