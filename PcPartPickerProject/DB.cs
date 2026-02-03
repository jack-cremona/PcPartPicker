namespace PcPartPickerProject;

public static class DB
{
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

}