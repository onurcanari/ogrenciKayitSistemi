using Dropbox.Api;
using Dropbox.Api.Files;

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OgrenciKayitSistemi
{
    class VeritabaniEsitle
    {
        static string yol = @"db\veritabani.sqlite";
        public static async Task Esitle()
        {
            using (var dbx = new DropboxClient("Mmm7hGJ5NxoAAAAAAAAyi9WIIrDABH8hqWrXCNVcBK3u7HcwSPjwo7gM-Z8eTumf"))
            {
                using (FileStream fs = File.OpenRead(yol))
                {
                    var yukle = await dbx.Files.UploadAsync(yol,
                        mode: WriteMode.Overwrite.Instance,
                        autorename: false,
                        body: fs);
                }
            }
        }
        static async Task SiteyeYukle()
        {
            
        }
    }
}
