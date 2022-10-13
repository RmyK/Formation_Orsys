using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DirectiveEtAttribut
{
    internal static class EnumExtension
    {
        public static string GetDescription(this Enum val)
        {
            return typeof(Enum).GetMember(val.ToString()).FirstOrDefault()?.GetCustomAttribute<DescriptionAttribute>().Description;
        }
    }
}
