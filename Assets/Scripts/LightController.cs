using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightController : MonoBehaviour
{
    public GameObject player;
    public PlayerExp playerExp;
    public int targetReq = 4;
    public MeshRenderer objectRenderer;
    public bool nextLevelUnlocked = false;

    // Start is called before the first frame update
    void Start()
    {
        objectRenderer = GetComponent<MeshRenderer>();
        playerExp = player.GetComponent<PlayerExp>();
    }

    // Update is called once per frame
    void Update()
    {
        if (playerExp.targetsDestroyed == targetReq)
        {
            UnlockNextLevel();
        }
    }

    void UnlockNextLevel()
    {
        nextLevelUnlocked = true;
        objectRenderer.material.SetColor("_Color", Color.green);
        objectRenderer.material.SetColor("_EmissionColor", Color.green);
    }
}
