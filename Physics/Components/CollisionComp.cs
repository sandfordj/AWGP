﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlinkByte.Core;
using BlinkByte.Utilitys;

namespace BlinkByte.Physics

{
    public class CollisionComp : BlinkByte.Core.Component.Component
    {
        public Vector2 offset;

        public virtual bool CollisionCheck()
        {
            return false;
        }
    }
}