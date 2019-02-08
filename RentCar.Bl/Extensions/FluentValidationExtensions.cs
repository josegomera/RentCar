using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentCar.Bl.Extensions
{
    public static class FluentValidationExtensions
    {
        public static string ToMessage(this IList<ValidationFailure> errors)
        {
            var result = new StringBuilder();
            foreach (var error in errors)
            {
                result.AppendLine($"{error.ErrorMessage} {error.AttemptedValue}");
            }
            return result.ToString();
        }

        public static Dictionary<string, string> ToMessageDictionary(this IList<ValidationFailure> errors)
        {
            var result = new Dictionary<string, string>();
            foreach (var error in errors)
            {
                result.Add(error.PropertyName, error.ErrorMessage);
            }
            return result;
        }
    }
}
