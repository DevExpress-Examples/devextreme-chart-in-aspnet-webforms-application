Imports Microsoft.VisualBasic
Imports System
Imports System.Collections
Imports System.Web.Script.Serialization

Partial Public Class _Default
	Inherits System.Web.UI.Page
	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		RegisterScriptObjectFromDataObject(GetDataObject())
	End Sub
	Private Function GetDataObject() As IEnumerable
		Return New DataHelper().GetItems()
	End Function
	Private Sub RegisterScriptObjectFromDataObject(ByVal dataObject As IEnumerable)
		Dim serializer As New JavaScriptSerializer()
		Dim jsonData As String = serializer.Serialize(dataObject)

		ClientScript.RegisterStartupScript(Me.GetType(), "ANY_KEY", String.Format("var chartData = {0};", jsonData), True)
	End Sub
End Class