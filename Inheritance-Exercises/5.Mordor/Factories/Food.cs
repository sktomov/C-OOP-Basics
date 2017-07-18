public class Food
{
    private int pointsOfHappiness;
    private string foodName;

    public Food(string foodName)
    {
        this.FoodName = foodName;
        this.PointsOfHappiness = this.pointsOfHappiness;
    }

    public int PointsOfHappiness
    {
        get => this.pointsOfHappiness;
        private set { this.pointsOfHappiness = CalculateFoodHappiness(); }
    }

    private string FoodName
    {
        get => this.foodName;
        set
        {
            if (!string.IsNullOrWhiteSpace(value) || !string.IsNullOrEmpty(value))
            {
                string name = value.ToLower();
                if (name == "cram" || name == "lembas" || name == "apple" || name == "melon" || name == "honeycake" ||
                    name == "mushrooms")
                {
                    this.foodName = name;
                }
                else
                {
                    this.foodName = "other";
                }
            }
        }
    }

    private int CalculateFoodHappiness()
    {
        int points = 0;
        switch (this.foodName)
        {
            case "cram":
                points = 2;
                break;
            case "lembas":
                points = 3;
                break;
            case "apple":
                points = 1;
                break;
            case "melon":
                points = 1;
                break;
            case "honeycake":
                points = 5;
                break;
            case "mushrooms":
                points = -10;
                break;
            case "other":
                points = -1;
                break;
        }
        return points;
    }

}

