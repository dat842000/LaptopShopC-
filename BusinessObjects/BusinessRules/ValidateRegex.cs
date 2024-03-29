﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BusinessObjects.BusinessRules
{
    public class ValidateRegex : BusinessRule
    {
        protected string Pattern { get; set; }

        public ValidateRegex(string propertyName, string pattern)
            : base(propertyName)
        {
            Pattern = pattern;
        }

        public ValidateRegex(string propertyName, string errorMessage, string pattern)
            : this(propertyName, pattern)
        {
            Error = errorMessage;
        }

        public override bool Validate(BusinessObject businessObject)
        {
            return Regex.Match(GetPropertyValue(businessObject).ToString(), Pattern).Success;
        }
    }
}
