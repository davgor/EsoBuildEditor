using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace EsoBuildEditor.models
{
    class SkillBar
    {
        ObservableCollection<Skill> skillBar { get; set; }
        int type { get; set; }
    }
}
