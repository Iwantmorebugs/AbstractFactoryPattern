using AbstractFactoryExercise.Products;

namespace AbstractFactoryExercise.Factories
{
    internal class MentiraFactory : AbstractFactory
    {
        public override Cuñadismos CrearCuñadismo()
        {
            return new CuñadaMala();
        }

        public override Mentiras CrearMentiras()
        {
            return new MentiraBuena();
        }
    }
}