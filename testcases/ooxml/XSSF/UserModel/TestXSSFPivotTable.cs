/* ====================================================================
   Licensed to the Apache Software Foundation (ASF) under one or more
   contributor license agreements.  See the NOTICE file distributed with
   this work for Additional information regarding copyright ownership.
   The ASF licenses this file to You under the Apache License, Version 2.0
   (the "License"); you may not use this file except in compliance with
   the License.  You may obtain a copy of the License at

       http://www.apache.org/licenses/LICENSE-2.0

   Unless required by applicable law or agreed to in writing, software
   distributed under the License is distributed on an "AS IS" BASIS,
   WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
   See the License for the specific language governing permissions and
   limitations under the License.
==================================================================== */
namespace NPOI.XSSF.UserModel
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using NPOI.OpenXmlFormats.Spreadsheet;
    using NPOI.SS.UserModel;
    using NPOI.SS.Util;
    using NUnit.Framework;


    [TestFixture]
    public class TestXSSFPivotTable
    {
        private XSSFPivotTable pivotTable;
        private XSSFPivotTable offsetPivotTable;
        private ICell offsetOuterCell;
        [SetUp]
        public void SetUp()
        {
            IWorkbook wb = new XSSFWorkbook();
            XSSFSheet sheet = (XSSFSheet)wb.CreateSheet();

            IRow row1 = sheet.CreateRow(0);
            // Create a cell and Put a value in it.
            ICell cell = row1.CreateCell(0);
            cell.SetCellValue("Names");
            ICell cell2 = row1.CreateCell(1);
            cell2.SetCellValue("#");
            ICell cell7 = row1.CreateCell(2);
            cell7.SetCellValue("Data");
            ICell cell10 = row1.CreateCell(3);
            cell10.SetCellValue("Value");

            IRow row2 = sheet.CreateRow(1);
            ICell cell3 = row2.CreateCell(0);
            cell3.SetCellValue("Jan");
            ICell cell4 = row2.CreateCell(1);
            cell4.SetCellValue(10);
            ICell cell8 = row2.CreateCell(2);
            cell8.SetCellValue("Apa");
            ICell cell11 = row1.CreateCell(3);
            cell11.SetCellValue(11.11);

            IRow row3 = sheet.CreateRow(2);
            ICell cell5 = row3.CreateCell(0);
            cell5.SetCellValue("Ben");
            ICell cell6 = row3.CreateCell(1);
            cell6.SetCellValue(9);
            ICell cell9 = row3.CreateCell(2);
            cell9.SetCellValue("Bepa");
            ICell cell12 = row1.CreateCell(3);
            cell12.SetCellValue(12.12);

            AreaReference source = new AreaReference("A1:C2");
            pivotTable = sheet.CreatePivotTable(source, new CellReference("H5"));


            XSSFSheet offsetSheet = (XSSFSheet)wb.CreateSheet();

            IRow tableRow_1 = offsetSheet.CreateRow(1);
            offsetOuterCell = tableRow_1.CreateCell(1);
            offsetOuterCell.SetCellValue(-1);
            ICell tableCell_1_1 = tableRow_1.CreateCell(2);
            tableCell_1_1.SetCellValue("Row #");
            ICell tableCell_1_2 = tableRow_1.CreateCell(3);
            tableCell_1_2.SetCellValue("Exponent");
            ICell tableCell_1_3 = tableRow_1.CreateCell(4);
            tableCell_1_3.SetCellValue("10^Exponent");

            IRow tableRow_2 = offsetSheet.CreateRow(2);
            ICell tableCell_2_1 = tableRow_2.CreateCell(2);
            tableCell_2_1.SetCellValue(0);
            ICell tableCell_2_2 = tableRow_2.CreateCell(3);
            tableCell_2_2.SetCellValue(0);
            ICell tableCell_2_3 = tableRow_2.CreateCell(4);
            tableCell_2_3.SetCellValue(1);

            IRow tableRow_3 = offsetSheet.CreateRow(3);
            ICell tableCell_3_1 = tableRow_3.CreateCell(2);
            tableCell_3_1.SetCellValue(1);
            ICell tableCell_3_2 = tableRow_3.CreateCell(3);
            tableCell_3_2.SetCellValue(1);
            ICell tableCell_3_3 = tableRow_3.CreateCell(4);
            tableCell_3_3.SetCellValue(10);

            IRow tableRow_4 = offsetSheet.CreateRow(4);
            ICell tableCell_4_1 = tableRow_4.CreateCell(2);
            tableCell_4_1.SetCellValue(2);
            ICell tableCell_4_2 = tableRow_4.CreateCell(3);
            tableCell_4_2.SetCellValue(2);
            ICell tableCell_4_3 = tableRow_4.CreateCell(4);
            tableCell_4_3.SetCellValue(100);

            AreaReference offsetSource = new AreaReference(new CellReference("C2"), new CellReference("E4"));
            offsetPivotTable = offsetSheet.CreatePivotTable(offsetSource, new CellReference("C6"));
        }

        /**
         * Verify that when creating a row label it's  Created on the correct row
         * and the count is increased by one.
         */
        [Test]
        public void TestAddRowLabelToPivotTable()
        {
            int columnIndex = 0;

            Assert.AreEqual(0, pivotTable.GetRowLabelColumns().Count);

            pivotTable.AddRowLabel(columnIndex);
            CT_PivotTableDefinition defintion = pivotTable.GetCTPivotTableDefinition();

            Assert.AreEqual(defintion.rowFields.GetFieldArray(0).x, columnIndex);
            Assert.AreEqual(defintion.rowFields.count, 1);
            Assert.AreEqual(1, pivotTable.GetRowLabelColumns().Count);

            columnIndex = 1;
            pivotTable.AddRowLabel(columnIndex);
            Assert.AreEqual(2, pivotTable.GetRowLabelColumns().Count);

            Assert.AreEqual(0, (int)pivotTable.GetRowLabelColumns()[(0)]);
            Assert.AreEqual(1, (int)pivotTable.GetRowLabelColumns()[(1)]);
        }
        /**
         * Verify that it's not possible to create a row label outside of the referenced area.
         */
        [Test]
        public void TestAddRowLabelOutOfRangeThrowsException()
        {
            int columnIndex = 5;

            try
            {
                pivotTable.AddRowLabel(columnIndex);
            }
            catch (IndexOutOfRangeException)
            {
                return;
            }
            Assert.Fail();
        }

        /**
         * Verify that when creating one column label, no col fields are being Created.
         */
        [Test]
        public void TestAddOneColumnLabelToPivotTableDoesNotCreateColField()
        {
            int columnIndex = 0;

            pivotTable.AddColumnLabel(DataConsolidateFunction.SUM, columnIndex);
            CT_PivotTableDefinition defintion = pivotTable.GetCTPivotTableDefinition();

            Assert.AreEqual(defintion.colFields, null);
        }

        /**
         * Verify that it's possible to create three column labels with different DataConsolidateFunction
         */
        [Test]
        public void TestAddThreeDifferentColumnLabelsToPivotTable()
        {
            int columnOne = 0;
            int columnTwo = 1;
            int columnThree = 2;

            pivotTable.AddColumnLabel(DataConsolidateFunction.SUM, columnOne);
            pivotTable.AddColumnLabel(DataConsolidateFunction.MAX, columnTwo);
            pivotTable.AddColumnLabel(DataConsolidateFunction.MIN, columnThree);
            CT_PivotTableDefinition defintion = pivotTable.GetCTPivotTableDefinition();

            Assert.AreEqual(defintion.dataFields.dataField.Count, 3);
        }


        /**
         * Verify that it's possible to create three column labels with the same DataConsolidateFunction
         */
        [Test]
        public void TestAddThreeSametColumnLabelsToPivotTable()
        {
            int columnOne = 0;
            int columnTwo = 1;
            int columnThree = 2;

            pivotTable.AddColumnLabel(DataConsolidateFunction.SUM, columnOne);
            pivotTable.AddColumnLabel(DataConsolidateFunction.SUM, columnTwo);
            pivotTable.AddColumnLabel(DataConsolidateFunction.SUM, columnThree);
            CT_PivotTableDefinition defintion = pivotTable.GetCTPivotTableDefinition();

            Assert.AreEqual(defintion.dataFields.dataField.Count, 3);
        }

        /**
         * Verify that when creating two column labels, a col field is being Created and X is Set to -2.
         */
        [Test]
        public void TestAddTwoColumnLabelsToPivotTable()
        {
            int columnOne = 0;
            int columnTwo = 1;

            pivotTable.AddColumnLabel(DataConsolidateFunction.SUM, columnOne);
            pivotTable.AddColumnLabel(DataConsolidateFunction.SUM, columnTwo);
            CT_PivotTableDefinition defintion = pivotTable.GetCTPivotTableDefinition();

            Assert.AreEqual(defintion.colFields.field[0].x, -2);
        }

        /**
         * Verify that a data field is Created when creating a data column
         */
        [Test]
        public void TestColumnLabelCreatesDataField()
        {
            int columnIndex = 0;

            pivotTable.AddColumnLabel(DataConsolidateFunction.SUM, columnIndex);

            CT_PivotTableDefinition defintion = pivotTable.GetCTPivotTableDefinition();

            Assert.AreEqual(defintion.dataFields.dataField[(0)].fld, columnIndex);
            Assert.AreEqual(defintion.dataFields.dataField[(0)].subtotal,
                    (ST_DataConsolidateFunction)(DataConsolidateFunction.SUM.Value));
        }

        /**
         * Verify that it's possible to Set a custom name when creating a data column
         */
        [Test]
        public void TestColumnLabelSetCustomName()
        {
            int columnIndex = 0;

            String customName = "Custom Name";

            pivotTable.AddColumnLabel(DataConsolidateFunction.SUM, columnIndex, customName);

            CT_PivotTableDefinition defintion = pivotTable.GetCTPivotTableDefinition();

            Assert.AreEqual(defintion.dataFields.dataField[(0)].fld, columnIndex);
            Assert.AreEqual(defintion.dataFields.dataField[(0)].name, customName);
        }

        /**
         * Verify that it's not possible to create a column label outside of the referenced area.
         */
        [Test]
        public void TestAddColumnLabelOutOfRangeThrowsException()
        {
            int columnIndex = 5;

            try
            {
                pivotTable.AddColumnLabel(DataConsolidateFunction.SUM, columnIndex);
            }
            catch (ArgumentOutOfRangeException)
            {
                return;
            }
            Assert.Fail();
        }

        /**
        * Verify when creating a data column Set to a data field, the data field with the corresponding
        * column index will be Set to true.
        */
        [Test]
        public void TestAddDataColumn()
        {
            int columnIndex = 0;
            bool isDataField = true;

            pivotTable.AddDataColumn(columnIndex, isDataField);
            CT_PivotFields pivotFields = pivotTable.GetCTPivotTableDefinition().pivotFields;
            Assert.AreEqual(pivotFields.GetPivotFieldArray(columnIndex).dataField, isDataField);
        }

        /**
         * Verify that it's not possible to create a data column outside of the referenced area.
         */
        [Test]
        public void TestAddDataColumnOutOfRangeThrowsException()
        {
            int columnIndex = 5;
            bool isDataField = true;

            try
            {
                pivotTable.AddDataColumn(columnIndex, isDataField);
            }
            catch (ArgumentOutOfRangeException)
            {
                return;
            }
            Assert.Fail();
        }

        /**
        * Verify that it's possible to create a new filter
        */
        [Test]
        public void TestAddReportFilter()
        {
            int columnIndex = 0;

            pivotTable.AddReportFilter(columnIndex);
            CT_PageFields fields = pivotTable.GetCTPivotTableDefinition().pageFields;
            CT_PageField field = fields.pageField[(0)];
            Assert.AreEqual(field.fld, columnIndex);
            Assert.AreEqual(field.hier, -1);
            Assert.AreEqual(fields.count, 1);
        }

        /**
        * Verify that it's not possible to create a new filter outside of the referenced area.
        */
        [Test]
        public void TestAddReportFilterOutOfRangeThrowsException()
        {
            int columnIndex = 5;
            try
            {
                pivotTable.AddReportFilter(columnIndex);
            }
            catch (ArgumentOutOfRangeException)
            {
                return;
            }
            Assert.Fail();
        }

        /**
         * Verify that the Pivot Table operates only within the referenced area, even when the
         * first column of the referenced area is not index 0.
         */
        [Test]
        public void TestAddDataColumnWithOffsetData()
        {
            offsetPivotTable.AddColumnLabel(DataConsolidateFunction.SUM, 1);
            Assert.AreEqual(CellType.Numeric, offsetOuterCell.CellType);

            offsetPivotTable.AddColumnLabel(DataConsolidateFunction.SUM, 0);
        }
        [Ignore("not found in poi")]
        [Test]
        public void Test58294()
        {
            //XSSFWorkbook wb = new XSSFWorkbook("C:\\temp\\test1.xlsx");
            //XSSFSheet sheet = wb.GetSheetAt(1) as XSSFSheet;
            //XSSFSheet sheet0 = wb.GetSheetAt(0) as XSSFSheet;
            //sheet0.SetActiveCell("A4");
            //XSSFPivotTable pivotTable = sheet0.CreatePivotTable(new AreaReference("A3:H6"), new CellReference("A4"), sheet);
            //pivotTable.AddRowLabel(1);
            //pivotTable.AddRowLabel(3);
            //pivotTable.AddRowLabel(5);
            //pivotTable.AddColumnLabel(DataConsolidateFunction.SUM, 6, "Sum of days with hauls");
            //pivotTable.AddColumnLabel(DataConsolidateFunction.SUM, 7, "Sum of days site cutoff");
            ////checkPivotTables(wb);
            //FileStream fileOut = new FileStream("c:\\temp\\test2new.xlsx", FileMode.Create, FileAccess.ReadWrite);
            //try
            //{
            //    wb.Write(fileOut);
            //}
            //finally
            //{
            //    fileOut.Close();
            //}
            //XSSFWorkbook wbBack = XSSFTestDataSamples.WriteOutAndReadBack(wb);
            ////checkPivotTables(wbBack);
            //wb.Close();
        }
        private void checkPivotTables(XSSFWorkbook wb)
        {
            IList<XSSFPivotTable> pivotTables = (wb.GetSheetAt(0) as XSSFSheet).GetPivotTables();
            Assert.IsNotNull(pivotTables);
            Assert.AreEqual(3, pivotTables.Count);
            XSSFPivotTable pivotTable = pivotTables[0];
            checkPivotTable(pivotTable);
        }
        private void checkPivotTable(XSSFPivotTable pivotTableBack)
        {
            Assert.IsNotNull(pivotTableBack.GetPivotCacheDefinition());
            Assert.IsNotNull(pivotTableBack.GetPivotCacheDefinition().GetCTPivotCacheDefinition());
            CT_CacheFields cacheFields = pivotTableBack.GetPivotCacheDefinition().GetCTPivotCacheDefinition().cacheFields;
            Assert.IsNotNull(cacheFields);
            Assert.AreEqual(8, cacheFields.SizeOfCacheFieldArray());
            Assert.AreEqual("A", cacheFields.cacheField[0].name);
        }

    }
}
