using Backend;
using System;
using Xunit;

namespace XUnitTestProject1
{
    public class UnitTestBackend
    {
        [Fact]
        public void CreationTypeTest()
        {
            //arrange
            BodyType expected = BodyType.MOON;
            Moon moon;

            //act
            moon = new Moon("1","moon","",1.1,10,10,true,true,"");

            //assert
            Assert.Equal(expected, moon.BodyType);

        }

        [Fact]
        public void GetInfoTest()
        {
            //arrange
            string expected = "1 moon test Child of: earth";
            Moon moon = new Moon("1", "moon", "test", 1.1, 10, 10, true, true, "earth");

            //act
            string result = moon.getInfo();

            //assert
            Assert.Equal(expected, result);

        }
    }
}
