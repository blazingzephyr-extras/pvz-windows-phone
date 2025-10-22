
// blazingzephyr: This is a utility class which serves as a hook for the game.
// I tried keeping as much of the original code as possible, only removed
// Windows Phone-specific code, but this ought to be playable nonetheless.
//
// I suppose the only notable changes outside of that were changing this
// from the library to an executable due to how the game works, as well as
// migrating from .NET Framework 2.0 to .NET 4.0 Framework out of a necessity
// because I seem to be lacking some of the more important libraries.
// However, I presume it might be possible to compile this using .NET Framework 2.0?
namespace LAWN
{
    internal class Program
    {
        public static void Main()
        {
            Sexy.Main main = new Sexy.Main();
            main.Run();
        }
    }
}
