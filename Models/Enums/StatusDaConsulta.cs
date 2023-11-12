using System.ComponentModel.DataAnnotations;

namespace UBSDigital.Models.Enums;

public enum StatusDaConsulta
{
    [Display(Name = "Em aberto")]
    EM_ABERTO,

    [Display(Name = "Em andamento")]
    EM_ANDAMENTO,

    [Display(Name = "Finalizado")]
    FINALIZADO,
}
