using BenchmarkDotNet.Attributes;
using System;
using System.Linq;

namespace EntityFramework_Estudos
{
    public class Program
    {
        public static void Main()
        {
            var context = new Context();
            var cargos = context.Cargo.AsQueryable();
            var a = cargos.Where(x => x.Id > 10).ToList();
        }
    }

    [MemoryDiagnoser]
    public class TestesConsultas
    {

        [Benchmark]
        public void ConsultaComToList()
        {
            using var context = new Context();
            var cargoes = context.Cargo.ToList();

            foreach (var cargo in cargoes)
            {
                Console.WriteLine(cargo.Nome);
            }
        }

        [Benchmark]
        public void ConsultaComAsQueriable()
        {
            using var context = new Context();
            var cargoes = context.Cargo.AsQueryable();

            foreach (var cargo in cargoes)
            {
                Console.WriteLine(cargo.Nome);
            }
        }

        [Benchmark]
        public void ConsultaComNada()
        {
            using var context = new Context();
            var cargoes = context.Cargo;

            foreach (var cargo in cargoes)
            {
                Console.WriteLine(cargo.Nome);
            }
        }

        //[Benchmark]
        //public List<Usuario> ObterUsuariosSemAsNoTracking()
        //{
        //    using var context = new Context();
        //    var usuarios = context.Usuario.ToList();
        //    return usuarios;
        //}

        //[Benchmark]
        //public List<Usuario> ObterUsuariosComAsNoTracking()
        //{
        //    using var context = new Context();
        //    var usuarios = context.Usuario.AsNoTracking().ToList();
        //    return usuarios;
        //}

        //[Benchmark]
        //public IList<Usuario> PaginacaoComAsNoTracking()
        //{
        //    var pagina = 3;
        //    var tamanhoPagina = 10;
        //    using var context = new Context();
        //    var usuarios = context.Usuario.AsNoTracking().Skip((pagina - 1) * tamanhoPagina).Take(tamanhoPagina).AsQueryable();
        //    return usuarios.ToList();
        //}

        //[Benchmark]
        //public List<Usuario> PaginacaoSemAsNoTracking()
        //{
        //    using var context = new Context();
        //    var usuarios = context.Usuario.AsNoTracking().ToList();
        //    return usuarios;
        //}

        //[Benchmark]
        //public async Task<Usuario> FirstOrDefault()
        //{
        //    await using var context = new Context();
        //    var usuario = await context.Usuario.AsNoTracking().FirstOrDefaultAsync(x => x.Id == 103);
        //    return usuario;
        //}

        //[Benchmark]
        //public async Task<Usuario> SingleOrDefault()
        //{
        //    await using var context = new Context();
        //    var usuario = await context.Usuario.AsNoTracking().SingleOrDefaultAsync(x => x.Id == 103);
        //    return usuario;
        //}

        //    [Benchmark]
        //    public List<Usuario> JoinComLinq()
        //    {
        //        using var context = new Context();
        //        var usuario = context.Usuario.Join(context.Endereco, u => u.EnderecoId, e => e.Id, (u, e) => new { u, e })
        //            .Join(context.Cargo, @t => @t.u.EnderecoId, c => c.Id,
        //                (@t, c) => new Usuario
        //                {
        //                    Nome = @t.u.Nome,
        //                    Cargo = c,
        //                    Endereco = @t.e,
        //                    Sobrenome = @t.u.Sobrenome,
        //                    Telefone = @t.u.Telefone
        //                });

        //        return usuario.ToList();
        //    }

        //    [Benchmark]
        //    public List<Usuario> JoinSemLinq()
        //    {
        //        using var context = new Context();
        //        var usuario = from u in context.Usuario
        //                      join e in context.Endereco on u.EnderecoId equals e.Id
        //                      join c in context.Cargo on u.EnderecoId equals c.Id
        //                      select new Usuario
        //                      {
        //                          Nome = u.Nome,
        //                          Cargo = c,
        //                          Endereco = e,
        //                          Sobrenome = u.Sobrenome,
        //                          Telefone = u.Telefone
        //                      };

        //        return usuario.ToList();
        //    }

        //    [Benchmark]
        //    public List<Usuario> JoinComInclude()
        //    {
        //        using var context = new Context();
        //        var usuario = context.Usuario.Include(x => x.Cargo).Include(x => x.Endereco);
        //        return usuario.ToList();
        //    }
    }
}
