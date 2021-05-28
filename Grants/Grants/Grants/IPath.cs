using System;
using System.Collections.Generic;
using System.Text;

namespace Grants
{
    public interface IPath
    {
        string GetDatabasePath(string filename);
    }
}
