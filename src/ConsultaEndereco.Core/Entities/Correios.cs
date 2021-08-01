using System.Collections.Generic;

namespace ConsultaEndereco.Core.Entities
{
    public class Correios
    {
        /// <summary>
        /// Tipo de erro caso exista
        /// </summary>
        public bool Erro { get; set; }

        /// <summary>
        /// Mensagem de retorno na consulta
        /// </summary>
        public string Mensagem { get; set; }

        /// <summary>
        /// Quantidade de registros de retorno
        /// </summary>
        public int Total { get; set; }

        /// <summary>
        /// Lista de enderecos retornados
        /// </summary>
        public List<CorreiosAddress> Dados { get; set; }
    }

    public class CorreiosAddress
    {
        /// <summary>
        /// Unidade Federal - Estado
        /// </summary>
        public string Uf { get; set; }

        /// <summary>
        /// Nome da Cidade
        /// </summary>
        public string Localidade { get; set; }

        /// <summary>
        /// Nome da Cidade Subordinada
        /// </summary>
        public string LocalidadeSubordinada { get; set; }

        /// <summary>
        /// Nome da Rua, Avenida, Praça
        /// </summary>
        public string LogradouroDNEC { get; set; }

        /// <summary>
        /// Complemento referente ao endereço
        /// </summary>
        public string LogradouroTextoAdicional { get; set; }

        public string LogradouroTexto { get; set; }

        /// <summary>
        /// Nome do Bairro
        /// </summary>
        public string Bairro { get; set; }

        /// <summary>
        /// Nome da Unidade
        /// </summary>
        public string NomeUnidade { get; set; }

        /// <summary>
        /// Codigo de Endereço Postal
        /// </summary>
        public string Cep { get; set; }

        /// <summary>
        /// Tipo de Codigo Postal
        /// </summary>
        public string TipoCep { get; set; }

        /// <summary>
        /// Numero do Casa
        /// </summary>
        public string NumeroLocalidade { get; set; }

        /// <summary>
        /// Situação 
        /// </summary>
        public string Situacao { get; set; }

        /// <summary>
        /// Faixa de Caixa Postal
        /// </summary>
        public string[] FaixasCaixaPosta { get; set; }

        /// <summary>
        /// Faixa de Codigo Postal
        /// </summary>
        public string[] FaixasCep { get; set; }
    }

    public class Address
    {
        /// <summary>
        /// Nome da Rua
        /// </summary>
        public string Street { get; set; }

        /// <summary>
        /// Nome do Distrito / Bairro
        /// </summary>
        public string District { get; set; }

        /// <summary>
        /// Nome da Cidade
        /// </summary>
        public string City { get; set; }

        /// <summary>
        /// Nome do Estado
        /// </summary>
        public string State { get; set; }

        /// <summary>
        /// Codigo de Endereço Postal
        /// </summary>
        public string ZipCode { get; set; }
    }
}
