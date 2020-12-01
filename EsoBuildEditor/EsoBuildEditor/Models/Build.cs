using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace EsoBuildEditor.models
{
    class Build
    {
        ObservableCollection<Gear> GearSet { get; set; }
        SkillBar SkillBarOne { get; set; }
        SkillBar SkillBarTwo { get; set; }
        Champion ChampionPoints { get; set; }
        ObservableCollection<Skill> skillSet { get; set; }
        String boon { get; set; }
        String baseClass { get; set; }
    }
}
