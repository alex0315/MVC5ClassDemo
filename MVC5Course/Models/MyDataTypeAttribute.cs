using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC5Course.Models
{
    public class MyDataTypeAttribute : DataTypeAttribute
    {
        public MyDataTypeAttribute()
            : base("MyDataType")
        {
        }

        public override bool IsValid(object value)
        {
            int parse;
            if (int.TryParse(value.ToString(), out parse))
            {
                return parse % 2 == 0;
            }   
            return false;
        }
    }
}