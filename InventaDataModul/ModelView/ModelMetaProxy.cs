using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventaDataModul
{
    #region Тип_улицы
    [MetadataType(typeof(ModelViewТип_улицы))]
    public partial class Тип_улицы
    {
        
    }

    
    class ModelViewТип_улицы
    {
        public int Код { get; set; }

        [Display(Name = "Тип улицы")]
        public string Название { get; set; }
    }
    #endregion

    #region Тип_лога

    [MetadataType(typeof(ModelViewТип_лога))]
    public partial class Тип_лога
    {
    }


    class ModelViewТип_лога
    {
        [Required]
        [Display(Name = "Название")]
        public string Название { get; set; }

        [Display(Name = "Описание")]
        public string Описание { get; set; }


    }

    #endregion

    #region Улица

    [MetadataType(typeof(ModelViewУлица))]
    public partial class Улица
    {
    }


    class ModelViewУлица
    {
        [Display(Name = "Название")]
        public string Название { get; set; }

        [Display(Name = "Тип")]
        public string Код_типа { get; set; }


    }

    #endregion

    #region Тип_населенного_пункта

    [MetadataType(typeof(ModelViewТип_населенного_пункта))]
    public partial class Тип_населенного_пункта
    {
    }


    class ModelViewТип_населенного_пункта
    {
        [Display(Name = "Название типа населенного пункта")]
        public string Название { get; set; }


    }

    #endregion

    #region Населенный_пункт

    [MetadataType(typeof(ModelViewНаселенный_пункт))]
    public partial class Населенный_пункт
    {
    }


    class ModelViewНаселенный_пункт
    {
        [Display(Name = "Название")]
        public string Название { get; set; }

        [Display(Name = "Тип")]
        public string Код_типа { get; set; }


    }

    #endregion

    #region Физическое_лицо

    [MetadataType(typeof(ModelViewФизическое_лицо))]
    public partial class Физическое_лицо
    {
        public string ФамилияИО
        {
            get { return Фамилия+" "+Имя[0]+". "+Отчество[0]+"."; }
        }
    }


    class ModelViewФизическое_лицо
    {
        [Display(Name = "Фамилия")]
        public string Фамилия { get; set; }

        [Display(Name = "Имя")]
        public string Имя { get; set; }

        [Display(Name = "Отчество")]
        public string Отчество { get; set; }

        [Display(Name = "Телефон")]
        public string Телефон { get; set; }


    }

    #endregion

    #region Должность

    [MetadataType(typeof(ModelViewДолжность))]
    public partial class Должность
    {
    }


    class ModelViewДолжность
    {
        [Display(Name = "Название")]
        public string Название { get; set; }

        [Display(Name = "Краткое название")]
        public string Краткое_название { get; set; }


    }

    #endregion

    #region Адрес

    [MetadataType(typeof(ModelViewАдрес))]
    public partial class Адрес
    {
        public string АдресПунктУлицаДом
        {
            get
            {
                return this.Населенный_пункт.Тип_населенного_пункта.Название.ToLower()[0] + ". " +
                       this.Населенный_пункт.Название +
                       ", " + this.Улица.Тип_улицы.Название.Remove(2).ToLower() + " " + this.Улица.Название+
                       ", д. "+Номер_дома;
            }
        }
    }


    class ModelViewАдрес
    {
        [Display(Name = "Номер дома")]
        public string Номер_дома { get; set; }

        [Display(Name = "Улица")]
        public string Код_улицы { get; set; }

        [Display(Name = "Населенный пункт")]
        public string Код_нас_пункта { get; set; }

        [Display(Name = "Физическое лицо")]
        public string Код_физического_лица { get; set; }


    }

    #endregion

    #region Тип_юр__лица

    [MetadataType(typeof(ModelViewТип_юр__лица))]
    public partial class Тип_юр__лица
    {
    }


    class ModelViewТип_юр__лица
    {
        [Display(Name = "Название")]
        public string Название { get; set; }

        [Display(Name = "Описание")]
        public string Описание { get; set; }


    }

    #endregion

    #region Юридическое_лицо

    [MetadataType(typeof(ModelViewЮридическое_лицо))]
    public partial class Юридическое_лицо
    {
        public string Юр_лицо_Тип
        {
            get { return this.Тип_юр__лица.Название + " " + this.Название; }
        }
    }


    class ModelViewЮридическое_лицо
    {
        [Display(Name = "Название")]
        public string Название { get; set; }

        [Display(Name = "Краткое название")]
        public string Краткое_название { get; set; }

        [Display(Name = "Телефон")]
        [DataType(DataType.PhoneNumber)]
        public string Телефон { get; set; }

        [Display(Name = "Тип")]
        public string Код_типа { get; set; }

        [Display(Name = "Юрид. лицо")]
        public string Код_юрид__лица { get; set; }


    }

    #endregion

    #region Фр__труд__договора

    [MetadataType(typeof(ModelViewФр__труд__договора))]
    public partial class Фр__труд__договора
    {
    }


    class ModelViewФр__труд__договора
    {
        [Required]
        [Display(Name = "Дата приема")]
        [DataType(DataType.Date)]
        public string Дата_приема { get; set; }

        [Display(Name = "Дата увольнения")]
        [DataType(DataType.Date)]
        public string Дата_увольнения { get; set; }

        [Display(Name = "Физическое лицо")]
        public string Код_физ__лица { get; set; }

        [Display(Name = "Юридическое лицо")]
        public string Код_юр__лица { get; set; }

        [Display(Name = "Должность")]
        public string Код_должности { get; set; }


    }

    #endregion

    #region Хост

    [MetadataType(typeof(ModelViewХост))]
    public partial class Хост
    {
    }


    class ModelViewХост
    {
        [Display(Name = "IP адрес")]
        public string IP_адрес { get; set; }

        [Display(Name = "Описание")]
        public string Описание { get; set; }

        [Display(Name = "Адрес")]
        public string Код_адреса { get; set; }


    }

    #endregion

    #region Тип_работ

    [MetadataType(typeof(ModelViewТип_работ))]
    public partial class Тип_работ
    {
    }


    class ModelViewТип_работ
    {
        [Display(Name = "Название")]
        public string Название { get; set; }


    }

    #endregion

    #region Тег

    [MetadataType(typeof(ModelViewТег))]
    public partial class Тег
    {
    }


    class ModelViewТег
    {
        [Display(Name = "Название")]
        public string Название { get; set; }

        [Display(Name = "Описание")]
        public string Описание { get; set; }


    }

    #endregion

    #region Оборудование

    [MetadataType(typeof(ModelViewОборудование))]
    public partial class Оборудование
    {
    }


    class ModelViewОборудование
    {
        [Display(Name = "Инвентарный номер")]
        [Required]
        public string Инвентарный_номер { get; set; }

        [Required]
        [Display(Name = "Дата изготовления")]
        [DataType(DataType.Date)]
        public string Дата_изготовления { get; set; }

        [Display(Name = "Описание")]
        [DataType(DataType.MultilineText)]
        public string Описание { get; set; }

        [Display(Name = "Собственник")]
        public string Код_юр__лица { get; set; }
        
    }

    #endregion

    #region Тип_показателя

    [MetadataType(typeof(ModelViewТип_показателя))]
    public partial class Тип_показателя
    {
    }


    class ModelViewТип_показателя
    {
        [Display(Name = "Название")]
        public string Название { get; set; }


    }

    #endregion

    #region Вид_показателя

    [MetadataType(typeof(ModelViewВид_показателя))]
    public partial class Вид_показателя
    {
    }


    class ModelViewВид_показателя
    {
        [Display(Name = "Название")]
        public string Название { get; set; }

        [Display(Name = "Описание")]
        [DataType(DataType.MultilineText)]
        public string Описание { get; set; }


    }

    #endregion

    #region Единицы_измерения

    [MetadataType(typeof(ModelViewЕдиницы_измерения))]
    public partial class Единицы_измерения
    {
        public string Представление
        {
            get { return Краткое_название == "" ? Название : Краткое_название; }
        }

    }


    class ModelViewЕдиницы_измерения
    {
        [Display(Name = "Название")]
        public string Название { get; set; }

        [Display(Name = "Краткое_название")]
        public string Краткое_название { get; set; }


    }

    #endregion

    #region Тип_журнала

    [MetadataType(typeof(ModelViewТип_журнала))]
    public partial class Тип_журнала
    {
    }


    class ModelViewТип_журнала
    {
        [Display(Name = "Название")]
        public string Название { get; set; }


    }

    #endregion

    #region Лог

    [MetadataType(typeof(ModelViewЛог))]
    public partial class Лог
    {
    }


    class ModelViewЛог
    {
        [Display(Name = "Сообщение")]
        public string Сообщение { get; set; }

        [Display(Name = "Код_тега")]
        public string Код_тега { get; set; }

        [Display(Name = "Код_лога")]
        public string Код_лога { get; set; }


    }

    #endregion

    #region Показатель

    [MetadataType(typeof(ModelViewПоказатель))]
    public partial class Показатель
    {
        public string Представление
        {
            get
            {
                var s = Вид_показателя.Название + ": " + Значение + " " + Единицы_измерения1.Представление;
                if (Код_показателя!=null)
                {
                    s+=Показатель1.Представление;
                }
                return s;
            }
        }
    }


    class ModelViewПоказатель
    {
        [Display(Name = "Значение")]
        public string Значение { get; set; }

        [Display(Name = "Показатель")]
        public string Код_показателя { get; set; }

        [Display(Name = "Состояние")]
        public string Код_состояния { get; set; }

        [Display(Name = "Тип показателя")]
        public string Тип_показателя { get; set; }

        [Display(Name = "Вид показателя")]
        public string Код_вида_показателя { get; set; }

        [Display(Name = "Единицы измерения")]
        public string Единицы_измерения { get; set; }


    }

    #endregion

    #region ПоказательОборудование

    [MetadataType(typeof(ModelViewПоказательОборудование))]
    public partial class ПоказательОборудование
    {
    }


    class ModelViewПоказательОборудование
    {
        [Display(Name = "Оборудование")]
        public string Код_Оборудования { get; set; }

        [Display(Name = "Показатель")]
        public string Код_Показателя { get; set; }


    }

    #endregion

    #region Документ_работ

    [MetadataType(typeof(ModelViewДокумент_работ))]
    public partial class Документ_работ
    {
    }


    class ModelViewДокумент_работ
    {
        [Display(Name = "Название")]
        public string Название { get; set; }

        [Display(Name = "Дата")]
        public string Дата { get; set; }

        [Display(Name = "Описание")]
        public string Описание { get; set; }

        [Display(Name = "Код_хоста")]
        public string Код_хоста { get; set; }

        [Display(Name = "Код_фр__труд__дог_")]
        public string Код_фр__труд__дог_ { get; set; }

        [Display(Name = "Код_типа")]
        public string Код_типа { get; set; }

        [Display(Name = "Код_оборудования")]
        public string Код_оборудования { get; set; }


    }

    #endregion

    #region Состояние_оборудования

    [MetadataType(typeof(ModelViewСостояние_оборудования))]
    public partial class Состояние_оборудования
    {
    }


    class ModelViewСостояние_оборудования
    {
        [Display(Name = "Номер_состояния")]
        public string Номер_состояния { get; set; }


    }

    #endregion

    #region Событие

    [MetadataType(typeof(ModelViewСобытие))]
    public partial class Событие
    {
    }


    class ModelViewСобытие
    {
        [Display(Name = "Дата")]
        public string Дата { get; set; }

        [Display(Name = "Описание")]
        public string Описание { get; set; }

        [Display(Name = "Код_журнала")]
        public string Код_журнала { get; set; }

        [Display(Name = "Код_хоста")]
        public string Код_хоста { get; set; }

        [Display(Name = "Код_лога")]
        public string Код_лога { get; set; }

        [Display(Name = "Код_состояния")]
        public string Код_состояния { get; set; }


    }

    #endregion

    #region Журнал

    [MetadataType(typeof(ModelViewЖурнал))]
    public partial class Журнал
    {
    }


    class ModelViewЖурнал
    {
        [Display(Name = "Название")]
        public string Название { get; set; }

        [Display(Name = "Код_типа")]
        public string Код_типа { get; set; }


    }

    #endregion
}
