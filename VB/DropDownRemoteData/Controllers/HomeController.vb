Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web
Imports System.Web.Mvc

Namespace DropDownRemoteData.Controllers
	Public Class HomeController
		Inherits Controller
		Public Function Index() As ActionResult
			Return View()
		End Function

		Public Function About() As ActionResult
			ViewBag.Message = "Your application description page."

			Return View()
		End Function

		Public Function Contact() As ActionResult
			ViewBag.Message = "Your contact page."

			Return View()
		End Function
	End Class
End Namespace