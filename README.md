# Web-Api-Consulta-Endereco
Api que consulta endereços a partir dos endereços públicos :
* ViaCep (https://viacep.com.br/)
* Postmon (https://postmon.com.br/)
* Cep La (http://cep.la/)
* Correios (https://buscacepinter.correios.com.br/)


### Sobre o Projeto
A aplicação consistem na leitura dos dadops disponibilizados de cada Api, sendo ele apenas através do Cep ou mesmo utilizando parcialmente dados do endereço.

<img src="https://github.com/teonett/Web-Api-Consulta-Endereco/blob/main/WebApi-Endereco.jpg">
<img src="https://github.com/teonett/Web-Api-Consulta-Endereco/blob/main/Swagger-01.png">

### Ferramentas Utilizadas
Para a construção foi utilizado:

* C# Neto Core 5.0 
* Web Api

A construção da aplicação foi feita utilizando alguns conceitos de Clean Code.

### Rodar aplicaçao Local
* Baixar o projeto seja através de Download ou Git Clone (git clone https://github.com/teonett/Web-Api-Consulta-Endereco.git)
* Restaurar o projeto via Visual Studio apenas clicando com o botão direito na Solution e escolhendo a opção "Restore Nuget Package"
* ou Restaurar o projeto via terminal via linha de comando "dotnet restore"
* Para execução do projeto via Visual Studio apenes clicar e "IIS Express"
* ou Para execução via terminal basta apenas digitar o comando "dotnet run", no path "~/Web-Api-Consulta-Endereco/src/ConsultaEndereco.Api"

### Observações
Sendo um projeto Net Core funciona tanto no ambiente Windows, quanto Linux e MacOs.
