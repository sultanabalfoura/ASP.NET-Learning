using System;
namespace CompanySystem.PL.Helper
{
	public static class DocumentConf
	{
		public static string DocumentUpload(IFormFile file, string fileName)
		{
			string folderPath = Path.Combine(Directory.GetCurrentDirectory(), "\\wwwroot\\File", fileName);

			return "";
		}
	}
}

