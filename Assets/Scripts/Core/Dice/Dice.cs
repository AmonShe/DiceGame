namespace Core.Dice
{
    public class Dice : IDice
    {
        private int m_NumberSides = 6;
        private System.Random m_Random;

        public Dice() : this(6)
        {
        }

        public Dice(int numberSides)
        {
            m_NumberSides = numberSides;
            m_Random = new System.Random();
        }

        public int Roll()
        {
            return m_Random.Next(1, m_NumberSides + 1);
        }
    }
}
