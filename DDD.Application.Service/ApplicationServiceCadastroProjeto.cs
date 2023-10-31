using DDD.Domain.SecretariaContext;
using DDD.Domain.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD.Application.Service
{
    /// <summary>
    /// Classe responsável por orquestrar a geração de um boletim, chamando 
    /// os métodos da Domain Service e outros que não são 
    /// triviais para o domínio.
    /// 
    /// </summary>
    public class ApplicationServiceCadastroProjeto
    {
        readonly CadastroService _cadastroService;

        public ApplicationServiceCadastroProjeto(CadastroService cadastroService)
        {
            _cadastroService = cadastroService;
        }

        public void GerarCadastro(int AnosDuracao, string Titulacao, string setor)
        {

            var cadastroEfetuado = _cadastroService.GerarCadastro(int AnosDuracao, string Titulacao, string setor);
            if (cadastroEfetuado)
            {
                //Enviar email
            }
        }
    }
}
