# PloomesAPI

Este projeto foi um teste solicitado pela empresa Ploomes, foi necessário construir uma  WEB PI em C# com acesso a um banco de dados SQL Server.

Fiz a criação usando o entity framework e ASP.NET core.

Para acesso e teste desta API devemos acessar o postman ou isomnia para PEGARMOS e ENVIARMOS informações:

METÓDO GET(PEGAR):

http://SEULOCALHOST/api/APIProdutos - Assim terá um retorno em JSON.


METÓDO POST(ENVIAR):

http://SEULOCALHOST/api/APIProdutos - Deverá ser enviado os dados em JSON como por exemplo:

{
	"descricao": "Teste",
        "preco": 180.0,
        "qtde": 5.0,
        "valorEstoque": 900.0
}

*Apenas um adendo em relação a este projeto... O mesmo já é um CRUD onde é possivel criar, editar e excluir os dados cadastrados no sistema ou enviados via API.*
