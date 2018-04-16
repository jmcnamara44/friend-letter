namespace FriendLetter.Models

{
  public class LetterVariable
  {
    private string _recipient;
    private string _sender;
    private string _location;
    private string _newLocation;

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

    public string GetLocation()
    {
      return _location;
    }

    public void SetLocation(string newLocation)
    {
      _location = newLocation;
    }
    public void SetNewLocation(string newNewLocation)
    {
      _newLocation = newNewLocation;
    }
    public string GetNewLocation()
    {
      return _newLocation;
    }
  }
}
