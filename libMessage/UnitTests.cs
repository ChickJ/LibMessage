namespace libMessage.CMessage {

using Xunit;
using System;

/// <summary>
/// Unit tests for <see cref="libMessage.Message.SayHello" />
/// </summary>
public class MSayHello
{
    [Fact]
    public void Succeeds()
    {
        const string expected = "Hello World";
        var msg = new libMessage.Message();
        var actual = msg.SayHello();
        Assert.Equal(expected, actual);
    }
}

} // namespace
