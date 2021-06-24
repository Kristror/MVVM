namespace Snake
{
    public sealed class Speed : ISpeed
    {
        private float _speed;
        public float MaxSpeed { get; }

        public float CurrentSpeed
        {
            get => _speed;
            set
            {
                if (value > 0)
                    _speed = value;
            }
        }

        public Speed(float maxSpeed, float speed)
        {
            MaxSpeed = maxSpeed;
            _speed = speed;
        }
    }
}