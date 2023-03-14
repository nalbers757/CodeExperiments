using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Numerics;

namespace MyClasses
{
    /*
     * IGM_Aircraft
     * -- Notice the Concord and Boeing747 classes that implement IGM_Aircraft must also implent Speed and static MaxSpeed
     * -- But Size does not have to be implemented as Size is a static member of the interface itself
     * -- Adding "abstract" to the interface member ensures that the classes that implement our interface must also implement this static member
     * -- This works equally well for methods
     * 
     * Notice that IGM_Aircraft has it's own static "SayHello()" method
     * -- Concord was not forced to implement this method
     * -- Boeing747 was also not forced to implement this method but he implemented one anyway
     * -- -- Boeing747 is not actually implementing SayHello(), it's just a coincidence that they both have a static method with this name
     * -- However both classes where forced to implement abstract "SayMessage()"
     * 
     * SpeedReport<T>(T aircraft)
     * -- accepts a type of IGM_Aircraft and returns what percentage of the max speed the instance of aircraft currently is
     * -- This shows us that we can pass in any instance of any class that implements <T> and access the members of either T or  the specific aircraft instance
     * -- There is a breakdown of what is, and is not, accessable in that method
     * 
     * Velocity
     * -- We make a simple Velocity class that implements an addition (+) operator that adds two velocities together
     * -- This is how it's always been except notice that our operator has to be static
     * -- There was previously no way to force an implementation of our interface to have it's own operator
     * -- NOW we can implement <IAdditionOperator> and force an addition operator (as seen in VelocityNew)
     * 
     * Now that we can add Velocity or VelocityNew together, we have a slight problem... we can't .Sum a list of them together
     * -- You'll notice in the RunMe method that a list velocity can not use .Sum
     * But since we can now do Generic Math, we can just extend IAdditionOperator for Sum, and our VelocityNew will work because it was forced to have an addition
     * 
     * Why was .Sum not already implemented by default (just calling our + operator over and over)? No idea, maybe it will in the future
    */



    public interface IGM_Aircraft
    {
        double Speed { get; }

        static double Size { get; set; }
        static abstract double MaxSpeed { get; }

        static string SayHello() { return "hello"; }
        static abstract string SayHi();
    }
    public class GM_Concord : IGM_Aircraft
    {
        public double Speed { get; set; }
        public static double MaxSpeed => 605;
        public static string SayHi() { return "Concord says hi!"; }
    }

    public class GM_Boeing747 : IGM_Aircraft
    {
        public double Speed { get; set; }
        public static double MaxSpeed => 274;
        public static string SayHi() { return "Boeing747 says hi"; }

        public static string SayHello()
        { return "Boing747 has his own SayHello method that is not required to be implement because it is not the same as the Interface.SayHello method."; }
    }



    public record struct Velocity(double x, double y, double z)
    {
        public static Velocity operator +(Velocity l, Velocity r)
        {
            return new Velocity(l.x + r.x, l.y + r.y, l.z + r.z);
        }
    }

    public record struct VelocityNew(double x, double y, double z) : IAdditionOperators<VelocityNew, VelocityNew, VelocityNew>
    {
        public static VelocityNew operator +(VelocityNew l, VelocityNew r)
        {
            return new VelocityNew(l.x + r.x, l.y + r.y, l.z + r.z);
        }
    }

    public static class Extensions
    {
        public static T Sum<T>(this IEnumerable<T> source) where T : IAdditionOperators<T, T, T>, new()
        {
            T sum = new();
            foreach (var item in source)
            { sum += item; }
            return sum;
        }
    }



