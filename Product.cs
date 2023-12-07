using System;
using System.Globalization;

namespace Course {
  class Product {

    private string _nome;
    private double _preco;
    private int _quantidade;

    public Product(
      string nome,
      double preco,
      int quantidade
    ){
      _nome = nome;
      _preco = preco;
      _quantidade = quantidade;
    }

    public Product(
      string nome, 
      double preco
    ){
      _nome = nome;
      _preco = preco;
      _quantidade = 4;
    }

    public string Nome{
      get { return _nome; }
      set { _nome = value ; }
    }

    public double Preco{
      get { return _preco; }
      set { _preco = value ; }
    }

    public int Quantidade{
      get { return _quantidade; }
      set { _quantidade = value ; }
    }

    public double ValorTotalEmEstoque(){
      return _preco * _quantidade;
    }

    public void AdicionarProdutos(int quantidade){
      _quantidade += quantidade;
    }
    
    public void RemoverProdutos(int quantidade){
      _quantidade -= quantidade;
    }
    
    public override string ToString() {
      return _nome
      + ", $ "
      + _preco.ToString("F2", CultureInfo.InvariantCulture)
      + ", "
      + _quantidade
      + " unidades, Total: $ "
      + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
    }
  }
}