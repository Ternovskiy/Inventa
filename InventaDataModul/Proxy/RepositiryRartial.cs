using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventaDataModul
{

    #region Тип_улицы Repository

    public partial class Repository
    {
        public IQueryable<Тип_улицы> GetТип_улицы
        {
            get { return Db.Тип_улицы; }
        }

        public Тип_улицы GetByIdТип_улицы(int id)
        {
            return Db.Тип_улицы.FirstOrDefault(t => t.Код == id);
        }

        public bool CreateТип_улицы(Тип_улицы instance)
        {
            if (instance.Код == 0)
            {
                Db.Тип_улицы.InsertOnSubmit(instance);
                Db.Тип_улицы.Context.SubmitChanges();
                return true;
            }
            return false;
        }

        public bool UpdateТип_улицы(Тип_улицы instance)
        {

            Тип_улицы cache = Db.Тип_улицы.FirstOrDefault(p => p.Код == instance.Код);
            if (cache != null)
            {
                cache.Название = instance.Название;

                Db.Тип_улицы.Context.SubmitChanges();
                return true;
            }
            return false;
        }

        public bool RemoveТип_улицы(Тип_улицы instance)
        {
            Тип_улицы cache = Db.Тип_улицы.FirstOrDefault(p => p.Код == instance.Код);
            if (cache != null)
            {
                Db.Тип_улицы.DeleteOnSubmit(cache);
                Db.Тип_улицы.Context.SubmitChanges();
                return true;
            }

            return false;
        }
    }

    #endregion

    #region Тип_лога Repository

    public partial class Repository
    {
        public IQueryable<Тип_лога> GetТип_лога
        {
            get { return Db.Тип_лога; }
        }

        public Тип_лога GetByIdТип_лога(int id)
        {
            return Db.Тип_лога.FirstOrDefault(t => t.Код == id);
        }

        public bool CreateТип_лога(Тип_лога instance)
        {
            if (instance.Код == 0)
            {
                Db.Тип_лога.InsertOnSubmit(instance);
                Db.Тип_лога.Context.SubmitChanges();
                return true;
            }
            return false;
        }

        public bool UpdateТип_лога(Тип_лога instance)
        {

            Тип_лога cache = Db.Тип_лога.FirstOrDefault(p => p.Код == instance.Код);
            if (cache != null)
            {

                cache.Название = instance.Название;


                cache.Описание = instance.Описание;


                Db.Тип_лога.Context.SubmitChanges();
                return true;
            }
            return false;
        }

        public bool RemoveТип_лога(Тип_лога instance)
        {
            Тип_лога cache = Db.Тип_лога.FirstOrDefault(p => p.Код == instance.Код);
            if (cache != null)
            {
                Db.Тип_лога.DeleteOnSubmit(cache);
                Db.Тип_лога.Context.SubmitChanges();
                return true;
            }

            return false;
        }
    }
    #endregion

    #region Улица

    public partial class Repository
    {
        public IQueryable<Улица> GetУлица
        {
            get { return Db.Улица; }
        }

        public Улица GetByIdУлица(int id)
        {
            return Db.Улица.FirstOrDefault(t => t.Код == id);
        }

        public bool CreateУлица(Улица instance)
        {
            if (instance.Код == 0)
            {
                Db.Улица.InsertOnSubmit(instance);
                Db.Улица.Context.SubmitChanges();
                return true;
            }
            return false;
        }

        public bool UpdateУлица(Улица instance)
        {

            Улица cache = Db.Улица.FirstOrDefault(p => p.Код == instance.Код);
            if (cache != null)
            {

                cache.Название = instance.Название;


                cache.Код_типа = instance.Код_типа;


                Db.Улица.Context.SubmitChanges();
                return true;
            }
            return false;
        }

        public bool RemoveУлица(Улица instance)
        {
            Улица cache = Db.Улица.FirstOrDefault(p => p.Код == instance.Код);
            if (cache != null)
            {
                Db.Улица.DeleteOnSubmit(cache);
                Db.Улица.Context.SubmitChanges();
                return true;
            }

            return false;
        }
    }
    #endregion

    #region Тип_населенного_пункта

    public partial class Repository
    {
        public IQueryable<Тип_населенного_пункта> GetТип_населенного_пункта
        {
            get { return Db.Тип_населенного_пункта; }
        }

        public Тип_населенного_пункта GetByIdТип_населенного_пункта(int id)
        {
            return Db.Тип_населенного_пункта.FirstOrDefault(t => t.Код == id);
        }

        public bool CreateТип_населенного_пункта(Тип_населенного_пункта instance)
        {
            if (instance.Код == 0)
            {
                Db.Тип_населенного_пункта.InsertOnSubmit(instance);
                Db.Тип_населенного_пункта.Context.SubmitChanges();
                return true;
            }
            return false;
        }

        public bool UpdateТип_населенного_пункта(Тип_населенного_пункта instance)
        {

            Тип_населенного_пункта cache = Db.Тип_населенного_пункта.FirstOrDefault(p => p.Код == instance.Код);
            if (cache != null)
            {

                cache.Название = instance.Название;


                Db.Тип_населенного_пункта.Context.SubmitChanges();
                return true;
            }
            return false;
        }

        public bool RemoveТип_населенного_пункта(Тип_населенного_пункта instance)
        {
            Тип_населенного_пункта cache = Db.Тип_населенного_пункта.FirstOrDefault(p => p.Код == instance.Код);
            if (cache != null)
            {
                Db.Тип_населенного_пункта.DeleteOnSubmit(cache);
                Db.Тип_населенного_пункта.Context.SubmitChanges();
                return true;
            }

            return false;
        }
    }
    #endregion

    #region Населенный_пункт

    public partial class Repository
    {
        public IQueryable<Населенный_пункт> GetНаселенный_пункт
        {
            get { return Db.Населенный_пункт; }
        }

        public Населенный_пункт GetByIdНаселенный_пункт(int id)
        {
            return Db.Населенный_пункт.FirstOrDefault(t => t.Код == id);
        }

        public bool CreateНаселенный_пункт(Населенный_пункт instance)
        {
            if (instance.Код == 0)
            {
                Db.Населенный_пункт.InsertOnSubmit(instance);
                Db.Населенный_пункт.Context.SubmitChanges();
                return true;
            }
            return false;
        }

        public bool UpdateНаселенный_пункт(Населенный_пункт instance)
        {

            Населенный_пункт cache = Db.Населенный_пункт.FirstOrDefault(p => p.Код == instance.Код);
            if (cache != null)
            {

                cache.Название = instance.Название;


                cache.Код_типа = instance.Код_типа;


                Db.Населенный_пункт.Context.SubmitChanges();
                return true;
            }
            return false;
        }

        public bool RemoveНаселенный_пункт(Населенный_пункт instance)
        {
            Населенный_пункт cache = Db.Населенный_пункт.FirstOrDefault(p => p.Код == instance.Код);
            if (cache != null)
            {
                Db.Населенный_пункт.DeleteOnSubmit(cache);
                Db.Населенный_пункт.Context.SubmitChanges();
                return true;
            }

            return false;
        }
    }
    #endregion

    #region Физическое_лицо

    public partial class Repository
    {
        public IQueryable<Физическое_лицо> GetФизическое_лицо
        {
            get { return Db.Физическое_лицо; }
        }

        public Физическое_лицо GetByIdФизическое_лицо(int id)
        {
            return Db.Физическое_лицо.FirstOrDefault(t => t.Код == id);
        }

        public bool CreateФизическое_лицо(Физическое_лицо instance)
        {
            if (instance.Код == 0)
            {
                Db.Физическое_лицо.InsertOnSubmit(instance);
                Db.Физическое_лицо.Context.SubmitChanges();
                return true;
            }
            return false;
        }

        public bool UpdateФизическое_лицо(Физическое_лицо instance)
        {

            Физическое_лицо cache = Db.Физическое_лицо.FirstOrDefault(p => p.Код == instance.Код);
            if (cache != null)
            {

                cache.Фамилия = instance.Фамилия;


                cache.Имя = instance.Имя;


                cache.Отчество = instance.Отчество;


                cache.Телефон = instance.Телефон;


                Db.Физическое_лицо.Context.SubmitChanges();
                return true;
            }
            return false;
        }

        public bool RemoveФизическое_лицо(Физическое_лицо instance)
        {
            Физическое_лицо cache = Db.Физическое_лицо.FirstOrDefault(p => p.Код == instance.Код);
            if (cache != null)
            {
                Db.Физическое_лицо.DeleteOnSubmit(cache);
                Db.Физическое_лицо.Context.SubmitChanges();
                return true;
            }

            return false;
        }
    }
    #endregion

    #region Должность

    public partial class Repository
    {
        public IQueryable<Должность> GetДолжность
        {
            get { return Db.Должность; }
        }

        public Должность GetByIdДолжность(int id)
        {
            return Db.Должность.FirstOrDefault(t => t.Код == id);
        }

        public bool CreateДолжность(Должность instance)
        {
            if (instance.Код == 0)
            {
                Db.Должность.InsertOnSubmit(instance);
                Db.Должность.Context.SubmitChanges();
                return true;
            }
            return false;
        }

        public bool UpdateДолжность(Должность instance)
        {

            Должность cache = Db.Должность.FirstOrDefault(p => p.Код == instance.Код);
            if (cache != null)
            {

                cache.Название = instance.Название;


                cache.Краткое_название = instance.Краткое_название;


                Db.Должность.Context.SubmitChanges();
                return true;
            }
            return false;
        }

        public bool RemoveДолжность(Должность instance)
        {
            Должность cache = Db.Должность.FirstOrDefault(p => p.Код == instance.Код);
            if (cache != null)
            {
                Db.Должность.DeleteOnSubmit(cache);
                Db.Должность.Context.SubmitChanges();
                return true;
            }

            return false;
        }
    }
    #endregion

    #region Адрес

    public partial class Repository
    {
        public IQueryable<Адрес> GetАдрес
        {
            get { return Db.Адрес; }
        }

        public Адрес GetByIdАдрес(int id)
        {
            return Db.Адрес.FirstOrDefault(t => t.Код == id);
        }

        public bool CreateАдрес(Адрес instance)
        {
            if (instance.Код == 0)
            {
                Db.Адрес.InsertOnSubmit(instance);
                Db.Адрес.Context.SubmitChanges();
                return true;
            }
            return false;
        }

        public bool UpdateАдрес(Адрес instance)
        {

            Адрес cache = Db.Адрес.FirstOrDefault(p => p.Код == instance.Код);
            if (cache != null)
            {

                cache.Номер_дома = instance.Номер_дома;


                cache.Код_улицы = instance.Код_улицы;


                cache.Код_нас_пункта = instance.Код_нас_пункта;


                cache.Код_физического_лица = instance.Код_физического_лица;


                Db.Адрес.Context.SubmitChanges();
                return true;
            }
            return false;
        }

        public bool RemoveАдрес(Адрес instance)
        {
            Адрес cache = Db.Адрес.FirstOrDefault(p => p.Код == instance.Код);
            if (cache != null)
            {
                Db.Адрес.DeleteOnSubmit(cache);
                Db.Адрес.Context.SubmitChanges();
                return true;
            }

            return false;
        }
    }
    #endregion

    #region Тип_юр__лица

    public partial class Repository
    {
        public IQueryable<Тип_юр__лица> GetТип_юр__лица
        {
            get { return Db.Тип_юр__лица; }
        }

        public Тип_юр__лица GetByIdТип_юр__лица(int id)
        {
            return Db.Тип_юр__лица.FirstOrDefault(t => t.Код == id);
        }

        public bool CreateТип_юр__лица(Тип_юр__лица instance)
        {
            if (instance.Код == 0)
            {
                Db.Тип_юр__лица.InsertOnSubmit(instance);
                Db.Тип_юр__лица.Context.SubmitChanges();
                return true;
            }
            return false;
        }

        public bool UpdateТип_юр__лица(Тип_юр__лица instance)
        {

            Тип_юр__лица cache = Db.Тип_юр__лица.FirstOrDefault(p => p.Код == instance.Код);
            if (cache != null)
            {

                cache.Название = instance.Название;


                cache.Описание = instance.Описание;


                Db.Тип_юр__лица.Context.SubmitChanges();
                return true;
            }
            return false;
        }

        public bool RemoveТип_юр__лица(Тип_юр__лица instance)
        {
            Тип_юр__лица cache = Db.Тип_юр__лица.FirstOrDefault(p => p.Код == instance.Код);
            if (cache != null)
            {
                Db.Тип_юр__лица.DeleteOnSubmit(cache);
                Db.Тип_юр__лица.Context.SubmitChanges();
                return true;
            }

            return false;
        }
    }
    #endregion

    #region Юридическое_лицо

    public partial class Repository
    {
        public IQueryable<Юридическое_лицо> GetЮридическое_лицо
        {
            get { return Db.Юридическое_лицо; }
        }

        public Юридическое_лицо GetByIdЮридическое_лицо(int id)
        {
            return Db.Юридическое_лицо.FirstOrDefault(t => t.Код == id);
        }

        public bool CreateЮридическое_лицо(Юридическое_лицо instance)
        {
            if (instance.Код == 0)
            {
                Db.Юридическое_лицо.InsertOnSubmit(instance);
                Db.Юридическое_лицо.Context.SubmitChanges();
                return true;
            }
            return false;
        }

        public bool UpdateЮридическое_лицо(Юридическое_лицо instance)
        {

            Юридическое_лицо cache = Db.Юридическое_лицо.FirstOrDefault(p => p.Код == instance.Код);
            if (cache != null)
            {

                cache.Название = instance.Название;


                cache.Краткое_название = instance.Краткое_название;


                cache.Телефон = instance.Телефон;


                cache.Код_типа = instance.Код_типа;


                cache.Код_юрид__лица = instance.Код_юрид__лица;


                Db.Юридическое_лицо.Context.SubmitChanges();
                return true;
            }
            return false;
        }

        public bool RemoveЮридическое_лицо(Юридическое_лицо instance)
        {
            Юридическое_лицо cache = Db.Юридическое_лицо.FirstOrDefault(p => p.Код == instance.Код);
            if (cache != null)
            {
                Db.Юридическое_лицо.DeleteOnSubmit(cache);
                Db.Юридическое_лицо.Context.SubmitChanges();
                return true;
            }

            return false;
        }
    }
    #endregion

    #region Фр__труд__договора

    public partial class Repository
    {
        public IQueryable<Фр__труд__договора> GetФр__труд__договора
        {
            get { return Db.Фр__труд__договора; }
        }

        public Фр__труд__договора GetByIdФр__труд__договора(int id)
        {
            return Db.Фр__труд__договора.FirstOrDefault(t => t.Номер == id);
        }

        public bool CreateФр__труд__договора(Фр__труд__договора instance)
        {
            if (instance.Номер == 0)
            {
                Db.Фр__труд__договора.InsertOnSubmit(instance);
                Db.Фр__труд__договора.Context.SubmitChanges();
                return true;
            }
            return false;
        }

        public bool UpdateФр__труд__договора(Фр__труд__договора instance)
        {

            Фр__труд__договора cache = Db.Фр__труд__договора.FirstOrDefault(p => p.Номер == instance.Номер);
            if (cache != null)
            {

                cache.Дата_приема = instance.Дата_приема;


                cache.Дата_увольнения = instance.Дата_увольнения;


                cache.Код_физ__лица = instance.Код_физ__лица;


                cache.Код_юр__лица = instance.Код_юр__лица;


                cache.Код_должности = instance.Код_должности;


                Db.Фр__труд__договора.Context.SubmitChanges();
                return true;
            }
            return false;
        }

        public bool RemoveФр__труд__договора(Фр__труд__договора instance)
        {
            Фр__труд__договора cache = Db.Фр__труд__договора.FirstOrDefault(p => p.Номер == instance.Номер);
            if (cache != null)
            {
                Db.Фр__труд__договора.DeleteOnSubmit(cache);
                Db.Фр__труд__договора.Context.SubmitChanges();
                return true;
            }

            return false;
        }
    }
    #endregion

    #region Хост

    public partial class Repository
    {
        public IQueryable<Хост> GetХост
        {
            get { return Db.Хост; }
        }

        public Хост GetByIdХост(int id)
        {
            return Db.Хост.FirstOrDefault(t => t.Номер == id);
        }

        public bool CreateХост(Хост instance)
        {
            if (instance.Номер == 0)
            {
                Db.Хост.InsertOnSubmit(instance);
                Db.Хост.Context.SubmitChanges();
                return true;
            }
            return false;
        }

        public bool UpdateХост(Хост instance)
        {

            Хост cache = Db.Хост.FirstOrDefault(p => p.Номер == instance.Номер);
            if (cache != null)
            {

                cache.IP_адрес = instance.IP_адрес;


                cache.Описание = instance.Описание;


                cache.Код_адреса = instance.Код_адреса;


                Db.Хост.Context.SubmitChanges();
                return true;
            }
            return false;
        }

        public bool RemoveХост(Хост instance)
        {
            Хост cache = Db.Хост.FirstOrDefault(p => p.Номер == instance.Номер);
            if (cache != null)
            {
                Db.Хост.DeleteOnSubmit(cache);
                Db.Хост.Context.SubmitChanges();
                return true;
            }

            return false;
        }
    }
    #endregion

    #region Тип_работ

    public partial class Repository
    {
        public IQueryable<Тип_работ> GetТип_работ
        {
            get { return Db.Тип_работ; }
        }

        public Тип_работ GetByIdТип_работ(int id)
        {
            return Db.Тип_работ.FirstOrDefault(t => t.Код == id);
        }

        public bool CreateТип_работ(Тип_работ instance)
        {
            if (instance.Код == 0)
            {
                Db.Тип_работ.InsertOnSubmit(instance);
                Db.Тип_работ.Context.SubmitChanges();
                return true;
            }
            return false;
        }

        public bool UpdateТип_работ(Тип_работ instance)
        {

            Тип_работ cache = Db.Тип_работ.FirstOrDefault(p => p.Код == instance.Код);
            if (cache != null)
            {

                cache.Название = instance.Название;


                Db.Тип_работ.Context.SubmitChanges();
                return true;
            }
            return false;
        }

        public bool RemoveТип_работ(Тип_работ instance)
        {
            Тип_работ cache = Db.Тип_работ.FirstOrDefault(p => p.Код == instance.Код);
            if (cache != null)
            {
                Db.Тип_работ.DeleteOnSubmit(cache);
                Db.Тип_работ.Context.SubmitChanges();
                return true;
            }

            return false;
        }
    }
    #endregion

    #region Тег

    public partial class Repository
    {
        public IQueryable<Тег> GetТег
        {
            get { return Db.Тег; }
        }

        public Тег GetByIdТег(int id)
        {
            return Db.Тег.FirstOrDefault(t => t.Код == id);
        }

        public bool CreateТег(Тег instance)
        {
            if (instance.Код == 0)
            {
                Db.Тег.InsertOnSubmit(instance);
                Db.Тег.Context.SubmitChanges();
                return true;
            }
            return false;
        }

        public bool UpdateТег(Тег instance)
        {

            Тег cache = Db.Тег.FirstOrDefault(p => p.Код == instance.Код);
            if (cache != null)
            {

                cache.Название = instance.Название;


                cache.Описание = instance.Описание;


                Db.Тег.Context.SubmitChanges();
                return true;
            }
            return false;
        }

        public bool RemoveТег(Тег instance)
        {
            Тег cache = Db.Тег.FirstOrDefault(p => p.Код == instance.Код);
            if (cache != null)
            {
                Db.Тег.DeleteOnSubmit(cache);
                Db.Тег.Context.SubmitChanges();
                return true;
            }

            return false;
        }
    }
    #endregion

    #region Оборудование

    public partial class Repository
    {
        public IQueryable<Оборудование> GetОборудование
        {
            get { return Db.Оборудование; }
        }

        public Оборудование GetByIdОборудование(int id)
        {
            return Db.Оборудование.FirstOrDefault(t => t.Номер == id);
        }

        public bool CreateОборудование(Оборудование instance)
        {
            
                Db.Оборудование.InsertOnSubmit(instance);
                Db.Оборудование.Context.SubmitChanges();
                return true;
            
            return false;
        }

        public bool UpdateОборудование(Оборудование instance)
        {

            Оборудование cache = Db.Оборудование.FirstOrDefault(p => p.Номер == instance.Номер);
            if (cache != null)
            {

                cache.Дата_изготовления = instance.Дата_изготовления;


                cache.Описание = instance.Описание;


                cache.Код_юр__лица = instance.Код_юр__лица;


                Db.Оборудование.Context.SubmitChanges();
                return true;
            }
            return false;
        }

        public bool RemoveОборудование(Оборудование instance)
        {
            Оборудование cache = Db.Оборудование.FirstOrDefault(p => p.Номер == instance.Номер);
            if (cache != null)
            {
                Db.Оборудование.DeleteOnSubmit(cache);
                Db.Оборудование.Context.SubmitChanges();
                return true;
            }

            return false;
        }
    }
    #endregion

    #region Тип_показателя

    public partial class Repository
    {
        public IQueryable<Тип_показателя> GetТип_показателя
        {
            get { return Db.Тип_показателя; }
        }

        public Тип_показателя GetByIdТип_показателя(int id)
        {
            return Db.Тип_показателя.FirstOrDefault(t => t.Код == id);
        }

        public bool CreateТип_показателя(Тип_показателя instance)
        {
            if (instance.Код == 0)
            {
                Db.Тип_показателя.InsertOnSubmit(instance);
                Db.Тип_показателя.Context.SubmitChanges();
                return true;
            }
            return false;
        }

        public bool UpdateТип_показателя(Тип_показателя instance)
        {

            Тип_показателя cache = Db.Тип_показателя.FirstOrDefault(p => p.Код == instance.Код);
            if (cache != null)
            {

                cache.Название = instance.Название;


                Db.Тип_показателя.Context.SubmitChanges();
                return true;
            }
            return false;
        }

        public bool RemoveТип_показателя(Тип_показателя instance)
        {
            Тип_показателя cache = Db.Тип_показателя.FirstOrDefault(p => p.Код == instance.Код);
            if (cache != null)
            {
                Db.Тип_показателя.DeleteOnSubmit(cache);
                Db.Тип_показателя.Context.SubmitChanges();
                return true;
            }

            return false;
        }
    }
    #endregion

    #region Вид_показателя

    public partial class Repository
    {
        public IQueryable<Вид_показателя> GetВид_показателя
        {
            get { return Db.Вид_показателя; }
        }

        public Вид_показателя GetByIdВид_показателя(int id)
        {
            return Db.Вид_показателя.FirstOrDefault(t => t.Код == id);
        }

        public bool CreateВид_показателя(Вид_показателя instance)
        {
            if (instance.Код == 0)
            {
                Db.Вид_показателя.InsertOnSubmit(instance);
                Db.Вид_показателя.Context.SubmitChanges();
                return true;
            }
            return false;
        }

        public bool UpdateВид_показателя(Вид_показателя instance)
        {

            Вид_показателя cache = Db.Вид_показателя.FirstOrDefault(p => p.Код == instance.Код);
            if (cache != null)
            {

                cache.Название = instance.Название;


                cache.Описание = instance.Описание;


                Db.Вид_показателя.Context.SubmitChanges();
                return true;
            }
            return false;
        }

        public bool RemoveВид_показателя(Вид_показателя instance)
        {
            Вид_показателя cache = Db.Вид_показателя.FirstOrDefault(p => p.Код == instance.Код);
            if (cache != null)
            {
                Db.Вид_показателя.DeleteOnSubmit(cache);
                Db.Вид_показателя.Context.SubmitChanges();
                return true;
            }

            return false;
        }
    }
    #endregion

    #region Единицы_измерения

    public partial class Repository
    {
        public IQueryable<Единицы_измерения> GetЕдиницы_измерения
        {
            get { return Db.Единицы_измерения; }
        }

        public Единицы_измерения GetByIdЕдиницы_измерения(int id)
        {
            return Db.Единицы_измерения.FirstOrDefault(t => t.Код == id);
        }

        public bool CreateЕдиницы_измерения(Единицы_измерения instance)
        {
            if (instance.Код == 0)
            {
                Db.Единицы_измерения.InsertOnSubmit(instance);
                Db.Единицы_измерения.Context.SubmitChanges();
                return true;
            }
            return false;
        }

        public bool UpdateЕдиницы_измерения(Единицы_измерения instance)
        {

            Единицы_измерения cache = Db.Единицы_измерения.FirstOrDefault(p => p.Код == instance.Код);
            if (cache != null)
            {

                cache.Название = instance.Название;


                cache.Краткое_название = instance.Краткое_название;


                Db.Единицы_измерения.Context.SubmitChanges();
                return true;
            }
            return false;
        }

        public bool RemoveЕдиницы_измерения(Единицы_измерения instance)
        {
            Единицы_измерения cache = Db.Единицы_измерения.FirstOrDefault(p => p.Код == instance.Код);
            if (cache != null)
            {
                Db.Единицы_измерения.DeleteOnSubmit(cache);
                Db.Единицы_измерения.Context.SubmitChanges();
                return true;
            }

            return false;
        }
    }
    #endregion

    #region Тип_журнала

    public partial class Repository
    {
        public IQueryable<Тип_журнала> GetТип_журнала
        {
            get { return Db.Тип_журнала; }
        }

        public Тип_журнала GetByIdТип_журнала(int id)
        {
            return Db.Тип_журнала.FirstOrDefault(t => t.Код == id);
        }

        public bool CreateТип_журнала(Тип_журнала instance)
        {
            if (instance.Код == 0)
            {
                Db.Тип_журнала.InsertOnSubmit(instance);
                Db.Тип_журнала.Context.SubmitChanges();
                return true;
            }
            return false;
        }

        public bool UpdateТип_журнала(Тип_журнала instance)
        {

            Тип_журнала cache = Db.Тип_журнала.FirstOrDefault(p => p.Код == instance.Код);
            if (cache != null)
            {

                cache.Название = instance.Название;


                Db.Тип_журнала.Context.SubmitChanges();
                return true;
            }
            return false;
        }

        public bool RemoveТип_журнала(Тип_журнала instance)
        {
            Тип_журнала cache = Db.Тип_журнала.FirstOrDefault(p => p.Код == instance.Код);
            if (cache != null)
            {
                Db.Тип_журнала.DeleteOnSubmit(cache);
                Db.Тип_журнала.Context.SubmitChanges();
                return true;
            }

            return false;
        }
    }
    #endregion

    #region Лог

    public partial class Repository
    {
        public IQueryable<Лог> GetЛог
        {
            get { return Db.Лог; }
        }

        public Лог GetByIdЛог(int id)
        {
            return Db.Лог.FirstOrDefault(t => t.Номер == id);
        }

        public bool CreateЛог(Лог instance)
        {
            if (instance.Номер == 0)
            {
                Db.Лог.InsertOnSubmit(instance);
                Db.Лог.Context.SubmitChanges();
                return true;
            }
            return false;
        }

        public bool UpdateЛог(Лог instance)
        {

            Лог cache = Db.Лог.FirstOrDefault(p => p.Номер == instance.Номер);
            if (cache != null)
            {

                cache.Сообщение = instance.Сообщение;


                cache.Код_тега = instance.Код_тега;


                cache.Код_лога = instance.Код_лога;


                Db.Лог.Context.SubmitChanges();
                return true;
            }
            return false;
        }

        public bool RemoveЛог(Лог instance)
        {
            Лог cache = Db.Лог.FirstOrDefault(p => p.Номер == instance.Номер);
            if (cache != null)
            {
                Db.Лог.DeleteOnSubmit(cache);
                Db.Лог.Context.SubmitChanges();
                return true;
            }

            return false;
        }
    }
    #endregion

    #region Показатель

    public partial class Repository
    {
        public IQueryable<Показатель> GetПоказатель
        {
            get { return Db.Показатель; }
        }

        public Показатель GetByIdПоказатель(int id)
        {
            return Db.Показатель.FirstOrDefault(t => t.Код == id);
        }

        public bool CreateПоказатель(Показатель instance)
        {
            if (instance.Код == 0)
            {
                Db.Показатель.InsertOnSubmit(instance);
                Db.Показатель.Context.SubmitChanges();
                return true;
            }
            return false;
        }

        public bool UpdateПоказатель(Показатель instance)
        {

            Показатель cache = Db.Показатель.FirstOrDefault(p => p.Код == instance.Код);
            if (cache != null)
            {

                cache.Значение = instance.Значение;


                cache.Код_показателя = instance.Код_показателя;


                cache.Код_состояния = instance.Код_состояния;


                cache.Тип_показателя = instance.Тип_показателя;


                cache.Код_вида_показателя = instance.Код_вида_показателя;


                cache.Единицы_измерения = instance.Единицы_измерения;


                Db.Показатель.Context.SubmitChanges();
                return true;
            }
            return false;
        }

        public bool RemoveПоказатель(Показатель instance)
        {
            Показатель cache = Db.Показатель.FirstOrDefault(p => p.Код == instance.Код);
            if (cache != null)
            {
                Db.Показатель.DeleteOnSubmit(cache);
                Db.Показатель.Context.SubmitChanges();
                return true;
            }

            return false;
        }
    }
    #endregion

    #region ПоказательОборудование

    public partial class Repository
    {
        public IQueryable<ПоказательОборудование> GetПоказательОборудование
        {
            get { return Db.ПоказательОборудование; }
        }

        public ПоказательОборудование GetByIdПоказательОборудование(int id)
        {
            return Db.ПоказательОборудование.FirstOrDefault(t => t.Код == id);
        }

        public bool CreateПоказательОборудование(ПоказательОборудование instance)
        {
            if (instance.Код == 0)
            {
                Db.ПоказательОборудование.InsertOnSubmit(instance);
                Db.ПоказательОборудование.Context.SubmitChanges();
                return true;
            }
            return false;
        }

        public bool UpdateПоказательОборудование(ПоказательОборудование instance)
        {

            ПоказательОборудование cache = Db.ПоказательОборудование.FirstOrDefault(p => p.Код == instance.Код);
            if (cache != null)
            {

                cache.Код_Оборудования = instance.Код_Оборудования;


                cache.Код_Показателя = instance.Код_Показателя;


                Db.ПоказательОборудование.Context.SubmitChanges();
                return true;
            }
            return false;
        }

        public bool RemoveПоказательОборудование(ПоказательОборудование instance)
        {
            ПоказательОборудование cache = Db.ПоказательОборудование.FirstOrDefault(p => p.Код == instance.Код);
            if (cache != null)
            {
                Db.ПоказательОборудование.DeleteOnSubmit(cache);
                Db.ПоказательОборудование.Context.SubmitChanges();
                return true;
            }

            return false;
        }
    }
    #endregion

    #region Документ_работ

    public partial class Repository
    {
        public IQueryable<Документ_работ> GetДокумент_работ
        {
            get { return Db.Документ_работ; }
        }

        public Документ_работ GetByIdДокумент_работ(int id)
        {
            return Db.Документ_работ.FirstOrDefault(t => t.Номер == id);
        }

        public bool CreateДокумент_работ(Документ_работ instance)
        {
            if (instance.Номер == 0)
            {
                Db.Документ_работ.InsertOnSubmit(instance);
                Db.Документ_работ.Context.SubmitChanges();
                return true;
            }
            return false;
        }

        public bool UpdateДокумент_работ(Документ_работ instance)
        {

            Документ_работ cache = Db.Документ_работ.FirstOrDefault(p => p.Номер == instance.Номер);
            if (cache != null)
            {

                cache.Название = instance.Название;


                cache.Дата = instance.Дата;


                cache.Описание = instance.Описание;


                cache.Код_хоста = instance.Код_хоста;


                cache.Код_фр__труд__дог_ = instance.Код_фр__труд__дог_;


                cache.Код_типа = instance.Код_типа;


                cache.Код_оборудования = instance.Код_оборудования;


                Db.Документ_работ.Context.SubmitChanges();
                return true;
            }
            return false;
        }

        public bool RemoveДокумент_работ(Документ_работ instance)
        {
            Документ_работ cache = Db.Документ_работ.FirstOrDefault(p => p.Номер == instance.Номер);
            if (cache != null)
            {
                Db.Документ_работ.DeleteOnSubmit(cache);
                Db.Документ_работ.Context.SubmitChanges();
                return true;
            }

            return false;
        }
    }
    #endregion

    #region Состояние_оборудования

    public partial class Repository
    {
        public IQueryable<Состояние_оборудования> GetСостояние_оборудования
        {
            get { return Db.Состояние_оборудования; }
        }

        public Состояние_оборудования GetByIdСостояние_оборудования(int id)
        {
            return Db.Состояние_оборудования.FirstOrDefault(t => t.Номер == id);
        }

        public bool CreateСостояние_оборудования(Состояние_оборудования instance)
        {
            if (instance.Номер == 0)
            {
                Db.Состояние_оборудования.InsertOnSubmit(instance);
                Db.Состояние_оборудования.Context.SubmitChanges();
                return true;
            }
            return false;
        }

        public bool UpdateСостояние_оборудования(Состояние_оборудования instance)
        {

            Состояние_оборудования cache = Db.Состояние_оборудования.FirstOrDefault(p => p.Номер == instance.Номер);
            if (cache != null)
            {

                cache.Номер_состояния = instance.Номер_состояния;


                Db.Состояние_оборудования.Context.SubmitChanges();
                return true;
            }
            return false;
        }

        public bool RemoveСостояние_оборудования(Состояние_оборудования instance)
        {
            Состояние_оборудования cache = Db.Состояние_оборудования.FirstOrDefault(p => p.Номер == instance.Номер);
            if (cache != null)
            {
                Db.Состояние_оборудования.DeleteOnSubmit(cache);
                Db.Состояние_оборудования.Context.SubmitChanges();
                return true;
            }

            return false;
        }
    }
    #endregion

    #region Событие

    public partial class Repository
    {
        public IQueryable<Событие> GetСобытие
        {
            get { return Db.Событие; }
        }

        public Событие GetByIdСобытие(int id)
        {
            return Db.Событие.FirstOrDefault(t => t.Код == id);
        }

        public bool CreateСобытие(Событие instance)
        {
            if (instance.Код == 0)
            {
                Db.Событие.InsertOnSubmit(instance);
                Db.Событие.Context.SubmitChanges();
                return true;
            }
            return false;
        }

        public bool UpdateСобытие(Событие instance)
        {

            Событие cache = Db.Событие.FirstOrDefault(p => p.Код == instance.Код);
            if (cache != null)
            {

                cache.Дата = instance.Дата;


                cache.Описание = instance.Описание;


                cache.Код_журнала = instance.Код_журнала;


                cache.Код_хоста = instance.Код_хоста;


                cache.Код_лога = instance.Код_лога;


                cache.Код_состояния = instance.Код_состояния;


                Db.Событие.Context.SubmitChanges();
                return true;
            }
            return false;
        }

        public bool RemoveСобытие(Событие instance)
        {
            Событие cache = Db.Событие.FirstOrDefault(p => p.Код == instance.Код);
            if (cache != null)
            {
                Db.Событие.DeleteOnSubmit(cache);
                Db.Событие.Context.SubmitChanges();
                return true;
            }

            return false;
        }
    }
    #endregion

    #region Журнал

    public partial class Repository
    {
        public IQueryable<Журнал> GetЖурнал
        {
            get { return Db.Журнал; }
        }

        public Журнал GetByIdЖурнал(int id)
        {
            return Db.Журнал.FirstOrDefault(t => t.Номер == id);
        }

        public bool CreateЖурнал(Журнал instance)
        {
            if (instance.Номер == 0)
            {
                Db.Журнал.InsertOnSubmit(instance);
                Db.Журнал.Context.SubmitChanges();
                return true;
            }
            return false;
        }

        public bool UpdateЖурнал(Журнал instance)
        {

            Журнал cache = Db.Журнал.FirstOrDefault(p => p.Номер == instance.Номер);
            if (cache != null)
            {

                cache.Название = instance.Название;


                cache.Код_типа = instance.Код_типа;


                Db.Журнал.Context.SubmitChanges();
                return true;
            }
            return false;
        }

        public bool RemoveЖурнал(Журнал instance)
        {
            Журнал cache = Db.Журнал.FirstOrDefault(p => p.Номер == instance.Номер);
            if (cache != null)
            {
                Db.Журнал.DeleteOnSubmit(cache);
                Db.Журнал.Context.SubmitChanges();
                return true;
            }

            return false;
        }
    }
    #endregion
}
