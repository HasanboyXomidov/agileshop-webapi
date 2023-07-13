using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgileShop.Service.Common.Helpers;

public class MediaHelper
{
    public static string MakeImageName(string filename)
    {
        FileInfo fileInfo = new FileInfo(filename);
        string extension=fileInfo.Extension;
        string name = "IMG_" + Guid.NewGuid() + extension;
        return name;
    }
}
