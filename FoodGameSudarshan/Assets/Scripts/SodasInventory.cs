using UnityEngine;

public class SodasInventory : MonoBehaviour
{
    private void OnTriggerEnter(Collider other){
        PlayerInventory playerInventory = other.GetComponent<PlayerInventory>();

        if(playerInventory!=null){
            playerInventory.SodasCollected();
            //gameObject.SetActive(false);
            Destroy(gameObject);
        }
    }
}
