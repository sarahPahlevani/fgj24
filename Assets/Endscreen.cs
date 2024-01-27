﻿using UnityEngine;

class Endscreen : MonoBehaviour
{
    private void Awake()
    {
        Hide();
    }

    public void Show() => gameObject.SetActive(true);
    public void Hide() => gameObject.SetActive(false);
}
