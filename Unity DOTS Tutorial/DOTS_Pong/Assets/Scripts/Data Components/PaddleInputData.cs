using Unity.Entities;
using UnityEngine;


//Makes it so Component Data can be put onto GameObjects before Entitiy Conversion.
[GenerateAuthoringComponent]
public struct PaddleInputData :IComponentData
{
    public KeyCode upKey;
    public KeyCode downKey;
}
