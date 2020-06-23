using System;
namespace lista
{
    public class cartao
    {
        public string titular { get; set; }
        public int numero { get; set; }
        public string bandeira { get; set; }
        public int vencimento { get; set; }
        public int cvv { get; set; }

        public cartao(){

        }

        public cartao(string titular, int numero, string bandeira, int vencimento, int cvv){
            this.titular = titular;
            this.numero = numero;
            this.bandeira = bandeira;
            this.vencimento = vencimento;
            this.cvv = cvv;
        }
    }
}