using System.Diagnostics.CodeAnalysis;

namespace PcPartPickerProject;

public class Cpu
{
    public required Guid Id { get; set; }
    public string chipsetType { get; private set; }
    public Manufacturer producer { get; set; }
    public string model { get; set; }
    public int coreCount { get; set; }
    public double performanceCoreBoostClock { get; set; }
    public string microarchitecture { get; set; }
    public int tdp { get; set; }

    #region Enum

    enum IntegratedGpu{ Intel,AMD,None }
    public enum Manufacturer
    {
        Intel,
        AMD
    }
    #endregion
    [SetsRequiredMembers]
    public Cpu(Manufacturer prod, string model, int coreCount, double performanceCoreBoostClock, string microarchitecture, string chipsetType, int tdp)
    {
        Id = Guid.NewGuid();
        producer = prod;
        this.model = model;
        this.chipsetType = chipsetType;
        this.coreCount = coreCount;
        this.performanceCoreBoostClock = performanceCoreBoostClock;
        this.microarchitecture = microarchitecture;
        this.tdp = tdp;
    }
}