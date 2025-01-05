using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

///<summary>
///This class includes the elements of a dated event (battle, death, victory)
///It does not include events that happen over a period of time (like a battle or a reaaally slow death
///It includes the necessary elemtns from the get go
///</summary>

namespace Linea_Lima.historical{
    public class HistoricalEvent {
        private int year;
        private bool commonEra; //True AD, false BC
        private Place place;
        private List<Persona> personaList; //list of characters
    }
}
