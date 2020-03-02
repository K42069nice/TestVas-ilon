using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestVas___ilon.Models
{
    public class BomERP
    {
        public string SEGMENT { get; set; }
        public string componentNumber { get; set; }
        public string materialShortText { get; set; }
        public string quantityInUnitOfEntry { get; set; }
        public string unitOfEntry { get; set; }
        public string baseQuantity { get; set; }
        public string baseUnitOfMeasure { get; set; }
        public string storageLocation { get; set; }
        public string itemCategory { get; set; }
        public string storageType { get; set; }
        public string storageBin { get; set; }
        public string usageProbabilityPercent { get; set; }
        public string validFromDate { get; set; }
        public string validToDate { get; set; }
        public string numberOfResevations { get; set; }
        public string itemNumberOfResevations { get; set; }
        public string operationNumber { get; set; }
        public string phaseIndicator { get; set; }
        public string BOM_ItemNumber { get; set; }
        public List<MaterialClassCharacteristicsERP> MaterialClassCharacteristics { get; set; }

    }
    public class MaterialClassCharacteristicsERP
    {
        public string pharmaCodeNumeric { get; set; }
        public string pharmaCodePlant { get; set; }
    }
}
