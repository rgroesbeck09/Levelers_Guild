using UnityEngine;

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

public class Hovercraft : MonoBehaviour
{

    /*
    *  Final Variables
    
    protected const float DEFAULT_SPEED = 10;
    protected const int   DEFAULT_WIDTH = 10;
    protected const float DEFAULT_TURN = 10;
    */


    // Hoverecraft Variables
    public craft_type type;

    [SerializeField]
    private float speed;

    // private int width;

    [SerializeField]
    private float turn_speed;

    [SerializeField]
    private GameObject laserPrefab;

    [SerializeField]
    private Transform shootPoint;
    
    //Variables for toggle
    [SerializeField]
    private Hovercraft[] hovercrafts;

    [SerializeField]
    private Camera mainCamera;

    private static int activeCraft = 0;

    void Start()
    {
	for(int i = 0; i < hovercrafts.Length; i++)
	{
	    hovercrafts[i].enabled = (i == activeCraft); 
	}
 
        switch(type)
        {
            case craft_type.average:
                speed = 10f;
                turn_speed = 10f;
                break;    

            case craft_type.fast:
                speed = 15f;
                turn_speed = 5f;
                break;  

            case craft_type.cornering:
                speed = 5f;
                turn_speed = 15f;
                break;  
        }        

    }

    void Update()
    {
	
        
    // shoot laser from average craft by pressing space
        if(type == craft_type.average)
        {
            if (Input.GetKeyDown(KeyCode.F))
            {
                Debug.Log("Laser Fired!");
                laser_Shot();
            }
        }

	if(Input.GetKeyDown(KeyCode.C))
	{
	    Change_Car_Type();
    }

    /*
    // default constructor for Hovercraft
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
    */

    // Toggle between cars
    public void Change_Car_Type()
    { 
    	hovercrafts[activeCraft].enabled = false;
	activeCraft = (activeCraft + 1) % hovercrafts.Length;
	if(mainCamera != null)
	{
	   mainCamera.transform.position = 
		hovercrafts[activeCraft].transform.position + new Vector3(0f, 10f, -10f);
	   mainCamera.transform.LookAt(
		hovercrafts[activeCraft}.transform
	   );
        }

    }
	

    
    // shoot laser method
    public void laser_Shot()
    { 
       Instantiate(
            laserPrefab, 
            shootPoint.position, 
            shootPoint.rotation
        );
    }

    
    
}



