using System;
using System.Collections;

class Reception : Event
{
    protected string _emailRSVP;

    public string _eventType = "Reception";

    public Reception()
    {

    }

    public Reception(string email)
    {
        _emailRSVP = email;
    }
        public override string getStandard()
    {
        return $"{_title}, {_description}, {_date}, at {_time}, {_address}";
    }

    public override string getDetails()
    {
        return $"We are happy to announce the {_title}, {_description}. Please Join Us on:{_date}, from {_time}. We will be celebrating at {_address}.  Please RSVP at {_emailRSVP}";
    }

    public override string getShort()
    {
        return $"{_title} on {_date}.";
    }
}