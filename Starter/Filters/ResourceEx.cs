using Microsoft.AspNetCore.Mvc.Filters;

namespace Starter.Filters
{
    public class ResourceEx : Attribute, IResourceFilter
    {

        private readonly string _name;
        private readonly ILogger<ResourceEx> _logger;
        private readonly Guid _randomId;


        public ResourceEx(ILogger<ResourceEx> logger, string name="Global")
        {
            this._logger = logger;
            this._name = name;
            _randomId = Guid.NewGuid();
        }

        public void OnResourceExecuted(ResourceExecutedContext context)
        {
            _logger.LogInformation("On Resource Executed" + _randomId);
        }

        public void OnResourceExecuting(ResourceExecutingContext context)
        {
            _logger.LogInformation("On Resource Executing" + _randomId);
        }
    }
}
