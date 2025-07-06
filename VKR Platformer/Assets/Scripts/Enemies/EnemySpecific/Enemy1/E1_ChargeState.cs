using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class E1_ChargeState : ChargeState
{
    private Enemy1 enemy;

    public E1_ChargeState(FiniteStateMashine stateMashine, Entity entity, string animBoolName, D_ChargeState stateData, Enemy1 enemy) : base(stateMashine, entity, animBoolName, stateData)
    {
        this.enemy = enemy;
    }

    public override void DoChecks()
    {
        base.DoChecks();

        if (CollisionsSences)
        {
            isDetectingLedge = CollisionsSences.LedgeVertical;
        }
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
        
        if (performCloseRangeAction)
        {
            stateMashine.ChangeState(enemy.meleeAttackState);
        }
        else if (!isDetectingLedge || isDetectingWall)
        {
            Movement?.Flip();
            stateMashine.ChangeState(enemy.moveState);
        }
        else if (isChargeTimeOver)
        {

            if (isPlayerInMinAgroRange)
            {
                stateMashine.ChangeState(enemy.playerDetectedState);
            }
            else
            {
                stateMashine.ChangeState(enemy.lookForPlayerState);
            }
        }
    }

    public override void PhysicsUpdate()
    {
        base.PhysicsUpdate();
    }
}
