using System.IdentityModel.Tokens;

namespace IdentityServer3.Contrib.Saml2Bearer
{
    public interface ISaml2AssertionSerializer
    {
        string ToXml(Saml2Assertion assertion);
    }
}