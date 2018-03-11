Option Strict On

'Funciones auxiliares

'Crea IComparer de delegados / lambda - .NET lo requiere de esa manera
Class FunctionComparer(Of T) : Implements IComparer(Of T)
    Private ReadOnly m_Func As Comparison(Of T)

    Public Sub New(ByVal Func As Comparison(Of T))
        m_Func = Func
    End Sub

    Public Function Compare(ByVal x As T, _
        ByVal y As T) As Integer _
        Implements System.Collections.Generic.IComparer(Of T).Compare

        Return m_Func(x, y)
    End Function
End Class

Module Helper
    'Cambiar dos valores
    Public Sub Swap(Of T)(ByRef a As T, ByRef b As T)
        Dim tmp = a
        a = b
        b = tmp
    End Sub
End Module
