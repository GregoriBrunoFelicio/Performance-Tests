using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using EntityFramework_Estudos.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace EntityFramework_Estudos
{
    public class Program
    {
        public static void Main()
        {
            //var endereco = context.Endereco.Include(x => x.Usuarios).ToList();
            //context.Database.EnsureCreated();
            //var databaseCreator = context.GetService<IRelationalDatabaseCreator>();

            //var context = new Context();
            //var usuario = new Faker<Usuario>()
            //    .RuleFor(x => x.Nome, f => f.Random.Word())
            //    .RuleFor(x => x.Sobrenome, f => f.Random.Word())
            //    .RuleFor(x => x.Telefone, f => f.Random.Word())
            //    .RuleFor(x => x.Cargo, f => new Faker<Cargo>().RuleFor(x => x.Nome, f => f.Random.Word()).RuleFor(x => x.Salario, f => f.Random.Decimal()).Generate())
            //    .RuleFor(x => x.Endereco, f => new Faker<Endereco>().RuleFor(x => x.Rua, f => f.Random.Word()).Generate())
            //    .Generate(900);

            //context.Usuario.AddRange(usuario);
            //context.SaveChanges();

            //var teste = new TestesConsultas();


            BenchmarkRunner.Run<TestesConsultas>();
        }
    }

    [MemoryDiagnoser]
    public class TestesConsultas
    {
        [Benchmark]
        public List<Usuario> ObterUsuariosSemAsNoTracking()
        {
            using var context = new Context();
            var usuarios = context.Usuario.ToList();
            return usuarios;
        }

        [Benchmark]
        public List<Usuario> ObterUsuariosComAsNoTracking()
        {
            using var context = new Context();
            var usuarios = context.Usuario.AsNoTracking().ToList();
            return usuarios;
        }
    }
}
