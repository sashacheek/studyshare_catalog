using System.Linq.Expressions;

namespace FinalProject.Models
{
    public class QueryOptions<T>
    {
        // TODO: consider implementing search bar where user can search for classes?
        // or filter by class type

        public Expression<Func<T, bool>> Where { get; set; } = null!;
        private string[] includes = Array.Empty<string>();

        public string Includes
        {
            set => includes = value.Replace(" ", "").Split(',');
        }

        public string[] GetIncludes() => includes;
        public bool HasWhere => Where != null;
    }
}
