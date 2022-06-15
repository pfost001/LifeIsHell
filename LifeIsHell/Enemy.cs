using System;
using System.Collections;
using System.Threading.Tasks;

namespace LifeIsHell
{
    internal class Enemy
    {
        public class EnemyClass
        {

        }

        public List<string> EnemyList = new List<string>()
        {          
            "Person who drives slow in the fast lane", 
            "Person who chews with their mouth open",
            "Person who talks during movies",
            "Person who wears too much perfume",
            "Person who USES ALL CAPS!!!",
            "Humblebragger",
            "Person who doesn't return the shopping cart",
            "Person who taps their foot violently",
            "Person who takes up two parking spaces",
            "Person who eats other people's lunch",
            "Person who always replys all",
            "Person who applauds at the end of a plane trip",
            "Person who applauds at the end of a movie",
            "Person in the express checkout with too many items",
            "Person talking loudly on the phone at the gym",
            "Person who doesn't replace the toilet paper",
            "Booger Eater",
            "Person who RSVPs at the last minute",
            "Person who leaves the toilet seat up",
            "Person who picks their teeth in public",
            "Person who sniffs loudly but never blows their nose",
            "Person who blows their nose at maximum volume",
            "Person who takes up both armrests on a plane",
            "Surface Shitter",
            "Chow Thief",
            "Loud Eater",
            "Person who blocks the sidewalk for their selfies",
            "Person who texts while walking in a crowd",
            "Person who asks the teacher for more homework",
            "Person who never picks up the tab",
            "Person who makes every conversation about themselves",
            "Habitual Line Cutter",
            "Person who stands too close in line",
            "Non-stop Pen Clicker",
            "Person who starts their sentences with 'No offense'",
            "Person who is never on time",
            "Person who snaps their chewing gum",
            "Overzealous Toucher",
            "Person who doesn't wipe down their machines at the gym",
            "Person who won't shut up about their diet",
            "Person who keeps their phone on full volume",
            "Person who never knows what to order",
            "Person who doesn't know how to merge",
            "Person who can't shut up about their 'fur baby'",
            "Person who wears inappropiate clothing to work",
            "Person who makes up random nicknames",
            "Close Talker",
            "One Upper",
            "Nail Biter",
            "Knuckle Cracker",
            "Person who violently cracks their neck in public",
            "Person who always interrupts",
            "Know it All",
            "Person who never returns what they 'borrow'",
            "Over Sharer",
            "Person who is holier than thou",
            "Person who thinks everything is a joke",
            "Inconsiderate Jerk",
            "Virtue Signaler",
            "Person who doesn't use their blinker",
            "Guilt Tripper",
            "Person who acts like they were raised by wolves",
            "Person who will 'literally' die without their phone",
            "Drama Queen",
            "Cheap Bastard",
            "Person who finishes your sentences",
            "Ghoster",
            "Negative Nancy",
            "Person who is way to happy to be here",
            "Consistent Complainer",
            "Person who always has to be right",
            "Passive Aggressive A-hole",
            "Person who relates everything to their daily horoscope",
            "Person who doesn't know when to shut up",
            "Person who doesn't shower",
            "Clickbait Ad",
            "Prince from Nigeria that wants to give you money",
            "Spoiled rich only child",
            "Politician",
            "Meter Maid",
            "Liberal Arts Major",
            "Person who spoils movie endings",
            "Person who wipes their nose with their hand",
            "Person who doesn't flush the toilet",
            "Whiner",
            "Person who screams when they talk",
            "Person who moans at the urinal",
            "Sweat Lord",
            "Person whose 'long story short' is still long",
            "Person with taco breath"
        };

