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
                Enunciado = "Quem é a namorada do Mickey?",
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
                Enunciado = "A água ferve em quantos graus centógrados?",
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
            new Pergunta
            {
                id = 11,
                Enunciado = "Quantos signos formam o zodíaco?",
                Alternativas = new()
                {
                    new Alternativa { Correta = false, Descricao = "NOVE"},
                    new Alternativa { Correta = false, Descricao = "DEZ"},
                    new Alternativa { Correta = false, Descricao = "ONZE"},
                    new Alternativa { Correta = true, Descricao = "DOZE"},
                }
            },
            new Pergunta
            {
                id = 12,
                Enunciado = "Como se chama o lugar onde são armazenadas as vbalas de um revólver?",
                Alternativas = new()
                {
                    new Alternativa { Correta = false, Descricao = "CANO"},
                    new Alternativa { Correta = true, Descricao = "TAMBOR"},
                    new Alternativa { Correta = false, Descricao = "AGULHA"},
                    new Alternativa { Correta = false, Descricao = "GATILHO"},
                }
            },
            new Pergunta
            {
                id = 13,
                Enunciado = "Qual personagem da turma da Mônica tem apenas cinco fios de cabelo?",
                Alternativas = new()
                {
                    new Alternativa { Correta = false, Descricao = "MÔNICA"},
                    new Alternativa { Correta = true, Descricao = "CEBOLINHA"},
                    new Alternativa { Correta = false, Descricao = "CASCÃO"},
                    new Alternativa { Correta = false, Descricao = "MAGALI"},
                }
            },
            new Pergunta
            {
                id = 14,
                Enunciado = "Quem é o criador dos personagens Pedrinho, Narizinho e Emília?",
                Alternativas = new()
                {
                    new Alternativa { Correta = false, Descricao = "MAURÍCIO DE SOUSA"},
                    new Alternativa { Correta = false, Descricao = "ZIRALDO"},
                    new Alternativa { Correta = true, Descricao = "MONTEIRO LOBATO"},
                    new Alternativa { Correta = false, Descricao = "MACHADO DE ASSIS"},
                }
            },
            new Pergunta
            {
                id = 15,
                Enunciado = "Quem fundou a Microsoft?",
                Alternativas = new()
                {
                    new Alternativa { Correta = false, Descricao = "SULTÃO DE BRUNEI"},
                    new Alternativa { Correta = false, Descricao = "AKIO MORITA"},
                    new Alternativa { Correta = true, Descricao = "BILL GATES"},
                    new Alternativa { Correta = false, Descricao = "PRÍNCIPE CHARLES"},
                }
            },
            new Pergunta
            {
                id = 16,
                Enunciado = "Qual é o nome dado ao pneu reserva do carro?",
                Alternativas = new()
                {
                    new Alternativa { Correta = false, Descricao = "CALOTA"},
                    new Alternativa { Correta = true, Descricao = "ESTEPE"},
                    new Alternativa { Correta = false, Descricao = "MACACO"},
                    new Alternativa { Correta = false, Descricao = "CHAVE DE RODA"},
                }
            },
            new Pergunta
            {
                id = 17,
                Enunciado = "Qual é o nome do cachorro medroso do Salsicha, dos desenhos animados?",
                Alternativas = new()
                {
                    new Alternativa { Correta = false, Descricao = "FLOQUINHO"},
                    new Alternativa { Correta = false, Descricao = "RIN-TIN-TIN"},
                    new Alternativa { Correta = false, Descricao = "LASSIE"},
                    new Alternativa { Correta = true, Descricao = "SCOOBY-DOO"},
                }
            },
            new Pergunta
            {
                id = 18,
                Enunciado = "Como se cahma o lugar onde se guardam vinhos?",
                Alternativas = new()
                {
                    new Alternativa { Correta = true, Descricao = "ADEGA"},
                    new Alternativa { Correta = false, Descricao = "BIBLIOTECA"},
                    new Alternativa { Correta = false, Descricao = "SÓTÃO"},
                    new Alternativa { Correta = false, Descricao = "SALA"},
                }
            },
            new Pergunta
            {
                id = 19,
                Enunciado = "Qual cantor ficou conhecido como 'o rei do rock'?",
                Alternativas = new()
                {
                    new Alternativa { Correta = false, Descricao = "FRANK SINATRA"},
                    new Alternativa { Correta = false, Descricao = "LITTLE RICHARD"},
                    new Alternativa { Correta = true, Descricao = "ELVIS PRESLEY"},
                    new Alternativa { Correta = false, Descricao = "RICHIE VALENS"},
                }
            },
            new Pergunta
            {
                id = 20,
                Enunciado = "Quem é o inimigo do Piu-Piu nos desenhos animados?",
                Alternativas = new()
                {
                    new Alternativa { Correta = false, Descricao = "LÉLIX"},
                    new Alternativa { Correta = false, Descricao = "TOM"},
                    new Alternativa { Correta = true, Descricao = "FRAJOLA"},
                    new Alternativa { Correta = false, Descricao = "MINGAU"},
                }
            },
        };
        List<Pergunta> perguntas_medias = new()
        {
            new Pergunta
            {
                id = 1,
                Enunciado = "Quantos jogadores um jogo de vôlei reúne na quadra?",
                Alternativas = new()
                {
                    new Alternativa { Correta = false, Descricao = "SEIS"},
                    new Alternativa { Correta = false, Descricao = "OITO"},
                    new Alternativa { Correta = false, Descricao = "DEZ"},
                    new Alternativa { Correta = true, Descricao = "DOZE"},
                }
            },
            new Pergunta
            {
                id = 2,
                Enunciado = "Qual é o país do tango?",
                Alternativas = new()
                {
                    new Alternativa { Correta = false, Descricao = "URUGUAI"},
                    new Alternativa { Correta = true, Descricao = "ARGENTINA"},
                    new Alternativa { Correta = false, Descricao = "PARAGUAI"},
                    new Alternativa { Correta = false, Descricao = "ESPANHA"},
                }
            },
            new Pergunta
            {
                id = 3,
                Enunciado = "Que imperdor pôs fogo em Roma?",
                Alternativas = new()
                {
                    new Alternativa { Correta = false, Descricao = "TRAJANO"},
                    new Alternativa { Correta = true, Descricao = "NERO"},
                    new Alternativa { Correta = false, Descricao = "BRUTUS"},
                    new Alternativa { Correta = false, Descricao = "CALÍGULA"},
                }
            },
            new Pergunta
            {
                id = 4,
                Enunciado = "A cidade de Pompéia, que foi soterrada por um vulcão fica em qual desses países?",
                Alternativas = new()
                {
                    new Alternativa { Correta = false, Descricao = "JAPÃO"},
                    new Alternativa { Correta = false, Descricao = "MÉXICO"},
                    new Alternativa { Correta = true, Descricao = "ITÁLIA"},
                    new Alternativa { Correta = false, Descricao = "ESTADOS UNIDOS"},
                }
            },
            new Pergunta
            {
                id = 5,
                Enunciado = "O que é um oboé?",
                Alternativas = new()
                {
                    new Alternativa { Correta = false, Descricao = "VULCÃO"},
                    new Alternativa { Correta = false, Descricao = "COMIDA"},
                    new Alternativa { Correta = true, Descricao = "INSTRUMENTO MUSICAL"},
                    new Alternativa { Correta = false, Descricao = "TRIBO INDÍGENA"},
                }
            },
            new Pergunta
            {
                id = 6,
                Enunciado = "Como eram chmados os polotos suicidas do Sagunda Guerra?",
                Alternativas = new()
                {
                    new Alternativa { Correta = true, Descricao = "CAMICASES"},
                    new Alternativa { Correta = false, Descricao = "SASHIMIS"},
                    new Alternativa { Correta = false, Descricao = "HARAQUIRIS"},
                    new Alternativa { Correta = false, Descricao = "SUMÔS"},
                }
            },
            new Pergunta
            {
                id = 7,
                Enunciado = "Sashimi é um prato originário de qual país?",
                Alternativas = new()
                {
                    new Alternativa { Correta = true, Descricao = "JAPÃO"},
                    new Alternativa { Correta = false, Descricao = "CHINA"},
                    new Alternativa { Correta = false, Descricao = "ÍNDIA"},
                    new Alternativa { Correta = false, Descricao = "INDONÉSIA"},
                }
            },
            new Pergunta
            {
                id = 8,
                Enunciado = "O alpinismo é praticado em que lugar?",
                Alternativas = new()
                {
                    new Alternativa { Correta = false, Descricao = "MAR"},
                    new Alternativa { Correta = true, Descricao = "MONTANHA"},
                    new Alternativa { Correta = false, Descricao = "RIO"},
                    new Alternativa { Correta = false, Descricao = "PRAIA"},
                }
            },
            new Pergunta
            {
                id = 9,
                Enunciado = "O Coliseu é um monumento histórico de que cidade europeia?",
                Alternativas = new()
                {
                    new Alternativa { Correta = false, Descricao = "PARIS"},
                    new Alternativa { Correta = false, Descricao = "COPENHAGUE"},
                    new Alternativa { Correta = true, Descricao = "ROMA"},
                    new Alternativa { Correta = false, Descricao = "LONDRES"},
                }
            },
            new Pergunta
            {
                id = 10,
                Enunciado = "Qual é o ponto mais alto da Terra?",
                Alternativas = new()
                {
                    new Alternativa { Correta = true, Descricao = "EVEREST"},
                    new Alternativa { Correta = false, Descricao = "MONTE SANAI"},
                    new Alternativa { Correta = false, Descricao = "MONTE CASTELO"},
                    new Alternativa { Correta = false, Descricao = "MONT BLANC"},
                }
            },
            new Pergunta
            {
                id = 11,
                Enunciado = "Quantos quilates tem o ouro puro?",
                Alternativas = new()
                {
                    new Alternativa { Correta = false, Descricao = "18"},
                    new Alternativa { Correta = false, Descricao = "20"},
                    new Alternativa { Correta = true, Descricao = "24"},
                    new Alternativa { Correta = false, Descricao = "30"},
                }
            },
            new Pergunta
            {
                id = 12,
                Enunciado = "Qual a sigla da Oranização das Nações Unidas?",
                Alternativas = new()
                {
                    new Alternativa { Correta = true, Descricao = "ONU"},
                    new Alternativa { Correta = false, Descricao = "FMI"},
                    new Alternativa { Correta = false, Descricao = "CIA"},
                    new Alternativa { Correta = false, Descricao = "OTAN"},
                }
            },
            new Pergunta
            {
                id = 13,
                Enunciado = "No filme, quem era parceiro de crimes da Bonnie?",
                Alternativas = new()
                {
                    new Alternativa { Correta = false, Descricao = "BILL"},
                    new Alternativa { Correta = true, Descricao = "CLYDE"},
                    new Alternativa { Correta = false, Descricao = "JAMES"},
                    new Alternativa { Correta = false, Descricao = "BUTCH"},
                }
            },
            new Pergunta
            {
                id = 14,
                Enunciado = "Quem é o parceiro de aventuras de Dom Quixote?",
                Alternativas = new()
                {
                    new Alternativa { Correta = true, Descricao = "SANCHO PANÇA"},
                    new Alternativa { Correta = false, Descricao = "GUILHERME TELL"},
                    new Alternativa { Correta = false, Descricao = "SIGMUND FREUD"},
                    new Alternativa { Correta = false, Descricao = "LANCELOT"},
                }
            },
            new Pergunta
            {
                id = 15,
                Enunciado = "Que planta era usada para favricação de papel no antigo Egito?",
                Alternativas = new()
                {
                    new Alternativa { Correta = true, Descricao = "PAPIRO"},
                    new Alternativa { Correta = false, Descricao = "EUCALIPTO"},
                    new Alternativa { Correta = false, Descricao = "OLIVEIRA"},
                    new Alternativa { Correta = false, Descricao = "MILHO"},
                }
            },
            new Pergunta
            {
                id = 16,
                Enunciado = "Que país europeu tem como atração a tourada?",
                Alternativas = new()
                {
                    new Alternativa { Correta = true, Descricao = "ESPANHA"},
                    new Alternativa { Correta = false, Descricao = "ITÁLIA"},
                    new Alternativa { Correta = false, Descricao = "FRANÇA"},
                    new Alternativa { Correta = false, Descricao = "ALEMANHA"},
                }
            },
            new Pergunta
            {
                id = 17,
                Enunciado = "Quem pintou o quadro 'La Gioconda', conhecido como 'Mona Lisa'?",
                Alternativas = new()
                {
                    new Alternativa { Correta = true, Descricao = "LEONARDO DA VINCI"},
                    new Alternativa { Correta = false, Descricao = "TICANO"},
                    new Alternativa { Correta = false, Descricao = "RAFAEL"},
                    new Alternativa { Correta = false, Descricao = "MICHELÂNCELO"},
                }
            },
            new Pergunta
            {
                id = 18,
                Enunciado = "Qual o nome do vulcão que sepultou cidades na Itália no ano de 79?",
                Alternativas = new()
                {
                    new Alternativa { Correta = false, Descricao = "VÊNUS"},
                    new Alternativa { Correta = true, Descricao = "VESÚVIO"},
                    new Alternativa { Correta = false, Descricao = "VARSÓVIA"},
                    new Alternativa { Correta = false, Descricao = "VENEZA"},
                }
            },
            new Pergunta
            {
                id = 19,
                Enunciado = "Qual a letra no alfabeto que simboliza o número dez em algarismo romano?",
                Alternativas = new()
                {
                    new Alternativa { Correta = false, Descricao = "V"},
                    new Alternativa { Correta = false, Descricao = "D"},
                    new Alternativa { Correta = false, Descricao = "L"},
                    new Alternativa { Correta = true, Descricao = "X"},
                }
            },
            new Pergunta
            {
                id = 20,
                Enunciado = "Em que continente se situa o rio Nilo?",
                Alternativas = new()
                {
                    new Alternativa { Correta = true, Descricao = "AFRICANO"},
                    new Alternativa { Correta = false, Descricao = "EUROPEU"},
                    new Alternativa { Correta = false, Descricao = "AMERICANO"},
                    new Alternativa { Correta = false, Descricao = "ASIÁTICO"},
                }
            },
        };
        List<Pergunta> perguntas_dificeis = new()
        {
            new Pergunta
            {
                id = 1,
                Enunciado = "Em que espécie o macho choca os ovos e a fêmea procura alimento?",
                Alternativas = new()
                {
                    new Alternativa { Correta = false, Descricao = "ANDORINHA"},
                    new Alternativa { Correta = false, Descricao = "PATO SELVAGEM"},
                    new Alternativa { Correta = true, Descricao = "PINGUIM"},
                    new Alternativa { Correta = false, Descricao = "MARRECO"},
                }
            },
            new Pergunta
            {
                id = 2,
                Enunciado = "Qual desses países não fica na Ásia?",
                Alternativas = new()
                {
                    new Alternativa { Correta = false, Descricao = "PAQUISTÃO"},
                    new Alternativa { Correta = false, Descricao = "JAPÃO"},
                    new Alternativa { Correta = false, Descricao = "TAILÂNDIA"},
                    new Alternativa { Correta = true, Descricao = "EGITO"},
                }
            },
            new Pergunta
            {
                id = 3,
                Enunciado = "Qual é a primeir letra do alfabeto grego?",
                Alternativas = new()
                {
                    new Alternativa { Correta = false, Descricao = "DELTA"},
                    new Alternativa { Correta = false, Descricao = "BETA"},
                    new Alternativa { Correta = true, Descricao = "ALFA"},
                    new Alternativa { Correta = false, Descricao = "GAMA"},
                }
            },
            new Pergunta
            {
                id = 4,
                Enunciado = "Qual desses quatro pesos é o mais leve?",
                Alternativas = new()
                {
                    new Alternativa { Correta = false, Descricao = "10 ONÇAS"},
                    new Alternativa { Correta = true, Descricao = "10 GRAMAS"},
                    new Alternativa { Correta = false, Descricao = "10 QUILOS"},
                    new Alternativa { Correta = false, Descricao = "10 LIBRAS"},
                }
            },
            new Pergunta
            {
                id = 5,
                Enunciado = "Que ramo da pecuária ocupa-se de bodes e cabras?",
                Alternativas = new()
                {
                    new Alternativa { Correta = false, Descricao = "ASININO"},
                    new Alternativa { Correta = true, Descricao = "CAPRINO"},
                    new Alternativa { Correta = false, Descricao = "BUFALINO"},
                    new Alternativa { Correta = false, Descricao = "MUAR"},
                }
            },
            new Pergunta
            {
                id = 6,
                Enunciado = "O trapézio é um músculo que está situado?",
                Alternativas = new()
                {
                    new Alternativa { Correta = true, Descricao = "NO PESCOÇO"},
                    new Alternativa { Correta = false, Descricao = "NO OMBRO"},
                    new Alternativa { Correta = false, Descricao = "NA CABEÇA"},
                    new Alternativa { Correta = false, Descricao = "NO BRAÇO"},
                }
            },
            new Pergunta
            {
                id = 7,
                Enunciado = "Que comflito ideológico envolveu o s EUA e a União Soviética?",
                Alternativas = new()
                {
                    new Alternativa { Correta = true, Descricao = "GUERRA FRIA"},
                    new Alternativa { Correta = false, Descricao = "GUERRA DO VIETNÃ"},
                    new Alternativa { Correta = false, Descricao = "GUERRA NAS ESTRELHAS"},
                    new Alternativa { Correta = false, Descricao = "GUERRA DA CORÉIA"},
                }
            },
            new Pergunta
            {
                id = 8,
                Enunciado = "Qual o símbolo químico do radônio?",
                Alternativas = new()
                {
                    new Alternativa { Correta = false, Descricao = "Rr"},
                    new Alternativa { Correta = false, Descricao = "Rd"},
                    new Alternativa { Correta = true, Descricao = "Rn"},
                    new Alternativa { Correta = false, Descricao = "Ro"},
                }
            },
            new Pergunta
            {
                id = 9,
                Enunciado = "Como é chamada a bola de gelo e poeira que orbita em torno do sol?",
                Alternativas = new()
                {
                    new Alternativa { Correta = true, Descricao = "COMETA"},
                    new Alternativa { Correta = false, Descricao = "METEORITO"},
                    new Alternativa { Correta = false, Descricao = "CAMAD DE OXÔNIO"},
                    new Alternativa { Correta = false, Descricao = "ESTRELA D'ALVA"},
                }
            },
            new Pergunta
            {
                id = 10,
                Enunciado = "A eletrônica é parte de qual ciência?",
                Alternativas = new()
                {
                    new Alternativa { Correta = true, Descricao = "FÍSICA"},
                    new Alternativa { Correta = false, Descricao = "BIOLOGIA"},
                    new Alternativa { Correta = false, Descricao = "QUÍMICA"},
                    new Alternativa { Correta = false, Descricao = "BOTÂNICA"},
                }
            },
            new Pergunta
            {
                id = 11,
                Enunciado = "A Bélgica é:",
                Alternativas = new()
                {
                    new Alternativa { Correta = true, Descricao = "UMA RAPÚBLICA"},
                    new Alternativa { Correta = false, Descricao = "UMA MONARQUIA CONSTITUICIONAL"},
                    new Alternativa { Correta = false, Descricao = "UM EMIRADO"},
                    new Alternativa { Correta = false, Descricao = "UM PRINCIPADO"},
                }
            },
            new Pergunta
            {
                id = 12,
                Enunciado = "Qual figura mitológica é conhecida por sua força extraordinária?",
                Alternativas = new()
                {
                    new Alternativa { Correta = false, Descricao = "ÁTILA"},
                    new Alternativa { Correta = false, Descricao = "MINOTAURO"},
                    new Alternativa { Correta = false, Descricao = "PERSEU"},
                    new Alternativa { Correta = true, Descricao = "HÉRCULES"},
                }
            },
            new Pergunta
            {
                id = 13,
                Enunciado = "Que símbolo está desenhado no centro da bandeira Argentina?",
                Alternativas = new()
                {
                    new Alternativa { Correta = true, Descricao = "SOL"},
                    new Alternativa { Correta = false, Descricao = "LUA"},
                    new Alternativa { Correta = false, Descricao = "ESTRELA"},
                    new Alternativa { Correta = false, Descricao = "FOICE E MARTELO"},
                }
            },
            new Pergunta
            {
                id = 14,
                Enunciado = "De quem é a frase 'Penso, logo existo?",
                Alternativas = new()
                {
                    new Alternativa { Correta = false, Descricao = "PLATÃO"},
                    new Alternativa { Correta = false, Descricao = "JÚLIO VERNE"},
                    new Alternativa { Correta = false, Descricao = "ARISTÓTOLES"},
                    new Alternativa { Correta = true, Descricao = "RENÉ DESCARTES"},
                }
            },
            new Pergunta
            {
                id = 15,
                Enunciado = "Quem foi aluno de Platão e tutor de Alexandre, o Grande?",
                Alternativas = new()
                {
                    new Alternativa { Correta = false, Descricao = "PITÁGORAS"},
                    new Alternativa { Correta = false, Descricao = "DIDEROT"},
                    new Alternativa { Correta = true, Descricao = "ARISTÓTELES"},
                    new Alternativa { Correta = false, Descricao = "GALILEU GALILEI"},
                }
            },
            new Pergunta
            {
                id = 16,
                Enunciado = "Qual metal possui o símbolo Hg?",
                Alternativas = new()
                {
                    new Alternativa { Correta = false, Descricao = "FERRO"},
                    new Alternativa { Correta = false, Descricao = "AÇO"},
                    new Alternativa { Correta = true, Descricao = "MERCÚRIO"},
                    new Alternativa { Correta = false, Descricao = "OURO"},
                }
            },
            new Pergunta
            {
                id = 17,
                Enunciado = "Qual é o nome dado a um conjunto de sinos?",
                Alternativas = new()
                {
                    new Alternativa { Correta = false, Descricao = "CORRIMÃO"},
                    new Alternativa { Correta = true, Descricao = "CARRILHÃO"},
                    new Alternativa { Correta = false, Descricao = "BADALADA"},
                    new Alternativa { Correta = false, Descricao = "CORSELETE"},
                }
            },
            new Pergunta
            {
                id = 18,
                Enunciado = "Quem ganhou a 1ª medalha de ouro olímpico para o Brsil?",
                Alternativas = new()
                {
                    new Alternativa { Correta = false, Descricao = "AFRANIO ANTONIO COSTA"},
                    new Alternativa { Correta = true, Descricao = "GUILHERME PARAENSE"},
                    new Alternativa { Correta = false, Descricao = "FERNANDO SOLEDADE"},
                    new Alternativa { Correta = false, Descricao = "SEBASTIÃO WOLF"},
                }
            },
            new Pergunta
            {
                id = 19,
                Enunciado = "Qual o quarto planeta do sistem solar?",
                Alternativas = new()
                {
                    new Alternativa { Correta = false, Descricao = "JÚPTER"},
                    new Alternativa { Correta = false, Descricao = "VÊNUS"},
                    new Alternativa { Correta = false, Descricao = "TERRA"},
                    new Alternativa { Correta = true, Descricao = "MARTE"},
                }
            },
            new Pergunta
            {
                id = 20,
                Enunciado = "Qual foi o piloto de Fórmula 1 que conquistou o título de campeão mundial cinco vezes?",
                Alternativas = new()
                {
                    new Alternativa { Correta = false, Descricao = "JACQUES STEWART"},
                    new Alternativa { Correta = false, Descricao = "ALAIN PROST"},
                    new Alternativa { Correta = false, Descricao = "AYRTON SENNA"},
                    new Alternativa { Correta = true, Descricao = "J. MANOEL FANGIO"},
                }
            },
        };
        List<Pergunta> perguntas_finais = new()
        {

        };

        /**
         * Sorteia uma pergunta fácil entre 1 e 20
         */
        public static Pergunta getRandomPerguntaFacil()
        {
            Random r = new Random();

            int sorteado = r.Next(1, perguntas_faceis.Count);

            return perguntas_faceis[sorteado];
        }

        /**
         * Sorteia uma pergunta fácil entre 1 e 20
         */
        public static Pergunta getRandomPerguntaMedia();

        public App()
        {
            InitializeComponent();

            MainPage = new AppShell();
        }
    }
}
