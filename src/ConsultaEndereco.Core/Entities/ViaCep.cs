namespace ConsultaEndereco.Core.Entities
{
    public class ViaCep
    {
        /// <summary>
        /// Codido de Endereço Postal
        /// </summary>
        public string Cep { get; set; }

        /// <summary>
        /// Nome da Rua, Avenida, Praça
        /// </summary>
        public string Logradouro { get; set; }

        /// <summary>
        /// Complemento do Endereço (caso exista)
        /// </summary>
        public string Complemento { get; set; }

        /// <summary>
        /// Bairro
        /// </summary>
        public string Bairro { get; set; }

        /// <summary>
        /// Nome da Cidade
        /// </summary>
        public string Localidade { get; set; }

        /// <summary>
        /// Estado
        /// </summary>
        public string Uf { get; set; }

        /// <summary>
        /// DDD da Localidade
        /// </summary>
        public string ddd { get; set; }

        /// <summary>
        /// Codigo da Cidade - IBGE
        /// </summary>
        public int Ibge { get; set; }

        /// <summary>
        /// Codigo da Cidade - Secretaria da Fazenda
        /// </summary>
        public int? Gia { get; set; }
    }
}
