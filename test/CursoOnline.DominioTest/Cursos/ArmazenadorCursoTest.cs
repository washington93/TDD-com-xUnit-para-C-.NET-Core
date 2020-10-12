

using CursoOnline.Dominio.Cursos;
using Moq;
using Xunit;

namespace CursoOnline.DominioTest.Cursos
{
    public class ArmazenadorDeCursoTest
    {
        [Fact]
        public void DeveAdicionarCurso()
        {
            var cursoDto = new CursoDto
            {
                nome = "Curso A",
                descricao = "Descrição",
                cargaHoraria = 80,
                publicoAlvoId = 1,
                valor = 850.00
            };

            var cursoReporitorioMock = new Mock<ICursoRepositorio>();

            var armazenadorDeCurso = new ArmazenadorDeCurso(cursoReporitorioMock.Object);
            armazenadorDeCurso.armazenar(cursoDto);

            cursoReporitorioMock.Verify(r =>r.adicionar(It.IsAny<Curso>()));
        }
    }

    public interface ICursoRepositorio
    {
        void adicionar(Curso curso);
    }

    public  class ArmazenadorDeCurso
    {
        private readonly ICursoRepositorio _cursoRepositorio;

        public ArmazenadorDeCurso(ICursoRepositorio cursoRepositorio)
        {
            _cursoRepositorio = cursoRepositorio;
        }

        public void armazenar(CursoDto cursoDto)
        {
            var curso = new Curso(
                cursoDto.nome,
                cursoDto.descricao,
                cursoDto.cargaHoraria,
                PublicoAlvo.Estudante,
                cursoDto.valor
                );
            _cursoRepositorio.adicionar(curso);
        }
    }

    public class CursoDto
    {
        public string nome { get; set; }
        public string descricao { get; set; }
        public int cargaHoraria { get; set; }
        public int publicoAlvoId { get; set; }
        public double valor { get; set; }
    }
}
