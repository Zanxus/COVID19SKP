﻿using System.Collections;
using System.Collections.Generic;
using Unity.Entities;
using Unity.Jobs;
using Unity.Physics;
using Unity.Transforms;
using UnityEngine;
using Unity.Mathematics;

[AlwaysSynchronizeSystem]
public class PaddleMovementSystem : JobComponentSystem
{
    protected override JobHandle OnUpdate(JobHandle inputDeps)
    {
        float deltaTime = Time.DeltaTime;
        float yBound = GameManager.main.yBound;

        Entities.ForEach((ref Translation trans, in PaddleMovementData data) =>
        {
            trans.Value.y = math.clamp(trans.Value.y + (data.speed * data.direction * deltaTime), -yBound,yBound);

        }).Run();

        return default;
    }
}
