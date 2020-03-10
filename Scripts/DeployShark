using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeployShark : MonoBehaviour
{
    public GameObject sharkPrefab;
    public float respawnTime = 1.0f;
    private Vector2 screenBounds;
    private Camera mainCamera;

    // Use this for initialization
    void Start () {
      StartCoroutine(sharkWave());
    }
    void Update (){
      mainCamera = gameObject.GetComponent<Camera>();
      screenBounds = mainCamera.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
    }
    
    private void spawnEnemy(){
        GameObject a = Instantiate(sharkPrefab) as GameObject;
        a.transform.position = new Vector2(screenBounds.x, Random.Range(-screenBounds.y+3, screenBounds.y-1));
    }
    IEnumerator sharkWave(){
        while(true){
            yield return new WaitForSeconds(respawnTime);
            spawnEnemy();
        }
    }
}
