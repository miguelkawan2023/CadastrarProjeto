using DDD.Domain.UserManagementContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD.Domain.PicContext
{
    public  class Pesquisador : User
    {
        public string Titulacao { get; set; }
        public List<Projeto> Projetos { get; set; }
    }
}
