namespace GitExercise
{
    class myClass
    {
public string Adresse { get; set; }
public string Navn { get; set; }
public int Postnr { get; set; }
public myClass(string navn, string adresse, int postnr)
{
    this.Navn = navn;
    this.Adresse = adresse;
    this.Postnr = postnr;
}
public override string ToString(){
    return $"{Navn} Lives at {Adresse}, {Postnr}";
}

    }
}