using System;

namespace SmartSchool.WebAPI.Dtos
{
    public class ProfessorRegistrarDto
    {

        public ProfessorRegistrarDto(int registro, string nome, string sobrenome, string telefone, DateTime dataIni, bool ativo)
        {
            this.Registro = registro;
            this.Nome = nome;
            this.Sobrenome = sobrenome;
            this.Telefone = telefone;
            this.DataIni = dataIni;
            this.Ativo = ativo;

        }

        public int Registro { get; set; }
        public string Nome { get; set; }

        public string Sobrenome { get; set; }

        public string Telefone { get; set; }

        public DateTime DataIni { get; set; } = DateTime.Now;

        public DateTime? DataFim { get; set; } = null;

        public bool Ativo { get; set; } = true;
    }
}