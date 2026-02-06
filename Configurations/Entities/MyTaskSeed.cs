using _2401377C.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace _2401377C.Configurations.Entities
{
    public class MyTaskSeed : IEntityTypeConfiguration<MyTask>
    {
        public void Configure(EntityTypeBuilder<MyTask> builder)
        {
            builder.HasData(
                new MyTask
                {
                    Id = 1,
                    TaskName = "Order Groceries",
                    IsCompleted = true,
                    DueDate = DateTime.Today.AddDays(-1)
                },
                new MyTask
                {
                    Id = 2,
                    TaskName = "Pick up laundry",
                    IsCompleted = false,
                    DueDate = DateTime.Today.AddDays(7)
                },
                new MyTask
                {
                    Id = 3,
                    TaskName = "Practical Test 2",
                    IsCompleted = false,
                    DueDate = DateTime.Today
                }
                );
        }
    }
}
