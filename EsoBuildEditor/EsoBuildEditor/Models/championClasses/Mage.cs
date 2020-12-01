using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace EsoBuildEditor.models.championClasses
{
    class Mage
    {
        ObservableCollection<ChampionNode> TheRitual { get; set; }
        ObservableCollection<ChampionNode> TheApprentice { get; set; }
        ObservableCollection<ChampionNode> TheAtronach { get; set; }

    }
}
