public class AirMonument : Monument
{
    private int airAffinity;

    public AirMonument(string name, int airAffinity) : base(name)
    {
        this.AirAffinity = airAffinity;
    }

    public int AirAffinity
    {
        get { return airAffinity; }
        private set { airAffinity = value; }
    }

    public override double GetMonumentBonus()
    {
        return this.AirAffinity;
    }

    public override string ToString()
    {
        return $"{base.ToString()}Air Affinity: {this.AirAffinity}";
    }
}

