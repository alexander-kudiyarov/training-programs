using System;
using System.Collections.Generic;
using Core.Entities;
using Core.Entities.Enums;
using Core.Entities.Exercises;
using Core.Entities.Repeats;
using static Core.Entities.Enums.ExerciseType;

namespace Core.TrainingPrograms
{
    public sealed class PullAndSquatProgram : BaseTrainingProgram
    {
        private static readonly IReadOnlyList<Func<Session>> Sessions = new Func<Session>[]
        {
            GetSession1_1, GetSession1_2, GetSession1_3, GetSession1_4, GetSession1_5,
            GetSession2_1, GetSession2_2, GetSession2_3, GetSession2_4, GetSession2_5,
            GetSession3_1, GetSession3_2, GetSession3_3, GetSession3_4, GetSession3_5,
            GetSession4_1, GetSession4_2
        };

        public PullAndSquatProgram() : base(Sessions)
        {
        }

        public override ProgramType Type => ProgramType.PullAndSquat;
        public override string Name => "Pull and Squat Program";

        private static Session GetSession1_1()
        {
            var ex1A = new Accessory(Hyperextension)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat {Repeats = 12}
                }
            };

            var ex1B = new Accessory(Crunch)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat {Repeats = 12}
                }
            };

            var ex2 = new Snatch(MuscleSnatch)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat {Percent = 0.4, Repeats = 5, Sets = 3}
                }
            };

            var ex3 = new Snatch(SnatchPull, HangSnatchPullBelowKnee)
            {
                Repeats = new Repeat[]
                {
                    new MultiRepeat {Percent = 0.6, Repeats = new[] {1, 3}},
                    new MultiRepeat {Percent = 0.8, Repeats = new[] {1, 3}, Sets = 2},
                    new MultiRepeat {Percent = 0.9, Repeats = new[] {1, 2}, Sets = 3}
                }
            };

            var ex4 = new BackSquat(ExerciseType.BackSquat)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat {Percent = 0.5, Repeats = 5},
                    new SingleRepeat {Percent = 0.6, Repeats = 5, Sets = 4}
                }
            };

            var ex5 = new Snatch(SotsPress)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat {Percent = 0.3, Repeats = 6, Sets = 3}
                }
            };

            var session = new Session
            {
                Rounds = new Round[]
                {
                    new(3, ex1A, ex1B),
                    new(ex2),
                    new(ex3),
                    new(ex4),
                    new(ex5)
                }
            };

            return session;
        }

        private static Session GetSession1_2()
        {
            var ex1A = new Accessory(ReverseHyperextension)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat {Repeats = 12}
                }
            };

            var ex1B = new Accessory(Crunch)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat {Repeats = 12}
                }
            };

            var ex1C = new CleanAndJerk(FrontSquat)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat {Weight = Stats.Bar, Repeats = 6}
                }
            };

            var ex2 = new CleanAndJerk(PowerClean)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat {Percent = 0.5, Repeats = 4, Sets = 2},
                    new SingleRepeat {Percent = 0.6, Repeats = 3, Sets = 3}
                }
            };

            var ex3 = new CleanAndJerk(CleanPull)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat {Percent = 0.7, Repeats = 3},
                    new SingleRepeat {Percent = 0.8, Repeats = 6, Sets = 3}
                }
            };

            var ex4 = new CleanAndJerk(BackSplitSquat)
            {
                Repeats = new Repeat[]
                {
                    new MultiRepeat {Percent = 0.5, Repeats = new[] {4, 4}, Sets = 3}
                }
            };

            var session = new Session
            {
                Rounds = new Round[]
                {
                    new(3, ex1A, ex1B, ex1C),
                    new(ex2),
                    new(ex3),
                    new(ex4)
                }
            };

            return session;
        }

        private static Session GetSession1_3()
        {
            var ex1A = new Accessory(Hyperextension)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat {Repeats = 12}
                }
            };

            var ex1B = new Accessory(Crunch)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat {Repeats = 12}
                }
            };

            var ex2 = new Snatch(MuscleSquatSnatch)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat {Percent = 0.5, Repeats = 6, Sets = 4}
                }
            };

            var ex3 = new Snatch(DeficitSnatchPull)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat {Percent = 0.5, Repeats = 3, Sets = 2},
                    new SingleRepeat {Percent = 0.6, Repeats = 3, Sets = 2},
                    new SingleRepeat {Percent = 0.7, Repeats = 3, Sets = 3}
                }
            };

            var ex4 = new CleanAndJerk(FrontSquat)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat {Percent = 0.5, Repeats = 4, Sets = 2},
                    new SingleRepeat {Percent = 0.6, Repeats = 4},
                    new SingleRepeat {Percent = 0.7, Repeats = 4},
                    new SingleRepeat {Percent = 0.8, Repeats = 4, Sets = 4}
                }
            };

            var ex5 = new Accessory(BoxJump)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat {Repeats = 5, Sets = 3}
                }
            };

            var session = new Session
            {
                Rounds = new Round[]
                {
                    new(3, ex1A, ex1B),
                    new(ex2),
                    new(ex3),
                    new(ex4),
                    new(ex5)
                }
            };

            return session;
        }

        private static Session GetSession1_4()
        {
            var ex1 = new Snatch(PowerSnatch)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat {Percent = 0.5, Repeats = 3, Sets = 3}
                }
            };

            var ex2 = new CleanAndJerk(Clean, Jerk)
            {
                Repeats = new Repeat[]
                {
                    new MultiRepeat {Percent = 0.5, Repeats = new[] {2, 2}, Sets = 2},
                    new MultiRepeat {Percent = 0.6, Repeats = new[] {2, 2}, Sets = 3}
                }
            };

            var session = new Session
            {
                Rounds = new Round[]
                {
                    new(ex1),
                    new(ex2)
                }
            };

            return session;
        }

        private static Session GetSession1_5()
        {
            var ex1A = new Accessory(Hyperextension)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat {Repeats = 12}
                }
            };

            var ex1B = new Accessory(Crunch)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat {Repeats = 12}
                }
            };

            var ex2 = new CleanAndJerk(FrontSquat, PushPress)
            {
                Repeats = new Repeat[]
                {
                    new MultiRepeat {Percent = 0.5, Repeats = new[] {1, 5}, Sets = 3}
                }
            };

            var ex3 = new BackSquat(BackSquatNarrowFeet)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat {Percent = 0.5, Repeats = 6},
                    new SingleRepeat {Percent = 0.6, Repeats = 6, Sets = 3}
                }
            };

            var ex4 = new CleanAndJerk(GoodMorningSquat)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat {Percent = 0.4, Repeats = 8, Sets = 3}
                }
            };

            var session = new Session
            {
                Rounds = new Round[]
                {
                    new(3, ex1A, ex1B),
                    new(ex2),
                    new(ex3),
                    new(ex4)
                }
            };

            return session;
        }

        private static Session GetSession2_1()
        {
            var ex1A = new Accessory(Hyperextension)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat {Repeats = 12}
                }
            };

            var ex1B = new Accessory(Crunch)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat {Repeats = 12}
                }
            };

            var ex2 = new Snatch(MuscleSnatch, SnatchBalance, OverheadSquat)
            {
                Repeats = new Repeat[]
                {
                    new MultiRepeat {Percent = 0.5, Repeats = new[] {2, 2, 4}, Sets = 3}
                }
            };

            var ex3 = new Snatch(RomanianDeadlift)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat {Percent = 0.5, Repeats = 6},
                    new SingleRepeat {Percent = 0.6, Repeats = 6},
                    new SingleRepeat {Percent = 0.7, Repeats = 6, Sets = 4}
                }
            };

            var ex4 = new BackSquat(BenchBackSquat)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat {Percent = 0.5, Repeats = 4, Sets = 2},
                    new SingleRepeat {Percent = 0.6, Repeats = 4},
                    new SingleRepeat {Percent = 0.7, Repeats = 4},
                    new SingleRepeat {Percent = 0.8, Repeats = 4, Sets = 3}
                }
            };

            var ex5 = new Snatch(SotsPress)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat {Percent = 0.3, Repeats = 8, Sets = 4}
                }
            };

            var session = new Session
            {
                Rounds = new Round[]
                {
                    new(3, ex1A, ex1B),
                    new(ex2),
                    new(ex3),
                    new(ex4),
                    new(ex5)
                }
            };

            return session;
        }

        private static Session GetSession2_2()
        {
            var ex1A = new Accessory(ReverseHyperextension)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat {Repeats = 12}
                }
            };

            var ex1B = new Accessory(Crunch)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat {Repeats = 12}
                }
            };

            var ex1C = new CleanAndJerk(FrontSquat)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat {Weight = Stats.Bar, Repeats = 6}
                }
            };

            var ex2 = new CleanAndJerk(PowerClean, FrontSquat, PushPress)
            {
                Repeats = new Repeat[]
                {
                    new MultiRepeat {Percent = 0.5, Repeats = new[] {2, 2, 4}, Sets = 4}
                }
            };

            var ex3 = new CleanAndJerk(DeficitCleanPull)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat {Percent = 0.5, Repeats = 4, Sets = 2},
                    new SingleRepeat {Percent = 0.7, Repeats = 4},
                    new SingleRepeat {Percent = 0.85, Repeats = 4, Sets = 3},
                    new SingleRepeat {Percent = 1.0, Repeats = 1}
                }
            };

            var ex4 = new CleanAndJerk(GoodMorning)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat {Percent = 0.4, Repeats = 6, Sets = 3}
                }
            };

            var session = new Session
            {
                Rounds = new Round[]
                {
                    new(3, ex1A, ex1B, ex1C),
                    new(ex2),
                    new(ex3),
                    new(ex4)
                }
            };

            return session;
        }

        private static Session GetSession2_3()
        {
            var ex1A = new Accessory(Hyperextension)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat {Repeats = 12}
                }
            };

            var ex1B = new Accessory(Crunch)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat {Repeats = 12}
                }
            };

            var ex2 = new Snatch(PowerSnatch, OverheadSquat)
            {
                Repeats = new Repeat[]
                {
                    new MultiRepeat {Percent = 0.5, Repeats = new[] {2, 3}},
                    new MultiRepeat {Percent = 0.6, Repeats = new[] {1, 3}, Sets = 3}
                }
            };

            var ex3 = new Snatch(HangSnatchPullAboveKnee)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat {Percent = 0.5, Repeats = 6, Sets = 4}
                }
            };

            var ex4 = new BackSquat(ExerciseType.BackSquat)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat {Percent = 0.5, Repeats = 4},
                    new SingleRepeat {Percent = 0.6, Repeats = 4, Sets = 4}
                }
            };

            var ex5 = new Accessory(BarbellSquatJump)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat {Repeats = 5, Sets = 3}
                }
            };

            var session = new Session
            {
                Rounds = new Round[]
                {
                    new(3, ex1A, ex1B),
                    new(ex2),
                    new(ex3),
                    new(ex4),
                    new(ex5)
                }
            };

            return session;
        }

        private static Session GetSession2_4()
        {
            var ex1 = new Snatch(ExerciseType.Snatch)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat {Percent = 0.5, Repeats = 3, Sets = 7}
                }
            };

            var ex2 = new CleanAndJerk(Clean, Jerk)
            {
                Repeats = new Repeat[]
                {
                    new MultiRepeat {Percent = 0.5, Repeats = new[] {2, 2}, Sets = 2},
                    new MultiRepeat {Percent = 0.6, Repeats = new[] {2, 1}},
                    new MultiRepeat {Percent = 0.6, Repeats = new[] {1, 2}},
                    new MultiRepeat {Percent = 0.7, Repeats = new[] {1, 1}, Sets = 2}
                }
            };

            var ex3 = new CleanAndJerk(JerkSupport)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat {Percent = 0.8, Repeats = 1},
                    new SingleRepeat {Percent = 1.0, Repeats = 1},
                    new SingleRepeat {Percent = 1.05, Repeats = 1, Sets = 3}
                }
            };

            var session = new Session
            {
                Rounds = new Round[]
                {
                    new(ex1),
                    new(ex2),
                    new(ex3)
                }
            };

            return session;
        }

        private static Session GetSession2_5()
        {
            var ex1A = new Accessory(ReverseHyperextension)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat {Repeats = 12}
                }
            };

            var ex1B = new Accessory(Crunch)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat {Repeats = 12}
                }
            };

            var ex1C = new CleanAndJerk(FrontSquat)
            {
                Repeats = new[]
                {
                    new SingleRepeat {Weight = Stats.Bar, Repeats = 6}
                }
            };

            var ex2 = new CleanAndJerk(MuscleSquatClean)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat {Percent = 0.5, Repeats = 4, Sets = 3}
                }
            };

            var ex3 = new CleanAndJerk(CleanPullSlowlyDown)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat {Percent = 0.5, Repeats = 4},
                    new SingleRepeat {Percent = 0.7, Repeats = 4},
                    new SingleRepeat {Percent = 0.9, Repeats = 4, Sets = 3},
                    new SingleRepeat {Percent = 1.0, Repeats = 4}
                }
            };

            var ex4 = new CleanAndJerk(BackSplitSquat)
            {
                Repeats = new Repeat[]
                {
                    new MultiRepeat {Percent = 0.5, Repeats = new[] {6, 6}, Sets = 4}
                }
            };

            var session = new Session
            {
                Rounds = new Round[]
                {
                    new(3, ex1A, ex1B, ex1C),
                    new(ex2),
                    new(ex3),
                    new(ex4)
                }
            };

            return session;
        }

        private static Session GetSession3_1()
        {
            var ex1A = new Accessory(Hyperextension)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat {Repeats = 15}
                }
            };

            var ex1B = new Accessory(Crunch)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat {Repeats = 20}
                }
            };

            var ex2 = new Snatch(MuscleSquatSnatch)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat {Percent = 0.5, Repeats = 5, Sets = 4}
                }
            };

            var ex3 = new Snatch(DeficitSnatchPull)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat {Percent = 0.5, Repeats = 4},
                    new SingleRepeat {Percent = 0.7, Repeats = 4},
                    new SingleRepeat {Percent = 0.9, Repeats = 4, Sets = 2},
                    new SingleRepeat {Percent = 1.0, Repeats = 3, Sets = 2},
                    new SingleRepeat {Percent = 1.05, Repeats = 2, Sets = 2}
                }
            };

            var ex4 = new CleanAndJerk(FrontSquat)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat {Percent = 0.7, Repeats = 3, Sets = 2},
                    new SingleRepeat {Percent = 0.8, Repeats = 3},
                    new SingleRepeat {Percent = 0.9, Repeats = 3, Sets = 3}
                }
            };

            var ex5 = new Snatch(SnatchPushPress)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat {Percent = 0.5, Repeats = 6, Sets = 2},
                    new SingleRepeat {Percent = 0.6, Repeats = 4, Sets = 2},
                    new SingleRepeat {Percent = 0.7, Repeats = 3, Sets = 3}
                }
            };

            var session = new Session
            {
                Rounds = new Round[]
                {
                    new(3, ex1A, ex1B),
                    new(ex2),
                    new(ex3),
                    new(ex4),
                    new(ex5)
                }
            };

            return session;
        }

        private static Session GetSession3_2()
        {
            var ex1A = new Accessory(ReverseHyperextension)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat {Repeats = 15}
                }
            };

            var ex1B = new Accessory(Crunch)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat {Repeats = 20}
                }
            };

            var ex1C = new CleanAndJerk(FrontSquat)
            {
                Repeats = new[]
                {
                    new SingleRepeat {Weight = Stats.Bar, Repeats = 6}
                }
            };

            var ex2 = new CleanAndJerk(CleanPull, Clean)
            {
                Repeats = new Repeat[]
                {
                    new MultiRepeat {Percent = 0.5, Repeats = new[] {2, 2}, Sets = 2},
                    new MultiRepeat {Percent = 0.6, Repeats = new[] {2, 2}, Sets = 3}
                }
            };

            var ex3 = new CleanAndJerk(CleanPullSlowlyDown)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat {Percent = 0.7, Repeats = 3},
                    new SingleRepeat {Percent = 0.9, Repeats = 3, Sets = 2},
                    new SingleRepeat {Percent = 1.0, Repeats = 3, Sets = 2},
                    new SingleRepeat {Percent = 1.05, Repeats = 2, Sets = 2}
                }
            };

            var ex4 = new Accessory(BoxJump)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat {Repeats = 5, Sets = 4}
                }
            };

            var session = new Session
            {
                Rounds = new Round[]
                {
                    new(3, ex1A, ex1B, ex1C),
                    new(ex2),
                    new(ex3),
                    new(ex4)
                }
            };

            return session;
        }

        private static Session GetSession3_3()
        {
            var ex1A = new Accessory(Hyperextension)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat {Repeats = 15}
                }
            };

            var ex1B = new Accessory(Crunch)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat {Repeats = 20}
                }
            };

            var ex2 = new Snatch(PowerSnatch, OverheadSquat)
            {
                Repeats = new Repeat[]
                {
                    new MultiRepeat {Percent = 0.5, Repeats = new[] {2, 4}, Sets = 4}
                }
            };

            var ex3 = new Snatch(MediumGripPull)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat {Percent = 0.5, Repeats = 5},
                    new SingleRepeat {Percent = 0.7, Repeats = 5},
                    new SingleRepeat {Percent = 0.9, Repeats = 5, Sets = 3}
                }
            };

            var ex4 = new BackSquat(BackSquatNarrowFeet)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat {Percent = 0.5, Repeats = 4},
                    new SingleRepeat {Percent = 0.6, Repeats = 4},
                    new SingleRepeat {Percent = 0.7, Repeats = 4, Sets = 4}
                }
            };

            var ex5 = new Snatch(SotsPress)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat {Percent = 0.3, Repeats = 8, Sets = 4}
                }
            };

            var session = new Session
            {
                Rounds = new Round[]
                {
                    new(3, ex1A, ex1B),
                    new(ex2),
                    new(ex3),
                    new(ex4),
                    new(ex5)
                }
            };

            return session;
        }

        private static Session GetSession3_4()
        {
            var ex1 = new Snatch(ExerciseType.Snatch)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat {Percent = 0.5, Repeats = 2, Sets = 2},
                    new SingleRepeat {Percent = 0.6, Repeats = 2, Sets = 2},
                    new SingleRepeat {Percent = 0.7, Repeats = 2, Sets = 3}
                }
            };

            var ex2 = new CleanAndJerk(Clean, Jerk)
            {
                Repeats = new Repeat[]
                {
                    new MultiRepeat {Percent = 0.5, Repeats = new[] {2, 2}, Sets = 5}
                }
            };

            var session = new Session
            {
                Rounds = new Round[]
                {
                    new(ex1),
                    new(ex2)
                }
            };

            return session;
        }

        private static Session GetSession3_5()
        {
            var ex1A = new Accessory(ReverseHyperextension)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat {Repeats = 15}
                }
            };

            var ex1B = new Accessory(Crunch)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat {Repeats = 20}
                }
            };

            var ex1C = new CleanAndJerk(FrontSquat)
            {
                Repeats = new[]
                {
                    new SingleRepeat {Weight = Stats.Bar, Repeats = 6}
                }
            };

            var ex2 = new CleanAndJerk(MuscleSquatClean)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat {Percent = 0.5, Repeats = 5, Sets = 3}
                }
            };

            var ex3 = new CleanAndJerk(FrontSquat)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat {Percent = 0.5, Repeats = 3},
                    new SingleRepeat {Percent = 0.7, Repeats = 3},
                    new SingleRepeat {Percent = 0.8, Repeats = 3, Sets = 2},
                    new SingleRepeat {Percent = 0.9, Repeats = 3},
                    new SingleRepeat {Percent = 1.0, Repeats = 3, Sets = 3}
                }
            };

            var ex4 = new CleanAndJerk(JerkSupport)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat {Percent = 1.1, Repeats = 1, Sets = 4}
                }
            };

            var ex5 = new CleanAndJerk(GoodMorningSquat)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat {Percent = 0.4, Repeats = 8, Sets = 3}
                }
            };

            var session = new Session
            {
                Rounds = new Round[]
                {
                    new(3, ex1A, ex1B, ex1C),
                    new(ex2),
                    new(ex3),
                    new(ex4),
                    new(ex5)
                }
            };

            return session;
        }

        private static Session GetSession4_1()
        {
            var ex1A = new Accessory(Hyperextension)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat {Repeats = 15}
                }
            };

            var ex1B = new Accessory(Crunch)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat {Repeats = 20}
                }
            };

            var ex2 = new Snatch(HipSnatch)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat {Percent = 0.5, Repeats = 4, Sets = 2},
                    new SingleRepeat {Percent = 0.6, Repeats = 4, Sets = 3}
                }
            };

            var ex3 = new Snatch(DeficitSnatchPull)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat {Percent = 0.7, Repeats = 4, Sets = 2},
                    new SingleRepeat {Percent = 0.8, Repeats = 4, Sets = 2},
                    new SingleRepeat {Percent = 0.9, Repeats = 3, Sets = 2},
                    new SingleRepeat {Percent = 1.0, Repeats = 1}
                }
            };

            var ex4 = new BackSquat(BackSquatWithPause)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat {Percent = 0.5, Repeats = 2},
                    new SingleRepeat {Percent = 0.6, Repeats = 2},
                    new SingleRepeat {Percent = 0.7, Repeats = 2},
                    new SingleRepeat {Percent = 0.8, Repeats = 2, Sets = 3}
                }
            };

            var session = new Session
            {
                Rounds = new Round[]
                {
                    new(3, ex1A, ex1B),
                    new(ex2),
                    new(ex3),
                    new(ex4)
                }
            };

            return session;
        }

        private static Session GetSession4_2()
        {
            var ex1A = new Accessory(ReverseHyperextension)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat {Repeats = 15}
                }
            };

            var ex1B = new Accessory(Crunch)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat {Repeats = 20}
                }
            };

            var ex1C = new CleanAndJerk(FrontSquat)
            {
                Repeats = new[]
                {
                    new SingleRepeat {Weight = Stats.Bar, Repeats = 6}
                }
            };

            var ex2 = new CleanAndJerk(CleanFromBlocks, FrontSquat)
            {
                Repeats = new Repeat[]
                {
                    new MultiRepeat {Percent = 0.5, Repeats = new[] {2, 3}, Sets = 2},
                    new MultiRepeat {Percent = 0.6, Repeats = new[] {2, 3}, Sets = 2},
                    new MultiRepeat {Percent = 0.7, Repeats = new[] {1, 3}, Sets = 2}
                }
            };

            var ex3 = new CleanAndJerk(CleanPullFromBlocks)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat {Percent = 0.8, Repeats = 4},
                    new SingleRepeat {Percent = 0.9, Repeats = 4, Sets = 2},
                    new SingleRepeat {Percent = 1.0, Repeats = 3, Sets = 3},
                    new SingleRepeat {Percent = 1.1, Repeats = 2, Sets = 2}
                }
            };

            var ex4 = new Accessory(BoxJump)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat {Repeats = 6, Sets = 4}
                }
            };

            var session = new Session
            {
                Rounds = new Round[]
                {
                    new(3, ex1A, ex1B, ex1C),
                    new(ex2),
                    new(ex3),
                    new(ex4)
                }
            };

            return session;
        }
    }
}