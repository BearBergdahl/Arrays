namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What´s an array");
            int[] ints = {1,2,3,4,5};
            foreach (int i in ints)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine(ints.FirstOrDefault());
            MultiDimensionArrayDemo();
            JaggedArrayDemo();
        }

        private static void JaggedArrayDemo()
        {
            int[][] jagged = new int[4][];
            jagged[0] = new int[] {1,2,3,4,5};
            jagged[1] = new int[] {2,3,4,5};
            jagged[2] = new int[] {3,4,5};
            jagged[3] = new int[] {4,5};
            foreach(int[] inner in jagged)
            {
                foreach (int i in inner) 
                {
                    Console.Write(i);
                }
                Console.WriteLine("Här slutar Jagged Array, del två kommer i eftermiddagens övningar.");
            }
        }

        private static void MultiDimensionArrayDemo()
        {
            int[,] multiInts = { { 2, 3, 4, 5 }, { 3, 3, 3, 3 } };
            Console.Write(multiInts[0, 0] + ",");
            Console.Write(multiInts[0, 1] + ",");
            Console.Write(multiInts[0, 2] + ",");
            Console.Write(multiInts[0, 3] + "\n");
            Console.Write(multiInts[1, 0] + ",");
            Console.Write(multiInts[1, 1] + ",");
            Console.Write(multiInts[1, 2] + ",");
            Console.Write(multiInts[1, 3] + "\n");

            Console.WriteLine("3D");
            
            int[,,] multi3DInts = { 
                { 
                    { 2, 3, 4, 5 }, { 3, 3, 3, 3 }, { 9, 6, 4, 9 }
                },
                {
                    { 5, 1, 4, 7 }, { 2, 2, 2, 2 }, { 4, 1, 7, 8 }
                }
            };
            string tab = "\t";
            Console.Write(multi3DInts[0, 0, 0] + ",");
            Console.Write(multi3DInts[0, 0, 1] + ",");
            Console.Write(multi3DInts[0, 0, 2] + ",");
            Console.Write(multi3DInts[0, 0, 3] + "\n");
            Console.Write(multi3DInts[0, 1, 0] + ",");
            Console.Write(multi3DInts[0, 1, 1] + ",");
            Console.Write(multi3DInts[0, 1, 2] + ",");
            Console.Write(multi3DInts[0, 1, 3] + "\n");
            Console.Write(multi3DInts[0, 2, 0] + ",");
            Console.Write(multi3DInts[0, 2, 1] + ",");
            Console.Write(multi3DInts[0, 2, 2] + ",");
            Console.Write(multi3DInts[0, 2, 3] + "\n");
            Console.Write(tab + multi3DInts[1, 0, 0] + ",");
            Console.Write(multi3DInts[1, 0, 1] + ",");
            Console.Write(multi3DInts[1, 0, 2] + ",");
            Console.Write(multi3DInts[1, 0, 3] + "\n");
            Console.Write(tab + multi3DInts[1, 1, 0] + ",");
            Console.Write(multi3DInts[1, 1, 1] + ",");
            Console.Write(multi3DInts[1, 1, 2] + ",");
            Console.Write(multi3DInts[1, 1, 3] + "\n");
            Console.Write(tab + multi3DInts[1, 2, 0] + ",");
            Console.Write(multi3DInts[1, 2, 1] + ",");
            Console.Write(multi3DInts[1, 2, 2] + ","); 
            Console.Write(multi3DInts[1, 2, 3] + "\n");
            Console.WriteLine("Det här fungerade ju, men är lite klumpigt. Gör en bättre i eftermiddag.");
        }
    }
}