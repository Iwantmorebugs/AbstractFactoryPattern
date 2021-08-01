using AbstractFactoryExercise.Products;

namespace AbstractFactoryExercise.Factories
{
    internal class CuñaderíaFactory : AbstractFactory
    {
        public override Cuñadismos CrearCuñadismo()
        {
            return new CuñadaBuena();
        }

        public override Mentiras CrearMentiras()
        {
            return new MentiraMala();
        }
    }
}