namespace PcPartPickerProject;

public class PowerSupplyUnit
{
    int wattage { get; set; }
    modular mod { get; set; }
    public enum modular
    {
        no,
        semi,
        full
    }
    public PowerSupplyUnit(int wattage, modular mod)
    {
        this.wattage = wattage;
        this.mod = mod;
    }
}