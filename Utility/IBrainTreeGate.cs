using Braintree;

namespace UShopping.Utility
{
    public interface IBrainTreeGate
    {
        
        IBraintreeGateway CreateGateway();

        IBraintreeGateway GetGateway();
    
    }
}