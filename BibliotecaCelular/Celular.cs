using System;
using System.Collections.Generic;

namespace BibliotecaCelular
{
    public class Celular
    {
        private readonly Dictionary<string, int> dicionarioTeclas;
        private string mensagem;

        public Celular(string mensagem)
        {
            this.mensagem = mensagem;
            dicionarioTeclas = new();
            CriaDicionario();
        }

        private void CriaDicionario()
        {
            dicionarioTeclas.Add("ABC", 2);
            dicionarioTeclas.Add("DEF", 3);
            dicionarioTeclas.Add("GHI", 4);
            dicionarioTeclas.Add("JKL", 5);
            dicionarioTeclas.Add("MNO", 6);
            dicionarioTeclas.Add("PQRS", 7);
            dicionarioTeclas.Add("TUV", 8);
            dicionarioTeclas.Add("WXYZ", 9);
            dicionarioTeclas.Add(" ", 0);
        }

        public string RecebeMensagem()
        {
            string resposta = "";
            if(mensagem.Length <= 255)
            {
                foreach (char c in mensagem)
                {
                    string numeros = ConverteCharParaNumero(c);
                    if (resposta.EndsWith(numeros[0]))
                        resposta += "_" + numeros;
                    else
                        resposta += numeros;
                }
            }
            return resposta;
        }

        private string ConverteCharParaNumero(char c)
        {
            string numero = "";
            foreach (KeyValuePair<string, int> item in dicionarioTeclas)
            {
                if (item.Key.Contains(c))
                {
                    for (int i = item.Key.IndexOf(c); i != -1; i--)
                        numero += item.Value;
                }
            }
            return numero;
        }
    }
}
