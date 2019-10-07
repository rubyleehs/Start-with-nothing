using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Reflection;

public class WordManager : MonoBehaviour
{
    public static WordManager instance;
    public static Words words;
    public static HashSet<string> history;
    public float ySquaredVariance;
    public Vector2 xSquaredVariance;

    public AudioSource appearSFX;
    public AudioSource indicatorSource;
    public AudioClip correctSFX, repeatSFX, wrongSFX;

    public TMPro.TextMeshProUGUI countText;
    private int totalValidWordsFormed = 0;


    public List<LetterItem> letters; //ordered by y position
    private List<LetterItem> lettersInCheck; //for calculation purposes


    private void Awake()
    {
        if (instance == null) instance = this;
        else Destroy(this);
        if(lettersInCheck == null) lettersInCheck = new List<LetterItem>();
        if(words == null) words = new Words();
        if(history == null) history = new HashSet<string>();
        if(letters == null) letters = new List<LetterItem>();
    }

    public void RemoveLetter(LetterItem item)
    {
        if (item == null) return;
        int index = FindLetterIndex(item);

        if(index >= 0) letters.RemoveAt(index);

    }
    private int FindLetterIndex(LetterItem item)
    {
        //binary searching
        int minIndex = 0;
        int maxIndex = letters.Count - 1;
        float y = item.transform.position.y;

        while (minIndex <= maxIndex)
        {
            int mid = (minIndex + maxIndex) / 2;
            if (y == letters[mid].transform.position.y) return mid;
            else if (y < letters[mid].transform.position.y) maxIndex = mid - 1;
            else minIndex = mid + 1;
        }
        return -1;
    }
    public int AddToLetters(LetterItem item)
    {
        //binary searching
        int minIndex = 0;
        int maxIndex = letters.Count - 1;
        float y = item.transform.position.y;

        while (minIndex <= maxIndex)
        {
            int mid = (minIndex + maxIndex) / 2;
            if (y == letters[mid].transform.position.y)
            {
                letters.Insert(mid + 1, item);
                return mid + 1;
            }
            else if (y < letters[mid].transform.position.y) maxIndex = mid - 1;
            else minIndex = mid + 1;
        }
        letters.Insert(minIndex, item);
        return minIndex;
    }
    public string TryFormWord(int index) //Previously GetLongestString()
    {
        string stringFormed = "";
        lettersInCheck.Clear();

        int minIndex = index;
        int maxIndex = index;
        float y = letters[index].transform.position.y;

        for (int i = index; i < letters.Count; i++)
        {
            if (Mathf.Pow(letters[i].transform.position.y - y, 2) <= ySquaredVariance) maxIndex = i;
            else break;
        }
        for (int i = index; i >= 0; i--)
        {
            if (Mathf.Pow(letters[i].transform.position.y - y, 2) <= ySquaredVariance) minIndex = i;
            else break;
        }

        lettersInCheck.AddRange(letters.GetRange(minIndex, maxIndex - minIndex + 1));
        lettersInCheck.Sort((a, b) => a.transform.position.x.CompareTo(b.transform.position.x));//

        int xIndex = lettersInCheck.FindIndex((a) => a == letters[index]);
        minIndex = xIndex;
        maxIndex = xIndex;
        float distance = 0;

        for (int i = xIndex; i < lettersInCheck.Count - 1; i++)
        {
            distance = Mathf.Pow(lettersInCheck[i].transform.position.x - lettersInCheck[i + 1].transform.position.x, 2);
            if (distance >= xSquaredVariance.x && distance <= xSquaredVariance.y) maxIndex = i + 1;
            else break;
        }
        for (int i = xIndex; i > 0; i--)
        {
            distance = Mathf.Pow(lettersInCheck[i].transform.position.x - lettersInCheck[i - 1].transform.position.x, 2);
            if (distance >= xSquaredVariance.x && distance <= xSquaredVariance.y) minIndex = i - 1;
            else break;
        }
        for (int i = minIndex; i <= maxIndex; i++)
        {
            stringFormed += lettersInCheck[i].character;
        }
    
        if (maxIndex - minIndex > 1)
        {
            bool isWord = words.ContainsWord(stringFormed);
            PlayIndicatorSound(isWord, history.Contains(stringFormed));

            for (int i = minIndex; i <= maxIndex; i++)
            {
                lettersInCheck[i].StartCoroutine(lettersInCheck[i].FlashColor(isWord, history.Contains(stringFormed)));
            }

            if (isWord)
            {
                if (!history.Contains(stringFormed))
                {
                    totalValidWordsFormed++;
                    countText.text = "" + totalValidWordsFormed;
                }
                MethodInfo mi = WordFuctions.instance.GetType().GetMethod(stringFormed);
                if (mi != null) mi.Invoke(WordFuctions.instance, null);
                history.Add(stringFormed);
            }
        }

        //Debug.Log(stringFormed);
        return stringFormed;
    }

    public void PlayBell()
    {
        appearSFX.pitch = 1 + Random.Range(-0.3f, 0.3f);
        appearSFX.Play();
    }

    public void PlayIndicatorSound(bool isCorrect, bool isRepeat)
    {
        indicatorSource.pitch = 1 + Random.Range(-0.1f, 0.1f);
        if (isCorrect)
        {
            if (isRepeat) indicatorSource.clip = repeatSFX;
            else indicatorSource.clip = correctSFX;            
        }
        else indicatorSource.clip = wrongSFX;
        indicatorSource.Play();
    }
}

public class Words
{
    HashSet<string> wordsHashset;

    public Words()
    {
        var wordFile = Resources.Load("words", typeof(TextAsset)) as TextAsset;
        wordsHashset = new HashSet<string>(wordFile.text.Split('\n'));
    }

    public bool ContainsWord(string s)
    {
        return wordsHashset.Contains(s);
    }
}