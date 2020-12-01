using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace EsoBuildEditor.models.championClasses
{
    class Thief
    {
        ObservableCollection<ChampionNode> TheTower { get; set; }
        ObservableCollection<ChampionNode> TheLover { get; set; }
        ObservableCollection<ChampionNode> TheShadow { get; set; }

    }
}
