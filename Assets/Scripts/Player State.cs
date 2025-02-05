using UnityEngine;

public class PlayerState
{
    protected PlayerStateMachine stateMachine;
    protected Player player;

    private string animBoolName;

    public PlayerState(Player _player, PlayerStateMachine _stateMachine, string animBoolName)
    {
        this.player = _player;
        this.stateMachine = _stateMachine; 
        this.animBoolName = animBoolName; 
    }

    public virtual void Enter()
    {
        Debug.Log("I enter " + animBoolName);
    }
    public virtual void Update()
    {
        Debug.Log("I'm in " + animBoolName);
    }
    public virtual void Exit()
    {
        Debug.Log("I exit " + animBoolName);
    }
}
