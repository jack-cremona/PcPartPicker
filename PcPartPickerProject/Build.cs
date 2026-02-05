using System.Diagnostics.CodeAnalysis;

namespace PcPartPickerProject;

public class Build
{
    public required Guid Id { get; set; }
    public Motherboard? motherboard { get; set
        {
            if (IsCompatible(value))
                field = value;
        } 
    }

    public Cpu? processor { get; set
        {
            if (IsCompatible(value))
                field = value;
        } 
    }

    public CpuCooler? cpuCooler { get; set
        {
            if (IsCompatible(value))
                field = value;
        } 
    }

    //public CpuCooler cpuCooler { get; private set; }
    public List<Ram> memory { get; private set; }
    public Gpu gpu { get; private set; }
    public List<Storage> storage;
    public Case pcCase { get; private set; }
    public PowerSupplyUnit psuUnit { get; private set; } 
    public bool IsComplete { get; private set; }
    
    [SetsRequiredMembers]
    public Build()
    {
        Id = Guid.NewGuid();
        IsComplete = false;
    }
    
    public bool IsCompatible(Cpu? cpu)
    {
        return cpu == null || (cpuCooler == null || cpuCooler.chipsetType.Contains(cpu.chipsetType))
            && (motherboard == null || cpu?.chipsetType.ToString() == motherboard?.chipsetType.ToString());
    }

    public bool IsCompatible(Motherboard? mobo)
    {
        return mobo == null || (cpuCooler == null || cpuCooler.chipsetType.Contains(mobo.chipsetType))
            && (processor == null || processor?.chipsetType == mobo?.chipsetType);
    }
  
  
    public bool IsCompatible(CpuCooler? cpuCoolerObject)
    {
        return cpuCoolerObject == null || (motherboard == null || cpuCoolerObject.chipsetType.Contains(motherboard.chipsetType))
            && (processor == null || cpuCoolerObject.chipsetType.Contains(processor.chipsetType));
    }

    /*
    public bool IsCompatibleCase(Case? caseObject)
    {
        return caseObject == null || (motherboard == null || caseObject.MotherboardFormFactors.ToString().Contains(motherboard.formFactor.ToString()))
    }
    */
    
    
}
