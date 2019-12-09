using Estudo.NET.Models.Entidades.Enuns;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Estudo.NET.Models.Entidades
{
    public class Movimentacao
    {
        public int Id { get; set; }

        public decimal Valor { get; set; }

        public DateTime data { get; set; }

        public Tipo Tipo { get; set; }

        public int UsuarioId { get; set; }

        public Usuario Usuario { get; set; }
    }
}