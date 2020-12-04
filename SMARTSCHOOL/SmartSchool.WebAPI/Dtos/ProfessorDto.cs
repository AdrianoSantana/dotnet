using System;

namespace SmartSchool.WebAPI.Dtos
{
    public class ProfessorDto
    {
        public int Id { get; set; }

        public int Registro { get; set; }
        public string Nome { get; set; }

        public string Telefone { get; set; }

        public DateTime DataIni { get; set; } = DateTime.Now;

        public DateTime? DataFim { get; set; } = DateTime.Now;

        public int TempoTrabalho { get; set; }

        public bool Ativo { get; set; } = true;
    }
}