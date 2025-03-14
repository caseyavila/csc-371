using UnityEngine;

public class NewPlate : MonoBehaviour
{
    public AirflowController airflowController;

    public bool startOn;


    private void OnTriggerStay(Collider other)
    {
        if(startOn){

            if (airflowController != null)
            {
                airflowController.isActive = false;
                airflowController.GetComponent<Collider>().enabled = false;
                airflowController.ToggleMist(false);
                airflowController.soundManager.PlayWind(false);
                
            }
        
        }else{

            if (airflowController != null)
            {
                airflowController.isActive = true;
                airflowController.GetComponent<Collider>().enabled = true;
                airflowController.ToggleMist(true);
                airflowController.soundManager.PlayWind(true);
                
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if(startOn){

            if (airflowController != null)
            {
                airflowController.isActive = true;
                airflowController.GetComponent<Collider>().enabled = true;
                airflowController.ToggleMist(true);
                airflowController.soundManager.PlayWind(true);
                
            }
        
        }else{

            if (airflowController != null)
            {
                airflowController.isActive = false;
                airflowController.GetComponent<Collider>().enabled = false;
                airflowController.ToggleMist(false);
                airflowController.soundManager.PlayWind(false);    
                
            }
        }
    }
}
