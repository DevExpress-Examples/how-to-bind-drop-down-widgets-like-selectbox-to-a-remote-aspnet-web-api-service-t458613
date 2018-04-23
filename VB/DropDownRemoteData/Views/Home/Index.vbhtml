@Code
    ViewBag.Title = ""
End Code
<script>
    function  customTemplate (data, index, container) {
        container.text("OrderID: " + data.OrderID + " (Country: " + data.ShipCountry + ", City: " + data.ShipCity + ")");
        return container;
    }
    function customText (data) {
        return data ? data.OrderID + "-" + data.ShipCountry + "/" + data.ShipCity : "";
    }
    $(function () {
        var remoteDataLoader = new DevExpress.data.DataSource({
            store: new DevExpress.data.AspNet.createStore({
                loadUrl: "api/Orders/",
                key: "OrderID"
            }),
            paginate: true,
            pageSize: 15
        })
        $("#sb").dxSelectBox({
            dataSource: remoteDataLoader,
            searchEnabled: true,
            displayExpr: customText,
            searchExpr: ["ShipCity", "ShipCountry", "OrderID"],
            itemTemplate: customTemplate,

        })
       
        $("#lookup").dxLookup({

            dataSource: remoteDataLoader,
            searchEnabled: true,
            displayExpr: customText,
            searchExpr: ["ShipCity", "ShipCountry", "OrderID"],
            itemTemplate: customTemplate,
        })
        $("#tgb").dxTagBox({
            width: 400,
            dataSource: remoteDataLoader,
            searchEnabled: true,
            displayExpr: customText,
            searchExpr: ["ShipCity", "ShipCountry", "OrderID"],
            itemTemplate: customTemplate,
        })
    })
</script>
<div class="jumbotron">
    <h2>ASP.NET MVC 5 Application</h2>
</div>

<div class="row">
    <div class="col-md-4">
        <h3>dxSelectBox</h3>
        <div id="sb"></div>
    </div>
    <div class="col-md-4">
        <h3>dxLookup</h3>
        <div id="lookup"></div>
    </div>
    <div class="col-md-4">
        <h3>dxTagBox</h3>
        <div id="tgb"></div>
    </div>
</div>