using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using System.Text;

namespace EntityFramework_Estudos
{
    public class Program
    {
        public static void Main()
        {
            //var context = new Context();
            //var cargos = context.Cargo.AsQueryable();
            //var a = cargos.Where(x => x.Id > 10);
            //foreach (var cargo in a)
            //{
            //    Console.WriteLine(cargo.Nome);
            //}
            //var testes = new TestesMetodos();

            BenchmarkRunner.Run<TestesMetodos>();
        }
    }

    [MemoryDiagnoser]
    public class TestesMetodos
    {
        [Benchmark]
        public string TesteString1()
        {
            var strn = ":)";
            var numero = 1;
            var palavra1 = "Palavra 1";
            var palavra2 = "Palavra 2";
            var palavra3 = "Palavra 3";

            strn = numero + "-" + palavra1 + "-" + palavra2 + "-" + palavra3;
            return strn;
        }

        [Benchmark]
        public string TesteString2()
        {
            var strn = ":)";
            var numero = 1;
            var palavra1 = "Palavra 1";
            var palavra2 = "Palavra 2";
            var palavra3 = "Palavra 3";

            strn = $"{numero}-{palavra1}-{palavra2}-{palavra3}";

            return strn;
        }

        [Benchmark]
        public string TesteString3()
        {
            var strn = ":)";
            var numero = 1;
            var palavra1 = "Palavra 1";
            var palavra2 = "Palavra 2";
            var palavra3 = "Palavra 3";

            var stb = new StringBuilder();

            stb.Append(numero);
            stb.Append("-");
            stb.Append(palavra1);
            stb.Append("-");
            stb.Append(palavra2);
            stb.Append("-");
            stb.Append(palavra3);

            strn = stb.ToString();
            return strn;
        }
    }

    //[Benchmark]
    //public int Sum1()
    //{
    //    var sum = 0;
    //    var x = 10;

    //    for (var i = 0; i < 100; i++)
    //    {
    //        sum += x * 2 % 5;
    //    }

    //    return sum;
    //}


    //[Benchmark]
    //public int Sum2()
    //{
    //    var sum = 0;
    //    var x = 10 * 2 % 5;
    //    ;

    //    for (var i = 0; i < 100; i++)
    //    {
    //        sum += x;
    //    }

    //    return sum;
    //}

    //[Benchmark]
    //public string Teste1()
    //{
    //    var n = Enumerable.Range(1, 10).Select(x => x);

    //    return n.FirstOrDefault().ToString();
    //}

    //[Benchmark]
    //public string Teste2() => Enumerable.Range(1, 10).Select(x => x).FirstOrDefault().ToString();
}

//[MemoryDiagnoser]
public class TestesConsultas
{

    //[Benchmark]
    //public void ConsultaComToList()
    //{
    //    var context = new Context();
    //    var cargos = context.Cargo.ToList();
    //    var a = cargos.Where(x => x.Id > 10);
    //    foreach (var cargo in a)
    //    {
    //        Console.WriteLine(cargo.Nome);
    //    }
    //}

    //[Benchmark]
    //public void ConsultaComAsQueriable()
    //{
    //    var context = new Context();
    //    var cargos = context.Cargo.AsQueryable().ToList();
    //    var a = cargos.Where(x => x.Id > 10);
    //    foreach (var cargo in a)
    //    {
    //        Console.WriteLine(cargo.Nome);
    //    }
    //}

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

    //[Benchmark]
    //public List<Usuario> JoinComLinq()
    //{
    //    using var context = new Context();
    //    var usuario = context.Usuario.Join(context.Endereco, u => u.EnderecoId, e => e.Id, (u, e) => new { u, e })
    //        .Join(context.Cargo, @t => @t.u.EnderecoId, c => c.Id,
    //            (@t, c) => new Usuario
    //            {
    //                Nome = @t.u.Nome,
    //                Cargo = c,
    //                Endereco = @t.e,
    //                Sobrenome = @t.u.Sobrenome,
    //                Telefone = @t.u.Telefone
    //            });

    //    return usuario.ToList();
    //}

    //[Benchmark]
    //public List<Usuario> JoinSemLinq()
    //{
    //    using var context = new Context();
    //    var usuario = from u in context.Usuario
    //                  join e in context.Endereco on u.EnderecoId equals e.Id
    //                  join c in context.Cargo on u.EnderecoId equals c.Id
    //                  select new Usuario
    //                  {
    //                      Nome = u.Nome,
    //                      Cargo = c,
    //                      Endereco = e,
    //                      Sobrenome = u.Sobrenome,
    //                      Telefone = u.Telefone
    //                  };

    //    return usuario.ToList();
    //}

    //[Benchmark]
    //public List<Usuario> JoinComInclude()
    //{
    //    using var context = new Context();
    //    var usuario = context.Usuario.Include(x => x.Cargo).Include(x => x.Endereco);
    //    return usuario.ToList();
    //}
}
