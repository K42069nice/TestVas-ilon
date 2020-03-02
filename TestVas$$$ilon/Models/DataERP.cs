using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestVas___ilon.Models
{
    public class DataERP
    {
        public string SEGMENT { get; set; }
        public string logicalSystem { get; set; }
        public string MES_ID { get; set; }
        public string interfaceID { get; set; }
        public string plant { get; set; }
        public string systemStatusLine { get; set; }
        public string orderType { get; set; }
        public string dateOfBOM_Explosion { get; set; }
        public string createdOnDate { get; set; }
        public string releaseDate { get; set; }
        public string outputMaterialNumber { get; set; }
        public string shortDescription { get; set; }
        public string reservationNumber { get; set; }
        public string quantity { get; set; }
        public string UOM { get; set; }
        public string productionVersion { get; set; }
        public string validFromDate_ProductionVersion { get; set; }
        public string validToDate_ProductionVersion { get; set; }
        public string scheduledStartTime { get; set; }
        public string scheduledFinishingDate { get; set; }
        public string scheduledFinishingTime { get; set; }
        public string BOM_Number { get; set; }
        public string alternateBOM_Number { get; set; }
        public string BOM_ECR_Number { get; set; }
        public string BOM_ChangeDate { get; set; }
        public string BOM_ValidFrom { get; set; }
        public string BOM_ValidTo { get; set; }
        public string recipeNumber { get; set; }
        public string storageLocation { get; set; }
        public string recipeCounter { get; set; }
        public string recipeECR_Number { get; set; }
        public string recipeChangeDate { get; set; }
        public string recipeValidFrom { get; set; }
        public string recipeValidTo { get; set; }
        public string batchNumber { get; set; }
        public string dateOfManufacturing { get; set; }
        public string dateOfExpiry { get; set; }
        public List<BomERP> BOM { get; set; }
        public List<RecipeERP> Recipe { get; set; }
        public List<BatchERP> Batch { get; set; }
        public string phase { get; set; }
        public string parentOperation { get; set; }
        public string workcenter { get; set; }
        public string confirmationNumber { get; set; }
        public string earliestStartDate { get; set; }
        public string earliestStartTime { get; set; }
        public string latestFinishDate { get; set; }
        public string latestFinishTime { get; set; }
        public string baseQuantity { get; set; }
        public string UOM_ForOperation { get; set; }
        public string standardValue1 { get; set; }
        public string UOM_ForStdValue1 { get; set; }
        public string standardValue2 { get; set; }
        public string UOM_ForStdValue2 { get; set; }
        public string standardValue3 { get; set; }
        public string UOM_ForStdValue3 { get; set; }
        public string standardValue4 { get; set; }
        public string standardValue5 { get; set; }
        public string confirmedActivity1 { get; set; }
        public string UOM_ForActivityToBeConfirmed1 { get; set; }
        public string recipconfirmedActivity2eCounter { get; set; }
        public string UOM_ForActivityToBeConfirmed2 { get; set; }
        public string confirmedActivity3 { get; set; }
        public string UOM_ForActivityToBeConfirmed3 { get; set; }
        public string confirmedActivity4 { get; set; }
        public string confirmedActivity5 { get; set; }
        public string efficiency { get; set; }
        public string user08 { get; set; }
        public string UOM_ForStdValue4 { get; set; }
        public string UOM_ForStdValue5 { get; set; }
        public string UOM_ForActivityToBeConfirmed4 { get; set; }
        public string UOM_ForActivityToBeConfirmed5 { get; set; }
    }
}
