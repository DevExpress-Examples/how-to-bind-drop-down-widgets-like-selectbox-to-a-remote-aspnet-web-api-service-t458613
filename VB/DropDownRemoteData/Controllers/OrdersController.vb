Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Data.Entity
Imports System.Data.Entity.Infrastructure
Imports System.Linq
Imports System.Net
Imports System.Net.Http
Imports System.Threading.Tasks
Imports System.Web.Http
Imports System.Web.Http.Description
Imports DropDownRemoteData.Models
Imports DevExtreme.AspNet.Data
Imports DevExtreme.AspNet.Data.Helpers

Namespace DropDownRemoteData.Controllers
	Public Class OrdersController
		Inherits ApiController
		Private db As New NorthwindEntities()

		' GET: api/Orders
		<HttpGet> _
		Public Function GetOrders() As HttpResponseMessage
			Dim parameters As DataSourceLoadOptions = GetLoadParams()
			Dim result = DataSourceLoader.Load(db.Orders, parameters)
			Return Request.CreateResponse(result)
		End Function

		Private Function GetLoadParams() As DataSourceLoadOptions
			Dim parameters As New DataSourceLoadOptions()
			Dim requestValues = Request.GetQueryNameValuePairs()
            DataSourceLoadOptionsParser.Parse(parameters, Function(key) DelegateHandler(key, requestValues))
            parameters.PrimaryKey = New String() {"OrderID"}
            Return parameters
        End Function

        'INSTANT VB TODO TASK: The return type of this anonymous method could not be determined by Instant VB:
        Private Function DelegateHandler(ByVal key As Object, ByVal requestValues As IEnumerable(Of KeyValuePair(Of String, String))) As String
            Dim items = requestValues.Where(Function(i) i.Key Is key)
            If items.Count() > 0 Then
                Return items.FirstOrDefault().Value
            Else
                Return Nothing
            End If
        End Function

		' GET: api/Orders/5
		<ResponseType(GetType(Order))> _
		Public async Function GetOrder(ByVal id As Integer) As Task(Of IHttpActionResult)
			Dim order As Order = await db.Orders.FindAsync(id)
			If order Is Nothing Then
				Return NotFound()
			End If

			Return Ok(order)
		End Function
		Protected Overrides Overloads Sub Dispose(ByVal disposing As Boolean)
			If disposing Then
				db.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		Private Function OrderExists(ByVal id As Integer) As Boolean
			Return db.Orders.Count(Function(e) e.OrderID = id) > 0
		End Function
	End Class
End Namespace