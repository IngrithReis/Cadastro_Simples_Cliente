using System.ComponentModel.DataAnnotations;

namespace TesteGTI.WebbApi.Entidades
{
    public class EnderecoCliente
    {
        public int Id { get; set; }
        public int ClienteId { get; set; }
        public  Cliente Cliente { get; set; }

        [Required(ErrorMessage = "Este campo deve ser preenchido sem traços EX: 01327010", AllowEmptyStrings = false)]
        [Display(Name = "CEP,apenas números, EX: 01327010")]
        [Range(0, long.MaxValue, ErrorMessage = "Valor não aceito como CEP")]
        [MinLength(8, ErrorMessage = "O CEP deve conter 8 números")]
        public string CEP { get; set; }
        public string Logradouro { get; set; }
        public string Numero { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public string  Cidade { get; set; }
        public string UF { get; set; }
    }
}
