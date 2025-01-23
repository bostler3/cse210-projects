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
        // Need to complete; maybe something like if word is isHidden, then _text equals _ _ _
    }
    public void Show()
    {
        // Need to complete; maybe something like if word is not isHidden, then 
    }
    public bool IsHidden()
    {
        // Need to fix
        return true;
    }

    public string GetDisplayText()
    {
        // Need to fix
        return _text;
    }
}