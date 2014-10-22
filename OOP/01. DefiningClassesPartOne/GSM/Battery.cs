using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public enum BatteryType
{
    Li_Ion, NiMH, NiCd
}
public class Battery
{
    private string model = null;
    private BatteryType type;
    private byte? hoursIdle;
    private byte? hoursTalk;

    public BatteryType Type
    {
        get { return this.type; }
        set { this.type = value; }
    }

    public Battery()
    {
    }
    public Battery(string model, byte? hoursIdle)
    {
        this.model = model;
        this.hoursIdle = hoursIdle;

    }
    public Battery(string model, byte? hoursIdle, byte? hoursTalk, BatteryType type)
        : this(model, hoursIdle)
    {
        this.hoursTalk = hoursTalk;
        this.type = type;
    }


    public string Model
    {
        get { return this.model; }
        set { this.model = value; }
    }
    public byte? HoursIdle
    {
        get { return this.hoursIdle; }
        set { this.hoursIdle = value; }
    }
    public byte? HoursTalk
    {
        get { return this.hoursTalk; }
        set { this.hoursTalk = value; }
    }

}


