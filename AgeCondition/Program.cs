string current_age = "100";

Console.Write("Ange din ålder: ");
string input_age = current_age ?? "0";

int age = int.Parse(input_age);

Console.WriteLine("Din ålder är " + age);