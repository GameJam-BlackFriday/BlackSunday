﻿using System.Collections;
using System.Collections.Generic;
using Objects.MyObject;

public class Urinal : MyObject
{
    string name = "Urinal";

    // Update is called once per frame
    public override void react()
    {
        print("It is awful. Somebody didn't flush it.");
    }
}
