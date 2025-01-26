public class Word
{
    private string _text;
    private bool _isHidden;
      
    public Word(string text)
    {
        _text = text;
        _isHidden = false;
    }
      
    public void Hide()
    {
        _isHidden = true;
    }
    public void Show()
    {
        _isHidden = false;
    }
    public bool IsHidden()
    {
        if (_isHidden == true)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public string GetDisplayText()
    {
        if (IsHidden() == true)
        {
            // Got help for this from a Bing search for how to replace a letter in a string
            string original = _text;
            char replacement = '_';
            return _text = new string(replacement, original.Length);
        }
        else
        {
            return _text;
        }
    }
}
