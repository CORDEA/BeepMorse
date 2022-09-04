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

        private readonly string _query;

        public Morse(string query)
        {
            _query = query;
        }

        public IEnumerable<int> Generate()
        {
            return _query.ToCharArray().SelectMany(e => Table[Code.IndexOf(e)]);
        }
    }
}
