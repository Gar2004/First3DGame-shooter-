using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneController : MonoBehaviour
{
    [SerializeField]  GameObject enemyPrefab;
    private GameObject enemy;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       if(enemy == null){
           enemy = Instantiate(enemyPrefab) as GameObject;
           AssignRandomColor(enemy);
           enemy.transform.localScale = Random.Range(0.5f, 2.0f) * Vector3.one;
           enemy.transform.position = new Vector3(0, 1, 0);
           float angle = Random.Range(0, 360);
           enemy.transform.Rotate(0, angle, 0);
       }
    }

    void AssignRandomColor(GameObject enemy)
{
    // Get the Renderer component from the enemy
    Renderer renderer = enemy.GetComponent<Renderer>();

    // Generate a random color
    Color randomColor = new Color(
        UnityEngine.Random.value, // Red
        UnityEngine.Random.value, // Green
        UnityEngine.Random.value  // Blue
    );

    // Assign the random color to the material
    renderer.material.color = randomColor;
}
}
