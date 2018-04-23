Imports Microsoft.VisualBasic
Imports System
Imports System.Collections
Imports System.Collections.Generic

Public Class DataHelper
	Private ReadOnly FeedList As List(Of String)

	Public Sub New()
		Me.FeedList = New List(Of String)()

		Me.FeedList.Add("ASP.NET")
		Me.FeedList.Add("WinForms")
		Me.FeedList.Add("WPF")
		Me.FeedList.Add("SL")
		Me.FeedList.Add("VCL")
	End Sub

	Public Function GetItems() As IEnumerable
		Dim randomizer As New Random()
		Dim kbItems As New List(Of KBInfo)()
		For Each name As String In FeedList
			kbItems.Add(New KBInfo() With {.PlatformName = name, .Count = randomizer.Next(100, 500)})
		Next name
		Return kbItems
	End Function
End Class

Public Class KBInfo
	Private privatePlatformName As String
	Public Property PlatformName() As String
		Get
			Return privatePlatformName
		End Get
		Set(ByVal value As String)
			privatePlatformName = value
		End Set
	End Property
	Private privateCount As Integer
	Public Property Count() As Integer
		Get
			Return privateCount
		End Get
		Set(ByVal value As Integer)
			privateCount = value
		End Set
	End Property
End Class