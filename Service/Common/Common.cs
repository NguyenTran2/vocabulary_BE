using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Common
{
    public static class Common
    {
        public static DateTime MondayOfWeek(this DateTime date)
        {
            var dayOfWeek = date.DayOfWeek;

            if (dayOfWeek == DayOfWeek.Sunday)
            {
                //xét chủ nhật là đầu tuần thì thứ 2 là ngày kế tiếp nên sẽ tăng 1 ngày
                //return date.AddDays(1);

                // nếu xét chủ nhật là ngày cuối tuần
                return date.AddDays(-6);
            }

            // nếu không phải thứ 2 thì lùi ngày lại cho đến thứ 2
            int offset = dayOfWeek - DayOfWeek.Monday;
            return date.AddDays(-offset);
        }

        public static DateTime SaturdayOfWeek(this DateTime date)
        {
            return date.MondayOfWeek().AddDays(6);
        }
    }
}