    public class GenericMath
    {
        public static StringBuilder RunMe()
        {
            StringBuilder returnValue = new();

            //Static values
            var aircraftSize = IGM_Aircraft.Size;
            var concordMaxSpeed = GM_Concord.MaxSpeed;
            var boeing747MaxSpeed = GM_Boeing747.MaxSpeed;

            returnValue.AppendLine($"IGM_Aircraft.Size: {aircraftSize}");
            returnValue.AppendLine($"GM_Concord.MaxSpeed: {concordMaxSpeed}");
            returnValue.AppendLine($"GM_Boeing747.MaxSpeed: {boeing747MaxSpeed}");



            GM_Concord myConcord = new() { Speed = 100 };
            GM_Boeing747 myBoeing = new() { Speed = 200 };

            returnValue.AppendLine($"myConcord.Speed: {myConcord.Speed}");
            returnValue.AppendLine($"myBoeing.Speed: {myBoeing.Speed}");



            var gmaircraftSayHello = IGM_Aircraft.SayHello();
            var concordSayHi = GM_Concord.SayHi();
            var boeingSayHi = GM_Boeing747.SayHi();
            var boeingSayHello = GM_Boeing747.SayHello();

            returnValue.AppendLine($"IGM_Aircraft.SayHello(): {gmaircraftSayHello}");
            returnValue.AppendLine($"GM_Concord.SayHi(): {concordSayHi}");
            returnValue.AppendLine($"GM_Boeing747.SayHi(): {boeingSayHi}");
            returnValue.AppendLine($"GM_Boeing747.SayHello(): {boeingSayHello}");



            var speedReportConcord = SpeedReport<GM_Concord>(myConcord);
            var speedReportBoeing = SpeedReport<GM_Boeing747>(myBoeing);

            returnValue.AppendLine($"SpeedReport<GM_Concord>(myConcord): {speedReportConcord}");
            returnValue.AppendLine($"SpeedReport<GM_Boeing747>(myBoeing): {speedReportBoeing}");



            var velocity1 = new Velocity(1, 2, 3);
            var velocity2 = new Velocity(2, 3, 4);
            var velocity3 = velocity1 + velocity2;
            var velocityList = new List<Velocity>() { velocity1, velocity2, velocity3 };
            //var velocitySum = velocityList.Sum(); //<-- THIS DOES NOT WORK

            var velocityNew1 = new VelocityNew(1, 2, 3);
            var velocityNew2 = new VelocityNew(4, 5, 6);
            var velocityNew3 = new VelocityNew(7, 8, 9);
            var velocityNewList = new List<VelocityNew>() { velocityNew1, velocityNew2, velocityNew3 };
            var velocityNewSum = velocityNewList.Sum();

            returnValue.AppendLine($"velocityNewSum: {velocityNewSum}");


            return returnValue; 
        }


        public static string SpeedReport<T>(T aircraft) where T : IGM_Aircraft
        {
            /*
            //pretend we pass in an instance of Concorde (T=Concord, aircraft=myConCord)
            var tSpeed = T.Speed; //<-- Not allowed, not a static member of Concord or Boeing class
            var tSize = T.Size; //<-- Not allowed, static member of IGM_Aircraft itself, but not Concord or Boeing class
            var tMaxSpeed = T.MaxSpeed; //<-- Allowed, as this is was forced by interface to be a static member of Concord or Boeing747 class
            var tSayHello = T.SayHello(); //<-- Not allowed, Not a static member of Concord or Boing747 class
            var tSayHi = T.SayHi(); //<-- Allowed, as this was forced by interface to e a static member of Concord or Boeing clas

            var aSpeed = aircraft.Speed; //<-- allowed, forced by interface to be a member of Concord or Boeing class
            var aSize = aircraft.Size; //<-- not allowed, this is a static member of the interface itself, not class instance
            var aMaxSpeed = aircraft.MaxSpeed; //<-- not allowed, this is a static member of Concord or Beoing class, not a member of an instance of those classes
            var aSayHello = aircraft.SayHello(); //<-- not allowed, this is a static member of IGM_Aircraft itself
            var aSayHi = aircraft.SayHi(); //<-- not allowed, this is a static method of either Concord or Boeing, not a method of an instance of those classes

            var validMaxSpeed = T.MaxSpeed; //allowed
            var validSayHi = T.SayHi(); //allowed
            var validSpeed = aircraft.Speed; //allowed
            */

            return $"Speed = {aircraft.Speed} ({aircraft.Speed * 100 / T.MaxSpeed})%";
        }
    }
}