        public static string GetName()
        {
            Random random = new Random();
            switch (random.Next(0, 89))
            {
                case 0:
                    return "Person who drives slow in the fast lane";
                case 1:
                    return "Person who chews with their mouth open";
                case 2:
                    return "Person who talks during movies";
                case 3:
                    return "Person who wears too much perfume";
                case 4:
                    return "Person who USES ALL CAPS!!!";
                case 5:
                    return "Humblebragger";
                case 6:
                    return "Person who doesn't return the shopping cart";
                case 7:
                    return "Person who taps their foot violently";
                case 8:
                    return "Person who takes up two parking spaces";
                case 9:
                    return "Person who eats other people's lunch";
                case 10:
                    return "Person who always replys all";
                case 11:
                    return "Person who applauds at the end of a plane trip";
                case 12:
                    return "Person who applauds at the end of a movie";
                case 13:
                    return "Person in the express checkout with too many items";
                case 14:
                    return "Person talking loudly on the phone at the gym";
                case 15:
                    return "Person who doesn't replace the toilet paper";
                case 16:
                    return "Booger Eater";
                case 17:
                    return "Person who RSVPs at the last minute";
                case 18:
                    return "Person who leaves the toilet seat up";
                case 19:
                    return "Person who picks their teeth in public";
                case 20:
                    return "Person who sniffs loudly but never blows their nose";
                case 21:
                    return "Person who blows their nose at maximum volume";
                case 22:
                    return "Person who takes up both armrests on a plane";
                case 23:
                    return "Surface Shitter";
                case 24:
                    return "Chow Thief";
                case 25:
                    return "Loud Eater";
                case 26:
                    return "Person who blocks the sidewalk for their selfies";
                case 27:
                    return "Person who texts while walking in a crowd";
                case 28:
                    return "Person who asks the teacher for more homework";
                case 29:
                    return "Person who never picks up the tab";
                case 30:
                    return "Person who makes every conversation about themselves";
                case 31:
                    return "Habitual Line Cutter";
                case 32:
                    return "Person who stands too close in line";
                case 33:
                    return "Non-stop Pen Clicker";
                case 34:
                    return "Person who starts their sentences with 'No offense'";
                case 35:
                    return "Person who is never on time";
                case 36:
                    return "Person who snaps their chewing gum";
                case 37:
                    return "Overzealous Toucher";
                case 38:
                    return "Person who doesn't wipe down their machines at the gym";
                case 39:
                    return "Person who won't shut up about their diet";
                case 40:
                    return "Person who keeps their phone on full volume";
                case 41:
                    return "Person who never knows what to order";
                case 42:
                    return "Person who doesn't know how to merge";
                case 43:
                    return "Person who can't shut up about their 'fur baby'";
                case 44:
                    return "Person who wears inappropiate clothing to work";
                case 45:
                    return "Person who makes up random nicknames";
                case 46:
                    return "Close Talker";
                case 47:
                    return "One Upper";
                case 48:
                    return "Nail Biter";
                case 49:
                    return "Knuckle Cracker";
                case 50:
                    return "Person who violently cracks their neck in public";
                case 51:
                    return "Person who always interrupts";
                case 52:
                    return "Know it All";
                case 53:
                    return "Person who never returns what they 'borrow'";
                case 54:
                    return "Over Sharer";
                case 55:
                    return "Person who is holier than thou";
                case 56:
                    return "Person who thinks everything is a joke";
                case 57:
                    return "Inconsiderate Jerk";
                case 58:
                    return "Virtue Signaler";
                case 59:
                    return "Person who doesn't use their blinker";
                case 60:
                    return "Guilt Tripper";
                case 61:
                    return "Person who acts like they were raised by wolves";
                case 62:
                    return "Person who will 'literally' die without their phone";
                case 63:
                    return "Drama Queen";
                case 64:
                    return "Cheap Bastard";
                case 65:
                    return "Person who finishes your sentences";
                case 66:
                    return "Ghoster";
                case 67:
                    return "Negative Nancy";
                case 68:
                    return "Person who is way to happy to be here";
                case 69:
                    return "Consistent Complainer";
                case 70:
                    return "Person who always has to be right";
                case 71:
                    return "Passive Aggressive A-hole";
                case 72:
                    return "Person who relates everything to their daily horoscope";
                case 73:
                    return "Person who doesn't know when to shut up";
                case 74:
                    return "Person who doesn't shower";
                case 75:
                    return "Clickbait Ad";
                case 76:
                    return "Prince from Nigeria that wants to give you money";
                case 77:
                    return "Spoiled rich only child";
                case 78:
                    return "Politician";
                case 79:
                    return "Meter Maid";
                case 80:
                    return "Liberal Arts Major";
                case 81:
                    return "Person who spoils movie endings";
                case 82:
                    return "Person who wipes their nose with their hand";
                case 83:
                    return "Person who doesn't flush the toilet";
                case 84:
                    return "Whiner";
                case 85:
                    return "Person who screams when they talk";
                case 86:
                    return "Person who moans at the urinal";
                case 87:
                    return "Sweat Lord";
                case 88:
                    return "Person whose 'long story short' is still long";
                case 89:
                    return "Person with taco breath";


            }
            return "default enemy name. you shouldn't be able to see this.";
        }
    }
}
