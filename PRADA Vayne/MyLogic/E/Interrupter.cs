﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeagueSharp;
using LeagueSharp.Common;

namespace PRADA_Vayne.MyLogic.E
{
    public static partial class Events
    {
        public static void OnPossibleToInterrupt(Obj_AI_Hero sender, Interrupter2.InterruptableTargetEventArgs args)
        {
            if (args.DangerLevel == Interrupter2.DangerLevel.High && Program.E.IsReady() && Program.E.IsInRange(sender) && (sender.CharData.BaseSkinName != "Shyvana") && sender.CharData.BaseSkinName != "Vayne")
            {
                Console.WriteLine("Interrupter");
                Program.E.Cast(sender);
            }
        }
    }
}
