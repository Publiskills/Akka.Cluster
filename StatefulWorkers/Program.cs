using Akka.Actor;

namespace StatefulWorkers
{
   class Program
   {
      private static void Main(string[] _) =>
         ActorSystem.Create("MyActorSystem").WhenTerminated.Wait();
   }
}
