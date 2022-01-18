using System;
using System.Collections.Generic;
using System.Linq;

namespace SCXOperator
{
    public class Runner
    {

        public List<DadosExecucao> HistoricoExecucao { get; set; }

        public Runner()
        {
            HistoricoExecucao = new List<DadosExecucao>();
        }

        public List<DadosExecucao> Executar(String fileName,
                             int totalExecucoes,
                             int totalPopulcao,
                             int maxGeracao,
                             int maxGeracaoSemMelhoria,
                             double txSelecaoMelhores,
                             double txMutacao,
                             double txGenes)
        {

            double[][] matriz = Util.CarregarMatrizCusto(fileName);

            for (int i = 0; i < totalExecucoes; i++)
            {

                Populacao populacao = new Populacao(totalPopulcao, matriz);
                Cromossomo solucao = populacao.CalcularMelhorSolucao(maxGeracao,
                                                                     maxGeracaoSemMelhoria,
                                                                     txSelecaoMelhores,
                                                                     txMutacao,
                                                                     txGenes);

                HistoricoExecucao.Add(new DadosExecucao()
                {
                    Tempo = populacao.TempoDeProcessamento,
                    TotalGeracaoConvergencia = populacao.HistoricoMelhoresPorGeracao.Count(),
                    MelhorFitness = solucao.Fitness
                });

            }

            return HistoricoExecucao;

        }

    }
}
