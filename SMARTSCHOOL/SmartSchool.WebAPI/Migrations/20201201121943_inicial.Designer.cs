﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SmartSchool.WebAPI.Data;

namespace SmartSchool.WebAPI.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20201201121943_inicial")]
    partial class inicial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("SmartSchool.WebAPI.Models.Aluno", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<bool>("Ativo")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("DataFim")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("DataIni")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("DataNasc")
                        .HasColumnType("TEXT");

                    b.Property<int>("Matricula")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Nome")
                        .HasColumnType("TEXT");

                    b.Property<string>("Sobrenome")
                        .HasColumnType("TEXT");

                    b.Property<string>("Telefone")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Alunos");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Ativo = true,
                            DataIni = new DateTime(2020, 12, 1, 9, 19, 43, 48, DateTimeKind.Local).AddTicks(2971),
                            DataNasc = new DateTime(2005, 7, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Matricula = 1,
                            Nome = "Marta",
                            Sobrenome = "Kent",
                            Telefone = "33225555"
                        },
                        new
                        {
                            Id = 2,
                            Ativo = true,
                            DataIni = new DateTime(2020, 12, 1, 9, 19, 43, 48, DateTimeKind.Local).AddTicks(4440),
                            DataNasc = new DateTime(2005, 7, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Matricula = 2,
                            Nome = "Paula",
                            Sobrenome = "Isabela",
                            Telefone = "3354078"
                        },
                        new
                        {
                            Id = 3,
                            Ativo = true,
                            DataIni = new DateTime(2020, 12, 1, 9, 19, 43, 48, DateTimeKind.Local).AddTicks(4497),
                            DataNasc = new DateTime(2005, 7, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Matricula = 3,
                            Nome = "Laura",
                            Sobrenome = "Antonia",
                            Telefone = "55668899"
                        },
                        new
                        {
                            Id = 4,
                            Ativo = true,
                            DataIni = new DateTime(2020, 12, 1, 9, 19, 43, 48, DateTimeKind.Local).AddTicks(4501),
                            DataNasc = new DateTime(2005, 7, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Matricula = 4,
                            Nome = "Luiza",
                            Sobrenome = "Maria",
                            Telefone = "6565659"
                        },
                        new
                        {
                            Id = 5,
                            Ativo = true,
                            DataIni = new DateTime(2020, 12, 1, 9, 19, 43, 48, DateTimeKind.Local).AddTicks(4505),
                            DataNasc = new DateTime(2005, 7, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Matricula = 5,
                            Nome = "Lucas",
                            Sobrenome = "Machado",
                            Telefone = "565685415"
                        },
                        new
                        {
                            Id = 6,
                            Ativo = true,
                            DataIni = new DateTime(2020, 12, 1, 9, 19, 43, 48, DateTimeKind.Local).AddTicks(4512),
                            DataNasc = new DateTime(2005, 7, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Matricula = 6,
                            Nome = "Pedro",
                            Sobrenome = "Alvares",
                            Telefone = "456454545"
                        },
                        new
                        {
                            Id = 7,
                            Ativo = true,
                            DataIni = new DateTime(2020, 12, 1, 9, 19, 43, 48, DateTimeKind.Local).AddTicks(4554),
                            DataNasc = new DateTime(2005, 7, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Matricula = 7,
                            Nome = "Paulo",
                            Sobrenome = "José",
                            Telefone = "9874512"
                        });
                });

            modelBuilder.Entity("SmartSchool.WebAPI.Models.AlunoCurso", b =>
                {
                    b.Property<int>("AlunoId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("CursoId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("DataFim")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("DataInic")
                        .HasColumnType("TEXT");

                    b.HasKey("AlunoId", "CursoId");

                    b.HasIndex("CursoId");

                    b.ToTable("AlunosCursos");
                });

            modelBuilder.Entity("SmartSchool.WebAPI.Models.AlunoDisciplina", b =>
                {
                    b.Property<int>("AlunoId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("DisciplinaId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("DataFim")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("DataInic")
                        .HasColumnType("TEXT");

                    b.Property<int?>("Nota")
                        .HasColumnType("INTEGER");

                    b.HasKey("AlunoId", "DisciplinaId");

                    b.HasIndex("DisciplinaId");

                    b.ToTable("AlunosDisciplinas");

                    b.HasData(
                        new
                        {
                            AlunoId = 1,
                            DisciplinaId = 2,
                            DataInic = new DateTime(2020, 12, 1, 9, 19, 43, 48, DateTimeKind.Local).AddTicks(5456)
                        },
                        new
                        {
                            AlunoId = 1,
                            DisciplinaId = 4,
                            DataInic = new DateTime(2020, 12, 1, 9, 19, 43, 48, DateTimeKind.Local).AddTicks(5904)
                        },
                        new
                        {
                            AlunoId = 1,
                            DisciplinaId = 5,
                            DataInic = new DateTime(2020, 12, 1, 9, 19, 43, 48, DateTimeKind.Local).AddTicks(5934)
                        },
                        new
                        {
                            AlunoId = 2,
                            DisciplinaId = 1,
                            DataInic = new DateTime(2020, 12, 1, 9, 19, 43, 48, DateTimeKind.Local).AddTicks(5936)
                        },
                        new
                        {
                            AlunoId = 2,
                            DisciplinaId = 2,
                            DataInic = new DateTime(2020, 12, 1, 9, 19, 43, 48, DateTimeKind.Local).AddTicks(5938)
                        },
                        new
                        {
                            AlunoId = 2,
                            DisciplinaId = 5,
                            DataInic = new DateTime(2020, 12, 1, 9, 19, 43, 48, DateTimeKind.Local).AddTicks(5941)
                        },
                        new
                        {
                            AlunoId = 3,
                            DisciplinaId = 1,
                            DataInic = new DateTime(2020, 12, 1, 9, 19, 43, 48, DateTimeKind.Local).AddTicks(5943)
                        },
                        new
                        {
                            AlunoId = 3,
                            DisciplinaId = 2,
                            DataInic = new DateTime(2020, 12, 1, 9, 19, 43, 48, DateTimeKind.Local).AddTicks(5944)
                        },
                        new
                        {
                            AlunoId = 3,
                            DisciplinaId = 3,
                            DataInic = new DateTime(2020, 12, 1, 9, 19, 43, 48, DateTimeKind.Local).AddTicks(5945)
                        },
                        new
                        {
                            AlunoId = 4,
                            DisciplinaId = 1,
                            DataInic = new DateTime(2020, 12, 1, 9, 19, 43, 48, DateTimeKind.Local).AddTicks(5948)
                        },
                        new
                        {
                            AlunoId = 4,
                            DisciplinaId = 4,
                            DataInic = new DateTime(2020, 12, 1, 9, 19, 43, 48, DateTimeKind.Local).AddTicks(5949)
                        },
                        new
                        {
                            AlunoId = 4,
                            DisciplinaId = 5,
                            DataInic = new DateTime(2020, 12, 1, 9, 19, 43, 48, DateTimeKind.Local).AddTicks(5950)
                        },
                        new
                        {
                            AlunoId = 5,
                            DisciplinaId = 4,
                            DataInic = new DateTime(2020, 12, 1, 9, 19, 43, 48, DateTimeKind.Local).AddTicks(5951)
                        },
                        new
                        {
                            AlunoId = 5,
                            DisciplinaId = 5,
                            DataInic = new DateTime(2020, 12, 1, 9, 19, 43, 48, DateTimeKind.Local).AddTicks(5952)
                        },
                        new
                        {
                            AlunoId = 6,
                            DisciplinaId = 1,
                            DataInic = new DateTime(2020, 12, 1, 9, 19, 43, 48, DateTimeKind.Local).AddTicks(5953)
                        },
                        new
                        {
                            AlunoId = 6,
                            DisciplinaId = 2,
                            DataInic = new DateTime(2020, 12, 1, 9, 19, 43, 48, DateTimeKind.Local).AddTicks(5955)
                        },
                        new
                        {
                            AlunoId = 6,
                            DisciplinaId = 3,
                            DataInic = new DateTime(2020, 12, 1, 9, 19, 43, 48, DateTimeKind.Local).AddTicks(5956)
                        },
                        new
                        {
                            AlunoId = 6,
                            DisciplinaId = 4,
                            DataInic = new DateTime(2020, 12, 1, 9, 19, 43, 48, DateTimeKind.Local).AddTicks(5959)
                        },
                        new
                        {
                            AlunoId = 7,
                            DisciplinaId = 1,
                            DataInic = new DateTime(2020, 12, 1, 9, 19, 43, 48, DateTimeKind.Local).AddTicks(5960)
                        },
                        new
                        {
                            AlunoId = 7,
                            DisciplinaId = 2,
                            DataInic = new DateTime(2020, 12, 1, 9, 19, 43, 48, DateTimeKind.Local).AddTicks(5961)
                        },
                        new
                        {
                            AlunoId = 7,
                            DisciplinaId = 3,
                            DataInic = new DateTime(2020, 12, 1, 9, 19, 43, 48, DateTimeKind.Local).AddTicks(5962)
                        },
                        new
                        {
                            AlunoId = 7,
                            DisciplinaId = 4,
                            DataInic = new DateTime(2020, 12, 1, 9, 19, 43, 48, DateTimeKind.Local).AddTicks(5963)
                        },
                        new
                        {
                            AlunoId = 7,
                            DisciplinaId = 5,
                            DataInic = new DateTime(2020, 12, 1, 9, 19, 43, 48, DateTimeKind.Local).AddTicks(5964)
                        });
                });

            modelBuilder.Entity("SmartSchool.WebAPI.Models.Curso", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Nome")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Cursos");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Nome = "Tecnologia da Informação"
                        },
                        new
                        {
                            Id = 2,
                            Nome = "Sistemas de Informação"
                        },
                        new
                        {
                            Id = 3,
                            Nome = "Ciência da Computação"
                        });
                });

            modelBuilder.Entity("SmartSchool.WebAPI.Models.Disciplina", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("CargaHoraria")
                        .HasColumnType("INTEGER");

                    b.Property<int>("CursoId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Nome")
                        .HasColumnType("TEXT");

                    b.Property<int?>("PrerequisitoId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("ProfessorId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("CursoId");

                    b.HasIndex("PrerequisitoId");

                    b.HasIndex("ProfessorId");

                    b.ToTable("Disciplinas");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CargaHoraria = 0,
                            CursoId = 1,
                            Nome = "Matemática",
                            ProfessorId = 1
                        },
                        new
                        {
                            Id = 2,
                            CargaHoraria = 0,
                            CursoId = 3,
                            Nome = "Matemática",
                            ProfessorId = 1
                        },
                        new
                        {
                            Id = 3,
                            CargaHoraria = 0,
                            CursoId = 3,
                            Nome = "Física",
                            ProfessorId = 2
                        },
                        new
                        {
                            Id = 4,
                            CargaHoraria = 0,
                            CursoId = 1,
                            Nome = "Português",
                            ProfessorId = 3
                        },
                        new
                        {
                            Id = 5,
                            CargaHoraria = 0,
                            CursoId = 1,
                            Nome = "Inglês",
                            ProfessorId = 4
                        },
                        new
                        {
                            Id = 6,
                            CargaHoraria = 0,
                            CursoId = 2,
                            Nome = "Inglês",
                            ProfessorId = 4
                        },
                        new
                        {
                            Id = 7,
                            CargaHoraria = 0,
                            CursoId = 3,
                            Nome = "Inglês",
                            ProfessorId = 4
                        },
                        new
                        {
                            Id = 8,
                            CargaHoraria = 0,
                            CursoId = 1,
                            Nome = "Programação",
                            ProfessorId = 5
                        },
                        new
                        {
                            Id = 9,
                            CargaHoraria = 0,
                            CursoId = 2,
                            Nome = "Programação",
                            ProfessorId = 5
                        },
                        new
                        {
                            Id = 10,
                            CargaHoraria = 0,
                            CursoId = 3,
                            Nome = "Programação",
                            ProfessorId = 5
                        });
                });

            modelBuilder.Entity("SmartSchool.WebAPI.Models.Professor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<bool>("Ativo")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("DataFim")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("DataIni")
                        .HasColumnType("TEXT");

                    b.Property<string>("Nome")
                        .HasColumnType("TEXT");

                    b.Property<int>("Registro")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Sobrenome")
                        .HasColumnType("TEXT");

                    b.Property<string>("Telefone")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Professores");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Ativo = true,
                            DataIni = new DateTime(2020, 12, 1, 9, 19, 43, 44, DateTimeKind.Local).AddTicks(5801),
                            Nome = "Lauro",
                            Registro = 1,
                            Sobrenome = "Oliveira"
                        },
                        new
                        {
                            Id = 2,
                            Ativo = true,
                            DataIni = new DateTime(2020, 12, 1, 9, 19, 43, 45, DateTimeKind.Local).AddTicks(6578),
                            Nome = "Roberto",
                            Registro = 2,
                            Sobrenome = "Soares"
                        },
                        new
                        {
                            Id = 3,
                            Ativo = true,
                            DataIni = new DateTime(2020, 12, 1, 9, 19, 43, 45, DateTimeKind.Local).AddTicks(6618),
                            Nome = "Ronaldo",
                            Registro = 3,
                            Sobrenome = "Marconi"
                        },
                        new
                        {
                            Id = 4,
                            Ativo = true,
                            DataIni = new DateTime(2020, 12, 1, 9, 19, 43, 45, DateTimeKind.Local).AddTicks(6620),
                            Nome = "Rodrigo",
                            Registro = 4,
                            Sobrenome = "Carvalho"
                        },
                        new
                        {
                            Id = 5,
                            Ativo = true,
                            DataIni = new DateTime(2020, 12, 1, 9, 19, 43, 45, DateTimeKind.Local).AddTicks(6664),
                            Nome = "Alexandre",
                            Registro = 5,
                            Sobrenome = "Montanha"
                        });
                });

            modelBuilder.Entity("SmartSchool.WebAPI.Models.AlunoCurso", b =>
                {
                    b.HasOne("SmartSchool.WebAPI.Models.Aluno", "Aluno")
                        .WithMany()
                        .HasForeignKey("AlunoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SmartSchool.WebAPI.Models.Curso", "Curso")
                        .WithMany()
                        .HasForeignKey("CursoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Aluno");

                    b.Navigation("Curso");
                });

            modelBuilder.Entity("SmartSchool.WebAPI.Models.AlunoDisciplina", b =>
                {
                    b.HasOne("SmartSchool.WebAPI.Models.Aluno", "Aluno")
                        .WithMany("AlunosDisciplinas")
                        .HasForeignKey("AlunoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SmartSchool.WebAPI.Models.Disciplina", "Disciplina")
                        .WithMany("AlunosDisciplinas")
                        .HasForeignKey("DisciplinaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Aluno");

                    b.Navigation("Disciplina");
                });

            modelBuilder.Entity("SmartSchool.WebAPI.Models.Disciplina", b =>
                {
                    b.HasOne("SmartSchool.WebAPI.Models.Curso", "Curso")
                        .WithMany("Disciplinas")
                        .HasForeignKey("CursoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SmartSchool.WebAPI.Models.Disciplina", "Prerequisito")
                        .WithMany()
                        .HasForeignKey("PrerequisitoId");

                    b.HasOne("SmartSchool.WebAPI.Models.Professor", "Professor")
                        .WithMany("Disciplinas")
                        .HasForeignKey("ProfessorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Curso");

                    b.Navigation("Prerequisito");

                    b.Navigation("Professor");
                });

            modelBuilder.Entity("SmartSchool.WebAPI.Models.Aluno", b =>
                {
                    b.Navigation("AlunosDisciplinas");
                });

            modelBuilder.Entity("SmartSchool.WebAPI.Models.Curso", b =>
                {
                    b.Navigation("Disciplinas");
                });

            modelBuilder.Entity("SmartSchool.WebAPI.Models.Disciplina", b =>
                {
                    b.Navigation("AlunosDisciplinas");
                });

            modelBuilder.Entity("SmartSchool.WebAPI.Models.Professor", b =>
                {
                    b.Navigation("Disciplinas");
                });
#pragma warning restore 612, 618
        }
    }
}