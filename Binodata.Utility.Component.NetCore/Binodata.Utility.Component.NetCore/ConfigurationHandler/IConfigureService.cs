using System;
using System.Collections.Generic;
using System.Text;

namespace Binodata.Utility.Component.NetCore.ConfigurationHandler
{
    public interface IConfigureService
    {
        string GetConfigByKey(string key);
    }
}
