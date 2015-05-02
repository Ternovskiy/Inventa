using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InventaDataModul;
using Moq;

namespace webInventa.Test
{
    public partial class MockRepository : Mock<IRepository>
    {
        public MockRepository(MockBehavior mockBehavior = MockBehavior.Strict)
            : base(mockBehavior)
        {
            
            GenerateUsers();

        }
    }


    public partial class MockRepository
    {
        public List<Тип_улицы> ListТип_улицы { get; set; }

        public void GenerateUsers()
        {
            ListТип_улицы = new List<Тип_улицы>();

            ListТип_улицы.Add(
                new Тип_улицы()
                {
                    Код = 1,
                    Название = "Терешклвой"
                }
                );


            ListТип_улицы.Add(
                new Тип_улицы()
                {
                    Код = 2,
                    Название = "Победы"
                }
                );
            

            this.Setup(p => p.GetТип_улицы).Returns(ListТип_улицы.AsQueryable());
            Setup(p => p.GetByIdТип_улицы(It.IsAny<int>())).Returns((int id) => 
                ListТип_улицы.FirstOrDefault(p => p.Код == id));
            
        }
    }
}
