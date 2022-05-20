using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace atividade2.Models
{
    public class PacotesTuristicos
    {
        public int idViagem {get;set;}

        public string NomeCliente {get;set;}

        public string Origem {get;set;}

        public string Destino {get;set;}

        public string Atrativos {get;set;}

        public DateTime Saida {get;set;}

        public DateTime Retorno{get;set;}

        public string usuario {get;set;}
    }
}