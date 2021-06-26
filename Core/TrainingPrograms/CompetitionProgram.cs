﻿using System;
using System.Collections.Generic;
using Core.Entities;
using Core.Entities.Enums;
using Core.Entities.Exercises;
using Core.Entities.Repeats;
using static Core.Entities.Enums.ExerciseType;

namespace Core.TrainingPrograms
{
    public class CompetitionProgram : BaseTrainingProgram
    {
        private static readonly IReadOnlyList<Func<Session>> Sessions = new Func<Session>[]
        {
            GetSession1_1
        };

        public CompetitionProgram() : base(Sessions)
        {
        }

        public override ProgramType Type => ProgramType.Competition;
        public override string Name => "Competition Program";

        private static Session GetSession1_1()
        {
            var warmup = GetSnatchWarmUp1();

            var ex1 = new Snatch(HangSnatchBelowKnees, HangSnatchAboveKnees)
            {
                Repeats = new Repeat[]
                {
                    new MultiRepeat {Percent = 0.5, Repeats = new[] {2, 2}, Sets = 2},
                    new MultiRepeat {Percent = 0.6, Repeats = new[] {2, 1}, Sets = 2},
                    new MultiRepeat {Percent = 0.65, Repeats = new[] {2, 1}, Sets = 2},
                    new MultiRepeat {Percent = 0.7, Repeats = new[] {2, 1}, Sets = 4}
                }
            };

            var ex2 = new Snatch(SnatchPull, HangSnatchPullBelowKnees)
            {
                Repeats = new Repeat[]
                {
                    new MultiRepeat {Percent = 0.7, Repeats = new[] {1, 3}, Sets = 2},
                    new MultiRepeat {Percent = 0.8, Repeats = new[] {1, 3}, Sets = 4}
                }
            };

            var ex3 = new BackSquat(ExerciseType.BackSquat)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat {Percent = 0.5, Repeats = 5, Sets = 2},
                    new SingleRepeat {Percent = 0.6, Repeats = 5, Sets = 4}
                }
            };

            var ex4 = new Snatch(SotsPress)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat {Percent = 0.3, Repeats = 12, Sets = 3}
                }
            };

            var session = new Session
            {
                Rounds = new Round[]
                {
                    new(warmup),
                    new(ex1),
                    new(ex2),
                    new(ex3),
                    new(ex4)
                }
            };

            return session;
        }

        private static BaseExercise[] GetSnatchWarmUp1()
        {
            var ex1 = new Accessory(Hyperextension)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat {Repeats = 15, Sets = 2}
                }
            };

            var ex2 = new Snatch(SnatchPushPress, SnatchBalance, OverheadSquat)
            {
                Repeats = new Repeat[]
                {
                    new MultiRepeat {Percent = 0.3, Repeats = new[] {4, 4, 4}, Sets = 3}
                }
            };

            var result = new BaseExercise[] {ex1, ex2};
            return result;
        }
    }
}