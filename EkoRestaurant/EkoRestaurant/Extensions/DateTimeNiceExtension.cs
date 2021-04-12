using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MudBlazor.Extensions;

namespace EkoRestaurant.Extensions
{
    public static class DateTimeNiceExtension
    {
        public static string Nice(this DateTime? date)
        {
            if (!date.HasValue)
                return "";

            var res = date.Value.Day + "/";
            res += date.Value.Month + "/";
            res += date.Value.Year;
            return res;
        }

    }
}
