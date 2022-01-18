using System;
using System.Globalization;
using System.IO;
using System.Xml;

namespace SCXOperator
{

    public class Util
    {

        public static double[][] CarregarMatrizCusto(String fileName)
        {

            String[] dados = File.ReadAllLines(fileName);

            if (dados[0].Equals("<?xml version=\"1.0\" encoding=\"UTF-8\" standalone=\"no\" ?>") &&
                dados[1].Equals("<travellingSalesmanProblemInstance>"))
                return CarregarInstanciaTSP(fileName);
            else
                return CarregarCSV(dados);

        }

        public static double[][] CarregarInstanciaTSP(String fileName)
        {

            XmlTextReader reader = new XmlTextReader(fileName);
            XmlDocument doc = new XmlDocument();
            doc.Load(reader);
            reader.Dispose();

            XmlNodeList lista = doc.SelectNodes("travellingSalesmanProblemInstance")[0].SelectNodes("graph")[0].SelectNodes("vertex");

            int totalAmostras = lista.Count;

            double[][] matriz = new double[totalAmostras][];

            for (int i = 0; i < totalAmostras; i++)
            {
                matriz[i] = new double[totalAmostras];
                for (int j = 0; j < lista[i].SelectNodes("edge").Count; j++)
                    matriz[i][j] = double.Parse(lista[i].SelectNodes("edge")[j].Attributes["cost"].Value,
                                                CultureInfo.InvariantCulture);

            }

            return matriz;

        }

        public static double[][] CarregarCSV(String[] dados)
        {

            double[][] matriz = new double[dados.Length][];

            for (int i = 0; i < dados.Length; i++)
            {

                String[] col = dados[i].Split(';');
                matriz[i] = new double[col.Length];

                for (int j = 0; j < col.Length; j++)
                {
                    matriz[i][j] = double.Parse(col[j]);
                }

            }

            return matriz;

        }

    }
}
