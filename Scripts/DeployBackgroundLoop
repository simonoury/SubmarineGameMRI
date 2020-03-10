using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeployBackground : MonoBehaviour
{
    public GameObject fish;
    public GameObject crab;
    public GameObject Coin;
    public GameObject heart;
    public GameObject chest;
    public float y = 5.13f;
    public float fishrespawnTime = 5.0f;
    public float crabrespawnTime = 9.0f;
    public float coinspawnTime = 3.0f;
    public float heartrespawntime = 22.0f;
    public float chestrespawntime = 17.0f;
    private Vector2 screenBounds;
    private Camera mainCamera;

    void Start(){
      StartCoroutine(fishWave());
      StartCoroutine(crabWave());
      StartCoroutine(coinWave());
      StartCoroutine(heartwave());
      StartCoroutine(chestwave());
    }

    void Update()
    {
      mainCamera = gameObject.GetComponent<Camera>();
      screenBounds = mainCamera.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
    }

    private void spawnBackgroundfish(){
      fish = Instantiate (fish) as GameObject;
      fish.transform.position = new Vector2(screenBounds.x, Random.Range(-screenBounds.y+2, screenBounds.y));
    }

    private void spawnBackgroundcrab(){
      crab = Instantiate (crab) as GameObject;
      crab.transform.position = new Vector2(screenBounds.x, -y);
    }

    private void spawnCoin(){
      Coin = Instantiate (Coin) as GameObject;
      Coin.transform.position = new Vector2(screenBounds.x, Random.Range(-screenBounds.y+3, screenBounds.y-1));
    }

    private void spawnHeart(){
      heart = Instantiate (heart) as GameObject;
      heart.transform.position = new Vector2(screenBounds.x, Random.Range(-screenBounds.y+3, screenBounds.y-1));
    }

    private void spawnChest(){
        chest = Instantiate (chest) as GameObject;
        chest.transform.position = new Vector2(screenBounds.x, -y+1);
    }


    IEnumerator fishWave(){
        while(true){
            yield return new WaitForSeconds(fishrespawnTime);
            spawnBackgroundfish();
        }
    }
    IEnumerator crabWave(){
        while(true){
            yield return new WaitForSeconds(crabrespawnTime);
            spawnBackgroundcrab();
        }
    }
    IEnumerator coinWave(){
        while(true){
            yield return new WaitForSeconds(coinspawnTime);
            spawnCoin();
        }
    }
    IEnumerator heartwave(){
      while(true){
        yield return new WaitForSeconds(heartrespawntime);
        spawnHeart();
      }
    }
    IEnumerator chestwave(){
      while(true){
        yield return new WaitForSeconds(chestrespawntime);
        spawnChest();
      }
    }
}
