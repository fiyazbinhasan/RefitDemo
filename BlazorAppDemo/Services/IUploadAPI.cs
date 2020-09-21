using Refit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorAppDemo.Services
{
    public interface IUploadAPI
    {
        [Multipart]
        [Post("/upload")]
        Task UploadPhoto([AliasAs("avatar")] StreamPart stream);
    }
}
