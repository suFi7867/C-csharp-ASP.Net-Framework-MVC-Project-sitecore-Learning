using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PurchaseSystem.Models
{
    public class ProductType
    {
        public int pk_prodtypeId {  get; set; }
        public string Description { get; set; }
    }
}



// 1 ) created model class , defined ProductType 
// 2 ) created controller , defined one List<ProductType> using this model class created dummy data returned ProductList in View ,
// right click on controller file , select add View it will create a folder in view and will create chtml file

// after adding controller and then created added view then 