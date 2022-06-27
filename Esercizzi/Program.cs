using System;
using System.Collections.Generic;
namespace Esercizzi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cliente CLiente1 = new Cliente("Michele",34,"MHL88fsqT4EG");
            Cliente CLiente2 = new Cliente("Damiano", 23, "MHL32f4T2EG");
            Cliente CLiente3 = new Cliente("Giulio", 19, "MH23f4543TEG");
            Conto Conto1 = new Conto(2345482.32M, CLiente1);
            Conto Conto2 = new Conto(4543482.32M, CLiente2);
            Conto Conto3 = new Conto(23445282.32M, CLiente3);

           
            
            


            Banca Banca = new Banca();
            Console.WriteLine(CLiente1._name+ "/ Eta: "+ CLiente1._eta+ " / Codice fiscale : "+ CLiente1._codiceFiscale );
            Console.WriteLine("saldo del conto :" + Conto1._saldo + " / Intestatario del conto : "+ Conto1._intestatario);
            Console.WriteLine();
            Console.WriteLine(CLiente2._name + "/ Eta: " + CLiente2._eta + " / Codice fiscale : " + CLiente2._codiceFiscale);
            Console.WriteLine("saldo del conto :" + Conto2._saldo + " / Intestatario del conto : " + Conto2._intestatario);
            Console.WriteLine();
            Console.WriteLine(CLiente3._name + "/ Eta: " + CLiente3._eta + " / Codice fiscale : " + CLiente3._codiceFiscale);
            Console.WriteLine("saldo del conto :" + Conto3._saldo + " / Intestatario del conto : " + Conto3._intestatario);

            Console.Read();
        }
    }
    public class Banca
    {
        public List<Cliente> _clienti = new List<Cliente>();
        public List<Conto> _conto = new List<Conto>();
        public Banca()
        {


        }
        public void AddClienti(Cliente cliente)
        {
            _clienti.Add(cliente);
        }
        public void AddConto(Conto conto)
        {
            _conto.Add(conto);
        }

    }



    public class Conto
    {
        public decimal _saldo;
        public Cliente _intestatario;
         public Conto ( decimal Saldo, Cliente Intestatario)
        {

            _saldo = Saldo;
            _intestatario = Intestatario;
            
        }
        

    }
   


    public class Cliente
    {
        public string _name;
        public int _eta;
        public string _codiceFiscale;

        public Cliente( string Name, int Eta, string Codicefiscale)
        {
            _name = Name;
            _eta = Eta;
            _codiceFiscale = Codicefiscale;
        }
    }


}



