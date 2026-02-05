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
    public enum RamSpeed
    {
        DDR_333,
        DDR_400,
        DDR2_400,
        DDR2_533,
        DDR2_667,
        DDR2_800,
        DDR3_1066,
        DDR3_1333,
        DDR3_1600,
        DDR4_2400,
        DDR4_2666,
        DDR4_2933,
        DDR4_3200,
        DDR4_3600,
        DDR4_4000,
        DDR4_4400,
        DDR5_4800,
        DDR5_5600,
        DDR5_6000,
        DDR5_6400,
        DDR5_7500,
        DDR5_8500
    }
    public RamSpeed type { get; set; }
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
    public enum FormFactor{
        SODIMM,
        DIMM
    }
    public FormFactor formFactor { get; set; }
    public Ram(string model, RamManufacturer ramManufacturer, int quantita, RamSpeed type, FormFactor formFactor, MemorySize memorySize)
    {
        this.model = model;
        this.quantita = quantita;
        this.type =  type;
        this.formFactor = formFactor;
        this.memorySize = memorySize;
        this.ramManufacturer = ramManufacturer;
    }
}