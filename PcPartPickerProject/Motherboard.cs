namespace PcPartPickerProject;

public class Motherboard
{
    public string chipsetType { get; private set; }
    public int sataSlots { get; private set; }
    public int m2Slots { get; private set; }
    public string model { get; set; }
    public enum Manufacturer
    {
        ASRock,
        Asus,
        Biostar,
        Colorful,
        ECS,
        EVGA,
        Foxconn,
        Gigabyte,
        Intel,
        Jetway,
        MAXSUN,
        MSI,
        NZXT,
        Sapphire,
        Supermicro,
        XFX,
        Zotac
    }
    public Manufacturer manufacturer { get; set; }
    public enum FormFactor
    {
        ATX,
        EATX,
        FlexATX,
        HPTX,
        MicroATX,
        MiniDTX,
        MiniITX,
        SSICEB,
        SSIEEB,
        ThinMiniITX,
        XLATX
    }
    public FormFactor formFactor { get; set; }    
    public int memoryMax { get; set; }
    public int memorySlots { get; set; }

    /*costruttore
    public Motherboard(string chipsetType, int sataSlots, int m2Slots, string model, Manufacturer manufacturer, FormFactor formFactor, int memoryMax, int memorySlots)
    {
        if(chipsetType == null)
            throw new ArgumentNullException("chipsetType is null");
        this.chipsetType = chipsetType;

        if(sataSlots < 0)
            throw new ArgumentException("sataSlots must be greater than 0");
        this.sataSlots = sataSlots;
        
        if(m2Slots < 0)
            throw  new ArgumentOutOfRangeException("m2Slots is less than 0");
        this.m2Slots = m2Slots;
        
        if(model == null)
            throw new ArgumentNullException("model is null");
        this.model = model;
        
        this.manufacturer = manufacturer;
        this.formFactor = formFactor;

        if(memoryMax <= 0)
            throw new ArgumentException("memoryMax must be greater than 0");
        this.memoryMax = memoryMax;

        if(memorySlots <= 0)
            throw new ArgumentException("memorySlots must be greater than 0");
        this.memorySlots = memorySlots;
    }
*/
}