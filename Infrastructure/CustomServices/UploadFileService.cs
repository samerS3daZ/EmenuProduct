using BCM.Infrastructure;
using BCM.Infrastructure.Dtos;
using BCM.Infrastructure.Helpers;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;

namespace BCM.Infrastructure.CustomServices
{
	public class UploadFileService : IUploadFileService
	{

		private readonly IHostingEnvironment _hosting;
		public UploadFileService(IHostingEnvironment hosting)
		{
			_hosting = hosting;
		}

		public async Task<string> AddFile(IFormFile file, string Folder)
		{
			try
			{
                if (file == null)
                    return null;

                var uploadPath = $"files/{Folder}";
                var uploadFolder = Path.Combine(_hosting.WebRootPath, uploadPath);
                if (!Directory.Exists(uploadFolder))
                {
                    Directory.CreateDirectory(uploadFolder);
                }
                var uniqueFileName = $"{Guid.NewGuid().ToString().Substring(0, 6)}__FILENAME__{file.FileName}";
                var filepath = Path.Combine(uploadFolder, uniqueFileName);
                await using var fileStream = new FileStream(filepath, FileMode.Create);
                await file.CopyToAsync(fileStream);

                return $"{uploadPath}/{uniqueFileName}";
            }
			catch (Exception ex)
			{
				return "";
			}
			
		}

		public bool DeleteFile(string filePath)
		{
			try
			{
				var path = Path.Combine(_hosting.WebRootPath, filePath);

				if (File.Exists(path))
				{
					File.Delete(path);
				}
				return true;
			}
			catch (Exception ex)
			{
				return false;
			}
		}

		
	}
}

