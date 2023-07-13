using AgileShop.Domain.Constants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgileShop.Service.Common.Helpers;

public class TimeHelpers
{
    public static DateTime GetDateTime()
    {
        var dtTime = DateTime.UtcNow;
        dtTime.AddHours(TimeConstants.UTC);
        return dtTime;
    }
}
