using DiRegistrationLifeTime.Services.Interfaces;

namespace DiRegistrationLifeTime.Services
{
    public class DatabaseService
    {
        private readonly ISingletonService singletonService;
        private readonly IScopedService scopedService;
        private readonly ITransientService transientService;

        public DatabaseService(
            ISingletonService singletonService,
            IScopedService scopedService,
            ITransientService transientService)
        {
            this.singletonService = singletonService;
            this.scopedService = scopedService;
            this.transientService = transientService;
        }

        public void SaveData()
        {
            Console.WriteLine("\n|||||||||||| SaveData ||||||||\n");
            Console.WriteLine($"Singleton UID:\t\t{singletonService.ServiceUniqueIdentifier}");
            Console.WriteLine($"Scoped UID:\t\t{scopedService.ServiceUniqueIdentifier}");
            Console.WriteLine($"Transient UID:\t\t{transientService.ServiceUniqueIdentifier}");
            
        }

    }
}
