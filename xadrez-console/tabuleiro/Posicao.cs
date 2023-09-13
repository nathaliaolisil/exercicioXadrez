using System;
namespace tabuleiro
{
	public class Posicao
	{
		int Linha { get; set; }
		int Coluna { get; set; }

		public Posicao(int linha, int coluna)
		{

			Linha = linha;
            Coluna = coluna;

		}

        public override string ToString()
        {
            return Linha
                + ", "
                + Coluna;
        }

    }
}

