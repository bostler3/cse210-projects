public class Scripture
{
  private Reference _reference;
  private List<Word> _words = new List<Word>();
    
  public Scripture(Reference reference, string text)
  {
    _reference = reference;
    string [] words = text.Split(' ');
    foreach (string word in words)
    {
      Word addWord = new Word(word);
      _words.Add(addWord);
    }
  }
      
  public void HideRandomWords(int numberToHide)
  {
    Random randomGenerator = new Random();
    int randomIndex;
    for (int i = 0; i <= (numberToHide-1); i++)
    {
      do
      {
        randomIndex = randomGenerator.Next(_words.Count);
      } while (_words[randomIndex].IsHidden() == true); 
      
      _words[randomIndex].Hide();
    }
  }
      
  public string GetDisplayText()
  {
    List<string> verseText = new List<string>();
    foreach (Word word in _words)
    {
      verseText.Add(word.GetDisplayText());
    }
    string display = $"{_reference.GetDisplayText()} {String.Join(" ", verseText)}";
    return display;
  }
      
  public bool IsCompletelyHidden()
  {
    int numberOfWords = _words.Count;
    int count = 0;
    foreach (Word word in _words)
    {
      if (word.IsHidden() == true)
      {
        count += 1;
      }
    }
    if (numberOfWords == count)
    {
      return true;
    }
    else
    {
      return false;
    }
  }
}
