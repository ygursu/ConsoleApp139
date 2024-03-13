Console.Write("Birinci sayıyı giriniz:");
A = Convert.ToDouble(Console.ReadLine());
Console.Write("İkinci sayıyı giriniz:");
B = Convert.ToDouble(Console.ReadLine());

YEDEK = A;
A = B;
B = YEDEK;

Console.WriteLine("Değişken içerikleri değiştirilmiştir.");
Console.ReadKey();