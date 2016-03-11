using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace Customer.Models
{
    public class MphoneAttribute : DataTypeAttribute
    {

        public MphoneAttribute() : base(DataType.Text)
        {
        }

        public override bool IsValid(object value)
        {
            var str = (string)value;
            if (string.IsNullOrEmpty(str))
            {
                return true;
            }
            else
            {
                Regex regex = new Regex(@"\d{4}-\d{6}");
                Match m = regex.Match(str);
                if (m.Success)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
    }



}