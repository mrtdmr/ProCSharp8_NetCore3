﻿using System;

namespace _3._2_FunWithLocalFunctions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
        static int AddWrapper(int x, int y)
        {
            return Add();
            int Add()
            {
                return x + y;
            }
        }
        static int AddWrapperWithSideEffect(int x, int y)
        {
            return Add();
            int Add()
            {
                x += 1;
                return x + y;
            }
        }
        static int AddWrapperWithStatic(int x, int y)
        {
            //Do some validation here
            return Add(x, y);
            static int Add(int x, int y)
            {
                return x + y;
            }
        }
    }
}