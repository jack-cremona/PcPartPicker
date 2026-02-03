namespace PcPartPickerProject;

public class Gpu
{
    string model { get; set; }
    public enum Manufacturer
    {
        Acer,
        AMD,
        ASRock,
        Asus,
        ATI,
        BFG,
        Biostar,
        Club3D,
        Colorful,
        Corsair,
        Dell,
        Diamond,
        ECS,
        EVGA,
        Gainward,
        GALAX,
        Galaxy,
        Gigabyte,
        HIS,
        HP,
        Inno3D,
        Intel,
        Jaton,
        KFA2,
        Leadtek,
        Lenovo,
        Matrox,
        MAXSUN,
        MSI,
        NVIDIA,
        OcUK,
        ONIX,
        Palit,
        PNY,
        PowerColor,
        Sapphire,
        SONNETTechnologies,
        Sparkle,
        VisionTek,
        XFX,
        Yeston,
        Zogis,
        Zotac
    }
    
    public Manufacturer manufacturer { get; private set; }
    
    public enum GpuChipsetType
    {
        // Intel
        IntelArc,        // es: Arc A310, A380, A750, A770, B570, B580
        IntelArcPro,     // es: Arc Pro A40, A50, A60, B50
        // AMD
        AMDFireGL,       // es: FireGL V7300
        AMDFirePro,      // es: FirePro V/W/S serie, R/S/G/…
        AMDRadeon,       // es: Radeon X/HD/R5/R7/R9 (serie “Radeon” generica)
        AMDRadeonRX,     // es: RX 460 … RX 7900 XTX, RX 7xxx/6xxx/5xxx
        AMDRadeonPro,    // es: Radeon Pro W/WX serie, Pro Duo
        AMDRadeonVega,   // es: RX VEGA 56/64, Radeon VII, Vega Frontier Edition
        // NVIDIA (consumer & pro)
        NvidiaGeForce,           // es: GeForce 210 … GTX 10xx/16xx, RTX 20/30/40/50 consumer
        NvidiaQuadro,            // es: Quadro FX/K/M/P/RTX (branding Quadro)
        NvidiaNVS,               // es: NVS 295, 420, 450, 810
        NvidiaTitan,             // es: TITAN RTX, GTX Titan, Titan X, Titan V
        NvidiaRTXProfessional,   // es: RTX A400/A2000/A5000/A6000, RTX 2000/4000/5000/6000 Ada Gen
        NvidiaTSeries            // es: T400, T600, T1000 (workstation entry)
    }
    
    public GpuChipsetType chipsetType { get; private set; }
    
    int memory { get; set; } // in GB
    float coreClock { get; set; } // in MHz
    float boostClock { get; set; } // in MHz
    int length { get; set; } //in mm


    public Gpu(string model, Manufacturer manufacturer, GpuChipsetType chipsetType, int memory, float coreClock, float boostClock, int length)
    {
        if(model == null)
            throw new ArgumentException("model is null");
        this.model = model;

        this.manufacturer = manufacturer;
        this.chipsetType = chipsetType;
        
        if(memory <= 0)
            throw new ArgumentException("memory <= 0");
        this.memory = memory;
        
        
        this.coreClock = coreClock;
        this.boostClock = boostClock;
        this.length = length;
    }
}