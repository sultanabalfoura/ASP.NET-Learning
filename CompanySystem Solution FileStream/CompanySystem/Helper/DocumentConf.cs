using System;
namespace CompanySystem.PL.Helper
{
	public static class DocumentConf
	{
		public static string DocumentUpload(IFormFile file, string folderName)
		{
			string folderPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot","File", folderName);
			string fileName = $"{Guid.NewGuid()}{file.FileName}";
			string filePath = Path.Combine(folderPath, fileName);
			var fs = new FileStream(filePath, FileMode.Create);
			file.CopyTo(fs);

			return fileName;
		}

		public static void DocumentDelete(string fileName, string folderName)
		{
			if (fileName is not null)
			{
                string filePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "File", folderName);
				if (File.Exists(filePath))
				{
					File.Delete(filePath);
				}
            }
        }
	}
}

