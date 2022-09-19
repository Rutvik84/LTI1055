using System;
using System.Collections.Generic;
using System.Text;

namespace consoleassmedicine
{   enum category
    {
        Orthopologist,cardiologist,ENT
    }

    internal class medicine
    {
        int medicine_id;
        String medicine_name;
        float Price;
        DateTime DOE;
        category ca;

        public  medicine()
        {
            medicine_id = 1004;
            medicine_name = "eye drops";
            Price = 128.06f;
            DOE = DateTime.Now;
            ca = 0;
        }

        public medicine(int a,string b,float c,DateTime d,category e)
        {
            medicine_id = a;
            medicine_name = b;
            Price = c;
            DOE = d;
            ca = e;
        }

        public override string ToString()
        {
            return "the medicine id is :" + medicine_id + "\n medicine name :" + medicine_name + "\n Price :" + Price + "\n" + DOE + "\n category" + ca;
        }


    }
}
