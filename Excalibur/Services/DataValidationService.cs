using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Excalibur.Models.BabylonDb;

namespace Excalibur.Services
{
    public class DataValidationService
    {
        public bool ValidateSourceValue(source_value sValue)
        {
            throw new NotImplementedException();
        }

        private bool Compare<T>(string op, T left, T right) where T : IComparable
        {
            switch (op)
            {
                case "==": return left.CompareTo(right) == 0;
                case "!=": return left.CompareTo(right) != 0;
                case ">": return left.CompareTo(right) > 0;
                case ">=": return left.CompareTo(right) >= 0;
                case "<": return left.CompareTo(right) < 0;
                case "<=": return left.CompareTo(right) <= 0;

                default:
                    return false;
            }
        }
    }
}