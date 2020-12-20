﻿using System;
using Core.Entities.Enums;
using Core.Entities.Enums.Exercises;

namespace Core.Entities.Exercises
{
    public class BackSquat : BaseExercise
    {
        private readonly BackSquatType _type;

        public BackSquat(BackSquatType type) : base(Stats.BackSquat)
        {
            _type = type;
        }

        public BackSquat(double baseWeight, BackSquatType type) : base(baseWeight)
        {
            _type = type;
        }

        public override string Name => _type switch
        {
            BackSquatType.BaseBackSquat => "Back Squat",
            BackSquatType.BenchBackSquat => "Bench Back Squat",
            _ => throw new ArgumentOutOfRangeException(nameof(_type), "Type is not defined")
        };

        public override EquipmentType EquipmentType => EquipmentType.Barbell;
    }
}