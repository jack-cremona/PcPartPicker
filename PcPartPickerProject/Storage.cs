namespace PcPartPickerProject;

public class Storage
{
    string manufacturer { get; set; }
    string model { get; set; }
    int cache { get; set; }
    int capacity { get; set; }
    public enum Type 
    {
        SATA,
        M2
    }
    public Type type { get; private set; }
    string formFactor { get; set; }
    public Storage(string manufacturer, string model, int cache, int capacity, Type type)
    {
        this.manufacturer = manufacturer;
        this.model = model;
        this.cache = cache;
        this.capacity = capacity;
        this.type = type;
        /*this.type = type;
        if (type.Contains("RPM"))
            this.formFactor = "3.5\"";
        else if (type.Contains("SSD SATA"))
            this.formFactor = "2.5\"";
        else
            this.formFactor = "M.2";*/
    }
}