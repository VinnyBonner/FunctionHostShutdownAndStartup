# FunctionHostShutdownAndStartup
Mock example of how to log when a host is shutting down during function execution and when a new host starts back up after the shutdown.

In order for TimerTrigger to [RunOnStartup](https://docs.microsoft.com/en-us/azure/azure-functions/functions-bindings-timer?tabs=in-process&pivots=programming-language-csharp#attributes) be sure to add the RunOnStartup = true in the TimerTrigger binding.

```
public void Run([TimerTrigger("0 0 0 0 1 *", RunOnStartup = true)]TimerInfo myTimer, ILogger log)
```
