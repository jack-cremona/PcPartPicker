namespace PcPartPickerProject;

public class CpuCooler
{
    public string manufacturer { get;  set; }
    public List<string> chipsetType { get; set; }
    public string model {get; private set;}

    public CpuCooler(string manufacturer, string model, List<string> chipsetType)
    {
        this.model = model;
        this.manufacturer = manufacturer;
        this.chipsetType = chipsetType;
    }
}