﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD.Domain.PicContext
{
    public class CadastroProjetoPersistence
    {
        public int CadastroProjetoPersistenceId { get; set; }
        public Projeto Projeto { get; set; }

        public int PesquisadorId { get; set; }


    }
}
