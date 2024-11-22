using System;

public class Contact
{

    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string PhoneNumber { get; set; }
    public Contact()
    { }

    public Contact(string firstName, string lastName, string phoneNumber)
    {
        FirstName = firstName;
        LastName = lastName;
        PhoneNumber = phoneNumber;
    }

    public override string ToString()
    {
        return $"Имя: {FirstName}, Фамилия: {LastName}, Телефон: {PhoneNumber}";
    }
}


