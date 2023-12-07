using System;
using System.Globalization;

namespace Course {
  class Product {

    public string Nome{get; private set;}
    public double Preco{get; private set;}
    public int Quantidade{get; private set;}

    public Product(
      string nome,
      double preco,
      int quantidade
    ){
      Nome = nome;
      Preco = preco;
      Quantidade = quantidade;
    }

    public Product(
      string nome, 
      double preco
    ){
      Nome = nome;
      Preco = preco;
      Quantidade = 4;
    }



    public double ValorTotalEmEstoque(){
      return Preco * Quantidade;
    }

    public void AdicionarProdutos(int quantidade){
      Quantidade += quantidade;
    }
    
    public void RemoverProdutos(int quantidade){
      Quantidade -= quantidade;
    }
    
    public override string ToString() {
      return Nome
      + ", $ "
      + Preco.ToString("F2", CultureInfo.InvariantCulture)
      + ", "
      + Quantidade
      + " unidades, Total: $ "
      + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
    }
  }
}