using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EAAutoFramework.Helpers
{
   /* class HtmlTableHelper
    {
        private static List<TableDatacollection> _tableDatacollections;

        public static void ReadTable(IWebElement table)
        {
            //Initialize the table
            _tableDatacollections = new List<TableDatacollection>();

            //Get all the columns from the table
            var columns = table.FindElements(By.TagName("th"));

            //Get all the rows
            var rows = table.FindElements(By.TagName("tr"));

            //Create row index
            int rowIndex = 0;
            foreach (var row in rows)
            {
                int colIndex = 0;
                var colDatas = row.FindElement(By.TagName("td"));
                //Store data only if it has value in row
                if (colDatas.Count != 0)
                    foreach (var colValue in colDatas)
                    {
                        _tableDatacollections.Add(new TableDatacollection
                        {
                            RowNumber = rowIndex,
                            ColumnName = columns[colIndex].Text != "" ?
                                         columns[colIndex].Text : colIndex.ToString(),
                            ColumnValue = colValue.Text,
                            ColumnSpecialValues = GetControl(colValue)
                        });
                        //Move to next column
                        colIndex++;
                    }
                rowIndex++;
            }
        }
        private static ColumnSpecialValue GetControl (IWebElement columnValue)
        {
            ColumnSpecialValue columnSpecialValue = null;
            //Check if the control has specfic tags like input/hyperlink etc
            if (columnValue.FindElement(By.TagName("a")).Count > 0)
            {
                ColumnSpecialValue = new ColumnSpecialValue
                {
                    ElementCollection = columnValue.FindElement(By.TagName("a")),
                    ControlType = "hyperLink"
                };
            }
            if (columnValue.FindElement(By.TagName("input")).Count > 0)
            {
                columnValue = new ColumnSpecialValue
                {
                    ElementCollection = columnValue.FindElement(By.TagName("a")),
                    ControlType = "input"
                };
            }
            return ColumnSpecialValue;
        }
    }


    public class TableDatacollection
    {
        public int RowNumber { get; set; }

        public string ColumnName { get; set; }

        public string ColumnValue { get; set; }

        public ColumnSpecialValue ColumnSpecialValues { get; set; }
    }

    public class ColumnSpecialValue
    {
    public IEnumerable<IWebElement> ElementCollection { get; set; }

    public string ControlType { get; set; }
    }*/
}
