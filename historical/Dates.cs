using System;
using System.Threading;

namespace historian.historical {
    public struct Date {
        private bool commonEra; //true is AD, false is BC
        private int year;
        private int month;
        private int day;
    }

}