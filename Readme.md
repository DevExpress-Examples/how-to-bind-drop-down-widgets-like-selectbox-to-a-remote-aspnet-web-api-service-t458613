<!-- default file list -->
*Files to look at*:

* [HomeController.cs](./CS/DropDownRemoteData/Controllers/HomeController.cs) (VB: [HomeController.vb](./VB/DropDownRemoteData/Controllers/HomeController.vb))
* [OrdersController.cs](./CS/DropDownRemoteData/Controllers/OrdersController.cs) (VB: [OrdersController.vb](./VB/DropDownRemoteData/Controllers/OrdersController.vb))
* **[Index.cshtml](./CS/DropDownRemoteData/Views/Home/Index.cshtml)**
* [_Layout.cshtml](./CS/DropDownRemoteData/Views/Shared/_Layout.cshtml)
<!-- default file list end -->
# How to bind drop-down widgets (like SelectBox) to a remote ASP.NET Web API service 


<p>This example illustrates how to implement remote operations for the<a href="https://js.devexpress.com/Documentation/ApiReference/UI_Widgets/dxSelectBox/"> dxSelectBox</a>, <a href="https://js.devexpress.com/Documentation/ApiReference/UI_Widgets/dxLookup/">dxLookup</a>, and <a href="https://js.devexpress.com/Documentation/ApiReference/UI_Widgets/dxTagBox/">dxTagBox</a> widgets if data is obtained from a remote ASP.NET Web API service. <br>To do this, it is not necessary to implement a custom store manually and you can to create it using the <strong>DevExpress.data.AspNet.createStore</strong> method implemented in the <strong>dx.aspnet.data.js</strong> library. This library is a part of the <a href="https://github.com/DevExpress/DevExtreme.AspNet.Data">DevExtreme.AspNet.Data</a> data layer extension for ASP.NET MVC. The attached example illustrates how to integrate this library to an MVC 5 application and create a <a href="https://js.devexpress.com/Documentation/ApiReference/Data_Layer/DataSource/">DataSource</a> for the mentioned widgets.<br><br>If you need to implement more custom logic, follow the instructions from the <a href="https://www.devexpress.com/Support/Center/Question/Details/KA18829">dxLookup - Why the "Lookup/byKey callback was not defined" error is thrown when clicking an item if data is loaded from a web service</a> help topic to create a <a href="https://js.devexpress.com/Documentation/ApiReference/Data_Layer/CustomStore/">CustomStore</a> instance manually.</p>

<br/>


