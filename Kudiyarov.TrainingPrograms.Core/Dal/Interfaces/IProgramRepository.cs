using System.Collections.Generic;
using Kudiyarov.TrainingPrograms.Core.Common.Entities;
using Kudiyarov.TrainingPrograms.Core.Common.Entities.Enums;
using Kudiyarov.TrainingPrograms.Core.Common.Entities.Requests;
using Kudiyarov.TrainingPrograms.Core.Common.TrainingPrograms;

namespace Kudiyarov.TrainingPrograms.Core.Dal.Interfaces
{
    public interface IProgramRepository
    {
        IEnumerable<BaseTrainingProgram> Get();
        BaseTrainingProgram Get(ProgramType type);
        Session Get(SessionRequest request);
    }
}