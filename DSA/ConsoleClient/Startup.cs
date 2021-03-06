﻿namespace ConsoleClient
{
    class Startup
    {
        static void Main(string[] args)
        {
            var binaryHeapTester = new BinaryHeapTester();
            binaryHeapTester.Test();

            var dijkstraTester = new DijsktraTester();
            dijkstraTester.Test();
        }
    }
}
