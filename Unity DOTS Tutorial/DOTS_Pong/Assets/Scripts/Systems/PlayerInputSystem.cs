using Unity.Entities;
using Unity.Jobs;
using UnityEngine;
//makes sure other jobs get done before or after this depending on need since this is a main thread job
[AlwaysSynchronizeSystem]
public class PlayerInputSystem : JobComponentSystem
{
    //OnUpdate is the DOTS version of Update() 
    protected override JobHandle OnUpdate(JobHandle inputDeps)
    {
        //Takes a Lamda expression as input
        //ref (READ AND WRITE FROM DATA)
        //in (ONLY READ FROM DATA)
        //ref must always be first in the order, simular to Inhertance and Interfaces on classes
        Entities.ForEach((ref PaddleMovementData moveData,in PaddleInputData inputData) =>
        {
            moveData.direction = 0;

            moveData.direction += Input.GetKey(inputData.upKey) ? 1 : 0;
            moveData.direction -= Input.GetKey(inputData.downKey) ? 1 : 0;
        //Run determines that this is a mean thead job we use Schedule() for worker threads
        }).Run();

        return default;
    }
}
