using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AgileShop.Service.Interfaces.Common;

public interface IFileService
{
    public Task<string> UploadImageAsync(IFormFile image);
    public Task<bool> DeleteImageAsync(string subpath);
    public Task<string> UploadAvatarAsync(IFormFile avater);
    public Task<bool> DeleteAvatarAsync(string subpath);
}
