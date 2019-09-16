using Microsoft.AspNetCore.Mvc;
using QuickyBuy.Dominio.Contratos;
using QuickyBuy.Dominio.Entidades;
using System;

namespace QuickyBuy.Web.Controllers
{
    [Route("api/[Controller]")]
    public class UsuarioController:Controller
    {
        private readonly IUsuarioRepositorio _usuarioRepositorio;

        public UsuarioController(IUsuarioRepositorio usuarioRepositorio)
        {
            _usuarioRepositorio = usuarioRepositorio;
        }

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
                var usuarioRetorno = _usuarioRepositorio.Obter(usuario.Email, usuario.Senha);

                if(usuarioRetorno != null)
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
        public ActionResult Post([FromBody] Usuario usuario)
        {
            try
            {
                var usuarioCadastrado = _usuarioRepositorio.Obter(usuario.Email);
                if(usuarioCadastrado != null)                
                    return BadRequest("Usuario ja cadastrado no Sistema");

                _usuarioRepositorio.Adicionar(usuario);
                

                return Ok();
            }
            catch (Exception ex)
            {

                return BadRequest(ex.ToString());
            }
        }
    }
}
