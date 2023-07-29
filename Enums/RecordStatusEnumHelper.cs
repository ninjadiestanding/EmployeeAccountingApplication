using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeAccountingApplication.Enums
{
    public class RecordStatusEnumHelper
    {
        public RecordStatusEnum GetEnumFromDescription(string description)
        {
            foreach (RecordStatusEnum value in Enum.GetValues(typeof(RecordStatusEnum)))
            {
                var fieldInfo = value.GetType().GetField(value.ToString());
                var descriptionAttribute = (DescriptionAttribute)Attribute.GetCustomAttribute(fieldInfo, typeof(DescriptionAttribute));

                if (descriptionAttribute != null && descriptionAttribute.Description == description)
                {
                    return value;
                }
            }

            return RecordStatusEnum.Current;
        }

        public string GetDescriptionFromEnum(Enum value)
        {
            var fieldInfo = value.GetType().GetField(value.ToString());
            var descriptionAttribute = (DescriptionAttribute)Attribute.GetCustomAttribute(fieldInfo,
                typeof(DescriptionAttribute));

            return descriptionAttribute.Description;
        }
    }
}
