using static System.Console;

namespace JoppesDjurFamilj
{
    public abstract class Animal
	{
        protected int _id;
		protected int _age;
		protected string _name = "";
		protected string _fav_food = "";
		protected string _breed = "";
		protected bool _hungry = new Random().Next(0, 2) == 1 ? true : false;
        protected int Energy = 3;

        public int ID { get { return _id; } set { _id = value; } }
		public abstract int Age { get; set; }
		public virtual int Months { get; set; }
		public string Name
        {
			set { _name = value; }	
			get { return _name; }
        }
		public bool Hungry
        {
            set { _hungry = value; }
            get { return _hungry; }
        }
		public string Fav_Food
        {
            set { _fav_food = value; }
            get { return _fav_food;}
        } 
		public string Breed
        {
			set { _breed = value; }
            get { return _breed;}
        }

		public virtual string[] Interact(Laser playLaser)
        {
            string status;
            string Msg;
            if (Hungry || Energy == 0)
            {
                Msg = ($"Cat *{Name} is hungry and/or with no energy to play*");
                status = "HungryCat";
            }
            else
            {
                if (playLaser.Battery == 0)
                {
                    Msg = ("The laser doesnt have battery please recharge");
                    status = "batterylow";
                }
                else
                {
                    playLaser.lower_battery();
                    Msg = ($"*The cat {Name} is playing 'laser chasin' with Joppe*");
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
		public virtual string[] Interact(Ball playBall)
        {
            string status;
            string Msg;
            if (Hungry || Energy == 0)
            {
                Msg = ($"*{Name} is hungry and with no energy to play*");
                status = "HungryDog";
            }
            else
            {
                if (playBall.Quality == 0)
                {
                    status = "BallBroken";
                    Msg = ("*The ball is broken, need a new ball*");
                }
                else
                {
                    playBall.lower_quality(2);
                    status = "PlayingDog";
                    Msg = ($"*{Name} is playing fetch ball with Joppe*");
                    Energy--;
                    if(Energy == 0)
                    {
                        Hungry = true;
                    }
                }
            }
            return new string[] {status, Msg};
        }

		public string eat(string food){
            if (Hungry)
            {
                if(food.ToLower() != Fav_Food.ToLower())
                {
				    return hungry_animal();
                }
                else
                {
				    Hungry = false;
                    Energy = 3;
				    return ("*eated food* and is now full");
                }
            }
            else
            {
                return ($"{Name} is full and dont want more food right now");
            }

        }
		public virtual string hungry_animal()
        {
			return ("*The pet didnt like the food and is whimpering*");
        }
		public abstract override string ToString();
	}
}
