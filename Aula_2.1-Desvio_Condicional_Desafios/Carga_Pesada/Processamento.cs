using System;
using System.Collections.Generic;
using System.Text;

namespace Carga_Pesada
{
    class Processamento
    {
        // Calcular Frete Por peso da carga
        public double valorImpostoPorEstado( string codEstado, int peso, string codCarga )
        {
            double imposto;
            double freteTotal;
            if (codEstado.ToUpper() == "PR")
            {
                imposto = 35.0 / 100.0;
                freteTotal = valorFreteSemImpostoEstado(peso, codCarga) * imposto;
                return freteTotal;
            }
            else if (codEstado.ToLower() == "RS")
            {
                imposto = 25.0 / 100.0;
                freteTotal = valorFreteSemImpostoEstado(peso, codCarga) * imposto;
                return freteTotal;
            }
            else if (codEstado.ToLower() == "RJ")
            {
                imposto = 15.0 / 100.0;
                freteTotal = valorFreteSemImpostoEstado(peso, codCarga) * imposto;
                return freteTotal;
            }
            else if (codEstado.ToLower() == "ES")
            {
                imposto = 5.0 / 100.0;
                freteTotal = valorFreteSemImpostoEstado(peso, codCarga) * imposto;
                return freteTotal;
            }
            else if (codEstado.ToLower() == "SP")
            {
                imposto = 1.0;
                freteTotal = valorFreteSemImpostoEstado(peso, codCarga) * imposto;
                return freteTotal;
            }

            return 1;
        }

        public double valorTotalFreteComImpostoEstado( int peso, string codEstado, string codCarga )
        {
            double imposto;
            double freteTotal;
            if (codEstado.ToUpper() == "PR")
            {
                imposto = 35.0 / 100.0;
                freteTotal = valorFreteSemImpostoEstado(peso, codCarga) +
                    (valorFreteSemImpostoEstado(peso, codCarga) * imposto);
                return freteTotal;
            }
            else if (codEstado.ToUpper() == "RS")
            {
                imposto = 25.0 / 100.0;
                freteTotal = valorFreteSemImpostoEstado(peso, codCarga) +
                    (valorFreteSemImpostoEstado(peso, codCarga) * imposto);
                return freteTotal;
            }
            else if (codEstado.ToUpper() == "RJ")
            {
                imposto = 15.0 / 100.0;
                freteTotal = valorFreteSemImpostoEstado(peso, codCarga) +
                    (valorFreteSemImpostoEstado(peso, codCarga) * imposto);
                return freteTotal;
            }
            else if (codEstado.ToUpper() == "ES")
            {
                imposto = 5.0 / 100.0;
                freteTotal = valorFreteSemImpostoEstado(peso, codCarga) +
                    (valorFreteSemImpostoEstado(peso, codCarga) * imposto);
                return freteTotal;
            }
            else if (codEstado.ToUpper() == "SP")
            {
                return valorFreteSemImpostoEstado(peso, codCarga);
            }

            return 0;
        }

        public double valorFreteSemImpostoEstado( int peso, string codCarga )
        {
            double total = 0.0;
            // categoria C
            if (peso >= 10 || peso <= 20)
            {
                total = converterToneladaQuilo(peso) * categoriaValor(codCarga);
                return total;
            }
            // categoria B
            else if (peso >= 21 || peso <= 30)
            {
                total = converterToneladaQuilo(peso) * categoriaValor(codCarga);
                return total;
            }
            // categoria A
            else if (peso >= 31 || peso <= 40)
            {
                total = converterToneladaQuilo(peso) * categoriaValor(codCarga);
                return total;
            }

            return total;
        }

        public double converterToneladaQuilo( int tonelada )
        {
            double quilo;
            quilo = tonelada * 1000;

            return quilo;
        }

        public int categoriaValor( string codCarga )
        {
            if (codCarga.ToUpper() == "A")
            {
                return 34;
            }
            if (codCarga.ToUpper() == "B")
            {
                return 20;
            }
            if (codCarga.ToUpper() == "C")
            {
                return 10;
            }
            return 0;
        }

    }
}
