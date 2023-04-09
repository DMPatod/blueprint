using Blueprint.Domain.Steps.Emuns;

namespace Blueprint.Domain.Steps.Interfaces
{
    public interface IStep
    {
        string Name { get; set; }
        string Description { get; set; }
        void Conclude(StepResult result);
    }
}
