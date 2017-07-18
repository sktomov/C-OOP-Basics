public class WaterMonument : Monument
{
    private int waterAffinity;

    public WaterMonument(string name, int waterAffinity) : base(name)
    {
        this.WaterAffinity = waterAffinity;
    }

    public int WaterAffinity
    {
        get { return waterAffinity; }
        private set { waterAffinity = value; }
    }

    public override double GetMonumentBonus()
    {
        return this.WaterAffinity;
    }

    public override string ToString()
    {
        return $"{base.ToString()}Water Affinity: {this.WaterAffinity}";
    }
}

