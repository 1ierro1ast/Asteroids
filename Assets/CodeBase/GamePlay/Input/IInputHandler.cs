using System;

namespace CodeBase.GamePlay.Input
{
    public interface IInputHandler
    {
        event Action ShootButtonPressed; 
        float HorizontalMove { get; }
        float VerticalMove { get; }
    }
}