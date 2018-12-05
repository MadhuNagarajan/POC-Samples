using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakeMedia.Services
{
    public interface IFileService
    {
        bool SaveFile(string filename, string content);
        string ReadFile(string filename);
    }
}
