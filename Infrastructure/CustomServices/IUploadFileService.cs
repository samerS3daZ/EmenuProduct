using System;
using BCM.Infrastructure.Dtos;
using Microsoft.AspNetCore.Http;

namespace BCM.Infrastructure.CustomServices
{
    public interface IUploadFileService
    {
        Task<string> AddFile(IFormFile file, string Folder);
        bool DeleteFile(string filePath);
        

	}
}

