using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SUCC : MonoBehaviour
{
    public GameObject dwarf;
    public GameObject GameObject;
    private GameController gameController;
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Z³oœliwy krasnolud")
        {
            gameController = GameObject.GetComponent<GameController>();
            gameController.succDwarf();
            StartCoroutine(succDwarf(other.gameObject));
        }
    }

    IEnumerator succDwarf(GameObject other)
    {
        other.SetActive(false);
        yield return new WaitForSeconds(5.0f);
        other.SetActive(true);
        dwarf.GetComponent<Spawn>().changePosition();
    }
}
