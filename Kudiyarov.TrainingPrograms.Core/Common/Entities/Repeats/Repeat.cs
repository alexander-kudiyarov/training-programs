namespace Kudiyarov.TrainingPrograms.Core.Common.Entities.Repeats
{
    public abstract class Repeat
    {
        public double? Percent { get; init; }
        public double? Weight { get; set; }
        public int Sets { get; init; } = 1;
    }
}