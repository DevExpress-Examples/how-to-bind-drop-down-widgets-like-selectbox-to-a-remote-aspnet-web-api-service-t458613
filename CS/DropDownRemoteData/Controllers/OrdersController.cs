using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;
using DropDownRemoteData.Models;
using DevExtreme.AspNet.Data;
using DevExtreme.AspNet.Data.Helpers;

namespace DropDownRemoteData.Controllers
{
    public class OrdersController : ApiController
    {
        private NorthwindEntities db = new NorthwindEntities();

        // GET: api/Orders
        [HttpGet]
        public HttpResponseMessage GetOrders()
        {
            DataSourceLoadOptions parameters = GetLoadParams();
            var result = DataSourceLoader.Load(db.Orders, parameters);
            return Request.CreateResponse(result);
        }

        private DataSourceLoadOptions GetLoadParams()
        {
            DataSourceLoadOptions parameters = new DataSourceLoadOptions();
            var requestValues = Request.GetQueryNameValuePairs();
            DataSourceLoadOptionsParser.Parse(parameters, (key) =>
            {
                var items = requestValues.Where(i => i.Key == key);
                if (items.Count() > 0)
                    return items.FirstOrDefault().Value;
                else
                    return null;
            });
            parameters.PrimaryKey = new string[] { "OrderID" };
            return parameters;
        }

        // GET: api/Orders/5
        [ResponseType(typeof(Order))]
        public async Task<IHttpActionResult> GetOrder(int id)
        {
            Order order = await db.Orders.FindAsync(id);
            if (order == null)
            {
                return NotFound();
            }

            return Ok(order);
        }
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool OrderExists(int id)
        {
            return db.Orders.Count(e => e.OrderID == id) > 0;
        }
    }
}