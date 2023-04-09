using Blueprint.Domain.Steps.Emuns;
using Blueprint.Domain.Steps.Interfaces;
using Microsoft.Extensions.Logging;

namespace Blueprint.Domain.Steps
{
    internal class ConditionalStep : IStep
    {
        private readonly ILogger<ConditionalStep> _logger;

        public ConditionalStep(ILogger<ConditionalStep> logger)
        {
            _logger = logger;
        }

        public string Name { get; set; } = "Conditional Step";
        public string Description { get; set; } = "";
        public void Conclude(StepResult result)
        {
            _logger.LogInformation(Name,
                result == StepResult.Success ? "Concluded Successful" : "Concluded with Fail");
        }
    }
}
