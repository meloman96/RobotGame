using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GameProject.StatsManager.framework
{
    interface gameStateInterface
    {
        void Init_State();
        void Draw_State();
        void Enter_State();
        void Update_State();
        void Leave_State();
        void Save_State();
    }
}
