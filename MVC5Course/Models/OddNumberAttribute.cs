using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC5Course.Models
{
    public class OddNumberAttribute : DataTypeAttribute
    {
        public OddNumberAttribute() : base("OddNumber")
        {
            this.ErrorMessage = "此欄位需為偶數";
        }

        public override bool IsValid(object value)
        {
            if (value == null)
                return true;

            int num;
            if (int.TryParse(value.ToString(), out num))
                return num % 2 == 0;

            return false;
        }
    }
}