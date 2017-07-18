
public class Mood
{

    public static string GetMood(int pointOfHappiness)
    {
        var mood = string.Empty;
        if (pointOfHappiness <= -6)
        {
            mood = "Angry";
        }
        else if (pointOfHappiness <= 0)
        {
            mood = "Sad";
        }
        else if (pointOfHappiness <= 15)
        {
            mood = "Happy";
        }
        else
        {
            mood = "JavaScript";
        }
        return mood;
    }   
}

