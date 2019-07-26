namespace Patrones.FactoryMethod
{
    public class BasePostre
    {
        public string IngredientePrincipal { get; set; }

        public BasePostre(string IngredientePrincipal) { this.IngredientePrincipal = IngredientePrincipal; }

        public void Preparar()
        {
            System.Console.WriteLine("Se preparó el postre con " + IngredientePrincipal);
        }
    }
}
