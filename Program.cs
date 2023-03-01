Console.Clear();

//robô

Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine("\nOi! Faz tempo que não te vejo Faustos!");
Console.ResetColor();

//usuário

Console.ForegroundColor = ConsoleColor.Magenta;
Console.Write("\nVocê errou... meu nome é...");
string FirstNome = Console.ReadLine()!;
Console.ResetColor();

Console.ForegroundColor = ConsoleColor.DarkGray;
Console.WriteLine("\npressione uma tecla para continuar...");
Console.ResetColor();
Console.ReadKey();

Console.Clear();

//robô

Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine($"\nFoi mal...{FirstNome}, eu tinha me esquecido\nMas enfim, vamos para o objetivo!\nVocê sendo um escritor famoso tem que seguir algumas regras");
Console.WriteLine("\nE uma delas é, ter o seu **nome de catalógo**");
Console.WriteLine("\nOkay! Seu sobrenome... por favor");
Console.ResetColor();

//usuário

Console.ForegroundColor = ConsoleColor.Magenta;
string SecondNome = Console.ReadLine()!;
Console.WriteLine($"\nÉ {SecondNome}, e não esqueça!");
Console.ResetColor();

Console.ForegroundColor = ConsoleColor.DarkGray;
Console.WriteLine("\npressione uma tecla para continuar...");
Console.ResetColor();
Console.ReadKey();

Console.Clear();

//robô

Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine("\nPode deixar...");
Console.WriteLine("\n***escrevendo***");
Console.WriteLine($"\nFicou assim! {SecondNome.ToUpper()}, {FirstNome.Substring(0,1).ToUpper()}{FirstNome.Substring(1).ToLower()} ");
Console.ResetColor();