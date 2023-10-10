class Program
{
    static void Main(string[] args)
    {
      
    }
}

public class Vehicle
{
    public string Licence { get; set; }
    public bool Pass { get; set; }
    public Vehicle(string licence, bool pass)
    {
        this.Licence = licence;
        this.Pass = pass;
    }
}

public class VehicleTracker
{
    //PROPERTIES
    public string Address { get; set; }
    public int Capacity { get; set; }
    public int SlotsAvailable { get; set; }
    public Dictionary<int, Vehicle> VehicleList { get; set; }

    public VehicleTracker(int capacity, string address)
    {
        this.Capacity = capacity;
        this.Address = address;
        this.VehicleList = new Dictionary<int, Vehicle>();

        this.GenerateSlots();
    }

    // STATIC PROPERTIES
    public static string BadSearchMessage = "Error: Search did not yield any result.";
    public static string BadSlotNumberMessage = "Error: No slot with number ";
    public static string SlotsFullMessage = "Error: no slots available.";

    // METHODS
    public void GenerateSlots()
    {
        this.VehicleList.Clear();
        for (int i = 1; i <= this.Capacity; i++)
        {
            this.VehicleList.Add(i, null);
        }
    }

    public void AddVehicle(Vehicle vehicle)
    {
        foreach (KeyValuePair<int, Vehicle> slot in this.VehicleList)
        {
            if (slot.Value == null)
            {
                this.VehicleList[slot.Key] = vehicle;
                this.SlotsAvailable++;
                return;
            }
        }
        throw new InvalidOperationException(SlotsFullMessage);
    }

    public void RemoveVehicle(string licence)
    {
        try
        {
            int slot = this.VehicleList.First(v => v.Value.Licence == licence).Key;
            this.SlotsAvailable++;
            this.VehicleList[slot] = null;
        }
        catch
        {
            throw new NullReferenceException(BadSearchMessage);
        }
    }

    public bool RemoveVehicle(int slotNumber)
    {
        try
        {
            if (slotNumber > this.Capacity || slotNumber<=0)
            {
                return false;
            }
        }
        catch
        {
            throw new NullReferenceException(BadSlotNumberMessage);
        }
        try 
        {
            this.VehicleList[slotNumber] = null;
            this.SlotsAvailable++;
            return true;
        }
        catch 
        {
            throw new NullReferenceException(BadSearchMessage);
        }
        
    }

    public List<Vehicle> ParkedPassholders()
    {
        List<Vehicle> passHolders = this.VehicleList.Values
            .Where(v => v != null && v.Pass)
            .ToList();

        return passHolders;
    }


    public double PassholderPercentage()
    {
        int passHolders = ParkedPassholders().Count();
        double percentage = (double)passHolders / this.Capacity * 100;
        return percentage;
    }

}


