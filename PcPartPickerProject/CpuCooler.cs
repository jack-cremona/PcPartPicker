using System.Diagnostics.CodeAnalysis;

namespace PcPartPickerProject;

public class CpuCooler
{
    public required Guid Id { get; set; }
    public string manufacturer { get;  set; }
    public List<string> chipsetType { get; set; }
    public string model {get; private set;}

    [SetsRequiredMembers]
    public CpuCooler(string manufacturer, string model, List<string> chipsetType)
    {
        Id = Guid.NewGuid();
        this.model = model;
        this.manufacturer = manufacturer;
        this.chipsetType = chipsetType;
    }
}