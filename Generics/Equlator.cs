namespace Generics
{
    internal class Equlator
    {
        internal static bool AreEquale(int v1, int v2)
        {
            return v1 == v2;
        }
        internal static bool AreEquale(double v1, double v2)
        {
            throw new NotImplementedException();
        }
        internal static bool AreEquale(string v1, string v2)
        {
            throw new NotImplementedException();
        }
    }
}