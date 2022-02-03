using UnityEngine;
using UnityEngine.SceneManagement;

public class HealthController : MonoBehaviour
{
    //Other script
    public SceneController sceneController;

    //Local
    public GameObject[] heart;
    public int numOfHearts = 3;

    private void Update()
    {
        if(numOfHearts > 1)
        {
            if (numOfHearts < 1)
            {
                Destroy(heart[0].gameObject);
            }
            else if (numOfHearts < 2)
            {
                Destroy(heart[1].gameObject);
            }
            else if (numOfHearts < 3)
            {
                Destroy(heart[2].gameObject);           
            }
        }      
    }
    public void DecreaseHeart(int decrease)
    {
        numOfHearts -= decrease;
        if(numOfHearts < 1)
        {
            sceneController.deadSceneLoad();
        }
    }

}
