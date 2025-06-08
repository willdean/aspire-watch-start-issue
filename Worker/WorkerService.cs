namespace Worker;

public class WorkerService : BackgroundService
{
    private readonly ILogger<WorkerService> _logger;
    readonly IHostApplicationLifetime _hostApplicationLifetime;

    public WorkerService(ILogger<WorkerService> logger, IHostApplicationLifetime hostApplicationLifetime)
    {
        _logger = logger;
        _hostApplicationLifetime = hostApplicationLifetime;
    }

    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        while (!stoppingToken.IsCancellationRequested)
        {
            if (_logger.IsEnabled(LogLevel.Information))
            {
                _logger.LogInformation("Worker running at: {time}", DateTimeOffset.Now);
            }

            Console.WriteLine("Working running waiting to stop");
            await Task.Delay(5000, stoppingToken);
            Console.WriteLine("Working stopping");
            _hostApplicationLifetime.StopApplication();
        }
    }
}
