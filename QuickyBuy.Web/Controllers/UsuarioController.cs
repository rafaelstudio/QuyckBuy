using Microsoft.AspNetCore.Mvc;
using QuickyBuy.Dominio.Entidades;
using System;

namespace QuickyBuy.Web.Controllers
{
    [Route("api/[Controller]")]
    public class UsuarioController:Controller
    {

        [HttpGet]
        public ActionResult Get()
        {
            try
            {
                return Ok();
            }
            catch (Exception ex)
            {

                return BadRequest(ex.ToString());
            }
        }

        [HttpPost("VerificarUsuario")]
        public ActionResult VerificarUsuario([FromBody] Usuario usuario)
        {
            try
            {
                if(usuario.Email == "rafa@teste.com" && usuario.Senha == "1234")
                {
                    return Ok(usuario);
                }
                return BadRequest("Usuario ou Senha invalido");
            }
            catch (Exception ex)
            {

                return BadRequest(ex.ToString());
            }
        }


        [HttpPost]
        public ActionResult Post()
        {
            try
            {
                return Ok();
            }
            catch (Exception ex)
            {

                return BadRequest(ex.ToString());
            }
        }
    }
}
