using EsoBuildEditor.models.championClasses;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace EsoBuildEditor.models
{
    class Champion
    {
        Thief thief { get; set; }
        Warrior warrior { get; set; }
        Mage mage { get; set; }
    }
}
