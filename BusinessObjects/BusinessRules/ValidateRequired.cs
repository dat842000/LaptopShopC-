using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObjects.BusinessRules
{
    public class ValidateRequired : BusinessRule
    {

        public ValidateRequired(string propertyName)
            : base(propertyName)
        {
            Error = propertyName + " is a required field.";
        }

        public ValidateRequired(string propertyName, string errorMessage)
            : base(propertyName)
        {
            Error = errorMessage;
        }

        public override bool Validate(BusinessObject businessObject)
        {
            try
            {
                return GetPropertyValue(businessObject).ToString().Length > 0;
            }
            catch
            {
                return false;
            }
        }
    }
}
