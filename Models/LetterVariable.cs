namespace FriendLetter.Models

{
  public class LetterVariable
  {
    private string _recipient;
    private string _sender;

    public string GetRecipient() /*Get Recipient*/
    {
      return _recipient;
    }

    public void SetRecipient(string newRecipient) /*Set Recipient*/
    {
      _recipient = newRecipient;
    }

    public string GetSender()
    {
      return _sender;
    }

    public void SetSender(string newSender)
    {
      _sender = newSender;
    }
  }
}
