using UnityEngine;
using System.Collections;
public class Movement : MonoBehaviour{
	
	//Movement Variables
	public float ShipTopSpeed = 10.0f;
    public float ShipSpeed = 0.0f;
    public float ShipSpeedIncrease = 0.1f;
    public float ShipSpeedDecrease = -0.1f;
    public float ShipTurnRate = 0.1f;
    public float turnSpeed = 50f;
    private Vector3 moveDirection = Vector3.zero;
    private Vector3 forward;
    
    void Update(){
        //All The Controller Initialization and Movement Crap
        
	CharacterController controller = GetComponent<CharacterController>();
	moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
	moveDirection = transform.TransformDirection(moveDirection);
        controller.Move(this.gameObject.transform.forward * ShipSpeed);


        if (Input.GetKey("w"))
        {
            if (ShipSpeed < ShipTopSpeed)
            {
                ShipSpeed += ShipSpeedDecrease;

                if (ShipSpeed > ShipTopReverseSpeed)
                {
                    ShipSpeed = ShipTopSpeed;
}}}
        if (Input.GetKey("s"))
	{
            if (ShipSpeed > -ShipTopSpeed)
            {
                ShipSpeed += ShipSpeedIncrease;

                if(ShipSpeed < ShipTopSpeed)
                {
                    ShipSpeed = ShipTopSpeed;
                }}}

       

        
        
        
        //Yaw 
        if (Input.GetKey(KeyCode.LeftArrow))
            transform.Rotate(Vector3.up, -turnSpeed * Time.deltaTime);

        if (Input.GetKey(KeyCode.RightArrow))
            transform.Rotate(Vector3.up, turnSpeed * Time.deltaTime);
        //Pitch
        if (Input.GetKey(KeyCode.UpArrow))
            transform.Rotate(Vector3.right, turnSpeed * Time.deltaTime);

        if (Input.GetKey(KeyCode.DownArrow))
            transform.Rotate(Vector3.right, -turnSpeed * Time.deltaTime);
        //Rotation
        if (Input.GetKey("q"))
            transform.Rotate(Vector3.forward, turnSpeed * Time.deltaTime);

        if (Input.GetKey("e"))
            transform.Rotate(Vector3.forward, -turnSpeed * Time.deltaTime);


    }
}
