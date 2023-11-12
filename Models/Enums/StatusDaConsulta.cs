using System.ComponentModel.DataAnnotations;

namespace UBSDigital.Models.Enums;

public enum StatusDaConsulta
{
    [Display(Name = "Em aberto")]
    EM_ABERTO,

    [Display(Name = "Finalizado")]
    FINALIZADO,
}
