namespace Morse
{
    public class Morse
    {
        private static readonly int[][] Table =
        {
            new[] {0, 1},
            new[] {1, 0, 0, 0},
            new[] {1, 0, 1, 0},
            new[] {1, 0, 0},
            new[] {0},
            new[] {0, 0, 1, 0},
            new[] {1, 1, 0},
            new[] {0, 0, 0, 0},
            new[] {0, 0},
            new[] {0, 1, 1, 1},
            new[] {1, 0, 1},
            new[] {0, 1, 0, 0},
            new[] {1, 1},
            new[] {1, 0},
            new[] {1, 1, 1},
            new[] {0, 1, 1, 0},
            new[] {1, 1, 0, 1},
            new[] {0, 1, 0},
            new[] {0, 0, 0},
            new[] {1},
            new[] {0, 0, 1},
            new[] {0, 0, 0, 1},
            new[] {0, 1, 1},
            new[] {1, 0, 0, 1},
            new[] {1, 0, 1, 1},
            new[] {1, 1, 0, 0},
            new[] {0, 1, 1, 1, 1},
            new[] {0, 0, 1, 1, 1},
            new[] {0, 0, 0, 1, 1},
            new[] {0, 0, 0, 0, 1},
            new[] {0, 0, 0, 0, 0},
            new[] {1, 0, 0, 0, 0},
            new[] {1, 1, 0, 0, 0},
            new[] {1, 1, 1, 0, 0},
            new[] {1, 1, 1, 1, 0},
            new[] {1, 1, 1, 1, 1},
        };

        private const string Code = "abcdefghijklmnopqrstuvwxyz1234567890";

        private readonly string[] _query;

        public Morse(string query)
        {
            _query = query.Split();
        }

        public IEnumerable<int> Generate()
        {
            return _query
                .Select(q =>
                    q.ToCharArray()
                        .Select(e => Table[Code.IndexOf(e)].Join(-1))
                        .Join(new[] {-1, -1, -1})
                )
                .Join(new[] {-1, -1, -1, -1, -1, -1, -1});
        }
    }

    internal static class Enumerable
    {
        public static IEnumerable<int> Join(this IEnumerable<IEnumerable<int>> query, IEnumerable<int> separator)
        {
            return query.SelectMany((e, i) => i == 0 ? e : separator.Concat(e));
        }

        public static IEnumerable<int> Join(this IEnumerable<int> query, int separator)
        {
            return query.SelectMany((e, i) => i == 0 ? new[] {e} : new[] {separator, e});
        }
    }
}
