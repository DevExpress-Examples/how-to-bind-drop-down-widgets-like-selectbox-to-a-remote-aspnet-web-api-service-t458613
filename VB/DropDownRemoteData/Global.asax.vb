Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web
Imports System.Web.Http
Imports System.Web.Mvc
Imports System.Web.Optimization
Imports System.Web.Routing

Namespace DropDownRemoteData
	Public Class MvcApplication
		Inherits System.Web.HttpApplication
		Protected Sub Application_Start()
			AreaRegistration.RegisterAllAreas()
            GlobalConfiguration.Configure(AddressOf WebApiConfig.Register)
			FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters)
			RouteConfig.RegisterRoutes(RouteTable.Routes)
			BundleConfig.RegisterBundles(BundleTable.Bundles)
		End Sub
	End Class
End Namespace
