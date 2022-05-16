using Xunit;

namespace xUnitTest;

public class UnitTest1
{
    [Fact]// The FACT annotation states to Xunit that this is a single test.
    public void Test1()
    {
        // Step 1. Arrange
        


        // Step 2. Act
        // this step is unneeded for this test 
        // because the constructor does the actions we would have done.


        // Step 3. Assert
        // .Equals() tests whether the two instances are 'considered' equal.
        // "Equal()" means the same memory location
        // .Equals() is like saying 1 == 1 even if the 2 instances of 1 are 
        // held in different spots in memory.
        //Assert.Equal("", );

    }
    [Fact]
    public void BoolCheck()
    {
        // Step 1, Arrange 
        int copy = 11;
        int product  = 11;

        //Step 2. Act unneeded

        // Step3. Assert
        Assert.Equal(copy, product);
        //Assert.Equal(expected, actual);
    }
    
}



    
