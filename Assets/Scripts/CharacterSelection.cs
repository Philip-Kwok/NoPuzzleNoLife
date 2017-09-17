using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CharacterSelection : MonoBehaviour
{
    private GameObject[] characterList;
    private int index;

    private void Start()
    {
        index = PlayerPrefs.GetInt("CharacterSelected");

        characterList = new GameObject[transform.childCount];
        //fill array with models
        for (int i = 0; i < transform.childCount; i++)
            characterList[i] = transform.GetChild(i).gameObject;
        //we toggle off their renderer
        foreach (GameObject go in characterList)
            go.SetActive(false);
        //we toggle on the selected character
        if (characterList[index])
            characterList[index].SetActive(true);


    }
    public void ToggleLeft()
    {
        //toggle off current model
        characterList[index].SetActive(false);

        index--;//index -= 1; index = index - 1;
        if (index < 0)
            index = characterList.Length - 1;

        //toggle new model
        characterList[index].SetActive(true);
    }
    public void ToggleRight()
    {
        //toggle off current model
        characterList[index].SetActive(false);

        index++;//index += 1; index = index + 1;
        if (index == characterList.Length)
            index = 0;

        //toggle new model
        characterList[index].SetActive(true);
    }
    public void ToggleConfirm()
    {
        PlayerPrefs.SetInt("CharacterSelected", index);
        SceneManager.LoadScene(1);
    }

}
