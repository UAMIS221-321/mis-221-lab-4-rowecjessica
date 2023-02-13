int menuChoice = Menu();
GetNumber();
Directory(menuChoice);



static int Menu(){
    int menuChoice = 0;
    System.Console.WriteLine(" Enter 1 to display full triangle\n Enter 2 to display partial triangle\n Enter 3 to exit");
    menuChoice = int.Parse(Console.ReadLine());
    return menuChoice;
}

static int GetNumber(){
    Random rnd = new Random();
    int number = rnd.Next(3,10);
    return number;
} 

static void Directory(int menuChoice){
    if ( menuChoice == 1 ){
    GetFull();
        } else if ( menuChoice == 2 ){
    GetPartial();
        } else if ( menuChoice == 3){
    ExitProgram();
        } else DisplayInvalid(); 
} 


static void GetFull(){
    int rand = GetNumber();
    Console.Clear();
    for ( int i = 0; i<rand; i ++){
        for ( int j = 0; j<=i; j ++){
        Console.Write("o"); 
        }
    Console.WriteLine();
    }
}

static void GetPartial(){
    int rand = GetNumber();
    int rand2 = GetNumber2();
    Console.Clear();
    for ( int i = 0; i<rand; i ++){
        for ( int j = 0; j<=i; j ++){
            if (rand2 == 1){
                Console.Write("o"); 
            }else Console.Write(" ");
        rand2 = GetNumber2();
        }
    Console.WriteLine();
    }
} 

static int GetNumber2(){
    Random rnd = new Random();
    int number = rnd.Next(0,2);
    return number;
}


static void DisplayInvalid(){
    Console.Clear();
    System.Console.WriteLine("Invalid response - Please try again");
    int menuChoice = Menu();
    GetNumber();
    Directory(menuChoice);
}
