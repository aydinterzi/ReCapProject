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
    }
}
