using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestVas___ilon.Models
{
    public class BatchERP
    {
        public string SEGMENT { get; set; }
        public string componentNumber { get; set; }
        public string componentBatchNumber { get; set; }
        public string componentBatchNumberQuantity { get; set; }
        public string componentBatchNumberUOM { get; set; }
        public string baseQuantity { get; set; }
        public string baseUnitOfMeasure { get; set; }
        public string componentBatchLocation { get; set; }
        public string storageType { get; set; }
        public string storageBin { get; set; }
        public string reservationNumber { get; set; }
        public string itemCategory { get; set; }
        public string BOM_ItemNumber { get; set; }
        public string reservationItemNumber { get; set; }
        public string itemNumberOfReservations { get; set; }
        public List<CharacteristicsERP> characteristics { get; set; }
    }
    public class CharacteristicsERP
    {
        public List<DataStructureERP> dataStructureERP { get; set; }
    }

    public class DataStructureERP 
    {
        public string SEGMENT { get; set; }
        public string batchCharacteristicsName { get; set; }
        public string batchCharacteristicsValue { get; set; }
    }
}