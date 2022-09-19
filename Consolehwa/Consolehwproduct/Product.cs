using System;
using System.Collections.Generic;
using System.Text;

namespace Consolehwproduct
{
    enum category
    {
        a,b,c,d,e
    }
    internal class Product
    {
        int Product_id;
        string Product_name;
        float Price;
        DateTime DOM;
        category ca;

      public Product()
        {
            Product_id = 1001;
            Product_name = "Laptop";
            Price = 1000.45f;
            DOM = DateTime.Now;
            ca = category.d;
        }
        public Product(int p,string q,float r,DateTime s,category t)
        {
            Product_id = p;
            Product_name = q;
            Price = r;  
            DOM = s;
            ca = t;
        }

        public override string ToString()
        {
            return "the Product id is :" + Product_id + "\n Product name :" + Product_name + "\n" + "\n Price :" + Price + "\n DOM :" + DOM + "\n category:" + ca;
               
        }
        
          
        }




   
}
