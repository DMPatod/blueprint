using Blueprint.Domain.Steps.Interfaces;

namespace Blueprint.Domain.Blueprints
{
    public class Blueprint
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public IStep Step { get; set; }
    }
}
