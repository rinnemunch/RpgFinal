using UnityEngine;

public class PlayerState
{
    protected PlayerStateMachine stateMachine;
    protected Player player;

    protected Rigidbody2D rb;

    protected float xInput;
    private string animBoolName;

    public PlayerState(Player _player, PlayerStateMachine _stateMachine, string animBoolName)
    {
        this.player = _player;
        this.stateMachine = _stateMachine; 
        this.animBoolName = animBoolName; 
    }

    public virtual void Enter()
    {
        player.anim.SetBool(animBoolName, true);
        rb = player.rb;
    }
    public virtual void Update()
    {
        xInput = Input.GetAxisRaw("Horizontal");
    }
    public virtual void Exit()
    {
        player.anim.SetBool(animBoolName, false);
    }
}
