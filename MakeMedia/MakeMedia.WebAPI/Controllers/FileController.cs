using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using MakeMedia.Services;
using MakeMedia.WebAPI.DataContracts;

namespace MakeMedia.WebAPI.Controllers
{
    public class FileController : ApiController
    {
        protected readonly IFileService _fileService;
        public FileController(IFileService fileService)
        {
            _fileService = fileService;
        }

        [Route("api/File/GetFile")]
        [HttpGet]
        public IHttpActionResult GetFile(string fileName)
        {
            try {
                string content = _fileService.ReadFile(fileName);
                return Ok(content);
            }
            catch (Exception ex) { throw ex; }
        }

        [Route("api/File/WriteFile")]
        public IHttpActionResult WriteFile(WriteFileDataContract writeFileDC)
        {
            try
            {
                _fileService.SaveFile(writeFileDC.Filename, writeFileDC.FileContent);
                return Ok();
            }
            catch (Exception ex) { throw ex; }
        }
    }
}
