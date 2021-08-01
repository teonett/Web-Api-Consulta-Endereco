namespace ConsultaEndereco.Core.Entities
{
    public class CepLa
    {
        /// <summary>
        /// Código de Endereço Postal
        /// </summary>
        public string Cep { get; set; }

        /// <summary>
        /// Unidade Federal - Estado
        /// </summary>
        public string Uf { get; set; }

        /// <summary>
        /// Nome da Cidade
        /// </summary>
        public string Cidade { get; set; }

        /// <summary>
        /// Bairro
        /// </summary>
        public string Bairro { get; set; }

        /// <summary>
        /// Nome da Avenida, Rua, Praça
        /// </summary>
        public string Logradouro { get; set; }
    }
}
