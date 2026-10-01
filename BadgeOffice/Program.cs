string FullName;
string Username;
int lettersLN;

//Asks for Full Name and stores it.
Console.Write("Enter your fullname:");

FullName = Console.ReadLine();
FullName = FullName.Trim();
//This seperates Full name in to First and Last name.
int spacePosition = FullName.IndexOf(" ");
string firstName = FullName.Substring(0, spacePosition);
string lastName = FullName.Substring(spacePosition + 1);
//this prints name on badge.
Console.WriteLine("Name on badge: " + firstName.ToUpper() + " " + lastName.ToUpper());
//This takes the first letter of the first name and adds to the front of the complete last name to form the username.
Username = firstName.ToLower()[0] + lastName.ToLower();
Console.WriteLine("Username: " + Username);
//This prints the Initials 
Console.WriteLine("Initials: " + firstName.ToUpper()[0] + "." + lastName.ToUpper()[0] + ".");
//This prints the letters in last name amount.
lettersLN = lastName.Length;
Console.WriteLine("Letters in last name: " + lettersLN.ToString());



// This is the start of part 2.

Random rng = new Random();

int StudentId;
int lockernumber;
//These randomly generate the Student ID and locker number.
StudentId = rng.Next(100000, 1000000);

lockernumber = rng.Next(1, 501);

Console.WriteLine("Student ID: " + StudentId.ToString(""));
Console.WriteLine("Locker: " + lockernumber.ToString(""));


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

Console.Write("Enter X of Dorm: ");
X1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter Y of Dorm: ");
Y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter X of Classroom: ");
X2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter Y of Classroom: ");
Y2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter Average Walking Speed in feet per second: ");
walkingspeed = Convert.ToDouble(Console.ReadLine());

PH1 = X2 - X1;
PH2 = Math.Pow(PH1, 2);
PH3 = Y2 - Y1;
PH4 = Math.Pow(PH3, 2);
distance = Math.Sqrt(PH2 + PH4);

walktimeabs = (distance / walkingspeed);
walktimeabs = Math.Round(walktimeabs);
walktimeM = walktimeabs / 60;
walktimeM = Math.Floor(walktimeM);
walktimeS = walktimeabs % 60;



Console.WriteLine("Distance: " + distance.ToString("F1") + " feet");
Console.WriteLine("Walk time: " + walktimeM + " minutes " + walktimeS + " seconds");





