using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiAppShowDoMilhao.Models
{
    internal class Pergunta
    {
        public int id { get; set; }
        public string Enunciado { get; set; }
        public List<Alternativa> Alternativas { get; set; }
    }
}
