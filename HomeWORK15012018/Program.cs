using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWORK15012018
{
    class Program
    {
        static void Main(string[] args)
        {
            //Крч, тут такая не очень штука, я сперва все сделал, потом понял, что мне нужен был консольапликейшн, 
            // я когда нажал на крестик, по запарке выбрал не сохранять
            // ВОобще сделал занова
            // вроде бы все есть, только не стал заполнять, времени не хватает 23:57 осталось 3  минуты(

        }

        public void CreTable1()
        {
            DataSet accessTab = new DataSet("AccessTab");

            DataTable tabsTable = new DataTable("TrackEvaluationPart");

    

            DataColumn intEvaluationPartId = new DataColumn("intEvaluationPartId", Type.GetType("System.Int32"));
            tabsTable.Columns.Add(intEvaluationPartId);
            tabsTable.PrimaryKey = new DataColumn[] { tabsTable.Columns["intEvaluationPartId"] };

            DataColumn intEvaluationId = new DataColumn("intEvaluationId", Type.GetType("System.Int32"));
            tabsTable.Columns.Add(intEvaluationId);
            tabsTable.PrimaryKey = new DataColumn[] { tabsTable.Columns["intEvaluationId"] };

            DataColumn intMasterPartId = new DataColumn("intMasterPartId", Type.GetType("System.Int32"));
            tabsTable.Columns.Add(intMasterPartId);
            tabsTable.PrimaryKey = new DataColumn[] { tabsTable.Columns["intMasterPartId"] };


            DataColumn floatQuantity = new DataColumn("floatQuantity", Type.GetType("System.Int32"));
            tabsTable.Columns.Add(floatQuantity);

            DataColumn floatUnitCostAvia  = new DataColumn("floatUnitCostAvia", Type.GetType("System.Int32"));
            tabsTable.Columns.Add(floatUnitCostAvia);

            DataColumn floatUnitCostTrack = new DataColumn("floatUnitCostTrack", Type.GetType("System.Int32"));
            tabsTable.Columns.Add(floatUnitCostTrack);

            DataColumn strAvailability = new DataColumn("strAvailability", Type.GetType("System.Int32"));
            tabsTable.Columns.Add(strAvailability);

            DataColumn strDescription = new DataColumn("strDescription", Type.GetType("System.Int32"));
            tabsTable.Columns.Add(strDescription);

            DataColumn intSimsld = new DataColumn("intSimsld", Type.GetType("System.Int32"));
            tabsTable.Columns.Add(intSimsld);

            DataColumn intPartStatus = new DataColumn("intPartStatus", Type.GetType("System.Int32"));
            tabsTable.Columns.Add(intPartStatus);

        }
        public void CreTable2()
        {
            DataSet accessTab = new DataSet("AccessTab");

            DataTable tabsTable = new DataTable("TrackComponent");


            DataColumn intComponentId = new DataColumn("intComponentId", Type.GetType("System.Int32"));
            tabsTable.Columns.Add(intComponentId);
            tabsTable.PrimaryKey = new DataColumn[] { tabsTable.Columns["intComponentId"] };

            DataColumn strComponentId = new DataColumn("strComponentId", Type.GetType("System.Int32"));
            tabsTable.Columns.Add(strComponentId);
            tabsTable.PrimaryKey = new DataColumn[] { tabsTable.Columns["strComponentId"] };

            DataColumn strUntil = new DataColumn("strUntil", Type.GetType("System.Int32"));
            tabsTable.Columns.Add(strUntil);
          
            DataColumn intComponentTypeID = new DataColumn("intComponentTypeID", Type.GetType("System.Int32"));
            tabsTable.Columns.Add(intComponentTypeID);

            DataColumn dlnitCycleDate = new DataColumn("dlnitCycleDate", Type.GetType("System.Int32"));
            tabsTable.Columns.Add(dlnitCycleDate);

            DataColumn intlintCycleUnits = new DataColumn("intlintCycleUnits", Type.GetType("System.Int32"));
            tabsTable.Columns.Add(intlintCycleUnits);

            DataColumn intEquipmentID = new DataColumn("intEquipmentID", Type.GetType("System.Int32"));
            tabsTable.Columns.Add(intEquipmentID);

            DataColumn LastDate = new DataColumn("LastDate", Type.GetType("System.Int32"));
            tabsTable.Columns.Add(LastDate);

            DataColumn intLastMetered = new DataColumn("intLastMetered", Type.GetType("System.Int32"));
            tabsTable.Columns.Add(intLastMetered);

            DataColumn intTotalMetered = new DataColumn("intTotalMetered", Type.GetType("System.Int32"));
            tabsTable.Columns.Add(intTotalMetered);

            DataColumn intSMCSComponentID = new DataColumn("intSMCSComponentID", Type.GetType("System.Int32"));
            tabsTable.Columns.Add(intSMCSComponentID);

            DataColumn intModelID = new DataColumn("intModelID", Type.GetType("System.Int32"));
            tabsTable.Columns.Add(intModelID);

            DataColumn intLocationID = new DataColumn("intLocationID", Type.GetType("System.Int32"));
            tabsTable.Columns.Add(intLocationID);

            DataColumn isRemoved = new DataColumn("isRemoved", Type.GetType("System.Int32"));
            tabsTable.Columns.Add(isRemoved);

            DataColumn intStatusComponent = new DataColumn("intStatusComponent", Type.GetType("System.Int32"));
            tabsTable.Columns.Add(intStatusComponent);

            DataColumn intModifierId = new DataColumn("intModifierId", Type.GetType("System.Int32"));
            tabsTable.Columns.Add(intModifierId);


        }

        static void DisplayRow(DataRow row)
        {
            DataTable tbl = row.Table;
            foreach (DataColumn col in tbl.Columns)
                Console.WriteLine("\t" + col.ColumnName + ": " + row[col]);
        }
    }
}
