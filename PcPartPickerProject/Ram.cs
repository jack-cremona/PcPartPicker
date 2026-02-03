namespace PcPartPickerProject;

public class Ram
{
    string model { get; set; }
    public enum RamManufacturer
    {
        Acer,
        ADATA,
        Addlink,
        AMD,
        Antec,
        Apacer,
        Apotop,
        Avexir,
        Biwin,
        Compustocx,
        Corsair,
        Crucial,
        Dell,
        EVGA,
        GSkill,
        GALAX,
        GeIL,
        Gigabyte,
        Gloway,
        GOODRAM,
        HP,
        IBM,
        KFA2,
        KingBank,
        Kingston,
        Klevv,
        Lenovo,
        Lexar,
        Micron,
        Mushkin,
        NeoForza,
        Netac,
        OCZ,
        OLOy,
        Panram,
        Pareema,
        Patriot,
        PNY,
        PROXMEM,
        Samsung,
        SiliconPower,
        SKHynix,
        SuperTalent,
        Supermicro,
        TEAMGROUP,
        Thermaltake,
        Timetec,
        Toshiba,
        Transcend,
        VColor,
        V7,
        VisionTek,
        Wintec,
        YEYIAN
    }
    public RamManufacturer ramManufacturer { get; set; }
    public enum Type
    {
        DDR,
        DDR1,
        DDR2,
        DDR3,
        DDR4,
        DDR5,
    }
    public Type type { get; set; }
    public enum MemorySize
    {
        MB256,
        MB512,
        GB1,
        GB2,
        GB4,
        GB8,
        GB16,
        GB32,
        GB64,
        GB96,
        GB128,
        GB192,
        GB256
    }
    public MemorySize memorySize { get; set; }
    private int quantita { get; set; }
    float speed { get; set; } //in mhz (333 - 9600)
    public enum FormFactor{
        SODIMM,
        DIMM
    }
    public FormFactor formFactor { get; set; }
    public Ram(string model, int quantita, float speed)
    {
        this.model = model;
        this.quantita = quantita;
        this.speed = speed;
    }
}