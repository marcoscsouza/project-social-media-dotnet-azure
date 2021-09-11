﻿using Domain.Interfaces.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ImageController : ControllerBase
    {
        [HttpPost]
        public async Task<IEnumerable<string>> Upload([FromServices] IBlobService blobService)
        {
            //valida content do request
            if (!Request.HasFormContentType)
                BadRequest();

            //inicia upload (assincronamente)
            var tasks = Request.Form.Files.Select(file =>
            {
                return blobService.UploadAsync(file.OpenReadStream());
            });

            //aguarda todas as tasks e devolve lista de uris
            return await Task.WhenAll(tasks);
        }
    }
}
