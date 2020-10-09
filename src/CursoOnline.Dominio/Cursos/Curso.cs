using CursoOnline.Dominio.Cursos;
using System;

namespace CursoOnline.DominioTest.Cursos
{
   
    public class Curso
    {

        public Curso(string nome, string descricao, double cargaHoraria, PublicoAlvo publicoAlvo, double valor)
        {
            if (string.IsNullOrEmpty(nome))
                throw new ArgumentException("Nome inválido");

            if (cargaHoraria < 1)
                throw new ArgumentException("Carga horária inválida");

            if (valor < 0)
                throw new ArgumentException("Valor inválido");

            this.nome = nome;
            this.descricao = descricao;
            this.cargaHoraria = cargaHoraria;
            this.publicoAlvo = publicoAlvo;
            this.valor = valor;
        }

        public string nome { get; private set; }
        public string descricao { get; private set; }
        public double cargaHoraria { get; private set; }
        public PublicoAlvo publicoAlvo { get; private set; }
        public double valor { get; private set; }
    }

}