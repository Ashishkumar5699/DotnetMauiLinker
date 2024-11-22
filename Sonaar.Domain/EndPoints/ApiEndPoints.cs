using System;

namespace Sonaar.Domain.EndPoints;

public class ApiEndPoints
{
    #region Account
    public string Register = "/api/Account/register";

    public string Login = "/api/Account/login";

    #endregion

    #region Contacts
    public string AddContacts = "/api/Contacts/AddContacts";

    public string GetAllContacts = "/api/Contacts/GetAllContacts";

    
    public string GetContactswithPhone = "/api/Contacts/GetContactswithPhone";

    #endregion

    #region FirmManagement
    public string AddFirmData = "/api/FirmManagement/AddFirmData";

    public string UpdateFirmData = "/api/FirmManagement/UpdateFirmData";

    public string GetAllFirmData = "/api/FirmManagement/GetAllFirmData";

    public string GetFirmDataByID = "/api/FirmManagement/GetFirmDataByID";
    
    #endregion

    #region Pdf

    public string GeneratePDFGPT = "/api/Pdf/GeneratePDFGPT";

    public string GenerateQuotation = "/api/Pdf/GenerateQuotation";

    #endregion

    #region PreSale
    public string CreatePreSale = "/api/PreSale/CreatePreSale";

    public string DeletePreSale = "/api/PreSale/DeletePreSale";

    public string GetAllPreSales = "/api/PreSale/GetAllPreSales";

    public string UpdatePreSale = "/api/PreSale/UpdatePreSale";

    #endregion

    #region Quotation
    public string CreateQuotation = "/api/Quotation/CreateQuotation";

    public string CreateNewQuotation = "/api/Quotation/CreateNewQuotation";

    public string GetAllQuotation = "/api/Quotation/GetAllQuotation";

    public string DeleteQuotation = "/api/Quotation/DeleteQuotation";

    #endregion
}
