using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace TestVas___ilon.Servicios
{
    public class PruebaDelXML
    {
        public string Prueba(string xml)
        {
            Console.WriteLine("inicio de Prueba");
            string res = "hecho";

            xml = "<?xml version=\"1.0\" encoding=\"UTF - 8\"?><GSK_Canonical_MESGX2><header SEGMENT=\"1\"><logicalSystem>RBPCLNT600</logicalSystem><MES_ID>ASPTEC01</MES_ID><interfaceID>POR</interfaceID><plant>ES51</plant><orderNumber>000200009475</orderNumber><systemStatusLine> REL MSPT PRT PRC SETC APG APGS APRS BCRQ BASC</systemStatusLine><orderType>ZPD1</orderType><dateOfBOM_Explosion>20190311</dateOfBOM_Explosion><createdOnDate>20190226</createdOnDate><releaseDate>20190306</releaseDate><outputMaterialNumber>10000000081445</outputMaterialNumber><shortDescription>AVAMYS ANS 27.5MCG 1X120D_BR</shortDescription><reservationNumber>0260066108</reservationNumber><quantity>     69000.000</quantity><UOM>EA</UOM><productionVersion>1005</productionVersion><validFromDate_ProductionVersion>20160822</validFromDate_ProductionVersion><validToDate_ProductionVersion>99991231</validToDate_ProductionVersion><scheduledStartDate>20190310</scheduledStartDate><scheduledStartTime>203759</scheduledStartTime><scheduledFinishingDate>20190320</scheduledFinishingDate><scheduledFinishingTime>145033</scheduledFinishingTime><BOM_Number>00002148</BOM_Number><alternateBOM_Number>03</alternateBOM_Number><BOM_ECR_Number>500000020630</BOM_ECR_Number><BOM_ChangeDate>20161003</BOM_ChangeDate><BOM_ValidFrom>20161007</BOM_ValidFrom><BOM_ValidTo>99991231</BOM_ValidTo><recipeNumber>00000011</recipeNumber><storageLocation>1000</storageLocation><recipeCounter>16</recipeCounter><recipeECR_Number>500000054227</recipeECR_Number><recipeChangeDate>20180227</recipeChangeDate><recipeValidFrom>20180227</recipeValidFrom><recipeValidTo>99991231</recipeValidTo><batchNumber>A94Y</batchNumber><dateOfManufacturing>20190228</dateOfManufacturing><dateOfExpiry>20220227</dateOfExpiry><BOM SEGMENT=\"1\"><componentNumber>62000000032827</componentNumber><materialShortText>ESTUCHE AVAMYS ANS 27,5MCG 120D BR</materialShortText><quantityInUnitOfEntry>     71415.000</quantityInUnitOfEntry><unitOfEntry>EA</unitOfEntry><baseQuantity>     71415.000</baseQuantity><baseUnitOfMeasure>EA</baseUnitOfMeasure><storageLocation>1000</storageLocation><itemCategory>L</itemCategory><storageType>AL4</storageType><storageBin>AL4</storageBin><usageProbabilityPercent>  0</usageProbabilityPercent><validFromDate>20190226</validFromDate><validToDate>99991229</validToDate><numberOfResevations>0260066108</numberOfResevations><itemNumberOfResevations>0009</itemNumberOfResevations><operationNumber>0020</operationNumber><phaseIndicator>0021</phaseIndicator><BOM_ItemNumber>0090</BOM_ItemNumber><materialClassCharacteristics SEGMENT=\"1\"><pharmaCodeNumeric>1531</pharmaCodeNumeric><pharmaCodePlant>ES51</pharmaCodePlant></materialClassCharacteristics></BOM><BOM SEGMENT=\"1\"><componentNumber>10000000086745</componentNumber><materialShortText>ETIQUETA AVAMYS ANS F 27,5MCG 120D BR</materialShortText><quantityInUnitOfEntry>     72795.000</quantityInUnitOfEntry><unitOfEntry>EA</unitOfEntry><baseQuantity>     72795.000</baseQuantity><baseUnitOfMeasure>EA</baseUnitOfMeasure><storageLocation>1000</storageLocation><itemCategory>L</itemCategory><storageType>AL4</storageType><storageBin>AL4</storageBin><usageProbabilityPercent>  0</usageProbabilityPercent><validFromDate>20160915</validFromDate><validToDate>99991231</validToDate><numberOfResevations>0260066108</numberOfResevations><itemNumberOfResevations>0010</itemNumberOfResevations><operationNumber>0020</operationNumber><phaseIndicator>0021</phaseIndicator><BOM_ItemNumber>0100</BOM_ItemNumber><materialClassCharacteristics SEGMENT=\"1\"><pharmaCodeNumeric>0086745</pharmaCodeNumeric><pharmaCodePlant>ES51</pharmaCodePlant></materialClassCharacteristics></BOM><BOM SEGMENT=\"1\"><componentNumber>62000000001475</componentNumber><materialShortText>ETIQUETA INVIOLABLE BR</materialShortText><quantityInUnitOfEntry>    144900.000</quantityInUnitOfEntry><unitOfEntry>EA</unitOfEntry><baseQuantity>       144.900</baseQuantity><baseUnitOfMeasure>T</baseUnitOfMeasure><storageLocation>1000</storageLocation><itemCategory>L</itemCategory><storageType>AL4</storageType><storageBin>AL4</storageBin><usageProbabilityPercent>  0</usageProbabilityPercent><validFromDate>20160915</validFromDate><validToDate>99991231</validToDate><numberOfResevations>0260066108</numberOfResevations><itemNumberOfResevations>0013</itemNumberOfResevations><operationNumber>0020</operationNumber><phaseIndicator>0021</phaseIndicator><BOM_ItemNumber>0130</BOM_ItemNumber></BOM><BOM SEGMENT=\"1\"><componentNumber>62000000032831</componentNumber><materialShortText>ETIQUETA AVAMYS ANS B 27,5MCG BR</materialShortText><quantityInUnitOfEntry>     72795.000</quantityInUnitOfEntry><unitOfEntry>EA</unitOfEntry><baseQuantity>     72795.000</baseQuantity><baseUnitOfMeasure>EA</baseUnitOfMeasure><storageLocation>1000</storageLocation><itemCategory>L</itemCategory><storageType>AL4</storageType><storageBin>AL4</storageBin><usageProbabilityPercent>  0</usageProbabilityPercent><validFromDate>20190226</validFromDate><validToDate>99991229</validToDate><numberOfResevations>0260066108</numberOfResevations><itemNumberOfResevations>0011</itemNumberOfResevations><operationNumber>0020</operationNumber><phaseIndicator>0021</phaseIndicator><BOM_ItemNumber>0110</BOM_ItemNumber><materialClassCharacteristics SEGMENT=\"1\"><pharmaCodeNumeric>A032831</pharmaCodeNumeric><pharmaCodePlant>ES51</pharmaCodePlant></materialClassCharacteristics></BOM><BOM SEGMENT=\"1\"><componentNumber>62000000032832</componentNumber><materialShortText>PROSPECTO AVAMYS ANS 27,5MCG BR</materialShortText><quantityInUnitOfEntry>     73830.000</quantityInUnitOfEntry><unitOfEntry>EA</unitOfEntry><baseQuantity>        73.830</baseQuantity><baseUnitOfMeasure>T</baseUnitOfMeasure><storageLocation>1000</storageLocation><itemCategory>L</itemCategory><storageType>AL4</storageType><storageBin>AL4</storageBin><usageProbabilityPercent>  0</usageProbabilityPercent><validFromDate>20190226</validFromDate><validToDate>99991229</validToDate><numberOfResevations>0260066108</numberOfResevations><itemNumberOfResevations>0012</itemNumberOfResevations><operationNumber>0020</operationNumber><phaseIndicator>0021</phaseIndicator><BOM_ItemNumber>0120</BOM_ItemNumber><materialClassCharacteristics SEGMENT=\"1\"><pharmaCodeNumeric>7061</pharmaCodeNumeric><pharmaCodePlant>ES51</pharmaCodePlant></materialClassCharacteristics></BOM><BOM SEGMENT=\"1\"><componentNumber>10000000104885</componentNumber><materialShortText>FRASCO VIDRIO III ANS AVAMYS</materialShortText><quantityInUnitOfEntry>     70035.000</quantityInUnitOfEntry><unitOfEntry>EA</unitOfEntry><baseQuantity>     70035.000</baseQuantity><baseUnitOfMeasure>EA</baseUnitOfMeasure><storageLocation>1000</storageLocation><itemCategory>L</itemCategory><storageType>AL4</storageType><storageBin>AL4 T</storageBin><usageProbabilityPercent>  0</usageProbabilityPercent><validFromDate>20160915</validFromDate><validToDate>99991231</validToDate><numberOfResevations>0260066108</numberOfResevations><itemNumberOfResevations>0002</itemNumberOfResevations><operationNumber>0020</operationNumber><phaseIndicator>0021</phaseIndicator><BOM_ItemNumber>0020</BOM_ItemNumber></BOM><BOM SEGMENT=\"1\"><componentNumber>10000000142866</componentNumber><materialShortText>FFNS PUMP VP7 CS15 ANS APTAR</materialShortText><quantityInUnitOfEntry>     70242.000</quantityInUnitOfEntry><unitOfEntry>EA</unitOfEntry><baseQuantity>     70242.000</baseQuantity><baseUnitOfMeasure>EA</baseUnitOfMeasure><storageLocation>1000</storageLocation><itemCategory>L</itemCategory><storageType>AL4</storageType><storageBin>AL4 T</storageBin><usageProbabilityPercent>  0</usageProbabilityPercent><validFromDate>20180813</validFromDate><validToDate>99991231</validToDate><numberOfResevations>0260066108</numberOfResevations><itemNumberOfResevations>0003</itemNumberOfResevations><operationNumber>0020</operationNumber><phaseIndicator>0021</phaseIndicator><BOM_ItemNumber>0030</BOM_ItemNumber><materialClassCharacteristics SEGMENT=\"1\"><pharmaCodeDirection>L-R</pharmaCodeDirection></materialClassCharacteristics></BOM><BOM SEGMENT=\"1\"><componentNumber>10000000064808</componentNumber><materialShortText>ANILLO PLASTICO AVAMYS ANS</materialShortText><quantityInUnitOfEntry>     72450.000</quantityInUnitOfEntry><unitOfEntry>EA</unitOfEntry><baseQuantity>        72.450</baseQuantity><baseUnitOfMeasure>T</baseUnitOfMeasure><storageLocation>1000</storageLocation><itemCategory>L</itemCategory><storageType>AL4</storageType><storageBin>AL4 T</storageBin><usageProbabilityPercent>  0</usageProbabilityPercent><validFromDate>20160915</validFromDate><validToDate>99991231</validToDate><numberOfResevations>0260066108</numberOfResevations><itemNumberOfResevations>0004</itemNumberOfResevations><operationNumber>0020</operationNumber><phaseIndicator>0021</phaseIndicator><BOM_ItemNumber>0040</BOM_ItemNumber></BOM><BOM SEGMENT=\"1\"><componentNumber>10000000064809</componentNumber><materialShortText>COLLAR PLASTICO AVAMYS ANS</materialShortText><quantityInUnitOfEntry>     71070.000</quantityInUnitOfEntry><unitOfEntry>EA</unitOfEntry><baseQuantity>        71.070</baseQuantity><baseUnitOfMeasure>T</baseUnitOfMeasure><storageLocation>1000</storageLocation><itemCategory>L</itemCategory><storageType>AL4</storageType><storageBin>AL4 T</storageBin><usageProbabilityPercent>  0</usageProbabilityPercent><validFromDate>20160915</validFromDate><validToDate>99991231</validToDate><numberOfResevations>0260066108</numberOfResevations><itemNumberOfResevations>0005</itemNumberOfResevations><operationNumber>0020</operationNumber><phaseIndicator>0021</phaseIndicator><BOM_ItemNumber>0050</BOM_ItemNumber></BOM><BOM SEGMENT=\"1\"><componentNumber>10000000064832</componentNumber><materialShortText>TAPA INFERIOR PLASTICO AVAMYS ANS</materialShortText><quantityInUnitOfEntry>     69690.000</quantityInUnitOfEntry><unitOfEntry>EA</unitOfEntry><baseQuantity>        69.690</baseQuantity><baseUnitOfMeasure>T</baseUnitOfMeasure><storageLocation>1000</storageLocation><itemCategory>L</itemCategory><storageType>AL4</storageType><storageBin>AL4 T</storageBin><usageProbabilityPercent>  0</usageProbabilityPercent><validFromDate>20160915</validFromDate><validToDate>99991231</validToDate><numberOfResevations>0260066108</numberOfResevations><itemNumberOfResevations>0006</itemNumberOfResevations><operationNumber>0020</operationNumber><phaseIndicator>0021</phaseIndicator><BOM_ItemNumber>0060</BOM_ItemNumber></BOM><BOM SEGMENT=\"1\"><componentNumber>10000000064830</componentNumber><materialShortText>DISPOSITIVO PLASTICO AVAMYS ANS</materialShortText><quantityInUnitOfEntry>     69345.000</quantityInUnitOfEntry><unitOfEntry>EA</unitOfEntry><baseQuantity>     69345.000</baseQuantity><baseUnitOfMeasure>EA</baseUnitOfMeasure><storageLocation>1000</storageLocation><itemCategory>L</itemCategory><storageType>AL4</storageType><storageBin>AL4 T</storageBin><usageProbabilityPercent>  0</usageProbabilityPercent><validFromDate>20160915</validFromDate><validToDate>99991231</validToDate><numberOfResevations>0260066108</numberOfResevations><itemNumberOfResevations>0007</itemNumberOfResevations><operationNumber>0020</operationNumber><phaseIndicator>0021</phaseIndicator><BOM_ItemNumber>0070</BOM_ItemNumber></BOM><BOM SEGMENT=\"1\"><componentNumber>62000000004454</componentNumber><materialShortText>EMBALAJE AVAMYS ANS</materialShortText><quantityInUnitOfEntry>      1510.000</quantityInUnitOfEntry><unitOfEntry>EA</unitOfEntry><baseQuantity>      1510.000</baseQuantity><baseUnitOfMeasure>EA</baseUnitOfMeasure><storageLocation>1000</storageLocation><itemCategory>L</itemCategory><storageType>AL4</storageType><storageBin>AL4</storageBin><usageProbabilityPercent>  0</usageProbabilityPercent><validFromDate>20160915</validFromDate><validToDate>99991231</validToDate><numberOfResevations>0260066108</numberOfResevations><itemNumberOfResevations>0008</itemNumberOfResevations><operationNumber>0020</operationNumber><phaseIndicator>0021</phaseIndicator><BOM_ItemNumber>0080</BOM_ItemNumber></BOM><BOM SEGMENT=\"1\"><componentNumber>10000000064834</componentNumber><materialShortText>FLUTICASONA FUROATO GRANEL 0,05%</materialShortText><quantityInUnitOfEntry>       690.000</quantityInUnitOfEntry><unitOfEntry>KG</unitOfEntry><baseQuantity>       690.000</baseQuantity><baseUnitOfMeasure>KG</baseUnitOfMeasure><storageLocation>1000</storageLocation><itemCategory>L</itemCategory><usageProbabilityPercent>  0</usageProbabilityPercent><validFromDate>20160915</validFromDate><validToDate>99991231</validToDate><numberOfResevations>0260066108</numberOfResevations><itemNumberOfResevations>0001</itemNumberOfResevations><operationNumber>0020</operationNumber><phaseIndicator>0021</phaseIndicator><BOM_ItemNumber>0010</BOM_ItemNumber></BOM><recipe SEGMENT=\"1\"><phase>0011</phase><parentOperation>0010</parentOperation><workcenter>INHPOHD1</workcenter><confirmationNumber>0006209231</confirmationNumber><earliestStartDate>20190310</earliestStartDate><earliestStartTime>203759</earliestStartTime><latestFinishDate>20190310</latestFinishDate><latestFinishTime>203759</latestFinishTime><baseQuantity>      1000.000</baseQuantity><UOM_ForOperation>EA</UOM_ForOperation><standardValue1>     4.000</standardValue1><UOM_ForStdValue1>UN</UOM_ForStdValue1><standardValue2>     0.200</standardValue2><UOM_ForStdValue2>HR</UOM_ForStdValue2><standardValue3>     0.200</standardValue3><UOM_ForStdValue3>HR</UOM_ForStdValue3><standardValue4>     0.000</standardValue4><standardValue5>     0.000</standardValue5><confirmedActivity1>         4.000</confirmedActivity1><UOM_ForActivityToBeConfirmed1>UN</UOM_ForActivityToBeConfirmed1><confirmedActivity2>        13.800</confirmedActivity2><UOM_ForActivityToBeConfirmed2>HR</UOM_ForActivityToBeConfirmed2><confirmedActivity3>        13.800</confirmedActivity3><UOM_ForActivityToBeConfirmed3>HR</UOM_ForActivityToBeConfirmed3><confirmedActivity4>         0.000</confirmedActivity4><confirmedActivity5>         0.000</confirmedActivity5><efficiency>         0.000</efficiency><user08>00000000</user08></recipe><recipe SEGMENT=\"1\"><phase>0021</phase><parentOperation>0020</parentOperation><workcenter>LPKBFAL4</workcenter><confirmationNumber>0006209233</confirmationNumber><earliestStartDate>20190310</earliestStartDate><earliestStartTime>203759</earliestStartTime><latestFinishDate>20190311</latestFinishDate><latestFinishTime>111558</latestFinishTime><baseQuantity>      1000.000</baseQuantity><UOM_ForOperation>EA</UOM_ForOperation><standardValue1>     0.833</standardValue1><UOM_ForStdValue1>HR</UOM_ForStdValue1><standardValue2>     0.200</standardValue2><UOM_ForStdValue2>HR</UOM_ForStdValue2><standardValue3>     0.000</standardValue3><UOM_ForStdValue3>HR</UOM_ForStdValue3><standardValue4>     3.332</standardValue4><UOM_ForStdValue4>HR</UOM_ForStdValue4><standardValue5>     0.800</standardValue5><UOM_ForStdValue5>HR</UOM_ForStdValue5><confirmedActivity1>         0.833</confirmedActivity1><UOM_ForActivityToBeConfirmed1>HR</UOM_ForActivityToBeConfirmed1><confirmedActivity2>        13.800</confirmedActivity2><UOM_ForActivityToBeConfirmed2>HR</UOM_ForActivityToBeConfirmed2><confirmedActivity3>         0.000</confirmedActivity3><UOM_ForActivityToBeConfirmed3>HR</UOM_ForActivityToBeConfirmed3><confirmedActivity4>         3.332</confirmedActivity4><UOM_ForActivityToBeConfirmed4>HR</UOM_ForActivityToBeConfirmed4><confirmedActivity5>        55.200</confirmedActivity5><UOM_ForActivityToBeConfirmed5>HR</UOM_ForActivityToBeConfirmed5><efficiency>         0.000</efficiency><user08>00000000</user08></recipe><batch SEGMENT=\"1\"><componentNumber>10000000064834</componentNumber><componentBatchNumber>9G4Y</componentBatchNumber><componentBatchNumberQuantity>       690.000</componentBatchNumberQuantity><componentBatchNumberUOM>KG</componentBatchNumberUOM><baseQuantity>       690.000</baseQuantity><baseUnitOfMeasure>KG</baseUnitOfMeasure><componentBatchLocation>1000</componentBatchLocation><storageType>AL4</storageType><storageBin>AL4</storageBin><reservationNumber>0260066108</reservationNumber><itemCategory>L</itemCategory><BOM_ItemNumber>0010</BOM_ItemNumber><reservationItemNumber>0014</reservationItemNumber><itemNumberOfReservations>0001</itemNumberOfReservations><characteristics SEGMENT=\"1\"><batchCharacteristicsName>BC_BATCH_TYPE</batchCharacteristicsName><batchCharacteristicsValue>Standard</batchCharacteristicsValue></characteristics><characteristics SEGMENT=\"1\"><batchCharacteristicsName>BC_GOODS_RECEIPT_DATE</batchCharacteristicsName><batchCharacteristicsValue>00.00.0000</batchCharacteristicsValue></characteristics><characteristics SEGMENT=\"1\"><batchCharacteristicsName>BC_MANUFACTURED_BATCH</batchCharacteristicsName><batchCharacteristicsValue>9G4Y</batchCharacteristicsValue></characteristics><characteristics SEGMENT=\"1\"><batchCharacteristicsName>BC_MANUFACTURING_DATE</batchCharacteristicsName><batchCharacteristicsValue>28.02.2019</batchCharacteristicsValue></characteristics><characteristics SEGMENT=\"1\"><batchCharacteristicsName>BC_PROCESS_ORDER_NO</batchCharacteristicsName></characteristics><characteristics SEGMENT=\"1\"><batchCharacteristicsName>BC_PRODUCTION_VERSION</batchCharacteristicsName></characteristics><characteristics SEGMENT=\"1\"><batchCharacteristicsName>BC_REVISION_LEVEL</batchCharacteristicsName></characteristics><characteristics SEGMENT=\"1\"><batchCharacteristicsName>BC_USAGE_DECISION</batchCharacteristicsName><batchCharacteristicsValue>Conditionally released</batchCharacteristicsValue></characteristics><characteristics SEGMENT=\"1\"><batchCharacteristicsName>BC_VENDOR_BATCH</batchCharacteristicsName></characteristics><characteristics SEGMENT=\"1\"><batchCharacteristicsName>LOBM_QNDAT</batchCharacteristicsName><batchCharacteristicsValue>00.00.0000</batchCharacteristicsValue></characteristics><characteristics SEGMENT=\"1\"><batchCharacteristicsName>LOBM_VFDAT</batchCharacteristicsName><batchCharacteristicsValue>27.02.2021</batchCharacteristicsValue></characteristics><characteristics SEGMENT=\"1\"><batchCharacteristicsName>LOBM_ZUSTD</batchCharacteristicsName><batchCharacteristicsValue>Released</batchCharacteristicsValue></characteristics></batch></header><overprint SEGMENT=\"1\"><batchNumber>A94Y</batchNumber><overprintingValueBatch1>A94Y</overprintingValueBatch1><overprintingFormattingTextBatch1>BATCH</overprintingFormattingTextBatch1><overprintingValueBatch3>A94Y</overprintingValueBatch3><overprintingFormattingTextBatch3>LOT:</overprintingFormattingTextBatch3><overprintingValueBatch4>A94Y</overprintingValueBatch4><overprintingFormattingTextBatch4>Lote</overprintingFormattingTextBatch4><overprintingValueBatch6>A94Y</overprintingValueBatch6><overprintingFormattingTextBatch6>BATCH NUMBER:</overprintingFormattingTextBatch6><dateOfManufacturing>20190228</dateOfManufacturing><overprintingValueDOM1>02-2019</overprintingValueDOM1><overprintingFormattingTextDOM1>DATE MANUFACTURE:</overprintingFormattingTextDOM1><overprintingValueDOM4>02-2019</overprintingValueDOM4><overprintingFormattingTextDOM4>FAB</overprintingFormattingTextDOM4><overprintingValueDOM6>28-02-2019</overprintingValueDOM6><overprintingFormattingTextDOM6>DATE OF MANUFACTURE:</overprintingFormattingTextDOM6><dateOfExpiry>20220227</dateOfExpiry><overprintingValueDOE1>02-2022</overprintingValueDOE1><overprintingFormattingTextDOE1>DATE OF EXPIRY:</overprintingFormattingTextDOE1><overprintingValueDOE3>02-2022</overprintingValueDOE3><overprintingFormattingTextDOE3>EXP:</overprintingFormattingTextDOE3><overprintingValueDOE4>02-2022</overprintingValueDOE4><overprintingFormattingTextDOE4>VAL</overprintingFormattingTextDOE4><overprintingValueDOE6>02-2022</overprintingValueDOE6><overprintingFormattingTextDOE6>DATE OF EXPIRY:</overprintingFormattingTextDOE6></overprint><overprintM SEGMENT=\"1\"><additionalOverprintTextLine1>EN ETIQUETA DE FRASCO MARCAR</additionalOverprintTextLine1><additionalOverprintTextLine2>TEXTO DE CADUCIDAD Y LOTE</additionalOverprintTextLine2><additionalOverprintTextLine3>JUNTO A DATOS VARIABLES</additionalOverprintTextLine3><additionalOverprintTextLine4>EJEMPLO LOT: 1234,EXP: 05-2012</additionalOverprintTextLine4></overprintM></GSK_Canonical_MESGX2>";

            XmlDocument doc = new XmlDocument();
            doc.LoadXml(xml);

            string json = JsonConvert.SerializeXmlNode(doc);
            JObject valores = (JObject)((JObject)JsonConvert.DeserializeObject(json))["GSK_Canonical_MESGX2"];

            JObject cabecera = (JObject)valores["header"];

            JArray recipe = (JArray)cabecera["recipe"];

            //JObject recipe = cabecera["recipe"];

            //JObject BOMS¿?

            int numeroDeClavesEnHeader = 0;
            int numeroDeValoresEnHeader = 0;
            int numeroDeClavesEnRecipe = 0;
            int numeroDeValoresEnRecipe = 0;
            string Data = "[{";

            foreach (var x in cabecera)
            {
                try
                {
                    //string Data = "";
                    string clave = x.Key.ToString();
                    string valor = x.Value.ToString();




                    numeroDeClavesEnHeader++;
                    numeroDeValoresEnHeader++;

                    Console.WriteLine("(header)clave: " + clave + " (header)valor: " + valor + "\n");

                    if (clave == "orderNumber")
                    {
                        Console.WriteLine("*///////////////////////OBTENIDO NumeroOrden: " + valor + "//////////////////////////////////////");
                    }

                    else if (clave == "scheduledStartDate")
                    {
                        Console.WriteLine("////////////////////////OBTENIDO FechaPrevista: " + DateTime.ParseExact(valor, "yyyyMMdd", CultureInfo.InvariantCulture) + "//////////////////////////////////////");
                    }

                    else if (clave != "BOM" && clave != "batch" && clave != "recipe")
                    {

                        //string value = "\"" + valor + "\"";
                        //Data += clave + ":" + value + " ,"; //todos los demas datos se meten en data

                        Data += "\"" + clave.Trim() + "\"" + ":" + "\"" + valor.Trim() + "\"" + ", ";

                    }
                    else
                    {

                        Data += "\"" + clave.Trim() + "\"" + ":" + valor.Trim() + ", ";
                    }

                }
                catch (Exception ex)
                {
                    //si no parsea
                }
            }

            foreach (var item in recipe)
            {
                JObject objetoLista = (JObject)item;

                foreach (var subObjeto in objetoLista)
                {
                    string valorsubObjeto = subObjeto.Value.ToString();
                    string clavesubObjeto = subObjeto.Key.ToString();

                    numeroDeClavesEnRecipe++;
                    numeroDeValoresEnRecipe++;

                    Console.WriteLine("(recipe)clave: " + clavesubObjeto + " (recipe)valor: " + clavesubObjeto + "\n");

                    if (clavesubObjeto == "parentOperation" && Convert.ToInt32(valorsubObjeto) >= 0020)
                    {
                        Console.WriteLine("/////////////////OBTENIDO Operacion: " + valorsubObjeto + "//////////////////////////////////////");
                    }

                    Data += "\"" + clavesubObjeto.Trim() + "\"" + ":" + "\"" + valorsubObjeto.Trim() + "\"" + ", ";
                }
            }

            Data = Data.Remove(Data.Length - 2, 2); //para que el json salga sin la coma final
            Data = Data.Replace("@", string.Empty);
            Data += "}]";

            File.WriteAllText(@"C:\code\mock.txt", Data);
            //  foreach (var x in recipe)
            //{
            //    try
            //    {
            //        string clave = x.Key.ToString();
            //        string valor = x.Value.ToString();

            //        numeroDeClavesEnRecipe++;
            //        numeroDeValoresEnRecipe++;

            //        Console.WriteLine("(recipe)clave: " + clave + " (recipe)valor: " + valor + "\n");

            //        if (clave == "parentOperation" && Convert.ToInt32(valor) >= 0020)
            //        {
            //            //planProduccionXML.Operacion = valor;
            //            Console.WriteLine("OBTENIDO Operacion: " + valor);
            //        }

            //    }
            //    catch (Exception ex)
            //    {

            //    }
            //}

            Console.WriteLine("\n ////////////////////////////OBTENIDO Data: " + Data + "//////////////////////////////////////");

            Guid g = new Guid();
            Console.WriteLine("\n ////////////////////////////OBTENIDO Hash: " + g.ToString() + "//////////////////////////////////////");


            Console.WriteLine("Fin de prueba");
            Console.WriteLine("Numero de claves en header: " + numeroDeClavesEnHeader + " Numero de valores en header: " + numeroDeValoresEnHeader);
            Console.WriteLine("Numero de claves en recipe: " + numeroDeClavesEnRecipe + " Numero de valores en recipe: " + numeroDeValoresEnRecipe);

            Console.ReadLine();

            return res;



        }
    }


}

