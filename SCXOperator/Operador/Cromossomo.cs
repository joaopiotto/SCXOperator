
using System;
using System.Collections.Generic;
using System.Linq;


namespace SCXOperator
{

    public class Cromossomo
    {

        private double[][] matrizCusto;

        public int[] Genes { get; set; }

        public double Fitness { get; set; }

        public Cromossomo(double[][] matrizCusto)
        {

            this.matrizCusto = matrizCusto;

            List<int> lstGene = new List<int>();
            int gerado = 0;

            for (int i = 0; i < matrizCusto.Length; i++)
            {

                do
                {
                    gerado = Program.getRandom.Next(matrizCusto.Length);
                } while (lstGene.Contains(gerado));

                lstGene.Add(gerado);

            }

            var total = lstGene.GroupBy(x => x).Select(group =>
                    new
                    {
                        valor = group.Key,
                        count = group.Count()
                    }
                );

            if (total.Where(x => x.count > 1).Count() > 0)
                throw new Exception("Cromossomo com genes repetidos");

            Genes = lstGene.ToArray();

            AtualizarFitness();

        }

        public Cromossomo(double[][] matrizCusto, int[] Genes)
        {

            this.Genes = Genes;
            this.matrizCusto = matrizCusto;

            AtualizarFitness();

        }

        public void AtualizarFitness()
        {

            this.Fitness = 0;

            for (int i = 0; i < Genes.Length - 1; i++)
            {
                this.Fitness += matrizCusto[Genes[i]][Genes[i + 1]];
            }

        }

    }

}
