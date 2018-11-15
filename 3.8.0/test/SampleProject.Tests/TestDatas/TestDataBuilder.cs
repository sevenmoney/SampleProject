using SampleProject.EntityFrameworkCore;

namespace SampleProject.Tests.TestDatas
{
    public class TestDataBuilder
    {
        private readonly SampleProjectDbContext _context;

        public TestDataBuilder(SampleProjectDbContext context)
        {
            _context = context;
        }

        public void Build()
        {
            //create test data here...
        }
    }
}