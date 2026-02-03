namespace PcPartPickerProject;

public class PowerSupplyUnit
{
    int wattage { get; set; }

    public enum modular
    {
        no,
        semi,
        full
    }
    modular mod { get; set; }
    public PowerSupplyUnit(int wattage, modular mod)
    {
        this.wattage = wattage;
        this.mod = mod;
    }
}