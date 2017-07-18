public class AirBender : Bender
{
    private double aerialIntegrity;

    public double AerialIntegrity
    {
        get { return aerialIntegrity; }
        private set { aerialIntegrity = value; }
    }

    public AirBender(string name, int power, double aerialIntegrity) : base(name, power)
    {
        this.AerialIntegrity = aerialIntegrity;
    }

    public override double GetTotalPower()
    {
        return this.AerialIntegrity * base.Power;
    }

    public override string ToString()
    {
        return $"{base.ToString()}Aerial Integrity: {this.AerialIntegrity:f2}";
    }
}

