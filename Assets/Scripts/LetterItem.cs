using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LetterItem : MonoBehaviour, IDraggable
{
    public new Transform transform;
    public char character;

    public float flashDuration;
    public Color sucessFlashColor, repeatFlashColor, failFlashColor;

    private Color startColor = Color.white;
    public Image image;
    private TMPro.TextMeshProUGUI mesh;

    public LetterItem(char character)
    {
        this.character = character;
    }//

    private void Awake()
    {
        transform = GetComponent<Transform>();
        image = GetComponent<Image>();
        mesh = GetComponent<TMPro.TextMeshProUGUI>();
        if (image != null) startColor = image.color;
        else if (mesh != null) startColor = mesh.color;

        if (Time.timeSinceLevelLoad < 2) return;
        RippleEffect.instance.AddRipple(transform.position, 1.8f, 1.6f);
        WordManager.instance.PlayBell();
    }

    private void Update()
    {
       // Debug.Log("R");
        //RippleEffect.instance.AddRipple(transform.position, 5f, 1);
    }

    private void Start()
    {
        WordManager.instance.AddToLetters(this);
    }

    public void PickUp()
    {
        WordManager.instance.RemoveLetter(this);
    }

    public void PlaceDown()
    {
        WordManager.instance.TryFormWord(WordManager.instance.AddToLetters(this));
    }

    public virtual IEnumerator FlashColor(bool sucess, bool isRepeat = false)
    {
        Color endColor;
        if (sucess)
        {
            if (isRepeat) endColor = repeatFlashColor;
            else endColor = sucessFlashColor;
        }
        else endColor = failFlashColor;

        float timer = 0;
        Color c;
        while(timer < flashDuration)
        {
            c = Color.Lerp(endColor, startColor, Mathf.SmoothStep(0, 1, timer / flashDuration));
            if (mesh != null) mesh.color = c;
            if (image != null) image.color = c;
            timer += Time.fixedDeltaTime;     
            yield return new WaitForFixedUpdate();
        }
        if (mesh != null) mesh.color = startColor;
        if (image != null) image.color = startColor;
    }
}
