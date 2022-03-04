using DiRegistrationLifeTime.Services.Interfaces;

namespace DiRegistrationLifeTime.Services
{
    public class TestService : ISingletonService, IScopedService, ITransientService
    {
        public string ServiceUniqueIdentifier { get;} = Guid.NewGuid().ToString();
    }
}
