using PurchaseSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PurchaseSystem.Controllers
{
    public class productTypeController : Controller
    {
        // GET: productType/List
        public ActionResult List()
        {
            List<ProductType> ProductTypeList = new List<ProductType>()
            {
                new ProductType(){pk_prodtypeId=1,Description="Open Product"},
                new ProductType(){pk_prodtypeId=3,Description="Close Product"},
                new ProductType(){pk_prodtypeId=3,Description="Cloth Product"}
            };
            return View(ProductTypeList);
            //return Content("Hello word") // will return this String in View 
           // return HttpNotFound("Hello word") // will load nod found page with passed string
           // return RedirectToAction("Index" , "Home", new {id=1, fk_prodtypeId=2})
                // so whenver we go on route /productType/List and render this view it will redirect to /Home/Index/1?fk_prodtypeId=2
        }
    }
}

/// after creating controller right click on file and click on ADD VIEW then select Layout 
/// it will create folder in Views using class name productTypeController will create productType folder and will create List.chtml file 
/// 
// Action Result types 
//     Type           HelperMethod 
// 1 ) ViewResult  >    View()
// 2 ) PartialViewResult  > PartialView() = use when parital view return or reusable comp
// 3 ) ContentResult >   Content()        = use when return String
// 4 ) RedirectResult >   = Redirect()    = user need to redirect on particular URL 
// 5 ) RedirectToRouteResult  >   RedirectToAction() = using this we can redirect Action 
// 6 ) JsonResult >   Json()               = usiing this we can return seralize or js object
// 7 ) FileResult >   File()             = using action we can result File
// 8 ) HttpNotFoundResult >   HttpNotFound() = using this Not FOund or 404 error we can return  
// 9 ) EmptyResult      = no returns
