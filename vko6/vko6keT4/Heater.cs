using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vko6keT4
{
    public class Heater
    {
        public bool IsOn { get; set; }
        float temperature;
        public float Temperature
        {
            get { return temperature; }
            set
            {
                temperature = value;
                if (temperature < 0 || temperature > 120.0)
                {
                    temperature = 0;
                }
            }
        }
        //kosteus voi olla välillä 0-100
        float humidity;
        public float Humidity
        {
            get { return humidity; }
            set
            {
                humidity = value;
                if (humidity < 0 || humidity > 100.0)
                {
                    humidity = 0;
                }
            }
        }
    }
}
