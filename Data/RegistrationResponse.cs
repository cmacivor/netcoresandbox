
using System.Collections.Generic;


public class Response 
{
    public RegistrationResponse data {get; set;}

    public string Message { get; set; }

    
}

public class RegistrationResponse
{
    //public string Message { get; set; }

    public List<string> ModelState { get; set; }
}