using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTouchingWallState : PlayerState
{
    protected bool isGrounded;
    protected bool isTouchingWall;
    protected bool jumpInput;

    protected int xInput;
    protected Movement Movement { get => movement ??= core.GetCoreComponent<Movement>(); }
    private Movement movement;

    private CollisionsSences CollisionsSences { get => collisionsSences ??= core.GetCoreComponent<CollisionsSences>(); }
    private CollisionsSences collisionsSences;

    public PlayerTouchingWallState(Player player, PlayerStateMashine playerStateMashine, PlayerData playerData, string animBoolName) : base(player, playerStateMashine, playerData, animBoolName)
    {

    }

    public override void AnimationFinishTrigger()
    {
        base.AnimationFinishTrigger();
    }

    public override void AnimationTrigger()
    {
        base.AnimationTrigger();
    }

    public override void DoChecks()
    {
        base.DoChecks();

        if (CollisionsSences)
        {
            isGrounded = CollisionsSences.Ground;
            isTouchingWall = CollisionsSences.WallFront;
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

        xInput = player.InputHandler.NormInputX;

        jumpInput = player.InputHandler.JumpInput;

        if (Stats.currentHealth <= 0)
        {
            playerStateMashine.ChangeState(player.DeadState);
        }

        if (jumpInput)
        {
            player.WallJumpState.DetermineWallJumpDirection(isTouchingWall);
            playerStateMashine.ChangeState(player.WallJumpState);
        }
        else if (isGrounded)
        {
            playerStateMashine.ChangeState(player.IdleState);
        }
        else if(!isTouchingWall || xInput != Movement?.FacingDirection)
        {
            playerStateMashine.ChangeState(player.InAirState);
        }
    }

    public override void PhysicsUpdate()
    {
        base.PhysicsUpdate();
    }
}
