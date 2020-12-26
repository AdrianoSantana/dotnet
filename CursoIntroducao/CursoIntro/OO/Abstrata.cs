namespace CursoIntro.OO
{
    public abstract class Celular
    {
        public abstract string Assistente();
        public string Tocar()
        {
            return "trim trim trim";
        }
    }
    public class Iphone : Celular
    {
        public override string Assistente()
        {
            return $"Assistente do celular siri";
        }
    }
    public class Abstrata
    {

        public static void Executar()
        {
            Celular iphoneX = new Iphone();
        }
    }
}