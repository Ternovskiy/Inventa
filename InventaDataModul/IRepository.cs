using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventaDataModul
{
    public interface IRepository
    {
        #region Тип_улицы
        /// <summary>
        /// Набор таблиц Тип_улицы
        /// </summary>
        IQueryable<Тип_улицы> GetТип_улицы { get; }

        /// <summary>
        /// Таблица Тип_улицы по уникальному ключю
        /// </summary>
        /// <param name="id">Ключ таблицы Тип_улицы</param>
        /// <returns></returns>
        Тип_улицы GetByIdТип_улицы(int id);
        
        /// <summary>
        /// Добавить в базу новый объект Тип_улицы
        /// </summary>
        /// <param name="instance">Объект Тип_улицы</param>
        /// <returns></returns>
        bool CreateТип_улицы(Тип_улицы instance);

        /// <summary>
        /// Редактировать объект Тип_улицы
        /// </summary>
        /// <param name="instance">Объет Тип_улицы</param>
        /// <returns></returns>
        bool UpdateТип_улицы(Тип_улицы instance);

        /// <summary>
        /// Удалить объет Тип_улицы(удаляется по уникальному ключю)
        /// </summary>
        /// <param name="instance">Объект Тип_улицы</param>
        /// <returns></returns>
        bool RemoveТип_улицы(Тип_улицы instance);
        
        #endregion

        #region Тип_лога IRepository

        /// <summary>
        /// Набор таблиц Тип_лога
        /// </summary>
        IQueryable<Тип_лога> GetТип_лога { get; }

        /// <summary>
        /// Таблица Тип_лога по уникальному ключю
        /// </summary>
        /// <param name="id">Ключ таблицы Тип_лога</param>
        /// <returns></returns>
        Тип_лога GetByIdТип_лога(int id);

        /// <summary>
        /// Добавить в базу новый объект Тип_лога
        /// </summary>
        /// <param name="instance">Объект Тип_лога</param>
        /// <returns></returns>
        bool CreateТип_лога(Тип_лога instance);

        /// <summary>
        /// Редактировать объект Тип_лога
        /// </summary>
        /// <param name="instance">Объет Тип_лога</param>
        /// <returns></returns>
        bool UpdateТип_лога(Тип_лога instance);

        /// <summary>
        /// Удалить объет Тип_лога(удаляется по уникальному ключю)
        /// </summary>
        /// <param name="instance">Объект Тип_лога</param>
        /// <returns></returns>
        bool RemoveТип_лога(Тип_лога instance);

        #endregion

        #region Улица

        /// <summary>
        /// Набор таблиц Улица
        /// </summary>
        IQueryable<Улица> GetУлица { get; }

        /// <summary>
        /// Таблица Улица по уникальному ключю
        /// </summary>
        /// <param name="id">Ключ таблицы Улица</param>
        /// <returns></returns>
        Улица GetByIdУлица(int id);

        /// <summary>
        /// Добавить в базу новый объект Улица
        /// </summary>
        /// <param name="instance">Объект Улица</param>
        /// <returns></returns>
        bool CreateУлица(Улица instance);

        /// <summary>
        /// Редактировать объект Улица
        /// </summary>
        /// <param name="instance">Объет Улица</param>
        /// <returns></returns>
        bool UpdateУлица(Улица instance);

        /// <summary>
        /// Удалить объет Улица(удаляется по уникальному ключю)
        /// </summary>
        /// <param name="instance">Объект Улица</param>
        /// <returns></returns>
        bool RemoveУлица(Улица instance);

        #endregion

        #region Тип_населенного_пункта

        /// <summary>
        /// Набор таблиц Тип_населенного_пункта
        /// </summary>
        IQueryable<Тип_населенного_пункта> GetТип_населенного_пункта { get; }

        /// <summary>
        /// Таблица Тип_населенного_пункта по уникальному ключю
        /// </summary>
        /// <param name="id">Ключ таблицы Тип_населенного_пункта</param>
        /// <returns></returns>
        Тип_населенного_пункта GetByIdТип_населенного_пункта(int id);

        /// <summary>
        /// Добавить в базу новый объект Тип_населенного_пункта
        /// </summary>
        /// <param name="instance">Объект Тип_населенного_пункта</param>
        /// <returns></returns>
        bool CreateТип_населенного_пункта(Тип_населенного_пункта instance);

        /// <summary>
        /// Редактировать объект Тип_населенного_пункта
        /// </summary>
        /// <param name="instance">Объет Тип_населенного_пункта</param>
        /// <returns></returns>
        bool UpdateТип_населенного_пункта(Тип_населенного_пункта instance);

        /// <summary>
        /// Удалить объет Тип_населенного_пункта(удаляется по уникальному ключю)
        /// </summary>
        /// <param name="instance">Объект Тип_населенного_пункта</param>
        /// <returns></returns>
        bool RemoveТип_населенного_пункта(Тип_населенного_пункта instance);

        #endregion

        #region Населенный_пункт

        /// <summary>
        /// Набор таблиц Населенный_пункт
        /// </summary>
        IQueryable<Населенный_пункт> GetНаселенный_пункт { get; }

        /// <summary>
        /// Таблица Населенный_пункт по уникальному ключю
        /// </summary>
        /// <param name="id">Ключ таблицы Населенный_пункт</param>
        /// <returns></returns>
        Населенный_пункт GetByIdНаселенный_пункт(int id);

        /// <summary>
        /// Добавить в базу новый объект Населенный_пункт
        /// </summary>
        /// <param name="instance">Объект Населенный_пункт</param>
        /// <returns></returns>
        bool CreateНаселенный_пункт(Населенный_пункт instance);

        /// <summary>
        /// Редактировать объект Населенный_пункт
        /// </summary>
        /// <param name="instance">Объет Населенный_пункт</param>
        /// <returns></returns>
        bool UpdateНаселенный_пункт(Населенный_пункт instance);

        /// <summary>
        /// Удалить объет Населенный_пункт(удаляется по уникальному ключю)
        /// </summary>
        /// <param name="instance">Объект Населенный_пункт</param>
        /// <returns></returns>
        bool RemoveНаселенный_пункт(Населенный_пункт instance);

        #endregion

        #region Физическое_лицо

        /// <summary>
        /// Набор таблиц Физическое_лицо
        /// </summary>
        IQueryable<Физическое_лицо> GetФизическое_лицо { get; }

        /// <summary>
        /// Таблица Физическое_лицо по уникальному ключю
        /// </summary>
        /// <param name="id">Ключ таблицы Физическое_лицо</param>
        /// <returns></returns>
        Физическое_лицо GetByIdФизическое_лицо(int id);

        /// <summary>
        /// Добавить в базу новый объект Физическое_лицо
        /// </summary>
        /// <param name="instance">Объект Физическое_лицо</param>
        /// <returns></returns>
        bool CreateФизическое_лицо(Физическое_лицо instance);

        /// <summary>
        /// Редактировать объект Физическое_лицо
        /// </summary>
        /// <param name="instance">Объет Физическое_лицо</param>
        /// <returns></returns>
        bool UpdateФизическое_лицо(Физическое_лицо instance);

        /// <summary>
        /// Удалить объет Физическое_лицо(удаляется по уникальному ключю)
        /// </summary>
        /// <param name="instance">Объект Физическое_лицо</param>
        /// <returns></returns>
        bool RemoveФизическое_лицо(Физическое_лицо instance);

        #endregion

        #region Должность

        /// <summary>
        /// Набор таблиц Должность
        /// </summary>
        IQueryable<Должность> GetДолжность { get; }

        /// <summary>
        /// Таблица Должность по уникальному ключю
        /// </summary>
        /// <param name="id">Ключ таблицы Должность</param>
        /// <returns></returns>
        Должность GetByIdДолжность(int id);

        /// <summary>
        /// Добавить в базу новый объект Должность
        /// </summary>
        /// <param name="instance">Объект Должность</param>
        /// <returns></returns>
        bool CreateДолжность(Должность instance);

        /// <summary>
        /// Редактировать объект Должность
        /// </summary>
        /// <param name="instance">Объет Должность</param>
        /// <returns></returns>
        bool UpdateДолжность(Должность instance);

        /// <summary>
        /// Удалить объет Должность(удаляется по уникальному ключю)
        /// </summary>
        /// <param name="instance">Объект Должность</param>
        /// <returns></returns>
        bool RemoveДолжность(Должность instance);

        #endregion

        #region Адрес

        /// <summary>
        /// Набор таблиц Адрес
        /// </summary>
        IQueryable<Адрес> GetАдрес { get; }

        /// <summary>
        /// Таблица Адрес по уникальному ключю
        /// </summary>
        /// <param name="id">Ключ таблицы Адрес</param>
        /// <returns></returns>
        Адрес GetByIdАдрес(int id);

        /// <summary>
        /// Добавить в базу новый объект Адрес
        /// </summary>
        /// <param name="instance">Объект Адрес</param>
        /// <returns></returns>
        bool CreateАдрес(Адрес instance);

        /// <summary>
        /// Редактировать объект Адрес
        /// </summary>
        /// <param name="instance">Объет Адрес</param>
        /// <returns></returns>
        bool UpdateАдрес(Адрес instance);

        /// <summary>
        /// Удалить объет Адрес(удаляется по уникальному ключю)
        /// </summary>
        /// <param name="instance">Объект Адрес</param>
        /// <returns></returns>
        bool RemoveАдрес(Адрес instance);

        #endregion

        #region Тип_юр__лица

        /// <summary>
        /// Набор таблиц Тип_юр__лица
        /// </summary>
        IQueryable<Тип_юр__лица> GetТип_юр__лица { get; }

        /// <summary>
        /// Таблица Тип_юр__лица по уникальному ключю
        /// </summary>
        /// <param name="id">Ключ таблицы Тип_юр__лица</param>
        /// <returns></returns>
        Тип_юр__лица GetByIdТип_юр__лица(int id);

        /// <summary>
        /// Добавить в базу новый объект Тип_юр__лица
        /// </summary>
        /// <param name="instance">Объект Тип_юр__лица</param>
        /// <returns></returns>
        bool CreateТип_юр__лица(Тип_юр__лица instance);

        /// <summary>
        /// Редактировать объект Тип_юр__лица
        /// </summary>
        /// <param name="instance">Объет Тип_юр__лица</param>
        /// <returns></returns>
        bool UpdateТип_юр__лица(Тип_юр__лица instance);

        /// <summary>
        /// Удалить объет Тип_юр__лица(удаляется по уникальному ключю)
        /// </summary>
        /// <param name="instance">Объект Тип_юр__лица</param>
        /// <returns></returns>
        bool RemoveТип_юр__лица(Тип_юр__лица instance);

        #endregion

        #region Юридическое_лицо

        /// <summary>
        /// Набор таблиц Юридическое_лицо
        /// </summary>
        IQueryable<Юридическое_лицо> GetЮридическое_лицо { get; }

        /// <summary>
        /// Таблица Юридическое_лицо по уникальному ключю
        /// </summary>
        /// <param name="id">Ключ таблицы Юридическое_лицо</param>
        /// <returns></returns>
        Юридическое_лицо GetByIdЮридическое_лицо(int id);

        /// <summary>
        /// Добавить в базу новый объект Юридическое_лицо
        /// </summary>
        /// <param name="instance">Объект Юридическое_лицо</param>
        /// <returns></returns>
        bool CreateЮридическое_лицо(Юридическое_лицо instance);

        /// <summary>
        /// Редактировать объект Юридическое_лицо
        /// </summary>
        /// <param name="instance">Объет Юридическое_лицо</param>
        /// <returns></returns>
        bool UpdateЮридическое_лицо(Юридическое_лицо instance);

        /// <summary>
        /// Удалить объет Юридическое_лицо(удаляется по уникальному ключю)
        /// </summary>
        /// <param name="instance">Объект Юридическое_лицо</param>
        /// <returns></returns>
        bool RemoveЮридическое_лицо(Юридическое_лицо instance);

        #endregion

        #region Фр__труд__договора

        /// <summary>
        /// Набор таблиц Фр__труд__договора
        /// </summary>
        IQueryable<Фр__труд__договора> GetФр__труд__договора { get; }

        /// <summary>
        /// Таблица Фр__труд__договора по уникальному ключю
        /// </summary>
        /// <param name="id">Ключ таблицы Фр__труд__договора</param>
        /// <returns></returns>
        Фр__труд__договора GetByIdФр__труд__договора(int id);

        /// <summary>
        /// Добавить в базу новый объект Фр__труд__договора
        /// </summary>
        /// <param name="instance">Объект Фр__труд__договора</param>
        /// <returns></returns>
        bool CreateФр__труд__договора(Фр__труд__договора instance);

        /// <summary>
        /// Редактировать объект Фр__труд__договора
        /// </summary>
        /// <param name="instance">Объет Фр__труд__договора</param>
        /// <returns></returns>
        bool UpdateФр__труд__договора(Фр__труд__договора instance);

        /// <summary>
        /// Удалить объет Фр__труд__договора(удаляется по уникальному ключю)
        /// </summary>
        /// <param name="instance">Объект Фр__труд__договора</param>
        /// <returns></returns>
        bool RemoveФр__труд__договора(Фр__труд__договора instance);

        #endregion

        #region Хост

        /// <summary>
        /// Набор таблиц Хост
        /// </summary>
        IQueryable<Хост> GetХост { get; }

        /// <summary>
        /// Таблица Хост по уникальному ключю
        /// </summary>
        /// <param name="id">Ключ таблицы Хост</param>
        /// <returns></returns>
        Хост GetByIdХост(int id);

        /// <summary>
        /// Добавить в базу новый объект Хост
        /// </summary>
        /// <param name="instance">Объект Хост</param>
        /// <returns></returns>
        bool CreateХост(Хост instance);

        /// <summary>
        /// Редактировать объект Хост
        /// </summary>
        /// <param name="instance">Объет Хост</param>
        /// <returns></returns>
        bool UpdateХост(Хост instance);

        /// <summary>
        /// Удалить объет Хост(удаляется по уникальному ключю)
        /// </summary>
        /// <param name="instance">Объект Хост</param>
        /// <returns></returns>
        bool RemoveХост(Хост instance);

        #endregion

        #region Тип_работ

        /// <summary>
        /// Набор таблиц Тип_работ
        /// </summary>
        IQueryable<Тип_работ> GetТип_работ { get; }

        /// <summary>
        /// Таблица Тип_работ по уникальному ключю
        /// </summary>
        /// <param name="id">Ключ таблицы Тип_работ</param>
        /// <returns></returns>
        Тип_работ GetByIdТип_работ(int id);

        /// <summary>
        /// Добавить в базу новый объект Тип_работ
        /// </summary>
        /// <param name="instance">Объект Тип_работ</param>
        /// <returns></returns>
        bool CreateТип_работ(Тип_работ instance);

        /// <summary>
        /// Редактировать объект Тип_работ
        /// </summary>
        /// <param name="instance">Объет Тип_работ</param>
        /// <returns></returns>
        bool UpdateТип_работ(Тип_работ instance);

        /// <summary>
        /// Удалить объет Тип_работ(удаляется по уникальному ключю)
        /// </summary>
        /// <param name="instance">Объект Тип_работ</param>
        /// <returns></returns>
        bool RemoveТип_работ(Тип_работ instance);

        #endregion

        #region Тег

        /// <summary>
        /// Набор таблиц Тег
        /// </summary>
        IQueryable<Тег> GetТег { get; }

        /// <summary>
        /// Таблица Тег по уникальному ключю
        /// </summary>
        /// <param name="id">Ключ таблицы Тег</param>
        /// <returns></returns>
        Тег GetByIdТег(int id);

        /// <summary>
        /// Добавить в базу новый объект Тег
        /// </summary>
        /// <param name="instance">Объект Тег</param>
        /// <returns></returns>
        bool CreateТег(Тег instance);

        /// <summary>
        /// Редактировать объект Тег
        /// </summary>
        /// <param name="instance">Объет Тег</param>
        /// <returns></returns>
        bool UpdateТег(Тег instance);

        /// <summary>
        /// Удалить объет Тег(удаляется по уникальному ключю)
        /// </summary>
        /// <param name="instance">Объект Тег</param>
        /// <returns></returns>
        bool RemoveТег(Тег instance);

        #endregion

        #region Оборудование

        /// <summary>
        /// Набор таблиц Оборудование
        /// </summary>
        IQueryable<Оборудование> GetОборудование { get; }

        /// <summary>
        /// Таблица Оборудование по уникальному ключю
        /// </summary>
        /// <param name="id">Ключ таблицы Оборудование</param>
        /// <returns></returns>
        Оборудование GetByIdОборудование(int id);

        /// <summary>
        /// Добавить в базу новый объект Оборудование
        /// </summary>
        /// <param name="instance">Объект Оборудование</param>
        /// <returns></returns>
        bool CreateОборудование(Оборудование instance);

        /// <summary>
        /// Редактировать объект Оборудование
        /// </summary>
        /// <param name="instance">Объет Оборудование</param>
        /// <returns></returns>
        bool UpdateОборудование(Оборудование instance);

        /// <summary>
        /// Удалить объет Оборудование(удаляется по уникальному ключю)
        /// </summary>
        /// <param name="instance">Объект Оборудование</param>
        /// <returns></returns>
        bool RemoveОборудование(Оборудование instance);

        #endregion

        #region Тип_показателя

        /// <summary>
        /// Набор таблиц Тип_показателя
        /// </summary>
        IQueryable<Тип_показателя> GetТип_показателя { get; }

        /// <summary>
        /// Таблица Тип_показателя по уникальному ключю
        /// </summary>
        /// <param name="id">Ключ таблицы Тип_показателя</param>
        /// <returns></returns>
        Тип_показателя GetByIdТип_показателя(int id);

        /// <summary>
        /// Добавить в базу новый объект Тип_показателя
        /// </summary>
        /// <param name="instance">Объект Тип_показателя</param>
        /// <returns></returns>
        bool CreateТип_показателя(Тип_показателя instance);

        /// <summary>
        /// Редактировать объект Тип_показателя
        /// </summary>
        /// <param name="instance">Объет Тип_показателя</param>
        /// <returns></returns>
        bool UpdateТип_показателя(Тип_показателя instance);

        /// <summary>
        /// Удалить объет Тип_показателя(удаляется по уникальному ключю)
        /// </summary>
        /// <param name="instance">Объект Тип_показателя</param>
        /// <returns></returns>
        bool RemoveТип_показателя(Тип_показателя instance);

        #endregion

        #region Вид_показателя

        /// <summary>
        /// Набор таблиц Вид_показателя
        /// </summary>
        IQueryable<Вид_показателя> GetВид_показателя { get; }

        /// <summary>
        /// Таблица Вид_показателя по уникальному ключю
        /// </summary>
        /// <param name="id">Ключ таблицы Вид_показателя</param>
        /// <returns></returns>
        Вид_показателя GetByIdВид_показателя(int id);

        /// <summary>
        /// Добавить в базу новый объект Вид_показателя
        /// </summary>
        /// <param name="instance">Объект Вид_показателя</param>
        /// <returns></returns>
        bool CreateВид_показателя(Вид_показателя instance);

        /// <summary>
        /// Редактировать объект Вид_показателя
        /// </summary>
        /// <param name="instance">Объет Вид_показателя</param>
        /// <returns></returns>
        bool UpdateВид_показателя(Вид_показателя instance);

        /// <summary>
        /// Удалить объет Вид_показателя(удаляется по уникальному ключю)
        /// </summary>
        /// <param name="instance">Объект Вид_показателя</param>
        /// <returns></returns>
        bool RemoveВид_показателя(Вид_показателя instance);

        #endregion

        #region Единицы_измерения

        /// <summary>
        /// Набор таблиц Единицы_измерения
        /// </summary>
        IQueryable<Единицы_измерения> GetЕдиницы_измерения { get; }

        /// <summary>
        /// Таблица Единицы_измерения по уникальному ключю
        /// </summary>
        /// <param name="id">Ключ таблицы Единицы_измерения</param>
        /// <returns></returns>
        Единицы_измерения GetByIdЕдиницы_измерения(int id);

        /// <summary>
        /// Добавить в базу новый объект Единицы_измерения
        /// </summary>
        /// <param name="instance">Объект Единицы_измерения</param>
        /// <returns></returns>
        bool CreateЕдиницы_измерения(Единицы_измерения instance);

        /// <summary>
        /// Редактировать объект Единицы_измерения
        /// </summary>
        /// <param name="instance">Объет Единицы_измерения</param>
        /// <returns></returns>
        bool UpdateЕдиницы_измерения(Единицы_измерения instance);

        /// <summary>
        /// Удалить объет Единицы_измерения(удаляется по уникальному ключю)
        /// </summary>
        /// <param name="instance">Объект Единицы_измерения</param>
        /// <returns></returns>
        bool RemoveЕдиницы_измерения(Единицы_измерения instance);

        #endregion

        #region Тип_журнала

        /// <summary>
        /// Набор таблиц Тип_журнала
        /// </summary>
        IQueryable<Тип_журнала> GetТип_журнала { get; }

        /// <summary>
        /// Таблица Тип_журнала по уникальному ключю
        /// </summary>
        /// <param name="id">Ключ таблицы Тип_журнала</param>
        /// <returns></returns>
        Тип_журнала GetByIdТип_журнала(int id);

        /// <summary>
        /// Добавить в базу новый объект Тип_журнала
        /// </summary>
        /// <param name="instance">Объект Тип_журнала</param>
        /// <returns></returns>
        bool CreateТип_журнала(Тип_журнала instance);

        /// <summary>
        /// Редактировать объект Тип_журнала
        /// </summary>
        /// <param name="instance">Объет Тип_журнала</param>
        /// <returns></returns>
        bool UpdateТип_журнала(Тип_журнала instance);

        /// <summary>
        /// Удалить объет Тип_журнала(удаляется по уникальному ключю)
        /// </summary>
        /// <param name="instance">Объект Тип_журнала</param>
        /// <returns></returns>
        bool RemoveТип_журнала(Тип_журнала instance);

        #endregion

        #region Лог

        /// <summary>
        /// Набор таблиц Лог
        /// </summary>
        IQueryable<Лог> GetЛог { get; }

        /// <summary>
        /// Таблица Лог по уникальному ключю
        /// </summary>
        /// <param name="id">Ключ таблицы Лог</param>
        /// <returns></returns>
        Лог GetByIdЛог(int id);

        /// <summary>
        /// Добавить в базу новый объект Лог
        /// </summary>
        /// <param name="instance">Объект Лог</param>
        /// <returns></returns>
        bool CreateЛог(Лог instance);

        /// <summary>
        /// Редактировать объект Лог
        /// </summary>
        /// <param name="instance">Объет Лог</param>
        /// <returns></returns>
        bool UpdateЛог(Лог instance);

        /// <summary>
        /// Удалить объет Лог(удаляется по уникальному ключю)
        /// </summary>
        /// <param name="instance">Объект Лог</param>
        /// <returns></returns>
        bool RemoveЛог(Лог instance);

        #endregion

        #region Показатель

        /// <summary>
        /// Набор таблиц Показатель
        /// </summary>
        IQueryable<Показатель> GetПоказатель { get; }

        /// <summary>
        /// Таблица Показатель по уникальному ключю
        /// </summary>
        /// <param name="id">Ключ таблицы Показатель</param>
        /// <returns></returns>
        Показатель GetByIdПоказатель(int id);

        /// <summary>
        /// Добавить в базу новый объект Показатель
        /// </summary>
        /// <param name="instance">Объект Показатель</param>
        /// <returns></returns>
        bool CreateПоказатель(Показатель instance);

        /// <summary>
        /// Редактировать объект Показатель
        /// </summary>
        /// <param name="instance">Объет Показатель</param>
        /// <returns></returns>
        bool UpdateПоказатель(Показатель instance);

        /// <summary>
        /// Удалить объет Показатель(удаляется по уникальному ключю)
        /// </summary>
        /// <param name="instance">Объект Показатель</param>
        /// <returns></returns>
        bool RemoveПоказатель(Показатель instance);

        #endregion

        #region ПоказательОборудование

        /// <summary>
        /// Набор таблиц ПоказательОборудование
        /// </summary>
        IQueryable<ПоказательОборудование> GetПоказательОборудование { get; }

        /// <summary>
        /// Таблица ПоказательОборудование по уникальному ключю
        /// </summary>
        /// <param name="id">Ключ таблицы ПоказательОборудование</param>
        /// <returns></returns>
        ПоказательОборудование GetByIdПоказательОборудование(int id);

        /// <summary>
        /// Добавить в базу новый объект ПоказательОборудование
        /// </summary>
        /// <param name="instance">Объект ПоказательОборудование</param>
        /// <returns></returns>
        bool CreateПоказательОборудование(ПоказательОборудование instance);

        /// <summary>
        /// Редактировать объект ПоказательОборудование
        /// </summary>
        /// <param name="instance">Объет ПоказательОборудование</param>
        /// <returns></returns>
        bool UpdateПоказательОборудование(ПоказательОборудование instance);

        /// <summary>
        /// Удалить объет ПоказательОборудование(удаляется по уникальному ключю)
        /// </summary>
        /// <param name="instance">Объект ПоказательОборудование</param>
        /// <returns></returns>
        bool RemoveПоказательОборудование(ПоказательОборудование instance);

        #endregion

        #region Документ_работ

        /// <summary>
        /// Набор таблиц Документ_работ
        /// </summary>
        IQueryable<Документ_работ> GetДокумент_работ { get; }

        /// <summary>
        /// Таблица Документ_работ по уникальному ключю
        /// </summary>
        /// <param name="id">Ключ таблицы Документ_работ</param>
        /// <returns></returns>
        Документ_работ GetByIdДокумент_работ(int id);

        /// <summary>
        /// Добавить в базу новый объект Документ_работ
        /// </summary>
        /// <param name="instance">Объект Документ_работ</param>
        /// <returns></returns>
        bool CreateДокумент_работ(Документ_работ instance);

        /// <summary>
        /// Редактировать объект Документ_работ
        /// </summary>
        /// <param name="instance">Объет Документ_работ</param>
        /// <returns></returns>
        bool UpdateДокумент_работ(Документ_работ instance);

        /// <summary>
        /// Удалить объет Документ_работ(удаляется по уникальному ключю)
        /// </summary>
        /// <param name="instance">Объект Документ_работ</param>
        /// <returns></returns>
        bool RemoveДокумент_работ(Документ_работ instance);

        #endregion

        #region Состояние_оборудования

        /// <summary>
        /// Набор таблиц Состояние_оборудования
        /// </summary>
        IQueryable<Состояние_оборудования> GetСостояние_оборудования { get; }

        /// <summary>
        /// Таблица Состояние_оборудования по уникальному ключю
        /// </summary>
        /// <param name="id">Ключ таблицы Состояние_оборудования</param>
        /// <returns></returns>
        Состояние_оборудования GetByIdСостояние_оборудования(int id);

        /// <summary>
        /// Добавить в базу новый объект Состояние_оборудования
        /// </summary>
        /// <param name="instance">Объект Состояние_оборудования</param>
        /// <returns></returns>
        bool CreateСостояние_оборудования(Состояние_оборудования instance);

        /// <summary>
        /// Редактировать объект Состояние_оборудования
        /// </summary>
        /// <param name="instance">Объет Состояние_оборудования</param>
        /// <returns></returns>
        bool UpdateСостояние_оборудования(Состояние_оборудования instance);

        /// <summary>
        /// Удалить объет Состояние_оборудования(удаляется по уникальному ключю)
        /// </summary>
        /// <param name="instance">Объект Состояние_оборудования</param>
        /// <returns></returns>
        bool RemoveСостояние_оборудования(Состояние_оборудования instance);

        #endregion

        #region Событие

        /// <summary>
        /// Набор таблиц Событие
        /// </summary>
        IQueryable<Событие> GetСобытие { get; }

        /// <summary>
        /// Таблица Событие по уникальному ключю
        /// </summary>
        /// <param name="id">Ключ таблицы Событие</param>
        /// <returns></returns>
        Событие GetByIdСобытие(int id);

        /// <summary>
        /// Добавить в базу новый объект Событие
        /// </summary>
        /// <param name="instance">Объект Событие</param>
        /// <returns></returns>
        bool CreateСобытие(Событие instance);

        /// <summary>
        /// Редактировать объект Событие
        /// </summary>
        /// <param name="instance">Объет Событие</param>
        /// <returns></returns>
        bool UpdateСобытие(Событие instance);

        /// <summary>
        /// Удалить объет Событие(удаляется по уникальному ключю)
        /// </summary>
        /// <param name="instance">Объект Событие</param>
        /// <returns></returns>
        bool RemoveСобытие(Событие instance);

        #endregion

        #region Журнал

        /// <summary>
        /// Набор таблиц Журнал
        /// </summary>
        IQueryable<Журнал> GetЖурнал { get; }

        /// <summary>
        /// Таблица Журнал по уникальному ключю
        /// </summary>
        /// <param name="id">Ключ таблицы Журнал</param>
        /// <returns></returns>
        Журнал GetByIdЖурнал(int id);

        /// <summary>
        /// Добавить в базу новый объект Журнал
        /// </summary>
        /// <param name="instance">Объект Журнал</param>
        /// <returns></returns>
        bool CreateЖурнал(Журнал instance);

        /// <summary>
        /// Редактировать объект Журнал
        /// </summary>
        /// <param name="instance">Объет Журнал</param>
        /// <returns></returns>
        bool UpdateЖурнал(Журнал instance);

        /// <summary>
        /// Удалить объет Журнал(удаляется по уникальному ключю)
        /// </summary>
        /// <param name="instance">Объект Журнал</param>
        /// <returns></returns>
        bool RemoveЖурнал(Журнал instance);

        #endregion

        #region Users

        /// <summary>
        /// Набор таблиц Users
        /// </summary>
        IQueryable<Users> GetUsers { get; }

        /// <summary>
        /// Таблица Users по уникальному ключю
        /// </summary>
        /// <param name="id">Ключ таблицы Users</param>
        /// <returns></returns>
        Users GetByIdUsers(string id);

        /// <summary>
        /// Добавить в базу новый объект Users
        /// </summary>
        /// <param name="instance">Объект Users</param>
        /// <returns></returns>
        bool CreateUsers(Users instance);

        /// <summary>
        /// Редактировать объект Users
        /// </summary>
        /// <param name="instance">Объет Users</param>
        /// <returns></returns>
        bool UpdateUsers(Users instance);

        /// <summary>
        /// Удалить объет Users(удаляется по уникальному ключю)
        /// </summary>
        /// <param name="instance">Объект Users</param>
        /// <returns></returns>
        bool RemoveUsers(Users instance);

        #endregion
    }
}
