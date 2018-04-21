using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bolt.Addons.Community.Downloader.Integration
{
    public interface DownloadModule
    {
        string ModuleName { get; }
    }
}