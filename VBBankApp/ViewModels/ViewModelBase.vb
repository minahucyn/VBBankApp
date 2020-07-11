Imports System.ComponentModel
Imports System.Runtime.CompilerServices

Public Class ViewModelBase
    Implements INotifyPropertyChanged
#Region "Events"
    Public Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged
#End Region

#Region "Public Methods"
    Public Sub OnPropertyChanged(<CallerMemberName> Optional propertyName As String = "")
        RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(propertyName))
    End Sub
#End Region
End Class
