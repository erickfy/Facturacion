﻿using Facturacion.Atributos;
using System.ComponentModel.DataAnnotations;

namespace Facturacion.DTOs
{
    public class IngresoRepoSriDto
    {

   
        public string RepresentanteLegal { get; set; }
        public string Obligado { get; set; }
        public string NombreComercial { get; set; }
        public string NumeroRuc { get; set; }
        public string AgenteRepresentante { get; set; }

        public string RazonSocial { get; set; }

    }

    public class CedulasRepositoriomanualDto
    {
        [Required(ErrorMessage = "Campo requerido {0}")]
        public string Cedula { get; set; }

        [Required(ErrorMessage = "Campo requerido {0}")]
        [EmailAddress]
        public string CorreoCliente { get; set; }
        [Required(ErrorMessage = "Campo requerido {0}")]

        public string Razonsocial { get; set; }

        public string? Direccion { get; set; }
        [StringLength(maximumLength: 10, MinimumLength = 10)]
        [RegularExpression("(^[0-9]+$)", ErrorMessage = "Solo se permiten números")]
        public string? NumeroTelefon { get; set; }

    }
    public class GetCliendteDto
    {
        [Required(ErrorMessage = "Campo requerido {0}")]

        public int Id { get; set; }

    }
    public class PostClienteEmpresaCreadaDTo
    {
        public int FkRespositorioCedulas { get; set; }
        public int? FkEmpresa { get; set; }
        public int? EmpresasCreadas { get; set; }
        public int FkUsuario { get; set; }
        public string Identificacion { get; set; }
        public string Razonsocial { get; set; }
        public string Direccion { get; set; }
        public string Email { get; set; }
        public string NumeroTelefon { get; set; }

    }
    public class GetListClienteEmpresaCreadaDto
    {
        public int Id { get; set; }
        public string Identificacion { get; set; }
        public string Razonsocial { get; set; }
        public string Direccion { get; set; }
        public string Email { get; set; }
        public string NumeroTelefon { get; set; }
        public bool Estado { get; set; }



    }
    public class PutClienteEmpresaCreadaDTo
    {
        [Required(ErrorMessage = $"El campo Id es Requerido")]
        public int Id { get; set; }
        [Required(ErrorMessage = $"El campo Direccion es Requerido")]
        public string Direccion { get; set; }
        [Required(ErrorMessage = $"El campo Email es Requerido")]
        public string Email { get; set; }
        public string NumeroTelefon { get; set; }
    }
    public class DeleteClienteEmpresaCreadaDTo
    {
        [Required(ErrorMessage = "El campo Id es Requerido")]
        public int Id { get; set; }

    }


    public class ViewClienteEmpresaCreadaDTo
    {
        public int? EmpresasCreadas { get; set; }
        public string? Identificacion { get; set; }
        public string? Razonsocial { get; set; }



    }


}
