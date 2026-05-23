using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace challengeFiap.src.Models
{
    [Table("T_CLYVO_ENDERECO_RESPONSAVEL")]
    public class EnderecoResponsavel
    {
        [Key]
        [Column("id_endereco_responsavel")]
        public int Id_endereco_responsavel { get; set; }
        [Required]
        [Column("pais")]
        public string? Pais { get; set; }
        [Required]
        [Column("estado")]
        public string? Estado { get; set; }
        [Required]
        [Column("cidade")]
        public string? Cidade { get; set; }
        [Required]
        [Column("bairro")]
        public string? Bairro { get; set; }
        [Required]
        [Column("logradouro_rua")]
        public string? Logradouro_rua { get; set; }
        [Required]
        [Column("nr_rua")]
        public string? Nr_rua { get; set; }
        [Required]
        [Column("completo")]
        public string? Complemento { get; set; }
        [Required]
        [Column("cep")]
        public string? Cep { get; set; }
        
        [Required]
        [Column("id_responsavel")]
        public int Id_responsavel { get; set; }

        [JsonIgnore]
        [ForeignKey("Id_responsavel")]
        public Responsavel? Responsavel{ get; set; }

        protected EnderecoResponsavel() { }

        public EnderecoResponsavel(int id_endereco_responsavel, string pais, string estado, string cidade, string bairro, string logradouro_rua, string nr_rua, string complemento, string cep, int id_responsavel)
        {
            Id_endereco_responsavel = id_endereco_responsavel;
            Pais = pais;
            Estado = estado;
            Cidade = cidade;
            Bairro = bairro;
            Logradouro_rua = logradouro_rua;
            Nr_rua = nr_rua;
            Complemento = complemento;
            Cep = cep;
            Id_responsavel = id_responsavel;
        }
    }
}
