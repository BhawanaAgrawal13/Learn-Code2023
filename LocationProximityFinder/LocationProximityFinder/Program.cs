using LocationProximityFinder;
using OfficeOpenXml;

class Program
{
    static void Main(string[] args)
    {
        List<Location> locations = ReadFile();

        LocationClusterCalculator locationCluster = new(locations);

        Console.ReadLine();
    }

    private static List<Location> ReadFile()
    {
        ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

        FileInfo fileInfo = new FileInfo("C:/Users/bhawana.agrawal/Desktop/L&C/Assignments/Locations.xlsx");

        List<Location> locations = new List<Location>();

        using (ExcelPackage package = new ExcelPackage(fileInfo))
        {
            ExcelWorksheet worksheet = package.Workbook.Worksheets["Location"];

            if (worksheet != null)
            {
                int rowCount = worksheet.Dimension.Rows;

                for (int row = 2; row <= rowCount; row++)
                {
                    locations.Add(CreateLocation(worksheet, row));
                }
            }
        }

        return locations;
    }

    private static Location CreateLocation(ExcelWorksheet worksheet,int row)
    {
        var name = worksheet.Cells[row, 1].Text;
        var latitude = worksheet.Cells[row, 2].Text;
        var longitude = worksheet.Cells[row, 3].Text;

        Location location = new Location(name, latitude, longitude);

        return location;
    }
}
