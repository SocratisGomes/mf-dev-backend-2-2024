using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Security.Principal;

namespace mf_dev_backend_2_2024.Models
{
    [Table("Veiculos")]

    public class Veiculo
    {
        [Key]        
        public int Id { get; set; }

        [Required(ErrorMessage = "Obigatório informar o nome")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Obigatório informar placa")]
        public string Placa { get; set; }

        [Required(ErrorMessage = "Obigatório informar o ano de Fabricação")]
        [Display(Name ="Ano de Fabricação")]
        public int AnoFabricacao { get; set; }

        [Required(ErrorMessage = "Obigatório informar o ano do Modelo")]
        [Display(Name = "Ano do Modelo")]
        public int AnoModelo { get; set; }

        public ICollection<Consumo> Consumos { get; set; }
    }
}
