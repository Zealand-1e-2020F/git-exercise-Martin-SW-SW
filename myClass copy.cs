namespace GitExercise
{
    class myClass2
    {
public string Adresse { get; set; }
public string Navn { get; set; }
public int Postnr { get; set; }
public string By { get; set; }
public myClass2(string navn, string adresse, int postnr, string by)
{
    this.Navn = navn;
    this.Adresse = adresse;
    this.Postnr = postnr;
    this.By = by;
}
public override string ToString(){
    return $"{Navn} Lives at {Adresse}, {Postnr}";
}

    }
}