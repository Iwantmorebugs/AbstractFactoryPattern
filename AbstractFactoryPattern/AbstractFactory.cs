using AbstractFactoryExercise.Products;

namespace AbstractFactoryExercise
{
    internal abstract class AbstractFactory
    {
        public abstract Cuñadismos CrearCuñadismo();
        public abstract Mentiras CrearMentiras();
    }
}