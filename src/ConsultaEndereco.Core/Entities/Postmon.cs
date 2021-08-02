namespace ConsultaEndereco.Core.Entities
{
    public class Postmon
    {
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Logradouro { get; set; }
        public EstadoInfo Estado_info { get; set; }
        public string Cep { get; set; }
        public CidadeInfo Cidade_info { get; set; }
        public string Estado { get; set; }
    }

    public class EstadoInfo
    {
        public string Area_km2 { get; set; }
        public string Codigo_ibge { get; set; }
        public string Nome { get; set; }
    }

    public class CidadeInfo
    {
        public string Area_km2 { get; set; }
        public string Codigo_ibge { get; set; }
    }
}
