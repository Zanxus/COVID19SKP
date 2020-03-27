using System.Collections;
using System.Collections.Generic;
using Unity.Entities;
using UnityEngine;

public struct SpeedIncreaseOverTimeData : IComponentData
{
    //Default is to name structs varible "Value" if it only contains one, but sometimes this doesn't discribe the variable very well so sometimes it's sercomvented
    public float increasePerSecond;
}
