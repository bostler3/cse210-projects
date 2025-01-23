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
        // Need to complete
    }
    
    public string GetDisplayText()
    {
        // need to complete
        // the following is for testing
        /*foreach (Word item in _words)
        {
            Console.WriteLine(item);
            //return display;
        }
        */
        return "";
    }
    
    public bool IsCompletelyHidden()
    {
      // need to fix
      return true;
    }
}