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
    string model { get; set; }
    int coreCount { get; set; }
    float performanceCoreBoostClock { get; set; }
    string microarchitecture { get; set; }
    int tdp { get; set; }
    enum IntegratedGpu{ Intel,AMD,None }
    
    /*public Cpu(Manufacturer prod, string model, int coreCount, float performanceCoreBoostClock, string microarchitecture, int tdp)
    {

        producer = prod;

        if(model == null)
            throw new ArgumentNullException("model is null");
        this.model = model;

        if(coreCount <= 0)
            throw new ArgumentException("coreCount <= 0");
        this.coreCount = coreCount;

        if(performanceCoreBoostClock <= 0)
            throw new ArgumentException("performanceCoreBoostClock <= 0");
        this.performanceCoreBoostClock = performanceCoreBoostClock;
    
        if(microarchitecture == null)
            throw new ArgumentNullException("microarchitecture is null");
        this.microarchitecture = microarchitecture;
        
        if(tdp <= 0)
            throw new ArgumentException("tdp <= 0");
        this.tdp = tdp;
    }*/
}