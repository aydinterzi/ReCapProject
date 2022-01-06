using Core.Constants;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Helpers
{
    public class FileHelper
    {
        
        public static string AddImagetoFolder(IFormFile images)
        {
            string root = WebRootPath.ImagesPath;
            if (!Directory.Exists(root))
            {                         
                Directory.CreateDirectory(root);
            }
            var imgext = Path.GetExtension(images.FileName);
            var imageGuid = GuidHelper.GetGuid();
            var imageFile = imageGuid + imgext;
            using (var FileStream=File.Create(root+imageFile))
            {
                images.CopyTo(FileStream);
                FileStream.Flush();
                return imageFile;
            }
            
        }

        public static void DeleteImageFromFolder(string filePath)
        {
            if (File.Exists(filePath))
            {
                File.Delete(filePath);
            }
        }

        public static string Update(IFormFile file, string filePath)
        {

            if (File.Exists(filePath))// Tekrar if kontrolü ile parametrede gelen adreste öyle bir dosya var mı diye kontrol ediliyor.
            {
                File.Delete(filePath);//Eğer dosya var ise dosya bulunduğu yerden siliniyor.
            }
            return AddImagetoFolder(file);
        }
    }
}
