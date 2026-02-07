namespace PcPartPickerProject;

public static class DB
{
    public static List<Build> builds = [];
    public static List<Motherboard> motherboards = new List<Motherboard>()
    {
        new Motherboard("AM5",4,2,"B650 GAMING PLUS WIFI",Motherboard.Manufacturer.MSI,Motherboard.FormFactor.ATX,192,4),
        new Motherboard("LGA1700",4,3,"Z790 GAMING WIFI7",Motherboard.Manufacturer.Asus,Motherboard.FormFactor.ATX,192,4)
    };

    public static List<Cpu> cpus = new List<Cpu>()
    {
        new Cpu(Cpu.Manufacturer.AMD,"Ryzen 7 9800X3D",8,5.2,"Zen5","AM5",120),
        new Cpu(Cpu.Manufacturer.Intel,"i7-14700K",20,5.6,"Raptor Lake Refresh","LGA1700",125),
        new Cpu(Cpu.Manufacturer.AMD, "Ryzen 9 9950X", 16, 5.7, "Zen5", "AM5", 170),
        new Cpu(Cpu.Manufacturer.Intel, "Core i9-14900K", 24, 6.0, "Raptor Lake Refresh", "LGA1700", 125)
            
    };
    
    public static List<CpuCooler> cpuCoolers = new List<CpuCooler>()
    {
        new CpuCooler(
            "Cooler Master",
            "Hyper 212 Black Edition",
            new List<string> { "AM4", "AM5", "LGA1700" }
        ),
        new CpuCooler(
            "Noctua",
            "NH-D15",
            new List<string> { "LGA1200", "LGA1700", "AM4", "AM5" }
        ),
        new CpuCooler(
            "Arctic",
            "Freezer 34 eSports DUO",
            new List<string> { "AM4", "AM5", "LGA1700" }
        )
    };
    
    
    public static List<Gpu> gpus = new List<Gpu>()
    {
        new Gpu(
            "GeForce RTX 4070",
            Gpu.Manufacturer.MSI,
            Gpu.GpuChipsetType.NvidiaGeForce,
            12,          // GB
            1920f,       // Core Clock MHz (base)
            2475f,       // Boost Clock MHz
            242          // Lunghezza mm
        ),

        new Gpu(
            "Radeon RX 7800 XT",
            Gpu.Manufacturer.Sapphire,
            Gpu.GpuChipsetType.AMDRadeonRX,
            16,          // GB
            1295f,       // Core Clock MHz (base)
            2430f,       // Boost Clock MHz
            280          // Lunghezza mm
        ),

        new Gpu(
            "Arc A770",
            Gpu.Manufacturer.Intel,
            Gpu.GpuChipsetType.IntelArc,
            16,          // GB
            2100f,       // Core Clock MHz (base)
            2400f,       // Boost Clock MHz
            280          // Lunghezza mm
        )
    };
    
    public static List<Ram> rams = new List<Ram>()
    {
        // DDR4 Desktop 16GB (2x8) 3200 MHz
        new Ram(
            model: "Vengeance LPX",
            ramManufacturer: Ram.RamManufacturer.Corsair,
            quantita: 2,
            type: Ram.RamSpeed.DDR4_3200,
            formFactor: Ram.FormFactor.DIMM,
            memorySize: Ram.MemorySize.GB16
        ),

        // DDR5 Desktop 32GB (2x16) 6000 MHz
        new Ram(
            model: "FURY Beast",
            ramManufacturer: Ram.RamManufacturer.Kingston,
            quantita: 2,
            type: Ram.RamSpeed.DDR5_6000,
            formFactor: Ram.FormFactor.DIMM,
            memorySize: Ram.MemorySize.GB32
        ),

        // DDR4 SODIMM Notebook 32GB (2x16) 3200 MHz
        new Ram(
            model: "Ripjaws",
            ramManufacturer: Ram.RamManufacturer.GSkill,
            quantita: 2,
            type: Ram.RamSpeed.DDR4_3200,
            formFactor: Ram.FormFactor.SODIMM,
            memorySize: Ram.MemorySize.GB32
        ),

        // DDR5 Desktop 64GB (2x32) 5600 MHz
        new Ram(
            model: "Trident Z5",
            ramManufacturer: Ram.RamManufacturer.GSkill,
            quantita: 2,
            type: Ram.RamSpeed.DDR5_5600,
            formFactor: Ram.FormFactor.DIMM,
            memorySize: Ram.MemorySize.GB64
        ),

        // DDR3 Desktop 8GB (2x4) 1600 MHz – per piattaforme più vecchie
        new Ram(
            model: "Ballistix Sport",
            ramManufacturer: Ram.RamManufacturer.Crucial,
            quantita: 2,
            type: Ram.RamSpeed.DDR3_1600,
            formFactor: Ram.FormFactor.DIMM,
            memorySize: Ram.MemorySize.GB8
        )
    };
}