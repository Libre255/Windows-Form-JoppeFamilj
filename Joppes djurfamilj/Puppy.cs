using static System.Console;
namespace JoppesDjurFamilj
{
    public class Puppy : Dog
    {
        private int _months;
        public Puppy(string name, int months) : base(name, months)
        {
            Name = name;
            Age = 0;
            Months = months;
        }

        public override int Months
        {
            get { return _months; }
            set
            {
                if (value < 0)
                {
                    _months = 0;
                }
                else if (value > 12)
                {
                    _months = 12;
                }
                else
                {
                    _months = value;
                }
            }
        }

        public override string[] Interact(Ball playBall)
        {
            string status = "";
            string Msg = "";
            if (Hungry || Energy == 0)
            {
                Msg = ($"*{Name} is hungry and/or with no energy to play*");
                status = "HungryDog";
            }
            else
            {
                if(playBall.Quality == 0)
                {
                    Msg = ("*The ball is broken, need to buy a new ball*");
                    status = "BallBroken";
                }
                else
                {
                    playBall.lower_quality();
                    Msg = ($"* {Name} is playing with Joppes ball and got a bit broken *");
                    status = "Playing";
                    Energy--;
                    if (Energy == 0)
                    {
                        Hungry = true;
                    }
                }
            }
            return new string[] { status, Msg };
        }

        public override string ToString()
        {
            return $"******* Puppy Name: {Name} *********** " + "\n" +
                   $"        Months: {Months}" + "\n" +
                $"        Favorite Food: {Fav_Food}" + "\n" +
                $"        Breed: {Breed}" + "\n" +
                $"        Hungry: {Hungry}" + "\n";
        }
    }
}
