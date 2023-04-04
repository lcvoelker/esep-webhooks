using Xunit;
using Amazon.Lambda.Core;
using Amazon.Lambda.TestUtilities;

namespace EsepWebhook.Tests;

public class FunctionTest
{
    [Fact]
    public void TestToUpperFunction()
    {

        // Invoke the lambda function and confirm the string was upper cased.
        var function = new Function();
        var context = new TestLambdaContext();
        function.FunctionHandler("{'action':'edited','issue':{'url':'https://api.github.com/lcvoelker/esep-webhooks/repos/issues/3','repository_url':'https://api.github.com/repos/lcvoelker/esep-webhooks','labels_url':'https://api.github.com/repos/lcvoelker/esep-webhooks/issues/2/labels{/name}','comments_url':'https://api.github.com/repos/lcvoelker/esep-webhooks/issues/2/comments','events_url':'https://api.github.com/repos/lcvoelker/esep-webhooks/issues/2/events','html_url':'https://github.com/lcvoelker/esep-webhooks/issues/2','id':1402369902,'node_id':'I_kwDOILGT9s5Tlndu','number':2,'title':'test','user':{'login':'lcvoelker'}}}", context);
        
    }
}
//'id':1402369902,'node_id':'I_kwDOILGT9s5Tlndu'
