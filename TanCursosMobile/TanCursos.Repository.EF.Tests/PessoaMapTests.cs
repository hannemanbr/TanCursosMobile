using NUnit.Framework;
using System.Linq;
using TanCursos.Domain;
using TanCursos.Repository.EF.Context;

namespace TanCursos.Repository.EF.Tests
{
    [TestFixture]
    public class PessoaMapTests
    {
        private AppContexto _context;

        [SetUp]
        public void Setup()
        {
            if (_context==null)
                _context = new AppContexto();
        }

        [TearDown]
        public void TearDown()
        {
            //var deleted = _context.Pessoas.First(x => x.Id == id);

            //if (deleted != null)
            //{
            //    _context.Pessoas.Remove(deleted);
            //    _context.SaveChanges();
            //}
            
            _context.Dispose();
        }

        [Test]
        public void DeveIncluirPessoa()
        {
            var pessoa = new Pessoa() { Email = "Email1", Nome = "Nome 1" };

            _context.Pessoas.Add(pessoa);
            _context.SaveChanges();

            var response = _context.Pessoas.ToList();

            Assert.IsNotNull(response);

        }
    }
}
