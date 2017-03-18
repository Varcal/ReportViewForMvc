using System.Data;

namespace ReportViewerForMvc.Tests.Reports
{
    public class ReportData
    {
    }

    public class ReportTable : DataTable
    {
        public ReportTable()
        {
            Columns.Add("Column1");
            Columns.Add("Column2");
            Columns.Add("Column3");
        }
    }
}

