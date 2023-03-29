using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExampleCollection : MonoBehaviour
{
    // Create a List collection to store GameObjects
    public List<GameObject> gameObjects;

    void Start()
    {
        // Add GameObjects to the collection
        AddGameObjects();

        // Display the content of the collection
        DisplayGameObjects();
    }

    // Method to add GameObjects to the List
    private void AddGameObjects()
    {
        for (int i = 0; i < 5; i++)
        {
            GameObject newGameObject = new GameObject("Object " + i);
            gameObjects.Add(newGameObject);
        }
    }

    // Method to display the content of the List
    private void DisplayGameObjects()
    {
        foreach (GameObject obj in gameObjects)
        {
            Debug.Log("Game Object Name: " + obj.name);
        }
    }
}