using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Entities;

[GenerateAuthoringComponent]
public struct BallTag : IComponentData
{
    //a tag does not contain data, it's only here to tag entities as a way to grab all entities of a given type/tag
}
