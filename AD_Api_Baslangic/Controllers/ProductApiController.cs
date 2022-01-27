using AD_Api_Baslangic.Models.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Mvc;

namespace AD_Api_Baslangic.Controllers
{
    public class ProductApiController : ApiController
    {
        Context db = new Context();

        //Database'deki tüm ürünleri getirir
        public IEnumerable<Product> GetAll()
        {
            return db.Products.ToList();
        }


        //Şarta bağlı bir ürün getirmek için
        public IHttpActionResult GetProduct(int id) {
           var model =db.Products.FirstOrDefault(x => x.ProductId == id);
            if (model != null)
            {
                return Ok(model);
            }
            else
            {
                return NotFound();
            }
        
        }


        //Ürün Silme
        public IHttpActionResult GetDelete(int id)
        {
            var model = db.Products.FirstOrDefault(x => x.ProductId == id);
            if (model != null)
            {
                db.Products.Remove(model);
                db.SaveChanges();
                return Ok("Ürün silindi");
            }
            else
            {
                return NotFound();
            }
            
        }
    }
}
