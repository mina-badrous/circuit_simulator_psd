Public Class TestPoints

    Private _TP8 As Boolean
    Private _TP9 As Boolean
    Private _TP10 As Boolean
    Private _TP11 As Boolean
    Private _TP12 As Boolean
    Private _TP13 As Boolean
    Private _TP14 As Boolean
    Private _TP15 As Boolean
    Public Property TP8() As Boolean
        Get
            Return _TP8
        End Get
        Set(ByVal value As Boolean)
            _TP8 = value
        End Set
    End Property

    Public Property TP9() As Boolean
        Get
            Return _TP9
        End Get
        Set(ByVal value As Boolean)
            _TP9 = value
        End Set
    End Property


    Public Property TP10() As Boolean
        Get
            Return _TP10
        End Get
        Set(ByVal value As Boolean)
            _TP10 = value
        End Set
    End Property

    Public Property TP11() As Boolean
        Get
            Return _TP11
        End Get
        Set(ByVal value As Boolean)
            _TP11 = value
        End Set
    End Property


    Public Property TP12() As Boolean
        Get
            Return _TP12
        End Get
        Set(ByVal value As Boolean)
            _TP12 = value
        End Set
    End Property


    Public Property TP13() As Boolean
        Get
            Return _TP13
        End Get
        Set(ByVal value As Boolean)
            _TP13 = value
        End Set
    End Property

    Public Property TP14() As Boolean
        Get
            Return _TP14
        End Get
        Set(ByVal value As Boolean)
            _TP14 = value
        End Set
    End Property

    Public Property TP15() As Boolean
        Get
            Return _TP15
        End Get
        Set(ByVal value As Boolean)
            _TP15 = value
        End Set
    End Property


End Class


Public Class InputSignal
    Private _clear As Boolean
    Private _data As Boolean
    Public Property clear() As Boolean
        Get
            Return _clear
        End Get
        Set(ByVal value As Boolean)
            _clear = value
        End Set
    End Property

    Public Property data() As Boolean
        Get
            Return _data
        End Get
        Set(ByVal value As Boolean)
            _data = value
        End Set
    End Property

End Class