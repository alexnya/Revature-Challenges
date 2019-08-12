using System;
using Xunit;
using Palindrome.Domain;

namespace Palindrome.Testing
{
    public class IsAPalindrome
    {
        [Fact]
        public void LengthCheck() {
        //arranged
        var wordExample = new Palindrome();
        var expected = 5;

        //act
        var actual = Palindrome.length();
        
        //assert
        Assert.True(expected == true);
        }
    }
}
