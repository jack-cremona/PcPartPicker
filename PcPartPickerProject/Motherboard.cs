using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace PcPartPickerProject;

public class Motherboard
{
    public required Guid Id { get; set; }
    public string chipsetType { get; private set; }
    public int sataSlots { get; private set; }
    public int m2Slots { get; private set; }
    public string model { get; set; }
    
    public Manufacturer manufacturer { get; set; }
    
    public FormFactor formFactor { get; set; }

    [Range(1, 1024)]
    public int memoryMax { get; set; } //gb

    [Range(1, 1024)]
    public int memorySlots { get; set; }

    #region Enum
  
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
    #endregion
    //costruttore
    [SetsRequiredMembers]
    public Motherboard(string chipsetType, int sataSlots, int m2Slots, string model, Manufacturer manufacturer, FormFactor formFactor, int memoryMax, int memorySlots)
    {
        Id = Guid.NewGuid();
        this.chipsetType = chipsetType;
        this.sataSlots = sataSlots;
        this.m2Slots = m2Slots;
        this.model = model;
        this.manufacturer = manufacturer;
        this.formFactor = formFactor;
        this.memoryMax = memoryMax;
        this.memorySlots = memorySlots;
    }
}