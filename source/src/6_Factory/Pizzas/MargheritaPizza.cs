
namespace DesignPatterns._6_Factory
{
    public class MargheritaPizza : IPizza
    {
        public string Name => "Margherita";

        public List<string> Ingredients => new List<string>(["Tomatensauce", "Mozzarella"]);
    }
}
