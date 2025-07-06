using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goblin_DeadState : DeadState
{
    private Goblin goblin;
    public Goblin_DeadState(FiniteStateMashine stateMashine, Entity entity, string animBoolName, D_DeadState stateData, Goblin goblin) : base(stateMashine, entity, animBoolName, stateData)
    {
        this.goblin = goblin;
    }

    public override void DoChecks()
    {
        base.DoChecks();
    }

    public override void Enter()
    {
        base.Enter();
    }

    public override void Exit()
    {
        base.Exit();
    }

    public override void LogicUpdate()
    {
        base.LogicUpdate();
    }

    public override void PhysicsUpdate()
    {
        base.PhysicsUpdate();
    }
}
