using System;
using System.Collections.Generic;
using System.Text;

namespace EsoBuildEditor.models
{
    class Skill
    {
        String name { get; set; }
        Boolean purchased { get; set; }
        String type { get; set; } //Active/Passive
        String parent { get; set; } //if class is morphed parent abillity is here
    }
}
