using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qualtrics.Api.Helpers
{
    internal static class EnumHelper
    {
        internal static string GetFriendlyName(this Enum genericEnum)
        {
            var genericEnumType = genericEnum.GetType();
            var memberInfo = genericEnumType.GetMember(genericEnum.ToString());
            if (memberInfo != null && memberInfo.Length > 0)
            {
                var attrs = memberInfo[0].GetCustomAttributes(typeof(DescriptionAttribute), false);
                if (attrs != null && attrs.Count() > 0)
                    return ((DescriptionAttribute)attrs.ElementAt(0)).Description;
            }

            return genericEnum.ToString();
        }
    }
}
