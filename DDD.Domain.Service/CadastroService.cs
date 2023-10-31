using DDD.Domain.PicContext;
using DDD.Domain.SecretariaContext;
using DDD.Infra.SQLServer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD.Domain.Service
{
    public class CadastroService
    {
        readonly IPesquisadorRepository _pesquisadorRepository;
        readonly IProjetoRepository _projetoRepository;

        public CadastroService(IPesquisadorRepository pesquisadorRepository, IProjetoRepository projetoRepository)
        {
            _pesquisadorRepository = pesquisadorRepository;
            _projetoRepository = projetoRepository;
        }



        /// <summary>
        /// Ao gerar o boletim devemos fazer um check para verificar
        /// se cada uma das disciplinas a serem geradas no boletim
        /// de fato está vinculada para aquele aluno e Disponível 
        /// </summary>
        /// <param name="cadastroProjetos"></param>
        /// <returns></returns>
        public bool GerarCadastroProjeto(Projeto cadastroProjetos, int idPesquisador, int idProjeto)
        {
            try
            {
                Projeto projeto = new Projeto();
                var pesquisador = _pesquisadorRepository.GetPesquisadorById(idPesquisador);
                var tit = pesquisador.Titulacao;
                var proj = _projetoRepository.GetProjetosById(idProjeto);
                var set = proj.Setor;
                
                CadastroProjetoPersistence cadastroPersistence = new CadastroProjetoPersistence();

                foreach (var item in cadastroProjetos)
                {
                    var teste = disciplinasMatriculadas.FirstOrDefault(x => x.DisciplinaId == item.IdDisciplina);
                    if (teste != null)
                    {
                        cadastroPersistence.Aluno = aluno;
                        cadastroPersistence.DisciplinaId = item.IdDisciplina;
                        cadastroPersistence.Nota = item.Nota;
                        //boletim.Notas.Add(item.IdDisciplina, item.Nota);
                    }
                    _pesquisadorRepository.PersistirCadastro(cadastroPersistence);
                }




                return true;
            }
            catch (Exception ex)
            {
                var erro = ex.Message;
                throw;
            }

        }

    }
}