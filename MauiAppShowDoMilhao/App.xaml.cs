using MauiAppShowDoMilhao.Models;

namespace MauiAppShowDoMilhao
{
    public partial class App : Application
    {
        List<Pergunta> perguntas_faceis = new()
        {
            new Pergunta
            {
                id = 1,
                Enunciado = "Qual é o nome dado ao estado da água em forma de gelo?",
                Alternativas = new()
                {
                    new Alternativa { Correta = false, Descricao = "LÍQUIDO"},
                    new Alternativa { Correta = true, Descricao = "SÓLIDO"},
                    new Alternativa { Correta = false, Descricao = "GASOSO"},
                    new Alternativa { Correta = false, Descricao = "VAPOROSO"},
                }
            },
            new Pergunta
            {
                id = 2,
                Enunciado = "Quem é a namora do Mickey?",
                Alternativas = new()
                {
                    new Alternativa { Correta = false, Descricao = "MARGARIDA"},
                    new Alternativa { Correta = true, Descricao = "MINNIE"},
                    new Alternativa { Correta = false, Descricao = "A PEQUENA SEREIA"},
                    new Alternativa { Correta = false, Descricao = "OLÍVIA PALITO"},
                }
            },
            new Pergunta
            {
                id = 3,
                Enunciado = "Qual é o personagem do folclore brasiliero que tem uma perna só?",
                Alternativas = new()
                {
                    new Alternativa { Correta = false, Descricao = "CUCA"},
                    new Alternativa { Correta = false, Descricao = "NEGRINHO DO PASTOREIO"},
                    new Alternativa { Correta = false, Descricao = "BOITATÁ"},
                    new Alternativa { Correta = true, Descricao = "SACI-PERERÊ"},
                }
            },
            new Pergunta
            {
                id = 4,
                Enunciado = "Quem proclamou a república no Brasil em 1889?",
                Alternativas = new()
                {
                    new Alternativa { Correta = false, Descricao = "DUQUE DE CAXIAS"},
                    new Alternativa { Correta = false, Descricao = "MARECHAL RONDON"},
                    new Alternativa { Correta = true, Descricao = "DOM PEDRO II"},
                    new Alternativa { Correta = false, Descricao = "MARECHAL DEODORO"},
                }
            },
            new Pergunta
            {
                id = 5,
                Enunciado = "O que era o Frankenstein, de Mary Shelley?",
                Alternativas = new()
                {
                    new Alternativa { Correta = true, Descricao = "MONSTRO"},
                    new Alternativa { Correta = false, Descricao = "FORILA"},
                    new Alternativa { Correta = false, Descricao = "PRÍNCIPE"},
                    new Alternativa { Correta = false, Descricao = "SAPO"},
                }
            },
            new Pergunta
            {
                id = 6,
                Enunciado = "Qual é a cor que se associa com os grupos ecológicos?",
                Alternativas = new()
                {
                    new Alternativa { Correta = false, Descricao = "PRETA"},
                    new Alternativa { Correta = false, Descricao = "VERMELHA"},
                    new Alternativa { Correta = false, Descricao = "AZUL"},
                    new Alternativa { Correta = true, Descricao = "VERDE"},
                }
            },
            new Pergunta
            {
                id = 7,
                Enunciado = "A águaferve em quantos graus centógrados?",
                Alternativas = new()
                {
                    new Alternativa { Correta = false, Descricao = "200"},
                    new Alternativa { Correta = true, Descricao = "100"},
                    new Alternativa { Correta = false, Descricao = "170"},
                    new Alternativa { Correta = false, Descricao = "220"},
                }
            },
            new Pergunta
            {
                id = 8,
                Enunciado = "Quando é comemorado o dia da independência do Brasil?",
                Alternativas = new()
                {
                    new Alternativa { Correta = false, Descricao = "21 DE ABRIL"},
                    new Alternativa { Correta = false, Descricao = "12 DE OUTUBRO"},
                    new Alternativa { Correta = true, Descricao = "7 DE SETEMBRO"},
                    new Alternativa { Correta = false, Descricao = "25 DE DEZEMBRO"},
                }
            },
            new Pergunta
            {
                id = 9,
                Enunciado = "Quem tem por lema a frase 'Sempre alerta'?",
                Alternativas = new()
                {
                    new Alternativa { Correta = false, Descricao = "MÉDICOS"},
                    new Alternativa { Correta = true, Descricao = "ESCOTEIROS"},
                    new Alternativa { Correta = false, Descricao = "BOMBEIRO"},
                    new Alternativa { Correta = false, Descricao = "POLICIAIS"},
                }
            },
            new Pergunta
            {
                id = 10,
                Enunciado = "Quem foi o grande amor de Julieta?",
                Alternativas = new()
                {
                    new Alternativa { Correta = true, Descricao = "ROMEU"},
                    new Alternativa { Correta = false, Descricao = "ORFEU"},
                    new Alternativa { Correta = false, Descricao = "HAMLET"},
                    new Alternativa { Correta = false, Descricao = "IAGO"},
                }
            },
        }

        public App()
        {
            InitializeComponent();

            MainPage = new AppShell();
        }
    }
}
