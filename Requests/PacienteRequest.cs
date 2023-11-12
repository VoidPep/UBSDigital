﻿namespace UBSDigital.Requests;

public class PacienteRequest
{
    public Guid? Id { get; set; }
    public string Nome { get; set; }
    public string Cpf { get; set; }
    public string Senha { get; set; }
    public string Cep { get; set; }
    public string Logradouro { get; set; }
    public string Bairro { get; set; }
    public string Numero { get; set; }
    public string? Complemento { get; set; }
    public string Cidade { get; set; }
    public string Uf { get; set; }
}
