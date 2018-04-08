Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Net
Imports System.Windows
Imports System.Windows.Controls
Imports System.Windows.Documents
Imports System.Windows.Input
Imports System.Windows.Media
Imports System.Windows.Media.Animation
Imports System.Windows.Shapes
Imports DevExpress.Xpf.Bars
Imports DevExpress.Xpf.Core
Imports DXVisualizer

Namespace SilverlightApplication1
	Partial Public Class MainPage
		Inherits UserControl
		Public Sub New()
			DataContext = Me
			InitializeComponent()
		End Sub
	End Class

	Public Class MyCommand
		Implements ICommand
		Public Sub New()

		End Sub
		#Region "ICommand Members"

		Public Function CanExecute(ByVal parameter As Object) As Boolean Implements ICommand.CanExecute
			Return True
		End Function

		Public Event CanExecuteChanged As EventHandler Implements ICommand.CanExecuteChanged

		Public Sub Execute(ByVal parameter As Object) Implements ICommand.Execute
			CType(parameter, MainPage).biButton1.IsEnabled = Not(CType(parameter, MainPage)).biButton1.IsEnabled
		End Sub

		#End Region
	End Class


	Public Class MyCommands
		Private privateCommand As MyCommand
		Public Property Command() As MyCommand
			Get
				Return privateCommand
			End Get
			Set(ByVal value As MyCommand)
				privateCommand = value
			End Set
		End Property
		Public Sub New()
			Command = New MyCommand()
		End Sub
	End Class

End Namespace
