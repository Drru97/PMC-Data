using System;
using PMC_Lib;

namespace Client
{
    class Program
    {
        static void Main(string[] args)
        {
            Position2D<decimal>[] posXY = new Position2D<decimal>[100];
            Position1D<decimal>[] posX = new Position1D<decimal>[100];
            for (int i = 0; i < 100; i++)
            {
                posXY[i] = new Position2D<decimal>();
                posX[i] = new Position1D<decimal>();
            }

            Random rand = new Random();
            for (int i = 0; i < 50; i++)
                posXY[0].AddPoint(new Point2D<decimal>(rand.Next(), rand.Next()));
            for (int i = 0; i < 200; i++)
                posXY[1].AddPoint(new Point2D<decimal>(rand.Next(), rand.Next()));

            Matrix<Position2D<decimal>> matrXY = new Matrix<Position2D<decimal>>();
            Matrix<Position1D<decimal>> matrX = new Matrix<Position1D<decimal>>();
            matrXY.AddPosition(posXY);
            matrX.AddPosition(posX);

            Container[] containers = new Container[]
            {
                new Container(matrXY, matrX),
                new Container(matrXY, matrX),
                new Container(matrXY, matrX)
            };

            ContainerCollection collection = new ContainerCollection();
            collection.AddContainer(containers);

            // foreach by collection
            Console.WriteLine("Foreach by collection");
            foreach (var col in collection)
                Console.WriteLine(col);

            // foreach by container
            Console.WriteLine("Foreach by container");
            foreach (var cont in containers[0])
                Console.WriteLine(cont);

            // foreach by matrix
            Console.WriteLine("Foreach by matrix");
            foreach (var matr in matrXY)
                Console.WriteLine(matr);

            // foreach by position
            Console.WriteLine("Foreach by position");
            foreach (var pos in matrXY.Positions[1])
                Console.WriteLine(pos);

            // get access to matrix
            Console.WriteLine(containers[0].Matrices[0]);

            Console.ReadKey();
        }
    }
}
