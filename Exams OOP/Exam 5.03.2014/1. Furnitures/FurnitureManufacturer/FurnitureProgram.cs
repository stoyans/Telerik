namespace FurnitureManufacturer
{
    using Engine;
    using System.Globalization;
    using System.Threading;

    public class FurnitureProgram
    {
        
        public static void Main()
        {
            System.Globalization.CultureInfo.DefaultThreadCurrentCulture = CultureInfo.InstalledUICulture;
            FurnitureManufacturerEngine.Instance.Start();
        }
    }
}
