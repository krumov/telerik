using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Call
{
    private DateTime time;
    private string dialedNumber;
    private int duration;

    public Call(DateTime time, string dialedNumber, int duration)
    {
        this.time = time;
        this.dialedNumber = dialedNumber;
        this.duration = duration;
    }



    public DateTime Time
    {
        get { return this.time; }
        set { this.time = value; }
        //set { dateAndTime = DateTime.Parse(value.ToString()); }
    }
    public string DialedNumber
    {
        get { return this.dialedNumber; }
        set
        {
            if (value.Length >= 5)
            {
                this.dialedNumber = value;
            }
        }
    }

    public int Duration
    {
        get { return this.duration; }
        set
        {
            if (value > 0 && value < int.MaxValue)
            {
                this.duration = value;
            }
        }
    }

}