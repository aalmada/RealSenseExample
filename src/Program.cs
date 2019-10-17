using Intel.RealSense;
using System;

namespace RealSenseExample
{
    class Program
    {
        static void Main()
        {
            var pipe = new Pipeline();
            pipe.Start();

            while (true)
            {
                using var frames = pipe.WaitForFrames();
                using var depth = frames.DepthFrame;
                Console.WriteLine($"The camera is pointing at an object {depth.GetDistance(depth.Width / 2, depth.Height / 2)} meters away\t");

                Console.SetCursorPosition(0, 0);
            }
        }
    }
}
