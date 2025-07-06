using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "newPlayerData", menuName = "Data/Player Data/Base Data")]

public class PlayerData : ScriptableObject
{
    [Header("Move State")]
    public float movementVelocity = 10f;

    [Header("Jump State")]
    public float jumpVelocity = 15f;
    public int amountOfJumps = 1;

    [Header("In Air State")]
    public float coyoteTime = 0.2f;
    public float variableJumpHeightMultiplier = 0.4f;

    [Header("Wall Slide State")]
    public float wallSlideVelocity = 3.0f;

    [Header("Wall Jump State")]
    public float wallJumpVelocity = 20.0f;
    public float wallJumpTime = 0.4f;
    public Vector2 wallJumpAngle = new Vector2(1, 2);

    [Header("Player Statistics")]
    public int enemiesKilled = 0;
    public int blockCount = 0;
    public float inGameTime = 0;
    public int deaths = 0;
    public int takeDamageCount = 0;

}
