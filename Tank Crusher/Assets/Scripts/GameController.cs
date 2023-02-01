using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public Sprite image1;
    public GameObject element, completeObject;
    public Transform basePosition;

    public static GameController Instance;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(this);
        }
        else
        {
            Destroy(gameObject);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        //Debug.Log(image1.texture.height + "" + image1.texture.width);
        //Debug.Log(image1.texture.GetPixel(90,90));
        StartGame();
        Render3DObject();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void StartGame() { 
        
    }


    public void Render3DObject() {
        for (int i = 0; i < image1.texture.height; i++) {
            for (int j = 0; j < image1.texture.width; j++) {
                if (image1.texture.GetPixel(j, i).a == 0) continue;
                GameObject temp = Instantiate(element,basePosition.position + new Vector3(j/1,i/1,0), Quaternion.identity);
                temp.gameObject.GetComponent<Renderer>().material.color = image1.texture.GetPixel(j,i);
                temp.gameObject.transform.SetParent ( completeObject.transform);
            }
        }

        //completeObject.SetActive(false);
        completeObject.gameObject.transform.localScale = new Vector3(5, 5, 5);

    }

    public void PlayGame() {
        EditCamera.Instance.MoveCamToPlay();
        UIManager.Instance.ShowHomePanel(false);
        completeObject.SetActive(true);
    }




}
