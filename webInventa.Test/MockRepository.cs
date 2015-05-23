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
        {//Список для хранения переменных
            ListТип_улицы = new List<Тип_улицы>();
            //Добавление двух типов улиц
            ListТип_улицы.Add(
                new Тип_улицы()
                {
                    Код = 1,
                    Название = "Проспект"
                }
                );
            ListТип_улицы.Add(
                new Тип_улицы()
                {
                    Код = 2,
                    Название = "Улица"
                }
                );
            //Установка функции получить все 
            Setup(p => p.GetТип_улицы).Returns(ListТип_улицы.AsQueryable());
            //Установка функции получить по уник. индент.
            Setup(p => p.GetByIdТип_улицы(It.IsAny<int>())).Returns((int id) =>
                ListТип_улицы.FirstOrDefault(p => p.Код == id));
            //Установка функции добавления 
            Setup(p => p.CreateТип_улицы(It.IsAny<Тип_улицы>())).Returns((Тип_улицы instance) =>
            {
                ListТип_улицы.Add(instance);
                return true;
            });
            //Установка функции удаления
            Setup(p => p.UpdateТип_улицы(It.IsAny<Тип_улицы>())).Returns((Тип_улицы instance) =>
            {
                ListТип_улицы.First(p=>p.Код==instance.Код).Название=instance.Название;
                return true;
            });
            //Установка функции редактирования
            Setup(p => p.RemoveТип_улицы(It.IsAny<Тип_улицы>())).Returns((Тип_улицы instance) =>
            {
                ListТип_улицы.Remove(instance);
                return true;
            });
        }
    }
}
