namespace quadrant_assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("input value for x");
            int x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Input a value for y");
            int y = Convert.ToInt32(Console.ReadLine());

            if (x > 0 && y > 0)
            {
                Console.WriteLine($"the coordinate point ({x},{y}) lies in the first quadrant");
            }
            else if (x < 0 && y > 0)
            {
                Console.WriteLine($"the coordinate point ({x},{y}) lies in the second quadrant");
            }
            else if (x < 0 && y < 0)
            {
                Console.WriteLine($"the coordinate point ({x},{y}) lies in the third quadrant");

            }
            else if (x > 0 && y < 0)
            {
                Console.WriteLine($"the coordinate point ({x},{y}) lies in the fourth quadrant");

            }
            else
            {
                Console.WriteLine($"the coordinate point ({x},{y}) lies in the origin");
            }

            //=======================================================================//
            int[] array = { 0, 2, 1, 1, 9, 1, 1 };
            Console.Write("input array: \n[");
            foreach (var item in array)
            {
                Console.Write(item + ", ");
            }
            Console.WriteLine("]");

            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i] == 1 && array[i + 1] == 1)
                {
                    array[i] = array[i + 1] = 0;
                    break;
                }
            }
            Console.Write("output array: \n[ ");
            foreach(var item in array) 
            {  Console.Write(item+ ", "); }
            Console.WriteLine("]");
            
        }
    }
}
