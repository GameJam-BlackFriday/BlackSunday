﻿using System.Collections;
using System.Collections.Generic;
using Objects.MyObject;

public class WetFloorSign : MyObject
{

    // Update is called once per frame
    public override void react()
    {
        print("\"Wet floor, \n  watch out your step\"");
    }
}
