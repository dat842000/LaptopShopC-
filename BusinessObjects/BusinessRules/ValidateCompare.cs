﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObjects.BusinessRules
{
    public class ValidateCompare : BusinessRule
    {
        string OtherPropertyName { get; set; }
        ValidationDataType DataType { get; set; }
        ValidationOperator Operator { get; set; }

        public ValidateCompare(string propertyName, string otherPropertyName,
            ValidationOperator @operator, ValidationDataType dataType)
            : base(propertyName)
        {

            OtherPropertyName = otherPropertyName;
            Operator = @operator;
            DataType = dataType;

            Error = propertyName + " must be " + Operator.ToString() + " than " + otherPropertyName;
        }

        public ValidateCompare(string propertyName, string otherPropertyName, string errorMessage,
            ValidationOperator @operator, ValidationDataType dataType)
            : this(propertyName, otherPropertyName, @operator, dataType)
        {
            Error = errorMessage;
        }

        public override bool Validate(BusinessObject businessObject)
        {
            try
            {
                string propValue1 = businessObject.GetType().GetProperty(Property).GetValue(businessObject, null).ToString();
                string propValue2 = businessObject.GetType().GetProperty(OtherPropertyName).GetValue(businessObject, null).ToString();

                switch (DataType)
                {
                    case ValidationDataType.Integer:

                        int ival1 = int.Parse(propValue1);
                        int ival2 = int.Parse(propValue2);

                        switch (Operator)
                        {
                            case ValidationOperator.Equal: return ival1 == ival2;
                            case ValidationOperator.NotEqual: return ival1 != ival2;
                            case ValidationOperator.GreaterThan: return ival1 > ival2;
                            case ValidationOperator.GreaterThanEqual: return ival1 >= ival2;
                            case ValidationOperator.LessThan: return ival1 < ival2;
                            case ValidationOperator.LessThanEqual: return ival1 <= ival2;
                        }
                        break;

                    case ValidationDataType.Double:

                        double dval1 = double.Parse(propValue1);
                        double dval2 = double.Parse(propValue2);

                        switch (Operator)
                        {
                            case ValidationOperator.Equal: return dval1 == dval2;
                            case ValidationOperator.NotEqual: return dval1 != dval2;
                            case ValidationOperator.GreaterThan: return dval1 > dval2;
                            case ValidationOperator.GreaterThanEqual: return dval1 >= dval2;
                            case ValidationOperator.LessThan: return dval1 < dval2;
                            case ValidationOperator.LessThanEqual: return dval1 <= dval2;
                        }
                        break;

                    case ValidationDataType.Decimal:

                        decimal cval1 = decimal.Parse(propValue1);
                        decimal cval2 = decimal.Parse(propValue2);

                        switch (Operator)
                        {
                            case ValidationOperator.Equal: return cval1 == cval2;
                            case ValidationOperator.NotEqual: return cval1 != cval2;
                            case ValidationOperator.GreaterThan: return cval1 > cval2;
                            case ValidationOperator.GreaterThanEqual: return cval1 >= cval2;
                            case ValidationOperator.LessThan: return cval1 < cval2;
                            case ValidationOperator.LessThanEqual: return cval1 <= cval2;
                        }
                        break;

                    case ValidationDataType.Date:

                        DateTime tval1 = DateTime.Parse(propValue1);
                        DateTime tval2 = DateTime.Parse(propValue2);

                        switch (Operator)
                        {
                            case ValidationOperator.Equal: return tval1 == tval2;
                            case ValidationOperator.NotEqual: return tval1 != tval2;
                            case ValidationOperator.GreaterThan: return tval1 > tval2;
                            case ValidationOperator.GreaterThanEqual: return tval1 >= tval2;
                            case ValidationOperator.LessThan: return tval1 < tval2;
                            case ValidationOperator.LessThanEqual: return tval1 <= tval2;
                        }
                        break;

                    case ValidationDataType.String:

                        int result = string.Compare(propValue1, propValue2, StringComparison.CurrentCulture);

                        switch (Operator)
                        {
                            case ValidationOperator.Equal: return result == 0;
                            case ValidationOperator.NotEqual: return result != 0;
                            case ValidationOperator.GreaterThan: return result > 0;
                            case ValidationOperator.GreaterThanEqual: return result >= 0;
                            case ValidationOperator.LessThan: return result < 0;
                            case ValidationOperator.LessThanEqual: return result <= 0;
                        }
                        break;

                }
                return false;
            }
            catch { return false; }
        }
    }
}
