using NSE.WebApp.MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NSE.WebApp.MVC.Services
{
    public interface IAutenticacaoService
    {
        public Task<UsuarioRespostaLogin> Registro(UsuarioRegistro usuarioRegistro);

        public Task<UsuarioRespostaLogin> Login(UsuarioLogin usuarioLogin);
    }
}
