/*como eu instancio um objeto?
1. Criar classe
1 classe = 1 arquivo
*/

//onjeto
//Variavel
//TIPO NOME
using POO_Fundamentos;

//Instanciar
Carro carroDoVini = new Carro();

carroDoVini.Modelo = "HB20S";
carroDoVini.Marca = "Hyundai";
carroDoVini.Ano = 2024;

carroDoVini.ExibirInformacoes();

//Instanciel um novo objeto

Carro carroLegal = new Carro();

carroLegal.Modelo = "Legal";
carroLegal.Marca = "Marca Legal";
carroLegal.Ano = 1976;

carroLegal.ExibirInformacoes();

Console.WriteLine(carroLegal);


//Classe Pedido
//NomeDoCliente, item, quantidad, preco

Pedidio NovoPedido = new Pedidio();

NovoPedido.Nome = "Samuel";
NovoPedido.Item = "Salgados coxinhas, risolis, kibes e bolinho de queijo";
NovoPedido.Quantidade = 200;
NovoPedido.Preco = 89.49;

NovoPedido.InformacoesDoPedido();

Console.WriteLine(NovoPedido);