using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace EsoBuildEditor.models.championClasses
{
    class Warrior
    {
        ObservableCollection<ChampionNode> TheLord { get; set; }
        ObservableCollection<ChampionNode> TheLady { get; set; }
        ObservableCollection<ChampionNode> TheSteed { get; set; }
    }
}
