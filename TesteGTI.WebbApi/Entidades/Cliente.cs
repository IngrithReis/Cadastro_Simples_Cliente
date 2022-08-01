using System;
using System.ComponentModel.DataAnnotations;

namespace TesteGTI.WebbApi.Entidades
{
    public class Cliente
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Este é um campo obrigatório")]
        [Display(Name = "Nome*")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Este campo deve ser preenchido sem traços e sem pontos EX: 12345678912", AllowEmptyStrings = false)]
        [Display(Name = "CPF *")]
        [StringLength(maximumLength: 14)]
        public string CPF { get; set; }
        public string RG { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Data da Expedição")]
        public DateTime? DataExpedicaoRG { get; set; }

        [Display(Name = "Órgão de Expedição")]
        public string OrgaoExpedicaoRG { get; set; }

        [Display(Name = "UF Expedição")]
        public string UF { get; set; }
        
        [DataType(DataType.Date)]
        [Required(ErrorMessage = "Este campo é obrigatório", AllowEmptyStrings = false)]
        public DateTime Nascimento { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatório", AllowEmptyStrings = false)]
        public string Sexo { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatório", AllowEmptyStrings = false)]
        public string  EstadoCivil { get; set; }




    }
}
