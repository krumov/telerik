using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class GSM
{
    public Battery battery = new Battery();
    public Display display = new Display();

    private string model;
    private string manufacturer;
    private string owner;
    private decimal? price;
    private List<Call> callHistory = new List<Call>();

    static private GSM Iphone4S = new GSM("Iphone 4S", "Apple", "iStore", 999.99M);

    public GSM(string model, string manufacturer)
        : this(model, manufacturer, null, null)
    {
    }
    public GSM(string model, string manufacturer, string owner)
        : this(model, manufacturer, owner, null)
    {
    }
    public GSM(string model, string manufacturer, string owner, decimal? price)
    {
        this.model = model;
        this.manufacturer = manufacturer;
        this.price = price;
        this.owner = owner;
    }
    public GSM(string model, string manufacturer, string owner, decimal? price, Battery battery, Display display)
        : this(model, manufacturer, owner, price)
    {
        this.battery = battery;
        this.display = display;
    }

    public string Model
    {
        get { return this.model; }
        set { this.model = value; }
    }
    public string Manufacturer
    {
        get { return this.manufacturer; }
        set { this.manufacturer = value; }
    }
    public string Owner
    {
        get { return this.owner; }
        set { this.owner = value; }
    }
    public decimal? Price
    {
        get { return this.price; }
        set { this.price = value; }
    }

    public List<Call> CallHistory
    {
        get { return callHistory; }
        set { callHistory = value; }
    }
    public static GSM iPhone
    {
        get { return Iphone4S; }
    }

    public void AddCall(DateTime time, string number, int duration)
    {
        Call call = new Call(time, number, duration);
        callHistory.Add(call);
    }
    public void RemoveCall(int index = 0)
    {
        callHistory.RemoveAt(index);
    }
    public void RemoveLongestCall()
    {
        int longestCall = callHistory.Max(x => x.Duration);
        for (int i = 0; i < callHistory.Count; i++)
        {
            if (callHistory[i].Duration == longestCall)
            {
                RemoveCall(i);
            }
        }
    }
    public void ClearHistory()
    {
        callHistory.Clear();
    }
    public void ShowCallHistory()
    {
        foreach (var call in this.callHistory)
        {
            Console.WriteLine("{0}\n{1} - {2}seconds", call.DialedNumber, call.Time, call.Duration);
        }
    }
    public decimal CalcPrice(decimal price)
    {
        decimal finalPrice = 0;
        foreach (var call in callHistory)
        {
            finalPrice += (call.Duration / 60) * price;
        }
        Console.WriteLine("You have to pay: {0:C}", finalPrice);
        return finalPrice;

    }
    public override string ToString()
    {
        StringBuilder printer = new StringBuilder();
        printer.AppendFormat("Model: {0}\n", this.model);
        printer.AppendFormat("Manufucturer: {0}\n", this.manufacturer);
        printer.AppendFormat("Owner: {0}\n", this.owner ?? "Unknown owner");
        printer.AppendFormat("Price: {0:C}\n", this.price ?? 0);
        printer.AppendFormat("Battery Model: {0}\n", this.battery.Model ?? "Unknown model");
        printer.AppendFormat("Battery Type: {0}\n", this.battery.Type);
        printer.AppendFormat("Battery Hours Idle: {0}\n", this.battery.HoursIdle ?? 0);
        printer.AppendFormat("Battery Hours Talk: {0}\n", this.battery.HoursTalk ?? 0);
        printer.AppendFormat("Display Size: {0} inches\n", this.display.Size ?? 0);
        printer.AppendFormat("Display Number of Colors: {0} millions\n", this.display.NumberOfColors ?? 0);
        return printer.ToString();
    }

}

