'Got help for this code from here
'https://social.msdn.microsoft.com/Forums/windows/en-US/73de165c-e948-4015-bdcd-570f55a6e365/databinding-to-a-toolstripstatuslabel?forum=winformsdatacontrols

Imports System.Windows.Forms.Design

<ToolStripItemDesignerAvailability(ToolStripItemDesignerAvailability.StatusStrip)>
Public Class BindableToolStripStatusLabel
    Inherits ToolStripStatusLabel
    Implements IBindableComponent

    Private _context As BindingContext = Nothing
    Private _bindings As ControlBindingsCollection

    Public Property DataBindings As ControlBindingsCollection Implements IBindableComponent.DataBindings
        Get

            If _bindings Is Nothing Then
                _bindings = New ControlBindingsCollection(Me)
            End If

            Return _bindings
        End Get
        Set(ByVal value As ControlBindingsCollection)
            _bindings = value
        End Set
    End Property

    Public Property BindingContext As BindingContext Implements IBindableComponent.BindingContext
        Get

            If _context Is Nothing Then
                _context = New BindingContext()
            End If

            Return _context
        End Get
        Set(ByVal value As BindingContext)
            _context = value
        End Set
    End Property
End Class

