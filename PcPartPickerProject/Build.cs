namespace PcPartPickerProject;

public class Build
{
    public Motherboard motherboard { get; private set; }
    public Cpu processor { get; private set; }
    public CpuCooler cpuCooler { get; private set; }
    public List<Ram> memory { get; private set; }
    public Gpu gpu { get; private set; }
    public List<Storage> storage;
    public Case pcCase { get; private set; }
    public PowerSupplyUnit psuUnit { get; private set; } 
    public bool IsComplete { get; private set; }
    public Build()
    {
        IsComplete = false;
    }
    public Cpu? Cpu { get; set
        {
            if (IsCompatible(value))
                field = value;
        } 
    }
    public bool IsCompatible(Cpu? cpu)
    {
        /*return cpu == null || (CpuCooler == null || cpu?.Chipset == CpuCooler?.ChipsetCompatibility)
            && (Motherboard == null || cpu?.Chipset == Motherboard?.ChipsetCompatibility);*/
        return cpu=null;
    }
}
