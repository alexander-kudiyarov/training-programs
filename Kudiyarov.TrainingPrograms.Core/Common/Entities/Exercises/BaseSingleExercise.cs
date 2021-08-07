﻿using Kudiyarov.TrainingPrograms.Core.Common.Entities.Enums;

namespace Kudiyarov.TrainingPrograms.Core.Common.Entities.Exercises
{
    public abstract class BaseSingleExercise : BaseExercise
    {
        protected readonly ExerciseType Type;
        
        protected BaseSingleExercise(double? weight, ExerciseType type) : base(weight)
        {
            Type = type;
        }

        public override string Name => GetName(Type);
    }
}