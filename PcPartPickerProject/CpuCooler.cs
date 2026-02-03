namespace PcPartPickerProject;

public class CpuCooler
{
    private string manufacturer;
    public List<string> chipsetType;

    public CpuCooler(string manufacturer, List<string> chipsetType)
    {
        this.manufacturer = manufacturer;
        this.chipsetType = chipsetType;
    }
}