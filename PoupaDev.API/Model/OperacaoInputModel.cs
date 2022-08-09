using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PoupaDev.API.Enums;

namespace PoupaDev.API.Model
{
    public class OperacaoInputModel
    {
        public decimal Valor { get; set; }
        public TipoOperacao Tipo { get; set; }  
    }
}