
public class Person 
{
    private int yearOfBirth;

    public Person (int yearOfBirth)
    {
        this.yearOfBirth = yearOfBirth;
    }
    private string apellido ;

    public string Apellido 
    {
        get { return apellido;}
        set { apellido = value;}
    }

    public string Nombre {get;set;}


    public int Edad 
    {
        get { return DateTime.Today.Year - yearOfBirth; }
    }
}