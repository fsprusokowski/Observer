namespace Observer.Class
{
    public abstract class Investor
    {
        protected Stock Stock { get; set; }

        public abstract void Update();
    }
}
