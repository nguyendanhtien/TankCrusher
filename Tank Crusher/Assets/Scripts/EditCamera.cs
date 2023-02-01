using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EditCamera : MonoBehaviour
{
    public static EditCamera Instance;

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
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void MoveCamToPlay() {
        transform.DOMove(transform.position + new Vector3(200,0,-200), 2);
    }
}
