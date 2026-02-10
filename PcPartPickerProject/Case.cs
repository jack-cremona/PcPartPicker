namespace PcPartPickerProject;

public class Case
{
    public string manufacturer;
    public string model;
    public CaseFormFactor caseFormFactor { get; private set; }
    public int maximumVideoCardLength;
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
    
    public Case(string manufacturer, string model, int maximumVideoCardLength, List<MotherboardFormFactor> listMotherboardFormFactors, CaseFormFactor formFactorCase)
    {
        this.manufacturer = manufacturer;
        this.model = model;
        this.maximumVideoCardLength = maximumVideoCardLength;
        MotherboardFormFactors = listMotherboardFormFactors;
        caseFormFactor = formFactorCase;
    }
}