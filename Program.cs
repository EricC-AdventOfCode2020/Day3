namespace Day3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> sample = new List<string>()
            {
                "..##.......",
                "#...#...#..",
                ".#....#..#.",
                "..#.#...#.#",
                ".#...##..#.",
                "..#.##.....",
                ".#.#.#....#",
                ".#........#",
                "#.##...#...",
                "#...##....#",
                ".#..#...#.#"
            };

            List<string> data = new List<string>();

            using (var sR = new StreamReader(@"..\..\..\input"))
            {
                while (!sR.EndOfStream)
                {
                    data.Add(sR.ReadLine()!);
                }
            }

            int treeCount = 0;

            #region Part 1
            for (int i = 0; i < data.Count; i++)
            {
                int right = i * 3;
                if (data[i][right % data[i].Length] == '#')
                {
                    treeCount++;
                }
            }
            //for (int i = 0; i < sample.Count; i++)
            //{
            //    int right = i * 3;
            //    if (sample[i][right % sample[i].Length] == '#')
            //    {
            //        treeCount++;
            //    }
            //}
            #endregion

            #region Part 2
            long product = 1;
            treeCount = 0;
            // y = x
            for (int i = 0; i < data.Count; i++)
            {
                int right = i;
                if (data[i][right % data[i].Length] == '#')
                    treeCount++;
            }
            product *= treeCount;
            treeCount = 0;

            // y = 1/3x
            for (int i = 0; i < data.Count; i++)
            {
                int right = i * 3;
                if (data[i][right % data[i].Length] == '#')
                    treeCount++;
            }
            product *= treeCount;
            treeCount = 0;

            // y = 1/5x
            for (int i = 0; i < data.Count; i++)
            {
                int right = i * 5;
                if (data[i][right % data[i].Length] == '#')
                    treeCount++;
            }
            product *= treeCount;
            treeCount = 0;

            // y = 1/7x
            for (int i = 0; i < data.Count; i++)
            {
                int right = i * 7;
                if (data[i][right % data[i].Length] == '#')
                    treeCount++;
            }
            product *= treeCount;
            treeCount = 0;

            // y = 2x
            for (int i = 0; i < data.Count; i++)
            {
                int right = i;
                if (i * 2 < data.Count && data[i * 2][right % data[i].Length] == '#')
                    treeCount++;
            }
            product *= treeCount;
            treeCount = 0;
            #endregion

            // there was one that started with 2 i just forgot to paste it here, but it was too low
            // 816675328 too low
            // 9406609920
            Console.WriteLine(product);
        }
    }
}