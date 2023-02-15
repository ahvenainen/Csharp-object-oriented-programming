using InsuranceExercise;
Console.OutputEncoding = System.Text.Encoding.UTF8;

InsuranceManager im = new InsuranceManager();
Console.WriteLine("Vakuutukset");
im.AddInsurance("koira", "Rolle", false);
im.AddInsurance("koira", "Tessu", true);
im.AddInsurance("kissa", "Monni", true);
im.AddInsurance("koira", "Pluto", false);
im.AddInsurance("lintu", "Tipi", false);
im.PrintInsurances();
Console.WriteLine("---");
Console.WriteLine("Löytyi");
im.FindInsurances("koira", false);
im.FindInsurances("kissa", false);
