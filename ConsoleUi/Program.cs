﻿using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using Core.Bll;
using Core.Bll.Interfaces;
using Core.Dal;
using Core.Entities;
using Core.Entities.Enums;
using Microsoft.Extensions.Caching.Memory;

namespace ConsoleUi
{
    [MemoryDiagnoser]
    public abstract class Benchmark
    {
        private readonly ITrainingProgramLogic _logic;

        protected Benchmark()
        {
            var repository = new ProgramRepository();
            _logic = new TrainingProgramLogic(repository, new MemoryCache());
        }

        [Benchmark]
        public Session GetSession()
        {
            return _logic.Get(ProgramType.Legs, 3);
        }
    }

    internal static class Program
    {
        private static void Main()
        {
            BenchmarkRunner.Run<Benchmark>();
        }
    }
}