﻿using System;
using System.Collections.Generic;

namespace WolfPeopleKill.DBModels
{
    public partial class Occupation
    {
        public int OccupationId { get; set; }
        public string OccupationName { get; set; }
        public string OccupationGb { get; set; }
        public string Pic { get; set; }
        public string About { get; set; }
    }
}
