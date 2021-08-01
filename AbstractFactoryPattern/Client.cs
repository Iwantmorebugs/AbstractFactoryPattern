using AbstractFactoryExercise.Products;

namespace AbstractFactoryExercise
{
    internal class Client
    {
        private readonly Cuñadismos _cuñadismos;

        private readonly Mentiras _mentiras;


        public Client(AbstractFactory factory)
        {
            _mentiras = factory.CrearMentiras();
            _cuñadismos = factory.CrearCuñadismo();
        }

        public string DescribeYourLies()
        {
            return $"Today I feel like telling a lot of: {_mentiras.GetType().Name} and {_cuñadismos.GetType().Name}";
        }
    }
}