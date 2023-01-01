using UnityEngine;

abstract public class Missile : ScriptableObject
{
    protected ISeekBehaviour seekBehaviour;

    public void ApplySeek()
    {
        seekBehaviour.Seek();
    }

    public void SetSeekBehaviour(ISeekBehaviour seekType)
    {
        this.seekBehaviour = seekType;
    }
}
