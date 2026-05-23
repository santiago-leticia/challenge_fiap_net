using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace challengeFiap.src.Models
{
    [Table("T_CLYVO_RESPONSAVEL")]
    public class Responsavel
    {
        [Key]
        [Column("id_responsavel")]
        public int Id_responsavel { get; set; }

        [Required]
        [Column("cpf_responsavel")]
        public string? Cpf_responsavel { get; set; }

        [Required]
        [Column("nm_responsavel")]
        public string? Nm_responsavel { get; set; }

        [Required]
        [Column("nr_telefone_responsavel")]
        public string? Nr_telefone_responsavel { get; set; }

        protected Responsavel() { }

        public Responsavel(int id_responsavel, string cpf_responsavel, string nm_responsavel, string nr_telefone_responsavel)
        {
            Id_responsavel = id_responsavel;
            Cpf_responsavel = cpf_responsavel;
            Nm_responsavel = nm_responsavel;
            Nr_telefone_responsavel = nr_telefone_responsavel;
        }
    }
}
