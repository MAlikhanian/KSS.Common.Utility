namespace KSS.Common.Utility.Enum.Base
{
    public enum SystemId : byte
    {
        _000_ERP = 0,
        _001_SM = 1,
        _002_DMS = 2,
        _003_PMS = 3,
        _004_AMS = 4,
        _005_SAWMS = 5,
        _006_CMS = 6,
        _011_AMS = 11,
        _013_PMS = 13,
        _015_TMS = 15,
        _017_CMS = 17,
    }

    public enum TransactionLogTypeId : byte
    {
        View = 1,
        Add = 2,
        Update = 3,
        Remove = 4,
    }

    public enum DataType
    {
        Byte,
        Short,
        Integer,
        Long,
        Float,
        Double,
        String,
        DateTime,
        Boolean,
    }

    public enum Status : byte
    {
        Inserted = 1,
        Deleted = 255,
    }
}
