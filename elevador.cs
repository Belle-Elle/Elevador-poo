using System;

namespace Lista_exercicios_poo
{
    public class elevador
    {
        public int andarAtual;
        public int TotalAndares;
        public int Capacidade;
        public int PessoasPresentes;

        public void Inicializar()
        {

            Console.WriteLine("Bem Vindo ao simulador de Elevador Legal\n");
            Console.WriteLine("Para iniciar você devera setar o numero de andares e a Capacidade do Elevador\n");
        }
        public string Entrar()
        {
            Console.WriteLine("Uma pessoa entrou no Elevador\n");
            Console.WriteLine($"A capacidade maxima é de {Capacidade} pessoas\n");
            PessoasPresentes = PessoasPresentes + 1;
            if (PessoasPresentes >= Capacidade)
            {
                Console.WriteLine("O limite do Elevador foi exedido");
                PessoasPresentes = PessoasPresentes - 1;
            }


            return $"O numero atual de pessoas no elevador é {PessoasPresentes}";
        }
        public string Sair()
        {
            Console.WriteLine("Uma pessoa saiu do Elevador\n");


            if (PessoasPresentes <= 0)
            {
                Console.WriteLine("Não ha pessoas no elevador, logo niguem saira do Elevador");
            }
            else
            {
                PessoasPresentes = PessoasPresentes - 1;
            }


            return $"O numero atual de pessoas no elevador é {PessoasPresentes}";
        }
        public string Subir()
        {
            Console.WriteLine("O elevador subira um andar\n");
            andarAtual = andarAtual + 1;
            Console.WriteLine($"O elevador tem um total de {TotalAndares} andares\ns");

            if (andarAtual >= TotalAndares)
            {
                Console.WriteLine("O elevador ja está no ultimo andar, logo não podera subir");
                andarAtual = TotalAndares;
            }

            if (andarAtual == 0)
            {
                Console.WriteLine($@"O andar atual do Elevador é Térreo");
            }
            else
            {
                Console.WriteLine($@"O andar atual do Elevador é {andarAtual}");

            }
            return $@"";
        }
        public string Descer()
        {
            Console.WriteLine("O elevador descera um andar");

            Console.WriteLine($@"O elevador tem um total de {TotalAndares} andares");

            if (andarAtual == 0)
            {
                Console.WriteLine("O elevador ja está no térreo, logo não podera descer");
                andarAtual = 0;
            }
            else
            {
                andarAtual = andarAtual - 1;
            }


            if (andarAtual == 0)
            {
                Console.WriteLine($@"O andar atual do Elevador é Térreo");
            }
            else
            {
                Console.WriteLine($@"O andar atual do Elevador é {andarAtual}");

            }
            return "";
        }
    }
}