using System;

public abstract class Animals
{
    public abstract void MakeSound();

    public void Eat()
    {
        Console.WriteLine("The animal is eating.");
    }
}

public interface ICanJump
{
    void Jump();
}

public class Kangaroo : Animals, ICanJump
{
    public override void MakeSound()
    {
        Console.WriteLine("The kangaroo makes a sound.");
    }

    public void Jump()
    {
        Console.WriteLine("The kangaroo jumps.");
    }
}

public class CS33_DiffBetweenAbstractandInterface
{
     void Main(string[] args)
    {
        Animals kangaroo = new Kangaroo();
        kangaroo.MakeSound(); // Output: The kangaroo makes a sound.
        kangaroo.Eat(); // Output: The animal is eating.

        ICanJump jumpingKangaroo = new Kangaroo();
        jumpingKangaroo.Jump(); // Output: The kangaroo jumps.
    }
}
