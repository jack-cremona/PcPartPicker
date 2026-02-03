namespace PcPartPickerProject;

public class Cpu
{
    public string chipsetType { get; private set; }

    public enum Manufacturer
    {
        Intel,
        AMD
    }
    
    public Manufacturer producer { get; set; }
    public string model { get; set; }
    public int coreCount { get; set; }
    public double performanceCoreBoostClock { get; set; }
    public string microarchitecture { get; set; }
    public int tdp { get; set; }
    enum IntegratedGpu{ Intel,AMD,None }
    
    public Cpu(Manufacturer prod, string model, int coreCount, double performanceCoreBoostClock, string microarchitecture, string chipsetType, int tdp)
    {
        producer = prod;
        this.model = model;
        this.chipsetType = chipsetType;
        this.coreCount = coreCount;
        this.performanceCoreBoostClock = performanceCoreBoostClock;
        this.microarchitecture = microarchitecture;
        this.tdp = tdp;
    }
}