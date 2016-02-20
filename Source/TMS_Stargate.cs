using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace TMS_Stargate
{
    [KSPAddon(KSPAddon.Startup.SpaceCentre, true)]

    public class TMS_Stargate : MonoBehaviour
    {
        public void Awake()
        {
            //List<Vessel> existingStargates = new List<Vessel>();

            //foreach (Vessel gate in FlightGlobals.Vessels)
            //{
            //    if (gate.name != "Kerbin")
            //    {
                    string planet = "Kerbin";
                    CreateGates TMS_Module_001 = new CreateGates();
                    Debug.Log("Spawn the Ship");
                    TMS_Module_001.BuildGate(planet);
            //    }
            // }

        }
    }
}