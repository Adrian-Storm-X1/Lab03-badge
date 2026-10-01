/*
* Name: Adrian Aguero
* Course: CSCI 1250, Section 001
* Assignment: Lab 03, The Badge Office
* Date: September 30, 2026
* Description: Builds a student badge from a name, two random assignments,
* and the walking distance to a first class.
*/
string FullName;
string Username;
int lettersLN;
Random rng = new Random();

// Asks for Full Name and stores it.
Console.Write("Enter your fullname:");
FullName = Console.ReadLine();
FullName = FullName.Trim();
Console.WriteLine();

//This seperates Full name in to First and Last name.
int spacePosition = FullName.IndexOf(" ");
string firstName = FullName.Substring(0, spacePosition);
string lastName = FullName.Substring(spacePosition + 1);
//this prints name on badge.
Console.WriteLine("Name on badge: " + firstName.ToUpper() + " " + lastName.ToUpper());
Console.WriteLine();
//This takes the first letter of the first name and adds to the front of the complete last name to form the username.
Username = firstName.ToLower()[0] + lastName.ToLower();
Console.WriteLine("Username: " + Username);
Console.WriteLine();
//This prints the Initials 
Console.WriteLine("Initials: " + firstName.ToUpper()[0] + "." + lastName.ToUpper()[0] + ".");
Console.WriteLine();
//This prints the letters in last name amount.
lettersLN = lastName.Length;
Console.WriteLine("Letters in last name: " + lettersLN.ToString());
Console.WriteLine();




// This is the start of part 2.


int StudentId;
int lockernumber;
//These randomly generate the Student ID and locker number.
StudentId = rng.Next(100000, 1000000);

lockernumber = rng.Next(1, 501);

Console.WriteLine("Student ID: " + StudentId.ToString(""));
Console.WriteLine();
Console.WriteLine("Locker: " + lockernumber.ToString(""));
Console.WriteLine();



//This is the start of part 3.

int X1;
int X2;
int Y1;
int Y2;
double walkingspeed;
double distance;
double PH1;
double PH2;
double PH3;
double PH4;
double walktimeabs;
double walktimeM;
double walktimeS;
// These take user input for future use.
Console.Write("Enter X of Dorm: ");
X1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
Console.Write("Enter Y of Dorm: ");
Y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
Console.Write("Enter X of Classroom: ");
X2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
Console.Write("Enter Y of Classroom: ");
Y2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
Console.Write("Enter Average Walking Speed in feet per second: ");
walkingspeed = Convert.ToDouble(Console.ReadLine());
Console.WriteLine();

//This is the Distance Formula.
PH1 = X2 - X1;
PH2 = Math.Pow(PH1, 2);
PH3 = Y2 - Y1;
PH4 = Math.Pow(PH3, 2);
distance = Math.Sqrt(PH2 + PH4);
//This divides whole seconds into minutes and seconds.
walktimeabs = (distance / walkingspeed);
walktimeabs = Math.Round(walktimeabs);
walktimeM = walktimeabs / 60;
walktimeM = Math.Floor(walktimeM);
walktimeS = walktimeabs % 60;


//This prints Distance and Walk Time.
Console.WriteLine("Distance: " + distance.ToString("F1") + " feet");
Console.WriteLine();

Console.WriteLine("Walk time: " + walktimeM + " minutes " + walktimeS + " seconds");
Console.WriteLine();

//This is the start of part 4.
FullName = FullName.ToUpper();
int checkdegit;
checkdegit = StudentId % 9;

//This prints the badge.
Console.WriteLine("==================================");
Console.WriteLine("");
Console.WriteLine("        ETSU STUDENT BADGE");
Console.WriteLine("");
Console.WriteLine("==================================");
Console.WriteLine("");
Console.WriteLine("NAME".PadRight(10) + FullName);
Console.WriteLine("");
Console.WriteLine("USERNAME".PadRight(10) + Username);
Console.WriteLine("");
Console.WriteLine("ID".PadRight(10) + StudentId.ToString() + "-" + checkdegit.ToString());
Console.WriteLine("");
Console.WriteLine("LOCKER".PadRight(10) + lockernumber.ToString());
Console.WriteLine("");
Console.WriteLine("WALK".PadRight(10) + walktimeM + " min " + walktimeS + " sec");
Console.WriteLine("");
Console.WriteLine("==================================");









