using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EkoRestaurant.Data;

namespace EkoRestaurant.Extensions
{
    public static class ListeDeCourseDisplayExtension
    {
        public static string GetCompletionStatus(this ListeDesCourses liste)
        {
            string res = liste.CreationDateTime.Nice();
            if (liste.IsCompleted)
            {
                res += " (terminée)";
            }
            return res;
        }

    }
}
