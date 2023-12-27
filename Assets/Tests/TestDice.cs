using Core.Dice;
using NUnit.Framework;

public class TestDice
{
    [Test]
    public void TestDiceResult()
    {
        int numberSides = 20;
        IDice dice = new Dice(numberSides);

        for (int i = 0; i < 1000; i++)
        {
            int rollResult = dice.Roll();
            Assert.False(rollResult < 1 || rollResult > numberSides);
        }
    }
}