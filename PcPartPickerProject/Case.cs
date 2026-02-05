namespace PcPartPickerProject;

public class Case
{
    private string manufacturer;
    public CaseFormFactor caseFormFactor { get; private set; }

    //private int powerSupply; //in W
    /*public enum UsbPortType
    {
        USB_3_2_Gen2x2_TypeC,
        USB_3_2_Gen2_TypeC,
        USB_3_2_Gen1_TypeC,
        USB_3_2_Gen1_TypeA,
        USB_2_0_TypeA
    }*/
    
    private int maximumVideoCardLength;
    public List<MotherboardFormFactor> MotherboardFormFactors;
    
    #region enum
    public enum CaseFormFactor
    {
        ATX_Desktop,
        ATX_FullTower,
        ATX_MidTower,
        ATX_MiniTower,
        ATX_TestBench,
        HTPC,
        MicroATX_Desktop,
        MicroATX_MidTower,
        MicroATX_MiniTower,
        MicroATX_Slim,
        MiniITX_Desktop,
        MiniITX_TestBench,
        MiniITX_Tower,
        Rackmount_2U,
        Rackmount_3U,
        Rackmount_4U,
        Rackmount_5U
    }
    public enum MotherboardFormFactor
    {
        ATX,
        Deep_MicroATX,
        Deep_MiniITX,
        EATX,
        Flex_ATX,
        HPTX,
        MicroATX,
        MiniDTX,
        MiniITX,
        SSI_CEB,
        SSI_EEB,
        Thin_MiniITX,
        XL_ATX
    }
    
    #endregion
    
    public Case(string manufacturer, int maximumVideoCardLength, List<MotherboardFormFactor> listMotherboardFormFactors, CaseFormFactor formFactorCase)
    {
        this.manufacturer = manufacturer;
        //this.powerSupply = powerSupply;
        this.maximumVideoCardLength = maximumVideoCardLength;
        MotherboardFormFactors = listMotherboardFormFactors;
        caseFormFactor = formFactorCase;
    }
}