using System;
 
public class Klasa {
  public static void Main (string[] args)
  {
	Console.BackgroundColor = ConsoleColor.DarkBlue;
	Console.ForegroundColor = ConsoleColor.Yellow;
	for(int i=0;i<3;i++){
		for(int s=0;s<38;s++){
			Console.Write(" ");
		}
		if(i==1){
			Console.Write("***");
		}
		else{
			Console.Write(" * ");
		}
		for(int s=0;s<38;s++){
			Console.Write(" ");
		}
		Console.WriteLine("");
	}
	Console.ResetColor();


	//int a = (79-3)/2;
	for (int i=5;i<80;i=i+4){
		//Console.Write("wypisz i: "+i);

		int z = (79-i)/2;
		
		for(int j=0;j<z;j++){
			Console.BackgroundColor = ConsoleColor.DarkBlue;
			Console.ForegroundColor = ConsoleColor.Yellow;
			if( (i==5 && j==4) || (i==13 && j==20) || (i==29 && j==1) || (i==49 && j==5) ){
				Console.Write("*");
			}
			else{
				Console.Write(" ");
			}
			Console.ResetColor();
		}
		for(int j=0;j<i;j++){
				if(i%5==0 && j%6==0){
					if(j%9==0){
						Console.ForegroundColor = ConsoleColor.Blue;
					}
					else{
						Console.ForegroundColor = ConsoleColor.Red;
					}
					Console.BackgroundColor = ConsoleColor.DarkGreen;
					Console.Write("O");
					Console.ResetColor();
				}
				else if(i%3==0 && j%4==0){
					if(j%8==0){
						Console.ForegroundColor = ConsoleColor.Cyan;
					}
					else{
						Console.ForegroundColor = ConsoleColor.DarkMagenta;
					}
					Console.BackgroundColor = ConsoleColor.DarkGreen;
					Console.Write("O");
					Console.ResetColor();
				}
				
				else{
					Console.ForegroundColor = ConsoleColor.White;
					Console.BackgroundColor = ConsoleColor.DarkGreen;
					Console.Write("-");
					Console.ResetColor();
				}
		}
		for(int j=0;j<z;j++){
			Console.BackgroundColor = ConsoleColor.DarkBlue;
			Console.ForegroundColor = ConsoleColor.Yellow;
			if( (i==9 && j==14) || (i==37 && j==10) ){
				Console.Write("*");
			}
			else{
				Console.Write(" ");
			}
			Console.ResetColor();
		}
		Console.WriteLine("");
		//z = (79-1)/2;
		for(int j=0;j<39;j++){
			Console.BackgroundColor = ConsoleColor.DarkBlue;
			Console.Write(" ");
			Console.ResetColor();
		}

			Console.BackgroundColor = ConsoleColor.DarkGray;
			Console.Write(" ");
			Console.ResetColor();

		for(int j=0;j<39;j++){
			Console.BackgroundColor = ConsoleColor.DarkBlue;
			Console.Write(" ");
			Console.ResetColor();
		}
		Console.WriteLine("");
	}
Console.ReadKey();
  }
}
