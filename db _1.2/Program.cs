using System.Threading.Tasks;

namespace db__1._2
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            await using (var context = new SampleContextFactory().CreateDbContext(args))
            {
                await new LazyLoading(context).LoadThreeTablesAsync();
            }

            await using (var context = new SampleContextFactory().CreateDbContext(args))
            {
                await new LazyLoading(context).DateDiffAsync();
            }

            await using (var context = new SampleContextFactory().CreateDbContext(args))
            {
                await new LazyLoading(context).ChangeEntityAsync();
            }

            await using (var context = new SampleContextFactory().CreateDbContext(args))
            {
                await new LazyLoading(context).AddEntityAsync();
            }

            await using (var context = new SampleContextFactory().CreateDbContext(args))
            {
                await new LazyLoading(context).DeleteEntityAsync();
            }

            await using (var context = new SampleContextFactory().CreateDbContext(args))
            {
                await new LazyLoading(context).GroupRoleEmployeeAsync();
            }
        }
    }
}
