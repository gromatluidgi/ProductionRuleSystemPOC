using System;
using System.Collections.Generic;
using System.Text;

namespace BehavioralCriterias.Core.Criterias
{
    internal interface ICriteria
    {
        bool Evaluate<T>(T context);
    }
}
