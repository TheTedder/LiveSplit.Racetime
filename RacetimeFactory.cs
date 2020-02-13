﻿using LiveSplit.Model;
using LiveSplit.Racetime;
using LiveSplit.UI.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

[assembly: ComponentFactory(typeof(RacetimeFactory))]

namespace LiveSplit.Racetime
{
    public class RacetimeFactory : IRaceProviderFactory
    {
        public RaceProviderAPI Create(ITimerModel model)
        {
            return RacetimeAPI.Instance;
        }
    }
}
