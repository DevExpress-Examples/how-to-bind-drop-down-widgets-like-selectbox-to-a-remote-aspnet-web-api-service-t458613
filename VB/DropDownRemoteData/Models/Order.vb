'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated from a template.
'
'     Manual changes to this file may cause unexpected behavior in your application.
'     Manual changes to this file will be overwritten if the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------


Imports Microsoft.VisualBasic
	Imports System
	Imports System.Collections.Generic
Namespace DropDownRemoteData.Models

	Partial Public Class Order
		Private privateOrderID As Integer
		Public Property OrderID() As Integer
			Get
				Return privateOrderID
			End Get
			Set(ByVal value As Integer)
				privateOrderID = value
			End Set
		End Property
		Private privateCustomerID As String
		Public Property CustomerID() As String
			Get
				Return privateCustomerID
			End Get
			Set(ByVal value As String)
				privateCustomerID = value
			End Set
		End Property
		Private privateEmployeeID? As Integer
		Public Property EmployeeID() As Integer?
			Get
				Return privateEmployeeID
			End Get
			Set(ByVal value? As Integer)
				privateEmployeeID = value
			End Set
		End Property
		Private privateOrderDate As System.DateTime
		Public Property OrderDate() As System.DateTime
			Get
				Return privateOrderDate
			End Get
			Set(ByVal value As System.DateTime)
				privateOrderDate = value
			End Set
		End Property
		Private privateRequiredDate? As System.DateTime
		Public Property RequiredDate() As System.DateTime?
			Get
				Return privateRequiredDate
			End Get
			Set(ByVal value? As System.DateTime)
				privateRequiredDate = value
			End Set
		End Property
		Private privateShippedDate? As System.DateTime
		Public Property ShippedDate() As System.DateTime?
			Get
				Return privateShippedDate
			End Get
			Set(ByVal value? As System.DateTime)
				privateShippedDate = value
			End Set
		End Property
		Private privateShipVia? As Integer
		Public Property ShipVia() As Integer?
			Get
				Return privateShipVia
			End Get
			Set(ByVal value? As Integer)
				privateShipVia = value
			End Set
		End Property
		Private privateFreight? As Decimal
		Public Property Freight() As Decimal?
			Get
				Return privateFreight
			End Get
			Set(ByVal value? As Decimal)
				privateFreight = value
			End Set
		End Property
		Private privateShipName As String
		Public Property ShipName() As String
			Get
				Return privateShipName
			End Get
			Set(ByVal value As String)
				privateShipName = value
			End Set
		End Property
		Private privateShipAddress As String
		Public Property ShipAddress() As String
			Get
				Return privateShipAddress
			End Get
			Set(ByVal value As String)
				privateShipAddress = value
			End Set
		End Property
		Private privateShipCity As String
		Public Property ShipCity() As String
			Get
				Return privateShipCity
			End Get
			Set(ByVal value As String)
				privateShipCity = value
			End Set
		End Property
		Private privateShipRegion As String
		Public Property ShipRegion() As String
			Get
				Return privateShipRegion
			End Get
			Set(ByVal value As String)
				privateShipRegion = value
			End Set
		End Property
		Private privateShipPostalCode As String
		Public Property ShipPostalCode() As String
			Get
				Return privateShipPostalCode
			End Get
			Set(ByVal value As String)
				privateShipPostalCode = value
			End Set
		End Property
		Private privateShipCountry As String
		Public Property ShipCountry() As String
			Get
				Return privateShipCountry
			End Get
			Set(ByVal value As String)
				privateShipCountry = value
			End Set
		End Property
	End Class
End Namespace
