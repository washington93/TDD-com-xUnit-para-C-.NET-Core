using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace CursoOnline.DominioTest.Cursos
{
    public class CursoTeste
    {
        [Fact]
        public void DeveCriarCurso()
        {
            string nome = "Informática básica";
            double cargaHoraria = 80;
            string publicoAlvo = "Estudantes";
            double valor = 950;

            var curso = new Curso(nome, cargaHoraria, publicoAlvo, valor);

            Assert.Equal(nome, curso.nome);
            Assert.Equal(cargaHoraria, curso.cargaHoraria);
            Assert.Equal(publicoAlvo, curso.publicoAlvo);
            Assert.Equal(valor, curso.valor);
        }
    }

    internal class Curso
    {


        public Curso(string nome, double cargaHoraria, string publicoAlvo, double valor)
        {
            this.nome = nome;
            this.cargaHoraria = cargaHoraria;
            this.publicoAlvo = publicoAlvo;
            this.valor = valor;
        }

        public string nome { get; set; }
        public double cargaHoraria { get; set; }
        public string publicoAlvo { get; set; }
        public double valor { get; set; }
    }
}
