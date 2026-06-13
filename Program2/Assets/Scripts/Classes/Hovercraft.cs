
/*
 *  This is an enum to signify what the car type is. 
 */
public enum craft_type
{ 
    average,
    fast,
    cornering
}


///
/*   This is the class file for the hovercraft
 * 
 * 
 * 
 */
///

public class Hovercraft
{
    /*
     *  Final Variables
     */
    private const float DEFAULT_SPEED = 10;
    private const int DEFAULT_WIDTH = 10;
    private const float DEFAULT_TURN = 10;


    // Hoverecraft Variables
    craft_type type;
    float speed;
    int width;
    float turn_speed;

    // default constructor for Hovercar
    public Hovercraft()
    {
        type = craft_type.average;
        speed = DEFAULT_SPEED;
        width = DEFAULT_WIDTH;
        turn_speed = DEFAULT_TURN;
    }

    // custom constructor for Hovercar
    public Hovercraft(craft_type in_type, float in_speed, int in_width, float in_turn_speed)
    {
        type = in_type;
        speed = in_speed;
        width = in_width;
        turn_speed = in_turn_speed;
    }

    // TODO: Create a function to change the car type
    //        things to remember when changing the car type
    //        need to change speed, cornering as well as the type
    public void Change_Car_Type()
    { 
    
    }

    // TODO: Lazers
    public void laser_shot()
    { 
    
    }
}

