﻿using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;
using System.Text;
using System.Threading.Tasks;

namespace JAMK.IT
{
    public class TrainsVM
    {
        public static List<Train> GetTrainsAt(string station)
        {
            try
            {
                List<Train> trains = new List<Train>();
                if (station == "testi" || station == "")
                {
                    //Vaihe1: Placebo palauttaa oikean muotoista dataa
                    // keksitään muutama juna
                    Train tr = new Train();
                    tr.TrainNumber = "666";
                    tr.DepDate = new DateTime(2017, 3, 21);
                    tr.TargetStation = "Hell";
                    trains.Add(tr);
                }
                else
                {
                    //muutetaan haettu json olio-kokoelmaksi
                    string tmp = JAMK.IT.API.GetJsonFromLiikenneVirasto(station);
                    trains = JsonConvert.DeserializeObject<List<Train>>(tmp);

                }
                //palautus
                return trains;

            }
            catch (Exception ex)
            {

                throw;
            }
	    }
    }
}
