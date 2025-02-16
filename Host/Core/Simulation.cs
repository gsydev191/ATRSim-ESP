

using Serilog.Core;

namespace Host.Core;

public class Simulation
{
    public void Initialize()
    {
       LogManager.Info("Simulation initialized"); 
    }

    public void Run()
    {
        
    }

    public void Pause()
    {
        
    }

    public void Resume()
    {
        
    }

    public void Stop()
    {
        
    }

    public void Shutdown()
    {
        LogManager.Info("Simulation shutdown"); 
    }
}