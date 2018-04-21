using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bolt.Addons.Community.Downloader.Integration
{
    interface IDownloadableContent
    {
        List<Uri> DownloadURIs { get; set; }

        Task<bool> Download();
    }
}
