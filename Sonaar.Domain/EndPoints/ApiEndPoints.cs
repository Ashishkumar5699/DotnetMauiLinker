using System;

namespace Sonaar.Domain.EndPoints;

public static class ApiEndPoints
{
    #region Account
    public const string Register = "/api/Account/register";

    public const string Login = "/api/Account/login";

    #endregion

    #region Contacts
    public const string AddContacts = "/api/Contacts/AddContacts";

    public const string GetAllContacts = "/api/Contacts/GetAllContacts";

    
    public const string GetContactswithPhone = "/api/Contacts/GetContactswithPhone";

    #endregion

    #region FirmManagement
    public const string AddFirmData = "/api/FirmManagement/AddFirmData";

    public const string UpdateFirmData = "/api/FirmManagement/UpdateFirmData";

    public const string GetAllFirmData = "/api/FirmManagement/GetAllFirmData";

    public const string GetFirmDataByID = "/api/FirmManagement/GetFirmDataByID";
    
    #endregion

    #region Pdf

    public const string GenerateQuotation = "/api/Pdf/GenerateQuotation";

    public const string GenerateQuotationWithID = "/api/Pdf/GenerateQuotationWithID";

    #endregion

    #region PreSale
    public const string CreatePreSale = "/api/PreSale/CreatePreSale";

    public const string DeletePreSale = "/api/PreSale/DeletePreSale";

    public const string GetAllPreSales = "/api/PreSale/GetAllPreSales";

    public const string UpdatePreSale = "/api/PreSale/UpdatePreSale";

    #endregion

    #region Quotation
    public const string CreateQuotation = "/api/Quotation/CreateQuotation";

    public const string CreateNewQuotation = "/api/Quotation/CreateNewQuotation";

    public const string GetAllQuotation = "/api/Quotation/GetAllQuotation";

    public const string DeleteQuotation = "/api/Quotation/DeleteQuotation";

    #endregion

    #region StatementConfiguration
    public const string MonthlyQuatation = "/api/Statement/MonthlyStatementQuotation";
    #endregion

    #region Rate
    public const string TodayRate = "/api/Rate/TodayRate";
    #endregion
}
