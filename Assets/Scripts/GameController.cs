using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public Transform Flea;
    public Dog DogWithFlea;
    private bool inTransition;


    #region params
    public int animalCount = 20;
    public Vector2 spawnRange = new Vector2(20, -20);
    public GameObject dogPrefab;
    public List<Dog> animals = new List<Dog>();
    public GameObject spawnArea;
    #endregion

    void Start()
    {
        for (int i = 0; i < animalCount; i++)
        {
            GameObject animal = Instantiate(dogPrefab, new Vector3(Random.Range(spawnRange.x, spawnRange.y), 0, 0), Quaternion.identity, spawnArea.transform);
            animals.Add(animal.GetComponent<Dog>());
            animal.GetComponent<Dog>().gameController = this;
        }
    }

    void Update()
    {
        //if (Input.GetKey(KeyCode.Mouse0))
        //{
        //   Camera.main.ViewportPointToRay(Input.mousePosition)
        //}
    }

    public void MoveFlea(Dog dog)
    {
        if (inTransition) return;
        inTransition = true;

        LeanTween.move(Flea.gameObject, dog.transform, 2.0f).setEase(LeanTweenType.easeOutQuad)
            .setOnComplete(()=> {
                inTransition = false;
                DogWithFlea = dog;
                Flea.transform.parent = dog.transform;
            });
    }
}
