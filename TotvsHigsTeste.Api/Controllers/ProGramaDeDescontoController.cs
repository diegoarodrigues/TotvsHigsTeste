using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using TotvsHigsTeste.Domain.Contracts.Services;
using Newtonsoft.Json;
using System.Net.Http;
using System.Net;
using System.Threading.Tasks;
using Newtonsoft.Json.Serialization;
using TotvsHigsTeste.Api.Models;

namespace TotvsHigsTeste.Api.Controllers
{
    [RoutePrefix("api/ProgramaDeDesconto")]
    public class ProGramaDeDescontoController : ApiController
    {
        private IProgramaDeDescontoService _service;

        public ProGramaDeDescontoController(IProgramaDeDescontoService service)
        {
            _service = service;
        }

        [HttpPost]
        [Route("Add")]
        public Task<HttpResponseMessage> AddProgramaDeDesconto(ProGramaDeDescontoModel model)
        {
            HttpResponseMessage response = new HttpResponseMessage();

            try
            {
                _service.Add(model.CodigoConsultor, model.NomeCliente, model.CpfCliente, model.DescontoId);
                response = Request.CreateResponse(HttpStatusCode.OK, "Cadastrado novo programa de cliente");
            }
            catch (Exception ex)
            {
                response = Request.CreateResponse(HttpStatusCode.BadRequest, ex.Message);
            }

            var tsc = new TaskCompletionSource<HttpResponseMessage>();
            tsc.SetResult(response);
            return tsc.Task;
        }

        [HttpGet]
        [Route("ListaDesconto")]
        public Task<HttpResponseMessage> get()
        {
            HttpResponseMessage response = new HttpResponseMessage();

            try
            {
                var descontos = _service.ListDesconto();

                var json = JsonConvert.SerializeObject(
                    descontos,
                    Formatting.None,
                    new JsonSerializerSettings { ContractResolver = new CamelCasePropertyNamesContractResolver() });

                response = Request.CreateResponse(HttpStatusCode.OK, _service.ListDesconto());
            }
            catch (Exception ex)
            {
                response = Request.CreateResponse(HttpStatusCode.BadRequest, ex.Message);
            }

            var tsc = new TaskCompletionSource<HttpResponseMessage>();
            tsc.SetResult(response);
            return tsc.Task;
        }

        protected override void Dispose(bool disposing)
        {
            _service.Dispose();
        }
    }
}