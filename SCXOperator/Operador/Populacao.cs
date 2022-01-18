using System;
using System.Collections.Generic;
using System.Linq;

namespace SCXOperator
{

    public class Populacao
    {

        public double[][] matrizCusto { get; set; }

        public List<Cromossomo> Atual { get; set; }

        public List<Cromossomo> HistoricoMelhoresPorGeracao { get; set; }

        public TimeSpan TempoDeProcessamento { get; set; }

        public Populacao(int TamanhoPopulacao, double[][] matrizCusto)
        {

            this.matrizCusto = matrizCusto;
            Atual = new List<Cromossomo>();
            HistoricoMelhoresPorGeracao = new List<Cromossomo>();

            for (int i = 0; i < TamanhoPopulacao; i++)
                Atual.Add(new Cromossomo(matrizCusto));

        }

        public Cromossomo CalcularMelhorSolucao(int maxGeracao,
                                                int maxGeracaoSemMelhoria,
                                                double txSelecaoMelhores,
                                                double txMutacao,
                                                double txGenes)
        {

            int totalMelhores = (int)(Atual.Count() * txSelecaoMelhores);
            int totalMutacao = (int)(Atual.Count() * txMutacao);
            int totalGenes = (int)(Atual[0].Genes.Length * txGenes);

            DateTime dtInicio = DateTime.Now;

            for (int i = 0; i <= maxGeracao; i++)
            {

                List<Cromossomo> lstMelhores = Atual.OrderBy(x => x.Fitness).Take(totalMelhores).ToList();
                List<Cromossomo> lstNovaGeracao = new List<Cromossomo>(Atual.Count());
                HistoricoMelhoresPorGeracao.Add(lstMelhores[0]);

                #region Crossover

                int[][] pais = SelecionarPais(totalMelhores);

                for (int j = 0; j < pais.Length; j++)
                    lstNovaGeracao.Add(AplicarOperadorSCX(lstMelhores[pais[j][0]], lstMelhores[pais[j][1]]));

                #endregion

                #region Mutação
                                
                for (int j = 0; j < totalMutacao; j++)
                {

                    int idx = Program.getRandom.Next(0, lstNovaGeracao.Count);

                    for (int k = 0; k < totalGenes; k++)
                    {

                        int g1 = Program.getRandom.Next(0, lstNovaGeracao[idx].Genes.Length);
                        int g2 = Program.getRandom.Next(0, lstNovaGeracao[idx].Genes.Length);
                        while (g1 == g2)
                        {
                            g2 = Program.getRandom.Next(0, lstNovaGeracao[idx].Genes.Length);
                        }

                        int aux = lstNovaGeracao[idx].Genes[g1];
                        lstNovaGeracao[idx].Genes[g1] = lstNovaGeracao[idx].Genes[g2];
                        lstNovaGeracao[idx].Genes[g2] = aux;

                        lstNovaGeracao[idx].AtualizarFitness();

                    }

                }

                #endregion

                lstMelhores.AddRange(lstNovaGeracao);
                this.Atual = lstMelhores.ToArray().ToList(); // Usando ToList() para gerar uma nova referência

                if (HistoricoMelhoresPorGeracao.Count >= maxGeracaoSemMelhoria)
                {

                    List<Cromossomo> topN = HistoricoMelhoresPorGeracao.Skip(Math.Max(0, HistoricoMelhoresPorGeracao.Count() - maxGeracaoSemMelhoria)).ToList();

                    if (topN.All(o => o.Fitness == topN[0].Fitness))
                        break;
                    
                }

            }

            TempoDeProcessamento = (DateTime.Now - dtInicio);

            return Atual.OrderBy(x => x.Fitness).ToList()[0];

        }

        public int[][] SelecionarPais(int totalSelecao)
        {

            int[][] pais = new int[Atual.Count() - totalSelecao][];

            int idxP1, idxP2 = 0;
            bool continua = false;
            for (int i = 0; i < (Atual.Count() - totalSelecao); i++)
            {

                do
                {

                    continua = false;

                    idxP1 = Program.getRandom.Next(totalSelecao);
                    idxP2 = Program.getRandom.Next(totalSelecao);

                    if (idxP1 == idxP2)
                    {
                        continua = true;
                    }
                    else
                    {

                        for (int j = 0; j < i; j++)
                        {
                            if ((pais[j][0] == idxP1 && pais[j][1] == idxP2) || (pais[j][1] == idxP1 && pais[j][0] == idxP2))
                            {
                                continua = true;
                                break;
                            }
                        }

                    }

                } while (continua);

                pais[i] = new int[] { idxP1, idxP2 };

            }

            return pais;
            
        }

        public Cromossomo AplicarOperadorSCX(Cromossomo p1, Cromossomo p2)
        {
            
            // Vetor para os novos genes
            int[] NovosGene = Enumerable.Repeat(-1, p1.Genes.Count()).ToArray();
            
            // Declaração de variáveis auxiliares
            int idxP1 = 0, idxP2 = 0, idxNextP1 = 0, idxNextP2 = 0;
            double distA = 0, distB = 0;
            
            // Escolhe aleatoriamente o primeiro gene - pode ser de qualquer pai
            if (Program.getRandom.Next(3) % 2 == 0)
                NovosGene[0] = p1.Genes[Program.getRandom.Next(p1.Genes.Count())];
            else
                NovosGene[0] = p2.Genes[Program.getRandom.Next(p2.Genes.Count())];

            for (int i = 0; i < NovosGene.Length - 1; i++)
            {

                idxP1 = Array.IndexOf(p1.Genes, NovosGene[i]);
                idxP2 = Array.IndexOf(p2.Genes, NovosGene[i]);

                idxNextP1 = idxP1 + 1;
                idxNextP2 = idxP2 + 1;

                if (idxNextP1 >= p1.Genes.Count() || NovosGene.Contains(p1.Genes[idxNextP1]))
                {
                    for (int j = 0; j < p1.Genes.Length; j++)
                    {
                        if (!NovosGene.Contains(j))
                        {
                            idxNextP1 = Array.IndexOf(p1.Genes, j);
                            break;
                        }
                    }
                }

                if (idxNextP2 >= p2.Genes.Count() || NovosGene.Contains(p2.Genes[idxNextP2]))
                {
                    for (int j = 0; j < p2.Genes.Length; j++)
                    {
                        if (!NovosGene.Contains(j))
                        {
                            idxNextP2 = Array.IndexOf(p2.Genes, j);
                            break;
                        }
                    }
                }

                distA = matrizCusto[p1.Genes[idxP1]][p1.Genes[idxNextP1]];
                distB = matrizCusto[p2.Genes[idxP2]][p2.Genes[idxNextP2]];

                if (distA <= distB)
                    NovosGene[i + 1] = p1.Genes[idxNextP1];
                else
                    NovosGene[i + 1] = p2.Genes[idxNextP2];

            }
            
            return new Cromossomo(matrizCusto, NovosGene);

        }
        
    }

}
