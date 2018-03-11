Imports System.Drawing.Point

Module GrahamScan


    '¿Está el punto C a la izquierda, a la derecha o en el vector AB?
    Private Function Orientation(ByVal A As Point, _
        ByVal B As Point, ByVal C As Point) As Integer

        Return (B.X - A.X) * (C.Y - A.Y) - (C.X - A.X) * (B.Y - A.Y)
    End Function

    'Buscar punto mínimo (coordenada y más pequeña)
    Private Function Less(ByVal A As Point, ByVal B As Point) As Boolean
        Return (A.Y < B.Y) OrElse ((A.Y = B.Y) And (A.X < B.X))
    End Function

    Public Function ConvexHull( _
        ByVal RawPoints As IEnumerable(Of Point)) As IEnumerable(Of Point)

        If RawPoints.Count <= 3 Then Return RawPoints

        Dim Points = New List(Of Point)(RawPoints)

        'Busque el punto "más pequeño"
        Dim MinIndex = Enumerable.Range(0, Points.Count).Aggregate( _
            Function(Min, idx) If(Less(Points(idx), Points(Min)), idx, Min))
        Dim MinPoint = Points(MinIndex)

        ' Poner mínimo a la posición 0
        Call Swap(Points(0), Points(MinIndex))

        'Los puntos restantes de izquierda a derecha su ángulo al mínimo
        'Ordenar por punto
        Call Points.Sort(1, Points.Count - 1, _
            New FunctionComparer(Of Point)( _
                Function(a, b) Orientation(MinPoint, a, b)))


        'Apilar para los elementos
        Dim Stack As New List(Of Point)


        'Primero y segundo punto forman la posicion inicial
        Call Stack.Add(Points(0))
        Call Stack.Add(Points(1))

        'Repasa todos los otros puntos
        For i = 2 To Points.Count - 1


            'Anterior gira en el sentido de las agujas del reloj, no hacia la cascara
            'pertenecer, eliminar
            Do Until (Stack.Count < 2) OrElse _
                (Orientation(Stack(Stack.Count - 1), _
                    Stack(Stack.Count - 2), Points(i)) > 0)

                Call Stack.RemoveAt(Stack.Count - 1)
            Loop


            'Agregar punto
            Call Stack.Add(Points(i))
        Next

        ' Devolver la pila
        Return Stack
    End Function

End Module
