using LightInject;
using SimpleInjector;

namespace D02App1;

public class CustomContainerProgram
{
    internal static void SimpleInjectorExampe()
    {
        // Intialization for the concrete classes
        // var card1 = new MasterCard();
        // var card2 = new VisaCard();
        // Shopper client = new Shopper();
        // client.Checkout(card2);

        // 1. Create container instance
        Container container = new();
        
        // 2. Registration for types
        container.Register<ICreditCard, MasterCard>();
        container.Register<Shopper, Shopper>();
        
        // 3. Resolution for types to return concrete types
        var card1 = container.GetInstance<ICreditCard>();
        var client1 = container.GetInstance<Shopper>();

        client1.Checkout(card1);
        
        // // override for registration
        // // any resolution after this registration will return "MasterCard"
        // container.Register<ICreditCard, MasterCard>();
        // client1.Checkout(card1);

        ////if non-generic & Original method version not private
        //container.Register(typeof(ICreditCard), typeof(VisaCard));

        //// 3. resolution for types to return concrete types
        //var card2 = container.Resolve<ICreditCard>();
        //var client2 = container.Resolve<Shopper>();

        //client2.Checkout(card2);
    }
    internal static void LightInjectExample()
    {
        ServiceContainer container = new();
        // Register the service
        container.Register<ICreditCard, VisaCard>();
        container.Register<Shopper>();
        // Resolve the service
        var card = container.GetInstance<ICreditCard>();
        var client = container.GetInstance<Shopper>();
        client.Checkout(card);
    }
}