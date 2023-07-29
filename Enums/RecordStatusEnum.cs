using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeAccountingApplication.Enums
{
    public enum RecordStatusEnum
    {
        [Description("Действующая")]
        Current,
        [Description("Закрытая")]
        Closed
    }
}
